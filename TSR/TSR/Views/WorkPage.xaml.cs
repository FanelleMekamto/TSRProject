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
            fiche.AnneeExperienceTravailCanada = statutSelectedIndex;
        }

        private void pickerExperienceTravailEtranger_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var ValiditeTest = pickerValiditeTest.Items[pickerValiditeTest.SelectedIndex];
            var statutSelectedIndex = pickerExperienceTravailCanada.SelectedIndex;
            fiche.AnneeExperienceTravailEtranger = statutSelectedIndex;
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
            var statutSelectedIndex = pickerOffreEmploiValide.SelectedIndex;

            if (statutSelectedIndex == 1)
            {
                fiche.AOffreEmploi = true;
                choixNiveauCompetence.IsVisible = true;
                choixDetailCompetence.IsVisible = true;
            }
            else if (statutSelectedIndex == 2)
            {
                fiche.AOffreEmploi = false;
            }
        }

        private void pickerNiveauCompétence_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var ValiditeTest = pickerValiditeTest.Items[pickerValiditeTest.SelectedIndex];
            var statutSelectedIndex = pickerNiveauCompétence.SelectedIndex;
            fiche.NiveauCompetenceOffre = statutSelectedIndex;
        }

        private void pickerCertificatDesignationProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var ValiditeTest = pickerValiditeTest.Items[pickerValiditeTest.SelectedIndex];
            var statutSelectedIndex = pickerCertificatDesignationProvince.SelectedIndex;
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
            var statutSelectedIndex = pickerPresenceFrere.SelectedIndex;
            if (statutSelectedIndex == 1)
            {
                fiche.PresenceFrere = true;
            }
            else if (statutSelectedIndex == 2)
            {
                fiche.PresenceFrere = false;
            }
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            var page = new CpnDetailPage();

            page.CpnDetails.ItemSelected += (source, args) =>
            {
                Cpn cpn = args.SelectedItem as Cpn;
                descriptionCompetence.Text = cpn.Name;
                Navigation.PopAsync();
                fiche.DetailCompetence = args.SelectedItemIndex;
            };

            Navigation.PushAsync(page);
        }
    }
}