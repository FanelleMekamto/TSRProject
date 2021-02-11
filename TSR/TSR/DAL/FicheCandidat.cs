using System;
using System.Collections.Generic;
using System.Text;

namespace TSR.DAL
{
    public class FicheCandidat
    {
        public int Age { get; set; }
        public int PointTotal { get; set; }
        public int DetailCompetence { get; set; }
    public int EtudeComplete { get; set; }
        //public int NiveauEtude { get; set; }
        public int AnneeExperienceTravailCanada { get; set; }
        public int AnneeExperienceTravailEtranger { get; set; }
        public int AnneeExperienceTravailConjointCanada { get; set; }
        public int NiveauCompetenceOffre { get; set; }
        public int LangueOfficielle { get; set; }
        public int LangueOfficielleConjoint { get; set; }
        public Boolean AObtenuDiplomeCanadien { get; set; }
        public Boolean ACertificatCompetence { get; set; }
        public Boolean AOffreEmploi { get; set; }
        public int GroupeOffreEmploi { get; set; }
        public Boolean ACertificatDesignationProvince { get; set; }
        public Boolean AObtenuDiplomeCanadienConjoint { get; set; }
        public Boolean PresenceFrere { get; set; }
        public int DescriptionEtudeCanadien { get; set; }
        public int NoteLinguistique { get; set; }
        public int NoteLinguistiqueConjoint { get; set; }
        public Boolean ConjointAccompagne { get; set; }
        public int EtudeCompleteConjoint { get; set; }
        
        public void  PointAge(int age, Boolean conjointAccompagne)
        {
            int pointAge = 0;
                switch (age)
                {
                    case 0:
                    case 1:
                        pointAge =  0;
                        break;
                    case 2:
                        pointAge = !conjointAccompagne ? 99 : 90;
                        break;
                    case 3:
                        pointAge = !conjointAccompagne ? 105:95;
                        break;
                    case 4:
                        pointAge = !conjointAccompagne ? 110:100;
                        break;
                    case 5:
                        pointAge = !conjointAccompagne ? 105:95;
                        break;
                    case 6:
                        pointAge = !conjointAccompagne ? 99:90;
                        break;
                    case 7:
                        pointAge = !conjointAccompagne ? 94:85;
                        break;
                    case 8:
                        pointAge = !conjointAccompagne ? 88:80;
                        break;
                    case 9:
                        pointAge = !conjointAccompagne ? 83:75;
                        break;
                    case 10:
                        pointAge = !conjointAccompagne ? 77:70;
                        break;
                    case 11:
                        pointAge = !conjointAccompagne ? 72:65;
                        break;
                    case 12:
                        pointAge = !conjointAccompagne ? 66:60;
                        break;
                    case 13:
                        pointAge = !conjointAccompagne ? 61:55;
                        break;
                    case 14:
                        pointAge = !conjointAccompagne ? 55:50;
                        break;
                    case 15:
                        pointAge = !conjointAccompagne ? 50:45;
                        break;
                    case 16:
                        pointAge = !conjointAccompagne ? 39:35;
                        break;
                    case 17:
                        pointAge = !conjointAccompagne ? 28:25;
                        break;
                    case 18:
                        pointAge = !conjointAccompagne ? 17:15;
                        break;
                    case 19:
                        pointAge = !conjointAccompagne ? 6:5;
                        break;
                    case 20:
                        pointAge = 0;
                        break;
                    default:
                        pointAge = 0;
                        break;
            }

            PointTotal += pointAge;
        }

        public void pointageNiveauDeScolarite(Boolean aObtenuDiplomeCanadien, int niveauEtudeComplete, Boolean conjointAccompagne)
        {
            int pointEtude=0;

            if (aObtenuDiplomeCanadien) {
                switch (niveauEtudeComplete)
                {
                    case 1:
                        pointEtude = 0;
                        break;
                    case 2:
                        pointEtude = !conjointAccompagne ? 30 : 28;
                        break;
                    case 3:
                        pointEtude = !conjointAccompagne ? 90 : 84;
                        break;
                    case 4:
                        pointEtude = !conjointAccompagne ? 98 : 91;
                        break;
                    case 5:
                        pointEtude = !conjointAccompagne ? 120 : 112;
                        break;
                    case 6:
                        pointEtude = !conjointAccompagne ? 128 : 119;
                        break;
                    case 7:
                        pointEtude = !conjointAccompagne ? 135 : 126;
                        break;
                    case 8:
                        pointEtude = !conjointAccompagne ? 150 : 140;
                        break;
                }
            }
            PointTotal += pointEtude;
        }

