using System;
using TSR.DAL;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TSR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NiveauLangagePage : ContentPage
    {
        FicheCandidat fiche = MainPage.Fiche;

        /*int pickerLireFrancaisSelectedIndex, pickerEcrireFrancaisSelectedIndex, pickerEcouterFrancaisSelectedIndex, pickerParlerFrancaisSelectedIndex;

        int pickerLireAnglaisSelectedIndex, pickerEcrireAnglaisSelectedIndex, pickerEcouterAnglaisSelectedIndex, pickerParlerAnglaisSelectedIndex;
        private void selectedValuePicker()
        {
            pickerLireFrancaisSelectedIndex = pickerLireFrancais.SelectedIndex;
            pickerEcrireFrancaisSelectedIndex = pickerEcrireFrancais.SelectedIndex;
            pickerEcouterFrancaisSelectedIndex = pickerEcouterFrancais.SelectedIndex;
            pickerParlerFrancaisSelectedIndex = pickerParlerFrancais.SelectedIndex;
            pickerLireAnglaisSelectedIndex = pickerLireAnglais.SelectedIndex;
            pickerEcrireAnglaisSelectedIndex = pickerEcrireAnglais.SelectedIndex;
            pickerEcouterAnglaisSelectedIndex = pickerEcouterAnglais.SelectedIndex;
            pickerParlerAnglaisSelectedIndex = pickerParlerAnglais.SelectedIndex;
        }*/

        private void initPicker()
        {
            pickerLireFrancais.ItemsSource = Data.ListNiveauLangage;
            pickerEcrireFrancais.ItemsSource = Data.ListNiveauLangage;
            pickerEcouterFrancais.ItemsSource = Data.ListNiveauLangage;
            pickerParlerFrancais.ItemsSource = Data.ListNiveauLangage;
            pickerLireAnglais.ItemsSource = Data.ListNiveauLangage;
            pickerEcrireAnglais.ItemsSource = Data.ListNiveauLangage;
            pickerEcouterAnglais.ItemsSource = Data.ListNiveauLangage;
            pickerParlerAnglais.ItemsSource = Data.ListNiveauLangage;
        }
        public NiveauLangagePage()
        {
            InitializeComponent();
            initPicker();
        }

        async void nextNiveauLanguePage_Clicked(object sender, EventArgs e)
        {
            //fiche.PointAge(fiche.Age, fiche.ConjointAccompagne);
            await this.Navigation.PushAsync(new WorkPage());
        }

        private void pickerLireFrancais_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var langueOfficiel = pickerLireFrancais.ItemspickerLireFrancais.SelectedIndex];
            var statutSelectedIndex = pickerLireFrancais.SelectedIndex;
            fiche.PointFrLire = fiche.pointLangueCategorie(statutSelectedIndex); 
        }

        private void pickerEcrireFrancais_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var langueOfficiel = pickerLireFrancais.ItemspickerLireFrancais.SelectedIndex];
            var statutSelectedIndex = pickerEcrireFrancais.SelectedIndex;
            fiche.PointFrEcrire = fiche.pointLangueCategorie(statutSelectedIndex); 
        }

        private void pickerEcouterFrancais_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var langueOfficiel = pickerLireFrancais.ItemspickerLireFrancais.SelectedIndex];
            var statutSelectedIndex = pickerEcouterFrancais.SelectedIndex;
            fiche.PointFrEcouter = fiche.pointLangueCategorie(statutSelectedIndex); 
        }

        private void pickerParlerFrancais_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var langueOfficiel = pickerLireFrancais.ItemspickerLireFrancais.SelectedIndex];
            var statutSelectedIndex = pickerParlerFrancais.SelectedIndex;
            fiche.PointFrParler = fiche.pointLangueCategorie(statutSelectedIndex); 
        }

        private void pickerLireAnglais_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var langueOfficiel = pickerLireFrancais.ItemspickerLireFrancais.SelectedIndex];
            var statutSelectedIndex = pickerLireAnglais.SelectedIndex;
            fiche.PointEnLire = fiche.pointLangueCategorie(statutSelectedIndex); 
        }

        private void pickerEcrireAnglais_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var langueOfficiel = pickerLireFrancais.ItemspickerLireFrancais.SelectedIndex];
            var statutSelectedIndex = pickerEcrireAnglais.SelectedIndex;
            fiche.PointEnEcrire = fiche.pointLangueCategorie(statutSelectedIndex); 
        }

        private void pickerEcouterAnglais_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var langueOfficiel = pickerLireFrancais.ItemspickerLireFrancais.SelectedIndex];
            var statutSelectedIndex = pickerEcouterAnglais.SelectedIndex;
            fiche.PointEnEcouter = fiche.pointLangueCategorie(statutSelectedIndex); 
        }

        private void pickerParlerAnglais_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var langueOfficiel = pickerLireFrancais.ItemspickerLireFrancais.SelectedIndex];
            var statutSelectedIndex = pickerParlerAnglais.SelectedIndex;
            fiche.PointEnParler = fiche.pointLangueCategorie(statutSelectedIndex);
        }

    }
}