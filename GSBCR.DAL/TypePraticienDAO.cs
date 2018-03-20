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
    public static class TypePraticienDAO
    {
        public static TYPE_PRATICIEN FindById(string code)
        {
            //A faire : rechercher un médicament par son nom de dépot
            TYPE_PRATICIEN typ = null;
            using (var context = new GSB_visite_3Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from t in context.TYPE_PRATICIEN.Include("LesPraticiens")
                          where t.TYP_CODE == code
                          select t;
                typ = req.SingleOrDefault<TYPE_PRATICIEN>();

            }
            return typ;
        }

        public static List<TYPE_PRATICIEN> FindAll()
        {
            //A faire : rechercher un médicament par son nom de dépot
            List<TYPE_PRATICIEN> typs = null;
            using (var context = new GSB_visite_3Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from t in context.TYPE_PRATICIEN.Include("LesPraticiens")
                          select t;
                typs = req.ToList<TYPE_PRATICIEN>();

            }
            return typs;
        }

    }
}
