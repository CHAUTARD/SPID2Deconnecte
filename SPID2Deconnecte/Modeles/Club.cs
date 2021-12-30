using MySql.Data.MySqlClient;
using System;
using System.Windows;

namespace SPID2Deconnecte.Modeles
{
    internal class Club
    {
        // NUMERIC(15,0)
        public long CLUB_ID;

        // NUMERIC(15,0) - Non renseigné
        public long? ORGA_ID;

        // VARCHAR(8)
        public string CLUB_NM;

        // VARCHAR(32)
        public string CLUB_LB_LONG;

        // VARCHAR(15)
        public string CLUB_LB_COURT;

        // CHAR(1)
        public string CLUB_FG;

/*
        internal void ReadByNum(string str)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string sQuery = "SELECT * FROM club WHERE CLUB_ID = " + str;

            try
            {
                MySqlCommand command = new MySqlCommand( sQuery, conn);

                MySqlDataReader reader = command.ExecuteReader();
                if (reader != null)
                {
                    reader.Read();

                    CLUB_ID = (long)reader[0];
                    ORGA_ID = (long)reader[1];
                    CLUB_NM = (string)reader[2];
                    CLUB_LB_LONG = (string)reader[3];
                    CLUB_LB_COURT = (string)reader[4];
                    CLUB_FG = (string)reader[5];
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur: " + ex.Message, "Erreur lors de la modification.");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        internal int Update()
        {
            int iRet = 0;

            // UPDATE `club` SET `CLUB_NM` = '-101' WHERE `club`.`CLUB_ID` = -101 
            string sQuery = String.Format("UPDATE `club` set ( `ORGA_ID` = {0}, `CLUB_NM` = '{1}', `CLUB_LB_LONG` = '{2}', `CLUB_LB_COURT` = '{3}', `CLUB_FG` = '{4}' WHERE `CLUB_ID` = {5}');",     
                ORGA_ID,
                CLUB_NM,
                CLUB_LB_LONG,
                CLUB_LB_COURT,
                CLUB_FG,
                CLUB_ID
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
                MessageBox.Show("Erreur: " + ex.Message, "Erreur Modification Club !");
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
