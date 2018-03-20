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
    public static class MotifVisiteDAO
    {
        public static MOTIF_VISITE FindById(string code)
        {
            //A faire : rechercher un motif visite par son nom
            MOTIF_VISITE m1 = null;
            using (var context = new GSB_visite_3Entities())
            {
                var req = from m in context.MOTIF_VISITE.Include("LesRapports")
                          where m.MOT_CODE == code
                          select m;
                m1 = req.SingleOrDefault<MOTIF_VISITE>();
            }

            return m1;
        }

        public static List<MOTIF_VISITE> FindAll()
        {
            //A faire : charger tous les motifs visite
            List<MOTIF_VISITE> motifs = null;
            using (var context = new GSB_visite_3Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MOTIF_VISITE
                          select m;
                motifs = req.ToList<MOTIF_VISITE>();

            }
            return motifs;
        }
    }
}
