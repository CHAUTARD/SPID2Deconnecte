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
    internal class Package
    {
        // "PKG_ID"	NUMERIC(15, 0) NOT NULL,
        public ulong PKG_ID { get; set; }

        //  "UTIL_LB_LOGIN"	VARCHAR(15) NOT NULL,
        public string UTIL_LB_LOGIN { get; set; }

        // "PKG_LB"	VARCHAR(32),
        public string PKG_LB { get; set; }

        // "PKG_ETAT"	CHAR(1),
        public char PKG_ETAT { get; set; }

        // "PKG_LB_USER_MODIF"	VARCHAR(15),
        public string PKG_LB_USER_MODIF { get; set; }

        // "PKG_DT_MODIFICATION"	DATE,
        public DateTime PKG_DT_MODIFICATION { get; set; }

        // "PKG_DT_CREATION"	DATE,
        public DateTime PKG_DT_CREATION { get; set; }

        // "PKG_DATE_DESC"	DATE,
        public DateTime PKG_DATE_DESC { get; set; }

        // "PKG_DATE_MONTE"	DATE,
        public DateTime? PKG_DATE_MONTE { get; set; }
    }
}
