/*
 * Crée par SharpDevelop.
 * Utilisateur: CHAUTARD
 * Date: 13/12/2019
 * Heure: 08:01
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */

using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Windows;

namespace SPID2Deconnecte.Modeles
{
    internal class Joueur
    {
        // "JOUE_ID"	NUMERIC(15, 0) NOT NULL,
        public long JOUE_ID { get; set; }

        // "EPRV_ID"	NUMERIC(15, 0) NOT NULL,
        public long EPRV_ID { get; set; }

        // "LIC_ID"	NUMERIC(15, 0) NOT NULL,
        public long LIC_ID { get; set; }

        // "JOUE_NB_POINT_TOTAL"	VARCHAR(64),
        public string JOUE_NB_POINT_TOTAL { get; set; }

        // "JOUE_BL_FORFAIT_GENE"	NUMERIC(8, 0) NOT NULL,
        public long JOUE_BL_FORFAIT_GENE { get; set; }

        // "JOUE_LB_TRI_POINT"	VARCHAR(64),
        public string JOUE_LB_TRI_POINT { get; set; }

        public bool PRESENT { get; set; }

        public void MajPresent()
        {
            MySqlConnection connection = DBUtils.GetDBConnection();

            try
            {
                string sQuery = string.Format("UPDATE `joueur` SET `PRESENT` = {0} WHERE `JOUE_ID` = {1}", PRESENT ? 1 : 0, JOUE_ID);
                connection.Execute(sQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors du pointage !");
            }
            finally
            {
                connection.Close();
            }
        }

        /*
        public Joueur(long joueurId)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM JOUEUR WHERE JOUE_ID = " + joueurId.ToString(), conn);
                MySqlDataReader reader = command.ExecuteReader();

                JOUE_ID = (long)reader[0];
                EPRV_ID = (long)reader[1];
                LIC_ID = (long)reader[2];
                JOUE_NB_POINT_TOTAL = (string)reader[3];
                JOUE_BL_FORFAIT_GENE = (long)reader[4];
                JOUE_LB_TRI_POINT = (string)reader[5];
                PRESENT = (int)reader[6] > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur recherche joueur !");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public void GetById(long id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM JOUEUR WHERE JOUE_ID = " + id.ToString(), conn);

                MySqlDataReader reader = command.ExecuteReader();
                if (reader != null)
                {
                    reader.Read();

                    JOUE_ID = (long)reader[0];
                    EPRV_ID = (long)reader[1];
                    LIC_ID = (long)reader[2];
                    JOUE_NB_POINT_TOTAL = (string)reader[3];
                    JOUE_BL_FORFAIT_GENE = (long)reader[4];
                    JOUE_LB_TRI_POINT = (string)reader[5];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur recherche un joueur !");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private int Insert()
        {
            int iRet = 0;

            string sQuery = string.Format("INSERT INTO `joueur` (`JOUE_ID`, `EPRV_ID`, `LIC_ID`, `JOUE_NB_POINT_TOTAL`, `JOUE_BL_FORFAIT_GENE`, `JOUE_LB_TRI_POINT`, `PRESENT`) VALUES " +
            "( {0}, {1}, {2}, {3}, '{4}', '{5}', {6});",
                JOUE_ID,
                EPRV_ID,
                LIC_ID,
                JOUE_NB_POINT_TOTAL,
                JOUE_BL_FORFAIT_GENE,
                JOUE_LB_TRI_POINT,
                PRESENT
            );

            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                MySqlCommand comm = new MySqlCommand(sQuery, conn);
                iRet = comm.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur: " + ex.Message, "Erreur lors de l'ajout.");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return iRet;
        }
        */
    }
}
