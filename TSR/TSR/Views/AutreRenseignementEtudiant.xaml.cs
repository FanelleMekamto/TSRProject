using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSR.DAL;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TSR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AutreRenseignementEtudiant : ContentPage
    {
        FicheCandidat fiche = MainPage.Fiche;
        public AutreRenseignementEtudiant()
        {
            InitializeComponent();
        }

        async void nextAutreRenseignement_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new EndProcessPage());
        }

        private void pickerFunds_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valuePicker = pickerFunds.Items[pickerFunds.SelectedIndex];
            var statutSelectedIndex = pickerFunds.SelectedIndex;
            fiche.EtudeCompleteConjoint = statutSelectedIndex;
        }
        private void pickerDetailFunds_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valuePicker = pickerDetailFunds.Items[pickerDetailFunds.SelectedIndex];
            var statutSelectedIndex = pickerDetailFunds.SelectedIndex;
            fiche.EtudeCompleteConjoint = statutSelectedIndex;
        }

        private void pickerPresenceFrere_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valuePicker = pickerPresenceFrere.Items[pickerPresenceFrere.SelectedIndex];
            var statutSelectedIndex = pickerPresenceFrere.SelectedIndex;
            fiche.EtudeCompleteConjoint = statutSelectedIndex;
        }

        private void pickerRefuseVisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valuePicker = pickerRefuseVisa.Items[pickerRefuseVisa.SelectedIndex];
            var statutSelectedIndex = pickerRefuseVisa.SelectedIndex;
            fiche.EtudeCompleteConjoint = statutSelectedIndex;
        }

        private void pickerInfraction_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valuePicker = pickerInfraction.Items[pickerInfraction.SelectedIndex];
            var statutSelectedIndex = pickerInfraction.SelectedIndex;
            fiche.EtudeCompleteConjoint = statutSelectedIndex;
        }

    }
}