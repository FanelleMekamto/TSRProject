using System;
using System.Collections.Generic;
using System.Text;

namespace TSR.DAL
{
    public class FicheCandidat
    {
        public int Age { get; set; }
        public int PointTotal { get; set; }
        public int EtudeComplete { get; set; }
        public int AnneeEpérienceTravailCanada { get; set; }
        public int AnneeEpérienceTravailConjointCanada { get; set; }
        public int AnneeEpérienceTravailEtranger { get; set; }
        public int NiveauCompetenceOffre { get; set; }
        public int LangueOfficielle { get; set; }
        public int LangueOfficielleConjoint { get; set; }
        public Boolean AObtenuDiplomeCanadien { get; set; }
        public Boolean ACertificatCompetence { get; set; }
        public Boolean AOffreEmploi { get; set; }
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
        public void pointagePremiereLangue(Boolean expire, int choixTest, int noteEO, int notesCO,int notesCE, int notesEE, Boolean conjointAccompagne)
        {
            int pointTestLangue = 0;

            if (!expire)
            {
                switch (choixTest)
                {
                    case 1:
                        pointTestLangue = 0;
                        break;
                    case 2:
                        pointTestLangue = conjointAccompagne ? 30 : 28;
                        break;
                    case 3:
                        pointTestLangue = conjointAccompagne ? 90 : 84;
                        break;
                    case 4:
                        pointTestLangue = conjointAccompagne ? 98 : 91;
                        break;
                    case 5:
                        pointTestLangue = conjointAccompagne ? 120 : 112;
                        break;
                    case 6:
                        pointTestLangue = conjointAccompagne ? 128 : 119;
                        break;
                    case 7:
                        pointTestLangue = conjointAccompagne ? 135 : 126;
                        break;
                    case 8:
                        pointTestLangue = conjointAccompagne ? 150 : 140;
                        break;
                }
            }
            PointTotal += pointTestLangue;
        }

        public void pointageDeuxiemeLangue(Boolean expire, int choixTest, int noteEO, int notesCO, int notesCE, int notesEE, Boolean conjointAccompagne)
        {
            int pointTestLangue = 0;

            if (!expire)
            {
                switch (choixTest)
                {
                    case 1:
                        pointTestLangue = 0;
                        break;
                    case 2:
                        pointTestLangue = conjointAccompagne ? 30 : 28;
                        break;
                    case 3:
                        pointTestLangue = conjointAccompagne ? 90 : 84;
                        break;
                    case 4:
                        pointTestLangue = conjointAccompagne ? 98 : 91;
                        break;
                    case 5:
                        pointTestLangue = conjointAccompagne ? 120 : 112;
                        break;
                    case 6:
                        pointTestLangue = conjointAccompagne ? 128 : 119;
                        break;
                    case 7:
                        pointTestLangue = conjointAccompagne ? 135 : 126;
                        break;
                    case 8:
                        pointTestLangue = conjointAccompagne ? 150 : 140;
                        break;
                }
            }
            PointTotal += pointTestLangue;
        }

        public void pointageLangueConjoint(Boolean expire, int choixTest, int noteEO, int notesCO, int notesCE, int notesEE, Boolean conjointAccompagne)
        {
            int pointTestLangue = 0;

            if (!expire)
            {
                switch (choixTest)
                {
                    case 1:
                        pointTestLangue = 0;
                        break;
                    case 2:
                        pointTestLangue = conjointAccompagne ? 30 : 28;
                        break;
                    case 3:
                        pointTestLangue = conjointAccompagne ? 90 : 84;
                        break;
                    case 4:
                        pointTestLangue = conjointAccompagne ? 98 : 91;
                        break;
                    case 5:
                        pointTestLangue = conjointAccompagne ? 120 : 112;
                        break;
                    case 6:
                        pointTestLangue = conjointAccompagne ? 128 : 119;
                        break;
                    case 7:
                        pointTestLangue = conjointAccompagne ? 135 : 126;
                        break;
                    case 8:
                        pointTestLangue = conjointAccompagne ? 150 : 140;
                        break;
                }
            }
            PointTotal += pointTestLangue;
        }

        public void pointageExperienceTravail(int anneeExperience, Boolean conjointAccompagne)
        {
            int pointExpTravail = 0;

                switch (anneeExperience)
                {
                    case 1:
                        pointExpTravail = 0;
                        break;
                    case 2:
                        pointExpTravail = conjointAccompagne ? 35 : 40;
                        break;
                    case 3:
                        pointExpTravail = conjointAccompagne ? 46 : 53;
                        break;
                    case 4:
                        pointExpTravail = conjointAccompagne ? 56 : 64;
                        break;
                    case 5:
                        pointExpTravail = conjointAccompagne ? 63 : 72;
                        break;
                    case 6:
                        pointExpTravail = conjointAccompagne ? 70 : 80;
                        break;
                }
            
            PointTotal += pointExpTravail;
        }

