using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace GSBCR.DAL
{
    public static class PratricienDAO
    {
        public static PRATICIEN FindById(Int16 pranum)
        {
            //A faire : rechercher un pratricien par son numéro
            PRATICIEN p1 = null;
            using (var context = new GSB_visite_3Entities())
            {
                var req = from p in context.PRATICIEN.Include("LesSpecialites")
                          where p.PRA_NUM == pranum
                          select p;
                p1 = req.SingleOrDefault<PRATICIEN>();
            }

            return p1;
        }

        public static List<PRATICIEN> FindAll()
        {
            //A faire : charger tous les praticiens
            List<PRATICIEN> pats = null;
            using (var context = new GSB_visite_3Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from p in context.PRATICIEN.Include("LeType")
                          select p;
                pats = req.ToList<PRATICIEN>();
            }
            return pats;
        }

        public static List<PRATICIEN> FindByType(string code)
        {
            //A faire : charger tous les praticiens d'un type
            return null;
        }
    }
}