        public void pointageNiveauDeScolariteConjoint(Boolean aObtenuDiplomeCanadien, int niveauEtudeComplete)
        {
            int pointEtude = 0;

            if (aObtenuDiplomeCanadien)
            {
                switch (niveauEtudeComplete)
                {
                    case 1:
                        pointEtude = 0;
                        break;
                    case 2:
                        pointEtude = 2;
                        break;
                    case 3:
                        pointEtude = 6;
                        break;
                    case 4:
                        pointEtude = 7;
                        break;
                    case 5:
                        pointEtude = 8;
                        break;
                    case 6:
                        pointEtude = 9;
                        break;
                    case 7:
                        pointEtude = 10;
                        break;
                    case 8:
                        pointEtude = 10;
                        break;
                }
            }
            PointTotal += pointEtude;
        }

        //To modify
        public int pointagePremiereLangue(Boolean expire, int choixTest, int noteEO, int notesCO,int notesCE, int notesEE, Boolean conjointAccompagne)
        {
            int pointTestPremiereLangue = 0;

            if (!expire)
            {
                switch (choixTest)
                {
                    case 1:
                        pointTestPremiereLangue = 0;
                        break;
                    case 2:
                        pointTestPremiereLangue = conjointAccompagne ? 30 : 28;
                        break;
                    case 3:
                        pointTestPremiereLangue = conjointAccompagne ? 90 : 84;
                        break;
                    case 4:
                        pointTestPremiereLangue = conjointAccompagne ? 98 : 91;
                        break;
                    case 5:
                        pointTestPremiereLangue = conjointAccompagne ? 120 : 112;
                        break;
                    case 6:
                        pointTestPremiereLangue = conjointAccompagne ? 128 : 119;
                        break;
                    case 7:
                        pointTestPremiereLangue = conjointAccompagne ? 135 : 126;
                        break;
                    case 8:
                        pointTestPremiereLangue = conjointAccompagne ? 150 : 140;
                        break;
                }
            }
            PointTotal += pointTestPremiereLangue;

            return pointTestPremiereLangue;
        }

        public int pointageDeuxiemeLangue(Boolean expire, int choixTest, int noteEO, int notesCO, int notesCE, int notesEE, Boolean conjointAccompagne)
        {
            int pointTestDeuxiemeLangue = 0;

            if (!expire)
            {
                switch (choixTest)
                {
                    case 1:
                        pointTestDeuxiemeLangue = 0;
                        break;
                    case 2:
                        pointTestDeuxiemeLangue = conjointAccompagne ? 30 : 28;
                        break;
                    case 3:
                        pointTestDeuxiemeLangue = conjointAccompagne ? 90 : 84;
                        break;
                    case 4:
                        pointTestDeuxiemeLangue = conjointAccompagne ? 98 : 91;
                        break;
                    case 5:
                        pointTestDeuxiemeLangue = conjointAccompagne ? 120 : 112;
                        break;
                    case 6:
                        pointTestDeuxiemeLangue = conjointAccompagne ? 128 : 119;
                        break;
                    case 7:
                        pointTestDeuxiemeLangue = conjointAccompagne ? 135 : 126;
                        break;
                    case 8:
                        pointTestDeuxiemeLangue = conjointAccompagne ? 150 : 140;
                        break;
                }
            }
            PointTotal += pointTestDeuxiemeLangue;

            return pointTestDeuxiemeLangue;
        }

        public int pointageLangueConjoint(Boolean TestExpire, int choixTest, int noteEO, int notesCO, int notesCE, int notesEE, Boolean conjointAccompagne)
        {
            int pointTestLangueConjoint = 0;

            if (!TestExpire)
            {
                switch (choixTest)
                {
                    case 1:
                        pointTestLangueConjoint = 0;
                        break;
                    case 2:
                        pointTestLangueConjoint = conjointAccompagne ? 30 : 28;
                        break;
                    case 3:
                        pointTestLangueConjoint = conjointAccompagne ? 90 : 84;
                        break;
                    case 4:
                        pointTestLangueConjoint = conjointAccompagne ? 98 : 91;
                        break;
                    case 5:
                        pointTestLangueConjoint = conjointAccompagne ? 120 : 112;
                        break;
                    case 6:
                        pointTestLangueConjoint = conjointAccompagne ? 128 : 119;
                        break;
                    case 7:
                        pointTestLangueConjoint = conjointAccompagne ? 135 : 126;
                        break;
                    case 8:
                        pointTestLangueConjoint = conjointAccompagne ? 150 : 140;
                        break;
                }
            }
            PointTotal += pointTestLangueConjoint;

            return pointTestLangueConjoint;
        }

