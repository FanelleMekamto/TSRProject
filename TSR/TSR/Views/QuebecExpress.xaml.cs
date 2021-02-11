using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TSR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuebecExpress : ContentPage
    {

        public QuebecExpress()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayActionSheet("Choix de Province", "Annuler", "Supprimer", "Quebec", "Autres");

            await DisplayAlert("Suivant?", "Bouton cliqué", "OK");
        }
    }
}