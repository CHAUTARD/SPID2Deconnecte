using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;

namespace SPID2Deconnecte.Modeles
{
    internal class Division
    {
        // DIV_ID"	NUMERIC(15, 0) NOT NULL,
        public long DIV_ID { get; set; }

        // ORGA_ID"	NUMERIC(15, 0) NOT NULL,
        public long ORGA_ID { get; set; }

        // EPRV_ID"	NUMERIC(15, 0) NULL,
        public long? EPRV_ID { get; set; }

        // DIV_CD"	VARCHAR(5) NOT NULL,
        public string DIV_CD { get; set; }

        // DIV_LB"	VARCHAR(32) NOT NULL,
        public string DIV_LB { get; set; }

        // DIV_NB_POULE"	INTEGER NOT NULL,
        public int DIV_NB_POULE { get; set; }

        // DIV_FG_SEXE"	CHAR(1) NOT NULL,
        public string DIV_FG_SEXE { get; set; }

        // DIV_FG_TYPE_LICENCE"	CHAR(1) NOT NULL,
        public string DIV_FG_TYPE_LICENCE { get; set; }

        // DIV_BL_CORPO"	NUMERIC(1, 0) NOT NULL,
        public int DIV_BL_CORPO { get; set; }

        // DIV_NB_TOUR"	NUMERIC(1, 0),
        public int? DIV_NB_TOUR { get; set; }

        // DIV_CD_LETTRE"	CHAR(1) NOT NULL,
        public string DIV_CD_LETTRE { get; set; }

        // DIV_CM"	VARCHAR(255),
        public string DIV_CM;

        // DIV_LB_USER_MODIF"	VARCHAR(15) NOT NULL,
        public string DIV_LB_USER_MODIF { get; set; }

        // BAR_ID"	NUMERIC(15, 0),
        public long? BAR_ID { get; set; }

        // GCAT_CD"	CHAR(5),
        public string GCAT_CD { get; set; }

        // DIV_DIV_ID"	NUMERIC(15, 0),
        public long? DIV_DIV_ID { get; set; }

        // DIV_BL_DOUBLE"	NUMERIC(1, 0),
        public int? DIV_BL_DOUBLE { get; set; }

        // DIV_NB_POINT_MANCHE"	INTEGER NOT NULL,
        public int DIV_NB_POINT_MANCHE { get; set; }

        // DIV_NB_MANCHE_POULE"	INTEGER NOT NULL,
        public int DIV_NB_MANCHE_POULE { get; set; }

        // DIV_NB_MANCHE_TAB"	INTEGER NOT NULL,
        public int DIV_NB_MANCHE_TAB { get; set; }

        // DIV_NB_POINT_MIN"	INTEGER NOT NULL,
        public int DIV_NB_POINT_MIN { get; set; }

        // DIV_NB_POINT_MAX"	INTEGER NOT NULL,
        public int DIV_NB_POINT_MAX { get; set; }

        // DIV_DT_TOUR"	DATE,
        public DateTime DIV_DT_TOUR { get; set; }

        /*
        public Division()
        {
            ORGA_ID = -101; // Inc = LOCAL
            DIV_NB_MANCHE_POULE = 0; // 0 en LOCAL
            DIV_NB_TOUR = 0; // 0 pour LOCAL
            DIV_CD_LETTRE = "L"; // LOCAL
            DIV_FG_TYPE_LICENCE = "T"; // ???
            BAR_ID = null;
            DIV_DIV_ID =(long?) null;
            DIV_LB_USER_MODIF = "SPID2D";
            DIV_NB_MANCHE_TAB = 0;
            DIV_DT_TOUR = DateTime.Now;
        }

        public Division(IDataRecord dataRecord)
        {
            DIV_ID = (long)dataRecord[0];
            ORGA_ID = (long)dataRecord[1];
            EPRV_ID = (long)dataRecord[2];
            DIV_CD = (string)dataRecord[3];
            DIV_LB = (string)dataRecord[4];
            DIV_NB_POULE = (int)dataRecord[5];
            DIV_FG_SEXE = (string)dataRecord[6];
            DIV_FG_TYPE_LICENCE = (string)dataRecord[7];
            DIV_BL_CORPO = (int)dataRecord[8];
            DIV_NB_TOUR = (int?)dataRecord[9];
            DIV_CD_LETTRE = (string)dataRecord[10];
            DIV_CM = (string)dataRecord[11];
            DIV_LB_USER_MODIF = (string)dataRecord[12];
            BAR_ID = (long?)dataRecord[13];
            GCAT_CD = (string)dataRecord[14];
            DIV_DIV_ID = (long?)dataRecord[15];
            DIV_BL_DOUBLE = (int?)dataRecord[16];
            DIV_NB_POINT_MANCHE = (int)dataRecord[17];
            DIV_NB_MANCHE_POULE = (int)dataRecord[18];
            DIV_NB_MANCHE_TAB = (int)dataRecord[19];
            DIV_NB_POINT_MIN = (int)dataRecord[20];
            DIV_NB_POINT_MAX = (int)dataRecord[21];
            DIV_DT_TOUR = (DateTime)dataRecord[22];
        }


        public int Update()
        {
            int iRet = 0;

            string Query = String.Format("UPDATE `division` SET `ORGA_ID` = {0}, `EPRV_ID` = {1}, `DIV_CD` = `{2}`, `DIV_LB` = `{3}`, `DIV_NB_POULE` = {4}, " +
                "`DIV_FG_SEXE` = `{5}`, `DIV_FG_TYPE_LICENCE` = `{6}`, `DIV_BL_CORPO` = {7}, `DIV_NB_TOUR` = {8}, `DIV_CD_LETTRE`  = `{9}`, `DIV_CM` = `{10}`, " +
                "`DIV_LB_USER_MODIF` = `{11}`, `BAR_ID` = {12}, `GCAT_CD` = `{13}`, `DIV_DIV_ID` = {14}, `DIV_BL_DOUBLE` = {15}, `DIV_NB_POINT_MANCHE`  = {16}, " +
                "`DIV_NB_MANCHE_POULE` = {17}, `DIV_NB_MANCHE_TAB` = {18}, `DIV_NB_POINT_MIN` = {19}, `DIV_NB_POINT_MAX` = {20}, `DIV_DT_TOUR` = `{21}` " +
                "WHERE `division`.`DIV_ID` = {22}",        
                ORGA_ID,
                EPRV_ID,
                DIV_CD,
                DIV_LB,
                DIV_NB_POULE,
                DIV_FG_SEXE,
                DIV_FG_TYPE_LICENCE,
                DIV_BL_CORPO,
                DIV_NB_TOUR,
                DIV_CD_LETTRE,
                DIV_CM,
                DIV_LB_USER_MODIF,
                BAR_ID,
                GCAT_CD,
                DIV_DIV_ID,
                DIV_BL_DOUBLE,
                DIV_NB_POINT_MANCHE,
                DIV_NB_MANCHE_POULE,
                DIV_NB_MANCHE_TAB,
                DIV_NB_POINT_MIN,
                DIV_NB_POINT_MAX,
                DIV_DT_TOUR,
                DIV_ID
            );

            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                MySqlCommand comm = new MySqlCommand(Query, conn);
                iRet = comm.ExecuteNonQuery();
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
            return iRet;
        }


        public void Delete()
        {
            DBUtils.Delete("division", "DIV_ID", DIV_ID, "Division supprimmée !");
        }
        */
    }
}
