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
    public partial class LanguePage : ContentPage
    {
        FicheCandidat fiche = MainPage.Fiche;

        int pickerExpOraleSelectedIndex, pickerComOralSelectedIndex, pickerComEcritSelectedIndex, pickerExpEcriteSelectedIndex;

        int pickerExpOraleAutreSelectedIndex, pickerComOralAutreSelectedIndex, pickerComEcritAutreSelectedIndex, pickerExpEcriteAutreSelectedIndex;

        private void initPicker()
        {
             pickerExpOraleSelectedIndex = pickerExpOraleValue.SelectedIndex;
             pickerComOralSelectedIndex = pickerComOralValue.SelectedIndex;
             pickerComEcritSelectedIndex = pickerComEcritValue.SelectedIndex;
             pickerExpEcriteSelectedIndex = pickerExpEcriteValue.SelectedIndex;
        }

        private void initPickerAutreNotes()
        {
            pickerExpOraleAutreSelectedIndex = pickerExpOraleValueAutre.SelectedIndex;
            pickerComOralAutreSelectedIndex = pickerComOralValueAutre.SelectedIndex;
            pickerComEcritAutreSelectedIndex = pickerComEcritValueAutre.SelectedIndex;
            pickerExpEcriteAutreSelectedIndex = pickerExpEcriteValueAutre.SelectedIndex;
        }

        public LanguePage()
        {
            InitializeComponent();
            lblPointTotal.Text = MainPage.Fiche.PointTotal.ToString();
        }

        async void nextLanguePage_Clicked(object sender, EventArgs e)
        {
            //var response = await DisplayActionSheet("Choix de Province", "Annuler", "Supprimer", "Quebec", "Autres");

            fiche.PointAge(fiche.Age, fiche.ConjointAccompagne);

            await DisplayAlert("Point total actuel", fiche.PointTotal.ToString(), "OK");

            await this.Navigation.PushAsync(new WorkPage());
        }

        private void pickerLangueOfficielle_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var langueOfficiel = pickerLangueOfficielle.Items[pickerLangueOfficielle.SelectedIndex];
            var statutSelectedIndex = pickerLangueOfficielle.SelectedIndex;
            fiche.LangueOfficielle = statutSelectedIndex;
        }

        private void pickerValiditeTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var ValiditeTest = pickerValiditeTest.Items[pickerValiditeTest.SelectedIndex];
            var statutSelectedIndex = pickerValiditeTest.SelectedIndex;
            if (statutSelectedIndex == 1)
            {
                choixTestLinguistiqueOfficiel.IsVisible = true;
            }
            else if (statutSelectedIndex == 2)
            {
                choixTestLinguistiqueOfficiel.IsVisible = false;
                DisplayAlert("Candidature Inadmissible", "D'après vos réponses, vous ne semblez pas être admissible au processus de sélection", "OK");
            }
        }

        private void pickerTestLinguistiqueOfficiel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var TestLinguistiqueOfficiel = pickerTestLinguistiqueOfficiel.Items[pickerTestLinguistiqueOfficiel.SelectedIndex];
            var statutSelectedIndex = pickerTestLinguistiqueOfficiel.SelectedIndex;

            if (statutSelectedIndex != 0)
            {
                choixNotes.IsVisible = true; 
            }

            switch (statutSelectedIndex) {
                case 1:
                    pickerExpOraleValue.ItemsSource = Data.listNotesCELPIPG;
                    pickerComOralValue.ItemsSource = Data.listNotesCELPIPG;
                    pickerComEcritValue.ItemsSource = Data.listNotesCELPIPG;
                    pickerExpEcriteValue.ItemsSource = Data.listNotesCELPIPG;
                    break;
                case 2:
                    pickerExpOraleValue.ItemsSource = Data.listNotes_EOEE_IELTS;
                    pickerComOralValue.ItemsSource = Data.listNotes_CO_IELTS;
                    pickerComEcritValue.ItemsSource = Data.listNotes_CE_IELTS;
                    pickerExpEcriteValue.ItemsSource = Data.listNotes_EOEE_IELTS;
                    break;
                case 3:
                    pickerExpOraleValue.ItemsSource = Data.listNotes_EOEE_TEF;
                    pickerComOralValue.ItemsSource = Data.listNotes_CO_TEF;
                    pickerComEcritValue.ItemsSource = Data.listNotes_CE_TEF;
                    pickerExpEcriteValue.ItemsSource = Data.listNotes_EOEE_TEF;
                    break;
                case 4:
                    pickerExpOraleValue.ItemsSource = Data.listNotes_EOEE_TCF;
                    pickerComOralValue.ItemsSource = Data.listNotes_CO_TCF;
                    pickerComEcritValue.ItemsSource = Data.listNotes_CE_TCF;
                    pickerExpEcriteValue.ItemsSource = Data.listNotes_EOEE_TCF;
                    break;
            }

            initPickerAutreTest();
        }

        private void initPickerAutreTest() {
            var pickerTestLinguistiqueOfficielSelectedIndex = pickerTestLinguistiqueOfficiel.SelectedIndex;

            switch (pickerTestLinguistiqueOfficielSelectedIndex)
            {
                case 1:
                    pickerAutreTestLinguistique.ItemsSource = Data.ListAutreTest1;
                    break;
                case 2:
                    pickerAutreTestLinguistique.ItemsSource = Data.ListAutreTest1;
                    break;
                case 3:
                    pickerAutreTestLinguistique.ItemsSource = Data.ListAutreTest2;
                    break;
                case 4:
                    pickerAutreTestLinguistique.ItemsSource = Data.ListAutreTest2;
                    break;
            }
        }

        private void pickerAutreTestLinguistique_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pickerAutreTestLinguistiqueSelectedIndex = pickerAutreTestLinguistique.SelectedIndex;

            var pickerTestLinguistiqueOfficielSelectedIndex = pickerTestLinguistiqueOfficiel.SelectedIndex;

            if (pickerAutreTestLinguistiqueSelectedIndex != 0)
            {
                choixNotesAutresTest.IsVisible = true;
            }

            switch (pickerTestLinguistiqueOfficielSelectedIndex)
            {
                case 1:
                    switch (pickerAutreTestLinguistiqueSelectedIndex)
                    {
                        case 1:
                            pickerExpOraleValueAutre.ItemsSource = Data.listNotes_EOEE_TEF;
                            pickerComOralValueAutre.ItemsSource = Data.listNotes_CO_TEF;
                            pickerComEcritValueAutre.ItemsSource = Data.listNotes_CE_TEF;
                            pickerExpEcriteValueAutre.ItemsSource = Data.listNotes_EOEE_TEF;
                            break;
                        case 2:
                            pickerExpOraleValueAutre.ItemsSource = Data.listNotes_EOEE_TCF;
                            pickerComOralValueAutre.ItemsSource = Data.listNotes_CO_TCF;
                            pickerComEcritValueAutre.ItemsSource = Data.listNotes_CE_TCF;
                            pickerExpEcriteValueAutre.ItemsSource = Data.listNotes_EOEE_TCF;
                            break;
                    }
                    break;
                case 2:
                    switch (pickerAutreTestLinguistiqueSelectedIndex)
                    {
                        case 1:
                            pickerExpOraleValueAutre.ItemsSource = Data.listNotes_EOEE_TEF;
                            pickerComOralValueAutre.ItemsSource = Data.listNotes_CO_TEF;
                            pickerComEcritValueAutre.ItemsSource = Data.listNotes_CE_TEF;
                            pickerExpEcriteValueAutre.ItemsSource = Data.listNotes_EOEE_TEF;
                            break;
                        case 2:
                            pickerExpOraleValueAutre.ItemsSource = Data.listNotes_EOEE_TCF;
                            pickerComOralValueAutre.ItemsSource = Data.listNotes_CO_TCF;
                            pickerComEcritValueAutre.ItemsSource = Data.listNotes_CE_TCF;
                            pickerExpEcriteValueAutre.ItemsSource = Data.listNotes_EOEE_TCF;
                            break;
                    }
                    break;
                case 3:
                    switch (pickerAutreTestLinguistiqueSelectedIndex)
                    {
                        case 1:
                            pickerExpOraleValueAutre.ItemsSource = Data.listNotesCELPIPG;
                            pickerComOralValueAutre.ItemsSource = Data.listNotesCELPIPG;
                            pickerComEcritValueAutre.ItemsSource = Data.listNotesCELPIPG;
                            pickerExpEcriteValueAutre.ItemsSource = Data.listNotesCELPIPG;
                            break;
                        case 2:
                            pickerExpOraleValueAutre.ItemsSource = Data.listNotes_EOEE_IELTS;
                            pickerComOralValueAutre.ItemsSource = Data.listNotes_CO_IELTS;
                            pickerComEcritValueAutre.ItemsSource = Data.listNotes_CE_IELTS;
                            pickerExpEcriteValueAutre.ItemsSource = Data.listNotes_EOEE_IELTS;
                            break;
                    }
                    break;
                case 4:
                    switch (pickerAutreTestLinguistiqueSelectedIndex)
                    {
                        case 1:
                            pickerExpOraleValueAutre.ItemsSource = Data.listNotesCELPIPG;
                            pickerComOralValueAutre.ItemsSource = Data.listNotesCELPIPG;
                            pickerComEcritValueAutre.ItemsSource = Data.listNotesCELPIPG;
                            pickerExpEcriteValueAutre.ItemsSource = Data.listNotesCELPIPG;
                            break;
                        case 2:
                            pickerExpOraleValueAutre.ItemsSource = Data.listNotes_EOEE_IELTS;
                            pickerComOralValueAutre.ItemsSource = Data.listNotes_CO_IELTS;
                            pickerComEcritValueAutre.ItemsSource = Data.listNotes_CE_IELTS;
                            pickerExpEcriteValueAutre.ItemsSource = Data.listNotes_EOEE_IELTS;
                            break;
                    }
                    break;
            }
        }
        
        private void pickerExpOraleValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            initPicker();

            switch(pickerExpOraleSelectedIndex){
                case 0:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
                case 1:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
                case 2:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
                case 3:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
                case 4:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
                case 5:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
                case 6:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
                case 7:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
                case 8:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
            }

            /*if (pickerExpOraleSelectedIndex != 0 && pickerComOralSelectedIndex != 0 && pickerComEcritSelectedIndex != 0 && pickerExpEcriteSelectedIndex !=0)
            {
                choixAutreTest.IsVisible = true;
                initPickerAutreTest();

            }
            else
            {
                choixAutreTest.IsVisible = false;
            }*/
        }

        private void pickerComOralValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            initPicker();
            switch (pickerComOralSelectedIndex)
            {
                case 0:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
                case 1:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
                case 2:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
                case 3:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
                case 4:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
                case 5:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
                case 6:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
                case 7:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
                case 8:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
            }

            /*if (pickerExpOraleSelectedIndex != 0 && pickerComOralSelectedIndex != 0 && pickerComEcritSelectedIndex != 0 && pickerExpEcriteSelectedIndex != 0)
            {
                choixAutreTest.IsVisible = true;
                initPickerAutreTest();

            }
            else
            {
                choixAutreTest.IsVisible = false;
            }*/
        }

        private void pickerComEcritValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            initPicker();
            switch (pickerComEcritSelectedIndex)
            {
                case 0:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
                case 1:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
                case 2:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
                case 3:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
                case 4:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
                case 5:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
                case 6:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
                case 7:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
                case 8:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
            }

            /*if (pickerExpOraleSelectedIndex != 0 && pickerComOralSelectedIndex != 0 && pickerComEcritSelectedIndex != 0 && pickerExpEcriteSelectedIndex != 0)
            {
                choixAutreTest.IsVisible = true;
                initPickerAutreTest();

            }
            else
            {
                choixAutreTest.IsVisible = false;
            }*/
        }

        private void pickerExpEcriteValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            initPicker();
            switch (pickerExpEcriteSelectedIndex)
            {
                case 0:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
                case 1:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
                case 2:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
                case 3:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
                case 4:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
                case 5:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
                case 6:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
                case 7:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
                case 8:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
            }

           /* if (pickerExpOraleSelectedIndex == 0 && pickerComOralSelectedIndex == 0 && pickerComEcritSelectedIndex == 0 && pickerExpEcriteSelectedIndex == 0)
            {
                choixAutreTest.IsVisible = false;
            }
            else
            {
                choixAutreTest.IsVisible = true;
            }*/
        }

        private void pickerExpOraleValueAutre_SelectedIndexChanged(object sender, EventArgs e)
        {
            initPickerAutreNotes();

            switch (pickerExpOraleSelectedIndex)
            {
                case 0:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
                case 1:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
                case 2:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
                case 3:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
                case 4:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
                case 5:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
                case 6:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
                case 7:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
                case 8:
                    fiche.NoteLinguistique = pickerExpOraleSelectedIndex;
                    break;
            }
        }

        private void pickerComOralValueAutre_SelectedIndexChanged(object sender, EventArgs e)
        {
            initPickerAutreNotes();
            switch (pickerComOralSelectedIndex)
            {
                case 0:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
                case 1:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
                case 2:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
                case 3:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
                case 4:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
                case 5:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
                case 6:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
                case 7:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
                case 8:
                    fiche.NoteLinguistique = pickerComOralSelectedIndex;
                    break;
            }
        }

        private void pickerComEcritValueAutre_SelectedIndexChanged(object sender, EventArgs e)
        {
            initPickerAutreNotes();
            switch (pickerComEcritSelectedIndex)
            {
                case 0:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
                case 1:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
                case 2:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
                case 3:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
                case 4:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
                case 5:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
                case 6:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
                case 7:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
                case 8:
                    fiche.NoteLinguistique = pickerComEcritSelectedIndex;
                    break;
            }
        }

        private void pickerExpEcriteValueAutre_SelectedIndexChanged(object sender, EventArgs e)
        {
            initPickerAutreNotes();
            switch (pickerExpEcriteSelectedIndex)
            {
                case 0:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
                case 1:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
                case 2:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
                case 3:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
                case 4:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
                case 5:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
                case 6:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
                case 7:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
                case 8:
                    fiche.NoteLinguistique = pickerExpEcriteSelectedIndex;
                    break;
            }
        }
    }
}