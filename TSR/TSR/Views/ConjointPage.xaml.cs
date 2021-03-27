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
    public partial class ConjointPage : ContentPage
    {
        FicheCandidat fiche = MainPage.Fiche; 

        //int pickerLireFrancaisConjointSelectedIndex, pickerEcrireFrancaisConjointSelectedIndex, pickerEcouterFrancaisConjointSelectedIndex, pickerParlerFrancaisConjointSelectedIndex;
        //int pickerLireAnglaisConjointSelectedIndex, pickerEcrireAnglaisConjointSelectedIndex, pickerEcouterAnglaisConjointSelectedIndex, pickerParlerAnglaisConjointSelectedIndex;

       /* private void selectedValuePicker()
        {
            pickerLireFrancaisConjointSelectedIndex = pickerLireFrancaisConjoint.SelectedIndex;
            pickerEcrireFrancaisConjointSelectedIndex = pickerEcrireFrancaisConjoint.SelectedIndex;
            pickerEcouterFrancaisConjointSelectedIndex = pickerEcouterFrancaisConjoint.SelectedIndex;
            pickerParlerFrancaisConjointSelectedIndex = pickerParlerFrancaisConjoint.SelectedIndex;
            pickerLireAnglaisConjointSelectedIndex = pickerLireAnglaisConjoint.SelectedIndex;
            pickerEcrireAnglaisConjointSelectedIndex = pickerEcrireAnglaisConjoint.SelectedIndex;
            pickerEcouterAnglaisConjointSelectedIndex = pickerEcouterAnglaisConjoint.SelectedIndex;
            pickerParlerAnglaisConjointSelectedIndex = pickerParlerAnglaisConjoint.SelectedIndex;
        }*/
        private void initPicker()
        {
            pickerLireFrancaisConjoint.ItemsSource = Data.ListNiveauLangage;
            pickerEcrireFrancaisConjoint.ItemsSource = Data.ListNiveauLangage;
            pickerEcouterFrancaisConjoint.ItemsSource = Data.ListNiveauLangage;
            pickerParlerFrancaisConjoint.ItemsSource = Data.ListNiveauLangage;
            pickerLireAnglaisConjoint.ItemsSource = Data.ListNiveauLangage;
            pickerEcrireAnglaisConjoint.ItemsSource = Data.ListNiveauLangage;
            pickerEcouterAnglaisConjoint.ItemsSource = Data.ListNiveauLangage;
            pickerParlerAnglaisConjoint.ItemsSource = Data.ListNiveauLangage; 
        }
        public ConjointPage()
        {
            InitializeComponent();
            initPicker();
        }

        async void nextConjointPage_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new AutreRenseignementEtudiant());
        }

        private void pickerEtudeCompleteConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerEtudeCompleteConjoint.SelectedIndex;
            fiche.EtudeCompleteConjoint = statutSelectedIndex;
        }

        private void pickerExperienceTravailConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerExperienceTravailConjoint.SelectedIndex;
            fiche.AnneeExperienceTravailConjointCanada = statutSelectedIndex;
        }

        private void pickerLireFrancaisConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerLireFrancaisConjoint.SelectedIndex;
            fiche.PointEnParlerConjoint = fiche.pointLangueCategorie(statutSelectedIndex);
        }

        private void pickerEcrireFrancaisConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerEcrireFrancaisConjoint.SelectedIndex;
            fiche.PointEnParlerConjoint = fiche.pointLangueCategorie(statutSelectedIndex);         
        }

        private void pickerParlerFrancaisConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerParlerFrancaisConjoint.SelectedIndex;
            fiche.PointEnParlerConjoint = fiche.pointLangueCategorie(statutSelectedIndex);
        }

        private void pickerEcouterFrancaisConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerEcouterFrancaisConjoint.SelectedIndex;
            fiche.PointEnParlerConjoint = fiche.pointLangueCategorie(statutSelectedIndex);
        }

        private void pickerLireAnglaisConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerLireAnglaisConjoint.SelectedIndex;
            fiche.PointEnParlerConjoint = fiche.pointLangueCategorie(statutSelectedIndex);
        }

        private void pickerEcrireAnglaisConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerEcrireAnglaisConjoint.SelectedIndex;
            fiche.PointEnParlerConjoint = fiche.pointLangueCategorie(statutSelectedIndex);
        }

        private void pickerParlerAnglaisConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerParlerAnglaisConjoint.SelectedIndex;
            fiche.PointEnParlerConjoint = fiche.pointLangueCategorie(statutSelectedIndex);
        }

        private void pickerEcouterAnglaisConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerEcouterAnglaisConjoint.SelectedIndex;
            fiche.PointEnParlerConjoint = fiche.pointLangueCategorie(statutSelectedIndex);
        }
    }
}
