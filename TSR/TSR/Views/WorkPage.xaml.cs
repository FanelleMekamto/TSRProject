using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TSR.DAL;

namespace TSR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkPage : ContentPage
    {
        FicheCandidat fiche = MainPage.Fiche;
        public WorkPage()
        {
            InitializeComponent();
        }

        async void nextWorkPage_Clicked(object sender, EventArgs e)
        {
            if (fiche.ConjointAccompagne)
            {
                await this.Navigation.PushAsync(new ConjointPage());
            }
            else
            {
                await this.Navigation.PushAsync(new EndProcessPage());
            }
        }

        private void pickerExperienceTravailCanada_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var ValiditeTest = pickerValiditeTest.Items[pickerValiditeTest.SelectedIndex];
            var statutSelectedIndex = pickerExperienceTravailCanada.SelectedIndex;
            fiche.AnneeEpérienceTravailCanada = statutSelectedIndex;
        }

        private void pickerExperienceTravailEtranger_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var ValiditeTest = pickerValiditeTest.Items[pickerValiditeTest.SelectedIndex];
            var statutSelectedIndex = pickerExperienceTravailCanada.SelectedIndex;
            fiche.AnneeEpérienceTravailEtranger = statutSelectedIndex;
        }

        private void pickerCertificatCanada_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var ValiditeTest = pickerValiditeTest.Items[pickerValiditeTest.SelectedIndex];
            var statutSelectedIndex = pickerExperienceTravailCanada.SelectedIndex;

            if (statutSelectedIndex == 1)
            {
                fiche.ACertificatCompetence = true;
            }else if (statutSelectedIndex == 2)
            {
                fiche.ACertificatCompetence = false;
            }
        }

        private void pickerOffreEmploiValide_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var ValiditeTest = pickerValiditeTest.Items[pickerValiditeTest.SelectedIndex];
            var statutSelectedIndex = pickerExperienceTravailCanada.SelectedIndex;

            if (statutSelectedIndex == 1)
            {
                fiche.AOffreEmploi = true;
            }
            else if (statutSelectedIndex == 2)
            {
                fiche.AOffreEmploi = false;
            }
        }

        private void pickerNiveauCompétence_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var ValiditeTest = pickerValiditeTest.Items[pickerValiditeTest.SelectedIndex];
            var statutSelectedIndex = pickerExperienceTravailCanada.SelectedIndex;
            fiche.NiveauCompetenceOffre = statutSelectedIndex;
        }

        private void pickerCertificatDesignationProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var ValiditeTest = pickerValiditeTest.Items[pickerValiditeTest.SelectedIndex];
            var statutSelectedIndex = pickerExperienceTravailCanada.SelectedIndex;
            if (statutSelectedIndex == 1)
            {
                fiche.ACertificatDesignationProvince = true;
            }
            else if (statutSelectedIndex == 2)
            {
                fiche.ACertificatDesignationProvince = false;
            }
        }

        private void pickerPresenceFrere_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var ValiditeTest = pickerValiditeTest.Items[pickerValiditeTest.SelectedIndex];
            var statutSelectedIndex = pickerExperienceTravailCanada.SelectedIndex;
            if (statutSelectedIndex == 1)
            {
                fiche.PresenceFrere = true;
            }
            else if (statutSelectedIndex == 2)
            {
                fiche.PresenceFrere = false;
            }
        }
    }
}