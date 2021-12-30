using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Windows;
using MySql.Data.MySqlClient;

namespace SPID2Deconnecte.Modeles
{
    internal class CatAgeGroupe : TableBase
    {
        public string GCAT_CD { get; set; }
        public string GCAT_LB_COURT { get; set; }
        public string GCAT_LB { get; set; }
    }
}
