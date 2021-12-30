namespace SPID2Deconnecte.Modeles
{
    internal class Column
    {
        /*
         *  Field 	        Type 	    Null 	Key 	Default 	Extra 	
         *  ORGA_ID 	    bigint(20) 	NO 	    PRI 	NULL 	
         *  ORG_ORGA_ID 	bigint(20) 	YES 	MUL 	NULL 	
         *  ORGA_LB 	    varchar(32) NO 		NULL 	
         *  ORGA_CD 	    varchar(5) 	NO 		NULL 	
         *  ORGA_FG 	    char(2) 	NO 		NULL 	
         *  ORGA_BL_MODULE 	tinyint(4) 	NO 		0 	
         *  BL_MAJ 	        tinyint(1) 	NO 		0 	
        */
        public string FIELD { get; set; }
        public string TYPE { get; set; }
        public string NULL { get; set; }
        public string KEY { get; set; }
        public string DEFAULT { get; set; }
        public string EXTRA { get; set; }

        public Column(string fIELD, string tYPE, string nULL, string kEY, string dEFAULT, string eXTRA)
        {
            FIELD = fIELD;
            TYPE = tYPE;
            NULL = nULL;
            KEY = kEY;
            DEFAULT = dEFAULT;
            EXTRA = eXTRA;
        }
    }
}
