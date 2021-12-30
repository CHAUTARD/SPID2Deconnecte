using Dapper;
using MySql.Data.MySqlClient;
using SPID2Deconnecte.Modeles;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;

namespace SPID2Deconnecte
{
    internal class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            // Connection String.
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            return conn;
        }

        public static string BuildInsertSQL(string sTable)
        {
            StringBuilder sql = new StringBuilder("INSERT INTO `" + sTable + "` (");
            StringBuilder values = new StringBuilder("VALUES (");
            DataTable table = new DataTable();
            bool bFirst = true;

            // Initialisation de la database
            MySqlConnection connection = DBUtils.GetDBConnection();

            string sQuery = "SHOW COLUMNS FROM `" + sTable.ToLower() + "`;";
            IEnumerable<Column> columns = connection.Query<Column>(sQuery);

            connection.Close();

            foreach (Column column in columns)
            {
                if (bFirst)
                    bFirst = false;
                else
                {
                    sql.Append(", ");
                    values.Append(", ");
                }

                sql.Append(column.FIELD);
                values.Append("@");
                values.Append(column.FIELD);
            }
            sql.Append(") ");
            sql.Append(values.ToString());
            sql.Append(");");

            string sqlString = sql.ToString();
            return sql.ToString();
        }

        internal static string BuildUpdateSQL(string sTable, string sWhere)
        {
            StringBuilder sql = new StringBuilder("UPDATE `" + sTable + "` SET ");
            DataTable table = new DataTable();
            bool bFirst = true;

            // Initialisation de la database
            MySqlConnection connection = DBUtils.GetDBConnection();

            // Tous les champs sauf le champ primaire de la table
            string sQuery = "SHOW COLUMNS FROM `" + sTable.ToLower() + "`;"; 
            IEnumerable<Column> columns = connection.Query<Column>(sQuery);

            connection.Close();

            foreach (Column column in columns)
            {
                if (bFirst)
                    bFirst = false;
                else
                {
                    sql.Append(", ");
                }

                sql.Append( "`" + column.FIELD + "`");
                sql.Append(" = @");
                sql.Append(column.FIELD);
            }
            sql.Append(" WHERE " + sWhere);
            sql.Append(";");

            return sql.ToString(); ;

        }

        // Suppression d'un enregistrement dans la table à partir de la clée primaire
        public static void Delete(string sTable, string sPrimaryKey, long IdValue, string sMessage)
        {
            MySqlConnection connection = DBUtils.GetDBConnection();

            try
            {
                string sQuery = string.Format("DELETE FROM `{0}` WHERE `{1}` = {2};", sTable, sPrimaryKey, IdValue);

                connection.Execute(sQuery);


                MessageBox.Show(sMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de la suppression !");
            }
            finally
            {
                connection.Close();
            }
        }

        public static int Count(string sTable, string sKey, long IdValue)
        {
            int iRet = 0;

            using (MySqlConnection connection = DBUtils.GetDBConnection())
            { 
                string sQuery = string.Format("SELECT COUNT(*) as Count FROM `{0}` WHERE `{1}` = {2};", sTable, sKey, IdValue);

                dynamic result = connection.Query(sQuery).Single();
                iRet = result.Count;

                connection.Close();
            }

            return iRet;
        }

        /*
        // Vidage d'une table donnée en paramètre
        public static void TRUNCATE(string sTableName)
        {
            // Obtenez une connexion à la base de données.
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                string sQuery = string.Format("TRUNCATE TABLE `{0}`;", sTableName);

                // Create a command associated with the Connection.
                MySqlCommand cmd = new MySqlCommand(sQuery, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors du vidage !");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            conn.Close();
        }

        // Suppression d'un enregistrement dans la table à partir de la clée primaire
        public static void Delete(string sTable, string sPrimaryKey, long IdValue, string sMessage)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                string sQuery = string.Format("DELETE FROM `{0}` WHERE `{1}` = {2};", sTable, sPrimaryKey, IdValue);

                MySqlCommand comm = new MySqlCommand(sQuery, conn);
                comm.ExecuteNonQuery();

                MessageBox.Show(sMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de la suppression !");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        */
    }
}
