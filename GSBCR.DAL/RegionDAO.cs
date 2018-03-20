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
    public static class RegionDAO
    {
        public static REGION FindById(string code)
        {
            //A faire : rechercher un médicament par son nom de dépot
            REGION reg = null;
            using (var context = new GSB_visite_3Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.REGION.Include("LeSecteur").Include("LesVisiteursAffectes")
                          where r.REG_CODE == code
                          select r;
                reg = req.SingleOrDefault<REGION>();

            }
            return reg;
        }

        public static List<REGION> FindAll()
        {
            //A faire : rechercher un médicament par son nom de dépot
            List<REGION> regs = null;
            using (var context = new GSB_visite_3Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.REGION.Include("LeSecteur").Include("LesVisiteursAffectes")
                          select r;
                regs = req.ToList<REGION>();

            }
            return regs;
        }
    }
}
