using MySql.Data.MySqlClient;
using System;
using System.Windows;

namespace SPID2Deconnecte.Modeles
{
    internal class Licencie
    {
        //         NUMERIC(15,0)
        public long LIC_ID { get; set; }

        //  NUMERIC(15,0)
        public long?  CAT_ID { get; set; }

        // NUMERIC(15,0)
        public long? CLUB_ID { get; set; }

        //  NUMERIC(15,0)
        public long? CLU_CLUB_ID { get; set; }

        //  NUMERIC(15,0)
        public long? TCLST_ID { get; set; } 

        // VARCHAR(64)
        public string PERS_LB_NOM { get; set; }

        //VARCHAR(15)
        public string PERS_LB_PRENOM { get; set; }

        //CHAR(1)
        public string PERS_FG_SEXE { get; set; }
        
        //DATE
        public DateTime? PERS_DT_NAISSANCE { get; set; }
        
        //VARCHAR(8)
        public string LIC_NB_LICENCE { get; set; }
        
        //CHAR(1)
        public string LIC_FG_NATIONALITE { get; set; }
        
        //CHAR(1)
        public string LIC_FG { get; set; }

        //CHAR(1)
        public string LIC_FG_MODULE { get; set; }

        //CHAR(1)
        public string LIC_FG_CERTIFICAT { get; set; }

        // DATE
        public DateTime? LIC_DT_CERTIFICAT { get; set; }

        // DATE
        public DateTime? LIC_DT_VALIDATION { get; set; }

        // INTEGER
        public int? LIC_NB_PLACE { get; set; }

        // NUMERIC(7,3)
        public string LIC_NB_POINT { get; set; }

        // CHAR(1)
        public string LIC_FG_ECHELON { get; set; }

        // VARCHAR(64)
        public string LIC_NB_POINT_CF_PREC { get; set; }

        // VARCHAR(64)
        public string LIC_NB_POINT_TOTAL_CF { get; set; }

        // VARCHAR(64)
        public string LIC_NB_TRI_POINT_CF { get; set; }

        // NUMERIC(1,0)
        public int LIC_BL_LOCAL { get; set; }

        // NUMERIC(1,0)
        public int LIC_BL_DOUBLE { get; set; }

        // NUMERIC(7,3)
        public string LIC_NB_TOTAL_POINT_DOUBLE { get; set; }

        // VARCHAR(64) 
        public string LIC_NB_POINT_TOUR_PREC_CF { get; set; }

        // NUMERIC(15,0)
        public long? EPRV_ID { get; set; }

        // NUMERIC(15,0)
        public long? DOUBLE_CLUB_ID { get; set; }

        // NUMERIC(15,0)
        public long? DOUBLE_CLU_CLUB_ID { get;  set; }

        /*
        public void GetByNumLicence(long lNumLicence)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `licencie` WHERE JOUE_ID = " + lNumLicence.ToString(), conn);

                MySqlDataReader reader = command.ExecuteReader();
                if (reader != null)
                {
                    reader.Read();

                    LIC_ID = (long)reader[0];
                    CAT_ID = (long)reader[1];
                    CLUB_ID = (long)reader[2];
                    CLU_CLUB_ID = (long)reader[3];
                    TCLST_ID = (long)reader[4];
                    PERS_LB_NOM = (string)reader[5];
                    PERS_LB_PRENOM = (string)reader[6];
                    PERS_FG_SEXE = (string)reader[7];
                    PERS_DT_NAISSANCE = (DateTime?)reader[8];
                    LIC_NB_LICENCE = (string)reader[9];
                    LIC_FG_NATIONALITE = (string)reader[10];
                    LIC_FG = (string)reader[11];
                    LIC_FG_MODULE = (string)reader[12];
                    LIC_FG_CERTIFICAT = (string)reader[13];
                    LIC_DT_CERTIFICAT = (DateTime)reader[14];
                    LIC_DT_VALIDATION = (DateTime)reader[15];
                    LIC_NB_PLACE = (int?)reader[16];
                    LIC_NB_POINT = (string)reader[17];
                    LIC_FG_ECHELON = (string)reader[18];
                    LIC_NB_POINT_CF_PREC = (string)reader[19];
                    LIC_NB_POINT_TOTAL_CF = (string)reader[20];
                    LIC_NB_TRI_POINT_CF = (string)reader[21];
                    LIC_BL_LOCAL = (int)reader[22];
                    LIC_BL_DOUBLE = (int)reader[23];
                    LIC_NB_TOTAL_POINT_DOUBLE = (string)reader[24];
                    LIC_NB_POINT_TOUR_PREC_CF = (string)reader[25];
                    EPRV_ID = (long)reader[26];
                    DOUBLE_CLUB_ID = (long)reader[27];
                    DOUBLE_CLU_CLUB_ID = (long)reader[28];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur recherche d'une licence !");
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