        public int pointageExperienceTravail(int anneeExperience, Boolean conjointAccompagne)
        {
            int pointExpTravailCanada = 0;

                switch (anneeExperience)
                {
                    case 1:
                        pointExpTravailCanada = 0;
                        break;
                    case 2:
                        pointExpTravailCanada = conjointAccompagne ? 35 : 40;
                        break;
                    case 3:
                        pointExpTravailCanada = conjointAccompagne ? 46 : 53;
                        break;
                    case 4:
                        pointExpTravailCanada = conjointAccompagne ? 56 : 64;
                        break;
                    case 5:
                        pointExpTravailCanada = conjointAccompagne ? 63 : 72;
                        break;
                    case 6:
                        pointExpTravailCanada = conjointAccompagne ? 70 : 80;
                        break;
                }
            
            PointTotal += pointExpTravailCanada;

            return pointExpTravailCanada;
        }

        public int pointageExperienceTravailConjoint(int anneeExperience)
        {
            int pointExperienceTravailConjoint = 0;

            switch (anneeExperience)
            {
                case 1:
                    pointExperienceTravailConjoint = 0;
                    break;
                case 2:
                    pointExperienceTravailConjoint = 5;
                    break;
                case 3:
                    pointExperienceTravailConjoint = 7;
                    break;
                case 4:
                    pointExperienceTravailConjoint = 8;
                    break;
                case 5:
                    pointExperienceTravailConjoint = 9;
                    break;
                case 6:
                    pointExperienceTravailConjoint = 10;
                    break;
            }

            PointTotal += pointExperienceTravailConjoint;

            return pointExperienceTravailConjoint;
        }

        //À Modifier
        public int combinaisonScolariteLangues(int niveauEtudeComplete, int pointPremiereLangue)
        {
            int pointCombinaisonSL = 0;

            if (niveauEtudeComplete == 0 || niveauEtudeComplete ==1)
                pointCombinaisonSL = 0;

            if (niveauEtudeComplete == 2 && pointPremiereLangue == 9)
                pointCombinaisonSL = 13;

            if (niveauEtudeComplete == 3 && pointPremiereLangue == 9)
                pointCombinaisonSL = 25;

            if (niveauEtudeComplete == 9 && pointPremiereLangue == 9)
                pointCombinaisonSL = 25;

            if (niveauEtudeComplete == 9 && pointPremiereLangue == 9)
                pointCombinaisonSL = 50;

            PointTotal += pointCombinaisonSL;

            return pointCombinaisonSL;
        }

        public int combinaisonScolariteTravailCanada(int niveauEtudeComplete, int pointTravailCanada)
        {
            int pointCombinaisonSTc = 0;

            if (niveauEtudeComplete == 0 || niveauEtudeComplete == 1)
                pointCombinaisonSTc = 0;

            if (niveauEtudeComplete <= 2 && pointTravailCanada == 2)
                pointCombinaisonSTc = 13;

            if (niveauEtudeComplete <= 2 && pointTravailCanada >= 3)
                pointCombinaisonSTc = 25;
           
            if (niveauEtudeComplete >= 6 && pointTravailCanada == 2)
                pointCombinaisonSTc = 25;

            if (niveauEtudeComplete >= 6 && pointTravailCanada >= 3)
                pointCombinaisonSTc = 50;

            PointTotal += pointCombinaisonSTc;

            return pointCombinaisonSTc;
        }

        //À modifier
        public int combinaisonLangueTravailEtranger(int pointLangue, int pointTravailEtranger)
        {
            int pointCombinaisonLTe = 0;

            if (pointTravailEtranger == 0 || pointTravailEtranger == 1)
                pointCombinaisonLTe = 0;

            if (pointLangue == 9 && (pointTravailEtranger == 2 || pointTravailEtranger == 3))
                pointCombinaisonLTe = 13;

            if (pointLangue == 9 && (pointTravailEtranger == 2 || pointTravailEtranger == 3))
                pointCombinaisonLTe = 25;

            if (pointLangue == 9 && pointTravailEtranger >= 4)
                pointCombinaisonLTe = 25;

            if (pointLangue == 9 && pointTravailEtranger >= 4)
                pointCombinaisonLTe = 50;

            PointTotal += pointCombinaisonLTe;

            return pointCombinaisonLTe;
        }

        public int combinaisonTravailCanada_Etranger(int anneeExperienceTravailEtranger, int anneeExperienceTravailCanada)
        {
            int pointCombinaisonTcTe = 0;

            if (anneeExperienceTravailEtranger == 0 || anneeExperienceTravailEtranger == 1)
                pointCombinaisonTcTe = 0;

            if ((anneeExperienceTravailEtranger == 2 || anneeExperienceTravailEtranger == 3) && anneeExperienceTravailCanada == 2)
                pointCombinaisonTcTe = 13;

            if ((anneeExperienceTravailEtranger == 2 || anneeExperienceTravailEtranger == 3) && anneeExperienceTravailCanada >= 3)
                pointCombinaisonTcTe = 25;

            if (anneeExperienceTravailEtranger == 4 && anneeExperienceTravailCanada == 2)
                pointCombinaisonTcTe = 25;

            if (anneeExperienceTravailEtranger == 4 && anneeExperienceTravailCanada >= 3)
                pointCombinaisonTcTe = 50;

            PointTotal += pointCombinaisonTcTe;

            return pointCombinaisonTcTe;
        }

