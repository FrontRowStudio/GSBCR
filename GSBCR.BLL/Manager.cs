﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using GSBCR.DAL;

namespace GSBCR.BLL
{
    public static class Manager
    {
         /// <summary>
        /// Permet de charger un visiteur à partir de son login et mot de passe
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <param name="mdp">mot de passe Visiteur</param>
        /// <returns>objet VISITEUR</returns>
        public static VISITEUR ChargerVisiteur(string matricule, string mdp)
        {
            VISITEUR vis = VisiteurDAO.FindById(matricule);
            if ((vis != null) && (vis.vis_mdp == mdp))
                return vis;
            else
                return null;

        }
        /// <summary>
        /// Permet de charger la dernière affectation du visiteur
        /// et donc son profil (visiteur, délégué, responsabe secteur) et sa région
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <returns>objet VAFFECTATION</returns>
        public static VAFFECTATION ChargerAffectationVisiteur(string matricule)
        {
            VAFFECTATION vaff = VaffectationDAO.FindByMatricule(matricule);
            return vaff;
        }
        /// Permet de charger les rapports non terminés du visiteur (état 1)
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <returns>List<RAPPORT_VISITE></returns>
        public static List<RAPPORT_VISITE> ChargerRapportVisiteurEncours(String m)
        {
            List<RAPPORT_VISITE> lr;
            List<string> lm = new List<string>();
            lm.Add(m);
            List<int> le = new List<int>();
            le.Add(1);
            lr = RapportVisiteDAO.FindByEtatEtVisiteur(lm, le);
            return lr;
        }
        /// Permet de charger un rapport de visite
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <param name="n">numéro rapport</param>
        /// <returns>RAPPORT_VISITE</returns>
        public static RAPPORT_VISITE ChargerRapportVisite(string m, int n)
        {
            RAPPORT_VISITE r = RapportVisiteDAO.FindById(m, n);
            return r;
        }
        /// Permet de charger les rapports terminés du visiteur (état 2 et 3) 
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportVisiteurFinis(String m)
        {
            List<int> ListeEtat = new List<int>();
            ListeEtat.Add(2);
            ListeEtat.Add(3);
            List<string> ListeVisiteur = new List<string>();
            ListeVisiteur.Add(m);
            List<RAPPORT_VISITE> lrv = RapportVisiteDAO.FindByEtatEtVisiteur(ListeVisiteur, ListeEtat);
            return lrv;
        }
        /// <summary>
        /// Permet de retourner une liste de visiteurs pour un région à partir de vaffectation
        /// </summary>
        /// <param name="regionCode">code région</param>
        /// <returns>List<VISITEUR></returns>
        public static List<VISITEUR> ChargerVisiteurByRegion(string regionCode)
        {
            List<VISITEUR> lv = new List<VISITEUR>();
            VISITEUR vis;
            List<VAFFECTATION> lvaff = VaffectationDAO.FindByRegion(regionCode);
            foreach (VAFFECTATION vaff in lvaff)
            {
                vis = VisiteurDAO.FindById(vaff.VIS_MATRICULE);
                lv.Add(vis);
            }
            return lv;
        }
    /// Permet de charger les rapports non consultés (état 2) des visiteurs d'une région  
    /// </summary>
    /// <param name="code">code région</param>
    /// <returns>List<RAPPORT_VISITE>/returns>
    public static List<RAPPORT_VISITE> ChargerRapportRegionNonLus(String code)
        {
            //A faire : charger les rapports terminés et non lus (état = 2 ) des visiteurs d'une région
            List<RAPPORT_VISITE> lrv = new List<RAPPORT_VISITE>();
            List<VAFFECTATION> lva = VaffectationDAO.FindByRegion(code);
            foreach (VAFFECTATION uneAffectation in lva)
            {
                lrv.Add(RapportVisiteDAO.FindById(uneAffectation.VIS_MATRICULE, 2));
            }
            return lrv;
        }
        /// Permet de charger les rapports terminés et consultés (état 3) des visiteurs d'une région 
        /// </summary>
        /// <param name="r">code région</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportRegionLus(String r)
        {
            //A faire : charger les rapports terminés (état = 3) des visiteurs d'une région
            List<RAPPORT_VISITE> lrv = new List<RAPPORT_VISITE>();
            List<VAFFECTATION> lva = VaffectationDAO.FindByRegion(r);
            foreach (VAFFECTATION uneAffectation in lva)
            {
                lrv.Add(RapportVisiteDAO.FindById(uneAffectation.VIS_MATRICULE, 3));
            }
            return lrv;
        }
        /// <summary>
        /// Permet de créer un rapport dans la base de données 
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public static void CreateRapport(RAPPORT_VISITE r)
        {
            RapportVisiteDAO.insert(r);
        }

        /// <summary>
        /// Permet de mettre à jour un rapport dans la base de données 
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public static void MajRapport(RAPPORT_VISITE r)
        {
            RapportVisiteDAO.update(r);
           
        }
        /// <summary>
        /// Permet de charger un médicament à partir de son nom de dépot légal
        /// </summary>
        /// <param name="depot">chaine caractères</param>
        public static MEDICAMENT ChargerLeMedicament(string depot)
        {
            MEDICAMENT l = MedicamentDAO.FindById(depot);
            return l;
        }
        /// <summary>
        /// Permet de charger tous les médicaments
        /// </summary>
        public static List<MEDICAMENT> ChargerMedicaments()
        {
            List<MEDICAMENT> lm = MedicamentDAO.FindAll();
            return lm;
        }
        /// <summary>
        /// Permet de charger tous les motifs visite
        /// </summary>
        public static List<MOTIF_VISITE> ChargerMotifVisites()
        {
            List<MOTIF_VISITE> lmv = MotifVisiteDAO.FindAll();
            return lmv;
        }
        /// <summary>
        /// Permet de charger tous les praticiens
        /// </summary>
        public static List<PRATICIEN> ChargerPraticiens()
        {
            List<PRATICIEN> lp = PratricienDAO.FindAll();
            return lp;
        }
        /// <summary>
        /// Permet de charger un praticien à partir de son numéro
        /// <param name="pranum">entier</param>
        /// </summary>
        public static PRATICIEN ChargerLePraticien(Int16 pranum)
        {
            return PratricienDAO.FindById(pranum); 
        }
    }
}
