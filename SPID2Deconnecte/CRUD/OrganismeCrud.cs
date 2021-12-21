using SPID2Deconnecte.Modeles;
using System;


namespace SPID2Deconnecte.CRUD
{
    internal class OrganismeCrud : Organisme
    {
        public OrganismeCrud()
        {
        }

        public OrganismeCrud(long IdOrganisme)
        {
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                // Recherche du joueur dans la table des licenciers
                db.SingleOrDefault<Organisme>("SELECT * FROM ORGANISME WHERE ORGA_ID=@0", args: IdOrganisme);
            }
        }
    }
}
