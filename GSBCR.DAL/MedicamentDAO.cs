﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace GSBCR.DAL
{
    public static class MedicamentDAO
    {
        public static MEDICAMENT FindById(string depot)
        {
            //A faire : rechercher un médicament par son nom de dépot
            MEDICAMENT med = null;
            using (var context = new GSB_visite_3Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MEDICAMENT.Include("LaFamille")
                          where m.MED_DEPOTLEGAL == depot
                          select m;
                med = req.SingleOrDefault<MEDICAMENT>();

            }
            return med;
        }

        public static List<MEDICAMENT> FindAll()
        {
            //A faire : charger tous les médicaments
            List<MEDICAMENT> meds = null;
            using (var context = new GSB_visite_3Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MEDICAMENT.Include("LaFamille")
                          select m;
                meds = req.ToList<MEDICAMENT>();

            }
            return meds;
            
        }

        public static List<MEDICAMENT> FindByFamille(string code)
        {
            //A faire : charger tous les médicaments d'une famille
            List<MEDICAMENT> meds = null;
            using (var context = new GSB_visite_3Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MEDICAMENT.Include("LaFamille")
                          where m.FAM_CODE == code
                          select m;
                meds = req.ToList<MEDICAMENT>();

            }
            return meds;
           
        }
    }
}
