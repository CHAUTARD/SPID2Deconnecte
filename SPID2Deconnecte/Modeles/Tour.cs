/*
 * Crée par SharpDevelop.
 * Utilisateur: CHAUTARD
 * Date: 13/12/2019
 * Heure: 08:01
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */

using System;

namespace SPID2Deconnecte.Modeles
{
    internal class Tour
    {
        // "TOUR_ID"	NUMERIC(15, 0) NOT NULL,
        public long TOUR_ID { get; set; }

        // "DIV_ID"	NUMERIC(15, 0) NOT NULL,
        public long DIV_ID { get; set; }

        // "TOUR_LB"	VARCHAR(32),
        public string TOUR_LB { get; set; }

        // "TOUR_NB_GROUPE"	INTEGER,
        public int? TOUR_NB_GROUPE { get; set; }

        // "TOUR_NB_POULE"	INTEGER,
        public int? TOUR_NB_POULE { get; set; }

        // "TOUR_NB_JOUEUR"	INTEGER,
        public int? TOUR_NB_JOUEUR { get; set; }

        // "TOUR_NB_JOUEUR_DESC"	INTEGER,
        public int? TOUR_NB_JOUEUR_DESC { get; set; }

        // "TOUR_NB_JOUEUR_MONT"	INTEGER,
        public int? TOUR_NB_JOUEUR_MONT { get; set; }

        // "TOUR_DT"	DATE,
        public DateTime TOUR_DT { get; set; }

        // "TOUR_LB_USER_MODIF"	VARCHAR(15),
        public string TOUR_LB_USER_MODIF { get; set; }

        // "TOUR_DT_MODIFICATION"	DATE,
        public DateTime TOUR_DT_MODIFICATION { get; set; }

        // "TOUR_DT_CREATION"	DATE,
        public DateTime TOUR_DT_CREATION { get; set; }

        // "GRIL_ID_RENC"	NUMERIC(15, 0),
        public long? GRIL_ID_RENC { get; set; }

        // "TOUR_BL_CLOTURE"	NUMERIC(1, 0),
        public int? TOUR_BL_CLOTURE { get; set; }

        // "TOUR_NM"	INTEGER,
        public int? TOUR_NM { get; set; }

        // "DIV_DIV_LB"	VARCHAR(32),
        public string DIV_DIV_LB { get; set; }

        // "DIV2_DIV_LB"	VARCHAR(32),
        public string DIV2_DIV_LB { get; set; }
        /*
        public int? GetIdTourByDivId(long divId)
        {
            MySqlCommand command = new MySqlCommand("SELECT TOUR_ID FROM TOUR WHERE DIV_ID = " + divId.ToString(), SingletonOutils.DATABASE);

            MySqlDataReader reader = command.ExecuteReader();
            if (reader == null)
                return null;

            return reader.GetInt32(0);
        }
        */
    }
}
