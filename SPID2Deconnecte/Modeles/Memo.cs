using System;
using System.Data.Common;
using System.Windows;
using Dapper;
using MySql.Data.MySqlClient;

namespace SPID2Deconnecte.Modeles
{

    internal class Memo
    {
        public string MEMO { get; set; }

        public Memo(string str)
        {
            this.MEMO = str;
        }

        public Memo()
        {
            MEMO = string.Empty;
        }

        public string Read()
        {
            string sRet = string.Empty;

            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                string sQuery = string.Format("SELECT * FROM `MEMO` LIMIT 1;");

                MySqlCommand comm = new MySqlCommand(sQuery, conn);

                using (DbDataReader reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();

                        sRet = reader.GetString(0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pas de mémo trouvé !");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return sRet;
        }

        // Un seul enregistrement dans la table mémo
        internal void Insert(string sText)
        {
            using (MySqlConnection connection = DBUtils.GetDBConnection())
            {
                try
                {
                    // Suppression des enregistrement si il existent
                    connection.Execute("TRUNCATE TABLE memo;");
                    connection.Execute(string.Format("INSERT INTO `memo` (`MEMO`) VALUES ('{0}') ;", sText.Replace("'", "\\'")));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur crétion mémo !");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