        //À modifier (Niveaux de compétence linguistique canadiens et dans le Canadian Language Benchmarks)
        public int combinaisonLangueCertificatCompetence(int pointLangue, int pointCertificat)
        {
            int pointCombinaisonCL = 0;

            if (pointLangue == 0 && pointCertificat == 0)
                pointCombinaisonCL = 25;

            if (pointLangue == 9 && pointCertificat == 9)
                pointCombinaisonCL = 50;

            PointTotal += pointCombinaisonCL;

            return pointCombinaisonCL;
        }

        public int designationProvince(bool aDesignation)
        {
            int pointDesignation = 0;

            if (aDesignation)
            {
                    pointDesignation = 600;
            }
    
            PointTotal += pointDesignation;

            return pointDesignation;
        }

        public int OffreEmploiAdmissible(bool aOffreEmploi, int gpeEmploi)
        {
            int pointOffreEmploi = 0;

            if (aOffreEmploi)
            {
                if (gpeEmploi == 0)
                {
                    pointOffreEmploi = 200;
                }
                else
                {
                    pointOffreEmploi = 50;
                }
            }

            PointTotal += pointOffreEmploi;

            return pointOffreEmploi;
        }

        public int presenceFraternite(bool aFrere)
        {
            int pointFrere = 0;
            if (aFrere)
            {
                pointFrere = 15;
            }
            PointTotal += pointFrere;

            return pointFrere;
        }

        //À modifier
        public int pointSuppLangueFrancais(bool testLinguitiqueValide, int pointLangueF)
        {
            int suppLangue = 0;

            if (pointLangueF > 7)
            {
                suppLangue = 25;
            }
            if (testLinguitiqueValide && pointLangueF > 7)
            {
                suppLangue = 25;
            }
            PointTotal += suppLangue;

            return suppLangue;
        }

        public int pointSuppDiplomeCanadien(int niveauEtude)
        {
            int suppDiplomeCanadien=0;
            if (niveauEtude == 0 || niveauEtude == 1)
            {
                suppDiplomeCanadien = 0;
            }
            if (niveauEtude == 2 || niveauEtude == 3)
            {
                suppDiplomeCanadien = 15;
            }
            if (niveauEtude >= 4)
            {
                suppDiplomeCanadien = 30;
            }

            PointTotal += suppDiplomeCanadien;

            return suppDiplomeCanadien;
        }

        // À paufiner
        public void calculerResultat()
        {
            this.PointAge(this.Age, this.ConjointAccompagne);
            
            this.pointageNiveauDeScolarite(this.AObtenuDiplomeCanadien,  this.EtudeComplete, this.ConjointAccompagne);
           
            this.pointageNiveauDeScolariteConjoint(this.AObtenuDiplomeCanadien, this.EtudeComplete);
           
            //int pointPremiereLangue = this.pointagePremiereLangue(this.Expire, this.ChoixTest, int noteEO, int notesCO, int notesCE, int notesEE, this.ConjointAccompagne);
            
            //this.pointageDeuxiemeLangue(this.Expire, this.ChoixTest, int noteEO, int notesCO, int notesCE, int notesEE, this.ConjointAccompagne);
           
            //this.pointageLangueConjoint(this.Expire, this.ChoixTest, int noteEO, int notesCO, int notesCE, int notesEE, this.ConjointAccompagne);
           
            int pointTravailCanada = this.pointageExperienceTravail(this.AnneeExperienceTravailCanada, this.ConjointAccompagne);
           
            this.pointageExperienceTravailConjoint(this.AnneeExperienceTravailConjointCanada);
            
           // int pointTravailEtranger = ;
            
            // this.combinaisonScolariteLangues(this.NiveauEtude, pointPremiereLangue);
            
            this.combinaisonScolariteTravailCanada(this.DescriptionEtudeCanadien, pointTravailCanada);

            //this.combinaisonLangueTravailEtranger(pointPremiereLangue,  pointTravailEtranger);

            this.combinaisonTravailCanada_Etranger(AnneeExperienceTravailEtranger, AnneeExperienceTravailCanada);

            //this.combinaisonLangueCertificatCompetence( pointLangue, pointCertificat);

            this.OffreEmploiAdmissible(AOffreEmploi, GroupeOffreEmploi);

            this.presenceFraternite(this.PresenceFrere);
            
            //this.pointSuppLangueFrancais(testLinguistiqueValide, pointLangueF);

            this.pointSuppDiplomeCanadien(this.DescriptionEtudeCanadien);
        }
    }
}
