using SPID2Deconnecte.Modeles;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace SPID2Deconnecte
{
    internal class TableauCrud : Tableau
    {
        public TableauCrud()
        {
        }

        public void FromTxt(string line)
        {
            /*
             *           1         2         3         4         5         6         7         8         9                   10        11        12        13        14        15        16        17        18        19        20        21        22        23        24        25        26        27        28        29        30        31        32        33        34        35   .    36        37        38        39        40        41        42        43        44        45        46        47        48        49        50        51        52        53        54        55        56        57        58        59        60        61        62        63        64        65        66        67        68        69        70        71        72        73           
             * 012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123
             * 39997                         39879          Groupe 1     Groupe 1                        21/11/2021                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              sportive.ligue@28/09/202107/07/2021
             */
            int pos = 0;

            TAB_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;
            TABREF_ID = SingletonOutils.LongParse(line.Substring(pos, 15));
            pos += 15;
            TOUR_ID = Convert.ToInt64(line.Substring(pos, 15));
            pos += 15;
            //MessageBox.Show(">" + line.Substring(pos, 8)+"<");
            TAB_NB_GROUPE = 0; //  Convert.ToUInt16( line.Substring(pos, 8));
            pos += 8;
            TAB_CD_TABLEAU = SingletonOutils.StringParse(line.Substring(pos, 5));
            pos += 5;
            TAB_LB = SingletonOutils.StringParse(line.Substring(pos, 32));
            pos += 32;
            TAB_DT_HEURE = DateTime.ParseExact(line.Substring(pos, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            pos += 10;
            TAB_LB_LIEU = SingletonOutils.StringParse(line.Substring(pos, 32));
            pos += 32;
            TAB_CM_TABLEAU = SingletonOutils.StringParse(line.Substring(pos, 255));
            pos += 255;
            TAB_CM_TABLE_JUGE = SingletonOutils.StringParse(line.Substring(pos, 255));
            pos += 255;
            TAB_LB_RAPPORT = SingletonOutils.StringParse(line.Substring(pos, 64));
            pos += 64;
            TAB_LB_USER_MODIF = line.Substring(pos, 15);
            pos += 15;
            TAB_DT_MODIFICATION = SingletonOutils.DateParse(line.Substring(pos, 10));
            pos += 10;
            TAB_DT_CREATION = DateTime.ParseExact(line.Substring(pos, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert("TABLEAU");
            }
        }

    }
}