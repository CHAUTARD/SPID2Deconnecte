namespace SPID2Deconnecte.Modeles
{
    internal class Epreuve
    {
        public Epreuve()
        {
            EPR_EPRV_ID = (long?)null;
        }

        //  "EPRV_ID"	NUMERIC(15, 0) NOT NULL,
        public long EPRV_ID { get; set; }

        //  "ORGA_ID"	NUMERIC(15, 0) NOT NULL,
        public long ORGA_ID { get; set; }

        //  "EPR_EPRV_ID"	NUMERIC(15, 0), il n'existe pas dans les données en entrées
        public long? EPR_EPRV_ID { get; set; }

        //  "EPRV_CD"	CHAR(2) NOT NULL,
        public string EPRV_CD { get; set; }

        //  "EPRV_LB_COURT"	VARCHAR(5) NOT NULL,
        public string EPRV_LB_COURT { get; set; }

        //  "EPRV_LB"	VARCHAR(32) NOT NULL,
        public string EPRV_LB { get; set; }

        //  "EPRV_FG"	CHAR(1) NOT NULL,
        public char EPRV_FG { get; set; }

        //  "EPRV_CM"	VARCHAR(255),
        public string EPRV_CM { get; set; }

        //  "EPRV_LB_USER_MODIF"	VARCHAR(15) NOT NULL,
        public string EPRV_LB_USER_MODIF { get; set; }

        /*
        public Epreuve(IDataRecord dataRecord)
        {
            EPRV_ID = (long)dataRecord[0];
            ORGA_ID = (long)dataRecord[1];
            EPR_EPRV_ID = (long?)dataRecord[2];
            EPRV_CD = (string)dataRecord[3];
            EPRV_LB_COURT = (string)dataRecord[4];
            EPRV_LB = (string)dataRecord[5];
            EPRV_FG = (char)dataRecord[6];
            EPRV_CM = (string)dataRecord[7];
            EPRV_LB_USER_MODIF = (string)dataRecord[8];
        }
        public int GetIdMax()
        {
            int iRet = 0;

            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                string sQuery = string.Format("SELECT MAX(EPRV_ID) from EPREUVE");

                MySqlCommand comm = new MySqlCommand(sQuery, conn);
                iRet = comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors du comptage !");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return ++iRet;
        }


        internal void ReadById(long id)
        {
            using (var SingletonOutils.DATABASE = new PetaPoco.Database("MySqlConnection"))
            {
                SingletonOutils.DATABASE.SingleOrDefault<EpreuveCrud>("WHERE EPRV_ID=@0", id);
            }
        }

        internal void Insert()
        {
            // Epreuve locale
            EPRV_ID = 0;
            ORGA_ID = -101; // ???
            EPR_EPRV_ID = 9; // ???
            EPRV_FG = 'I'; // ???
            EPRV_LB_USER_MODIF = "SPID2D";

            EPRV_CD = EPRV_CD;
            EPRV_LB_COURT = EPRV_LB_COURT;
            EPRV_LB = EPRV_LB;
            EPRV_CM = EPRV_CM;

            using (var SingletonOutils.DATABASE = new PetaPoco.Database("MySqlConnection"))
            {
                SingletonOutils.DATABASE.Insert(epreuve);
            }
        }

        internal void Update()
        {
            EPRV_LB_USER_MODIF = "SPID2D";

            EPRV_ID = EPRV_ID;
            ORGA_ID = ORGA_ID;
            EPR_EPRV_ID = EPR_EPRV_ID;
            EPRV_CD = EPRV_CD;
            EPRV_LB_COURT = EPRV_LB_COURT;
            EPRV_LB = EPRV_LB;
            EPRV_FG = EPRV_FG;
            EPRV_CM = EPRV_CM;

            using (var SingletonOutils.DATABASE = new PetaPoco.Database("MySqlConnection"))
            {
                SingletonOutils.DATABASE.Update(epreuve);
            }
        }
        */

    }
}
