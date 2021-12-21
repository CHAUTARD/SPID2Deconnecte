using System;
using PetaPoco;

namespace SPID2Deconnecte.Modeles
{
    [TableName("MEMO")]
    [PrimaryKey("MEMO", AutoIncrement = false)]

    internal class Memo
    {
        public string MEMO { get; set; }

        public Memo(string str)
        {
            this.MEMO = str;
        }

        public Memo()
        {
        }
    }
}
