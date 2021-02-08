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
    public partial class EndProcessPage : ContentPage
    {
        FicheCandidat fiche = MainPage.Fiche;
        public EndProcessPage()
        {
            InitializeComponent();
        }

        async void endProcess_Clicked(object sender, EventArgs e)
        {
            fiche.calculerResultat();

            await this.Navigation.PushAsync(new ThanksPage());
        }
    }
}