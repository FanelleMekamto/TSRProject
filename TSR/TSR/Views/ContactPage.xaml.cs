using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TSR.DAL;

namespace TSR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        FicheCandidat fiche = MainPage.Fiche;

        public ContactPage()
        {
            InitializeComponent();

            //var connection = DependencyService.Get<ISQLiteDb>();
         
        }

        async void nextContactPage_Clicked(object sender, EventArgs e)
        {

            //fiche.PointAge(fiche.Age, fiche.ConjointAccompagne);

            //await DisplayAlert("Point total actuel", fiche.PointTotal.ToString(), "OK");

            await this.Navigation.PushAsync(new ScolaritePage());

        }

         private void ViewCell_Tapped(object sender, EventArgs e)
        {
            var page = new AgePage();

            page.AgeDetails.ItemSelected += (source, args) =>
            {
                ageValue.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
                fiche.Age = args.SelectedItemIndex;
            };

            Navigation.PushAsync(page);
        }

        private void pickerStatutMatrimonial_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutMatrimonial = pickerStatutMatrimonial.Items[pickerStatutMatrimonial.SelectedIndex];
            var statutSelectedIndex = pickerStatutMatrimonial.SelectedIndex;
            if (statutSelectedIndex == 0 || statutSelectedIndex == 1) {
                choixStatutConjoint.IsVisible = true;
            }
            else
            {
                choixStatutConjoint.IsVisible = false;
            }
        }

        
        private void pickerStatutConjoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerStatutConjoint.SelectedIndex;
            if (statutSelectedIndex == 1)
            {
                choixAccompagner.IsVisible = true;
            }
            else
            {
                choixAccompagner.IsVisible = false;
            }
        }

        private void pickerAcommpagner_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerAcommpagner.SelectedIndex;

            if (statutSelectedIndex == 1)
            {
                fiche.ConjointAccompagne = false;
            }
            else if (statutSelectedIndex == 0)
            {
                fiche.ConjointAccompagne = true;
            }
        }
    }
}