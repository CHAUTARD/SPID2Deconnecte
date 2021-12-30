using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Windows;

namespace SPID2Deconnecte.Modeles
{
    internal class Categorie : TableBase
    {
        // NUMERIC( 15,0)
        public ulong CAT_ID { get; set; }

        // CHAR(5)
        public string GCAT_CD { get; set; }

        // VARCHAR(32)
        public string CAT_LB { get; set; }

        // VARCHAR(5)
        public string CAT_CD { get; set; }

        // DATE
        public DateTime CAT_DT_DEB { get; set; }

        // DATE
        public DateTime CAT_DT_FIN { get; set;}

        // CHAR(1)
        public string CAT_FG { get; set; }

        // NUMERIC( 15,0)
        public ulong DEM_ID { get; set; }
    }
}

