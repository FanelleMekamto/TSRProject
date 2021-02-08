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

        int pickerExpOraleConjointSelectedIndex, pickerComOralConjointSelectedIndex, pickerComEcritConjointSelectedIndex, pickerExpEcriteConjointSelectedIndex;

        private void initPicker()
        {
            pickerExpOraleConjointSelectedIndex = pickerExpOraleValueConjoint.SelectedIndex;
            pickerComOralConjointSelectedIndex = pickerComOralValueConjoint.SelectedIndex;
            pickerComEcritConjointSelectedIndex = pickerComEcritValueConjoint.SelectedIndex;
            pickerExpEcriteConjointSelectedIndex = pickerExpEcriteValueConjoint.SelectedIndex;
        }
        public ConjointPage()
        {
            InitializeComponent();

            pickerEtudeCompleteConjoint.ItemsSource = Data.ListNiveauScolarite;
        }

        async void nextConjointPage_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new EndProcessPage());
        }

        private void pickerEtudeCompleteConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerEtudeCompleteConjoint.SelectedIndex;
            fiche.EtudeCompleteConjoint = statutSelectedIndex;
        }

        private void pickerExperienceTravailConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerExperienceTravailConjoint.SelectedIndex;
            fiche.AnneeEpérienceTravailConjointCanada = statutSelectedIndex;
        }

        private void pickerLangueOfficielleConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerEtudeCompleteConjoint.SelectedIndex;
            fiche.LangueOfficielleConjoint = statutSelectedIndex;
        }

        private void pickerTestLinguistiqueConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerTestLinguistiqueConjoint.SelectedIndex;

            if (statutSelectedIndex != 0)
            {
                choixNotesConjoint.IsVisible = true;
            }

            switch (statutSelectedIndex)
            {
                case 1:
                    pickerExpOraleValueConjoint.ItemsSource = Data.listNotesCELPIPG;
                    pickerComOralValueConjoint.ItemsSource = Data.listNotesCELPIPG;
                    pickerComEcritValueConjoint.ItemsSource = Data.listNotesCELPIPG;
                    pickerExpEcriteValueConjoint.ItemsSource = Data.listNotesCELPIPG;
                    break;
                case 2:
                    pickerExpOraleValueConjoint.ItemsSource = Data.listNotes_EOEE_IELTS;
                    pickerComOralValueConjoint.ItemsSource = Data.listNotes_CO_IELTS;
                    pickerComEcritValueConjoint.ItemsSource = Data.listNotes_CE_IELTS;
                    pickerExpEcriteValueConjoint.ItemsSource = Data.listNotes_EOEE_IELTS;
                    break;
                case 3:
                    pickerExpOraleValueConjoint.ItemsSource = Data.listNotes_EOEE_TEF;
                    pickerComOralValueConjoint.ItemsSource = Data.listNotes_CO_TEF;
                    pickerComEcritValueConjoint.ItemsSource = Data.listNotes_CE_TEF;
                    pickerExpEcriteValueConjoint.ItemsSource = Data.listNotes_EOEE_TEF;
                    break;
                case 4:
                    pickerExpOraleValueConjoint.ItemsSource = Data.listNotes_EOEE_TCF;
                    pickerComOralValueConjoint.ItemsSource = Data.listNotes_CO_TCF;
                    pickerComEcritValueConjoint.ItemsSource = Data.listNotes_CE_TCF;
                    pickerExpEcriteValueConjoint.ItemsSource = Data.listNotes_EOEE_TCF;
                    break;
            }
        }

        private void pickerExpOraleValueConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            initPicker();

            switch (pickerExpOraleConjointSelectedIndex)
            {
                case 0:
                    fiche.NoteLinguistique = pickerExpOraleConjointSelectedIndex;
                    break;
                case 1:
                    fiche.NoteLinguistique = pickerExpOraleConjointSelectedIndex;
                    break;
                case 2:
                    fiche.NoteLinguistique = pickerExpOraleConjointSelectedIndex;
                    break;
                case 3:
                    fiche.NoteLinguistique = pickerExpOraleConjointSelectedIndex;
                    break;
                case 4:
                    fiche.NoteLinguistique = pickerExpOraleConjointSelectedIndex;
                    break;
                case 5:
                    fiche.NoteLinguistique = pickerExpOraleConjointSelectedIndex;
                    break;
                case 6:
                    fiche.NoteLinguistique = pickerExpOraleConjointSelectedIndex;
                    break;
                case 7:
                    fiche.NoteLinguistique = pickerExpOraleConjointSelectedIndex;
                    break;
                case 8:
                    fiche.NoteLinguistique = pickerExpOraleConjointSelectedIndex;
                    break;
            }
        }

        private void pickerComOralValueConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            initPicker();
            switch (pickerComOralConjointSelectedIndex)
            {
                case 0:
                    fiche.NoteLinguistique = pickerComOralConjointSelectedIndex;
                    break;
                case 1:
                    fiche.NoteLinguistique = pickerComOralConjointSelectedIndex;
                    break;
                case 2:
                    fiche.NoteLinguistique = pickerComOralConjointSelectedIndex;
                    break;
                case 3:
                    fiche.NoteLinguistique = pickerComOralConjointSelectedIndex;
                    break;
                case 4:
                    fiche.NoteLinguistique = pickerComOralConjointSelectedIndex;
                    break;
                case 5:
                    fiche.NoteLinguistique = pickerComOralConjointSelectedIndex;
                    break;
                case 6:
                    fiche.NoteLinguistique = pickerComOralConjointSelectedIndex;
                    break;
                case 7:
                    fiche.NoteLinguistique = pickerComOralConjointSelectedIndex;
                    break;
                case 8:
                    fiche.NoteLinguistique = pickerComOralConjointSelectedIndex;
                    break;
            }
        }

        private void pickerComEcritValueConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            initPicker();
            switch (pickerComEcritConjointSelectedIndex)
            {
                case 0:
                    fiche.NoteLinguistique = pickerComEcritConjointSelectedIndex;
                    break;
                case 1:
                    fiche.NoteLinguistique = pickerComEcritConjointSelectedIndex;
                    break;
                case 2:
                    fiche.NoteLinguistique = pickerComEcritConjointSelectedIndex;
                    break;
                case 3:
                    fiche.NoteLinguistique = pickerComEcritConjointSelectedIndex;
                    break;
                case 4:
                    fiche.NoteLinguistique = pickerComEcritConjointSelectedIndex;
                    break;
                case 5:
                    fiche.NoteLinguistique = pickerComEcritConjointSelectedIndex;
                    break;
                case 6:
                    fiche.NoteLinguistique = pickerComEcritConjointSelectedIndex;
                    break;
                case 7:
                    fiche.NoteLinguistique = pickerComEcritConjointSelectedIndex;
                    break;
                case 8:
                    fiche.NoteLinguistique = pickerComEcritConjointSelectedIndex;
                    break;
            }
        }

        private void pickerExpEcriteValueConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            initPicker();
            switch (pickerExpEcriteConjointSelectedIndex)
            {
                case 0:
                    fiche.NoteLinguistique = pickerExpEcriteConjointSelectedIndex;
                    break;
                case 1:
                    fiche.NoteLinguistique = pickerExpEcriteConjointSelectedIndex;
                    break;
                case 2:
                    fiche.NoteLinguistique = pickerExpEcriteConjointSelectedIndex;
                    break;
                case 3:
                    fiche.NoteLinguistique = pickerExpEcriteConjointSelectedIndex;
                    break;
                case 4:
                    fiche.NoteLinguistique = pickerExpEcriteConjointSelectedIndex;
                    break;
                case 5:
                    fiche.NoteLinguistique = pickerExpEcriteConjointSelectedIndex;
                    break;
                case 6:
                    fiche.NoteLinguistique = pickerExpEcriteConjointSelectedIndex;
                    break;
                case 7:
                    fiche.NoteLinguistique = pickerExpEcriteConjointSelectedIndex;
                    break;
                case 8:
                    fiche.NoteLinguistique = pickerExpEcriteConjointSelectedIndex;
                    break;
            }
        }
    }
}