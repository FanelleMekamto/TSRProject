using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TSR.DAL;

namespace TSR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChoixTypeImmigration : ContentPage
    {
        FicheCandidat fiche = new FicheCandidat();
        int pickerTypeImmigrationIndex;
        public ChoixTypeImmigration()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactPage());

            /*if (pickerTypeImmigrationIndex == 0)
            {
                await Navigation.PushAsync(new ContactPage());
            }
            else
            {
                await Navigation.PushAsync(new OtherProvince());
            }*/
        }

         private void pickerImmigration_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var statutSelectedIndex = pickerProvince.SelectedIndex;

            pickerTypeImmigrationIndex = pickerImmigration.SelectedIndex;
            fiche.TypeImmigration = pickerTypeImmigrationIndex;

        }
    }
}