        public void pointageExperienceTravailConjoint(int anneeExperience)
        {
            int pointExpTravail = 0;

            switch (anneeExperience)
            {
                case 1:
                    pointExpTravail = 0;
                    break;
                case 2:
                    pointExpTravail = 5;
                    break;
                case 3:
                    pointExpTravail = 7;
                    break;
                case 4:
                    pointExpTravail = 8;
                    break;
                case 5:
                    pointExpTravail = 9;
                    break;
                case 6:
                    pointExpTravail = 10;
                    break;
            }

            PointTotal += pointExpTravail;
        }

        //À Modifier
        public void combinaisonScolariteLangues(int niveauEtude, int pointPremiereLangue)
        {
            int pointCombinaisonSL = 0;

            if (niveauEtude == 0 || niveauEtude ==1)
                pointCombinaisonSL = 0;

            if (niveauEtude == 2 && pointPremiereLangue == 9)
                pointCombinaisonSL = 13;

            if (niveauEtude == 3 && pointPremiereLangue == 9)
                pointCombinaisonSL = 25;

            if (niveauEtude == 9 && pointPremiereLangue == 9)
                pointCombinaisonSL = 25;

            if (niveauEtude == 9 && pointPremiereLangue == 9)
                pointCombinaisonSL = 50;

            PointTotal += pointCombinaisonSL;
        }

        public void combinaisonScolariteTravailCanada(int niveauEtude, int pointTravail)
        {
            int pointCombinaisonSTc = 0;

            if (niveauEtude == 0 || niveauEtude == 1)
                pointCombinaisonSTc = 0;

            if (niveauEtude <= 2 && pointTravail == 2)
                pointCombinaisonSTc = 13;

            if (niveauEtude <= 2 && pointTravail >= 3)
                pointCombinaisonSTc = 25;
           
            if (niveauEtude >= 6 && pointTravail == 2)
                pointCombinaisonSTc = 25;

            if (niveauEtude >= 6 && pointTravail >= 3)
                pointCombinaisonSTc = 50;

            PointTotal += pointCombinaisonSTc;
        }

        //À modifier
        public void combinaisonLangueTravailEtranger(int pointLangue, int pointTravail)
        {
            int pointCombinaisonLTe = 0;

            if (pointTravail == 0 || pointTravail == 1)
                pointCombinaisonLTe = 0;

            if (pointLangue == 9 && (pointTravail == 2 || pointTravail == 3))
                pointCombinaisonLTe = 13;

            if (pointLangue == 9 && (pointTravail == 2 || pointTravail == 3))
                pointCombinaisonLTe = 25;

            if (pointLangue == 9 && pointTravail >= 4)
                pointCombinaisonLTe = 25;

            if (pointLangue == 9 && pointTravail >= 4)
                pointCombinaisonLTe = 50;

            PointTotal += pointCombinaisonLTe;
        }

        public void combinaisonTravailCanada_Etranger(int pointTravailEtranger, int pointTravailCanada)
        {
            int pointCombinaisonTcTe = 0;

            if (pointTravailEtranger == 0 || pointTravailEtranger == 1)
                pointCombinaisonTcTe = 0;

            if ((pointTravailEtranger == 2 || pointTravailEtranger == 3) && pointTravailCanada == 2)
                pointCombinaisonTcTe = 13;

            if ((pointTravailEtranger == 2 || pointTravailEtranger == 3) && pointTravailCanada >= 3)
                pointCombinaisonTcTe = 25;

            if (pointTravailEtranger == 4 && pointTravailCanada == 2)
                pointCombinaisonTcTe = 25;

            if (pointTravailEtranger == 4 && pointTravailCanada >= 3)
                pointCombinaisonTcTe = 50;

            PointTotal += pointCombinaisonTcTe;
        }

        //À modifier (Niveaux de compétence linguistique canadiens et dans le Canadian Language Benchmarks)
        public void combinaisonLangueCertificatCompetence(int pointLangue, int pointCertificat)
        {
            int pointCombinaisonCL = 0;

            if (pointLangue == 0 && pointCertificat == 0)
                pointCombinaisonCL = 25;

            if (pointLangue == 9 && pointCertificat == 9)
                pointCombinaisonCL = 50;

            PointTotal += pointCombinaisonCL;
        }

        public void designationProvince(bool aDesignation)
        {
            int pointDesignation = 0;

            if (aDesignation)
            {
                    pointDesignation = 600;
            }
    
            PointTotal += pointDesignation;
        }

        public void OffreEmploiAdmissible(bool aOffreEmploi, int gpeEmploi)
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
        }

        public void presenceFraternite(bool aFrere)
        {
            int pointFrere = 0;
            if (aFrere)
            {
                pointFrere = 15;
            }
            PointTotal += pointFrere;
        }

        //À modifier
        public void pointSuppLangueFrancais(bool testLinguitiqueValide, int pointLangueF)
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
        }

        public void pointSuppDiplomeCanadien(int niveauEtude)
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
        }

        // À paufiner
        public void calculerResultat()
        {
            this.PointAge(this.Age, this.ConjointAccompagne);
        }
    }
}
