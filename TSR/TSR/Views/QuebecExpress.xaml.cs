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
        //String filename = @"C:\Users\Fanelle\source\repos\TSR\TSR\TSR\testcpn.csv";
        public List<Cpn> list;
        public QuebecExpress()
        {
            InitializeComponent();

            InitTools();

            listViewCNP.ItemsSource = list;

            listViewCNP.ItemSelected += (sender, e) =>
            {
                if (listViewCNP.SelectedItem != null)
                {
                    Cpn cpn = listViewCNP.SelectedItem as Cpn;
                    DisplayAlert("CPN Num-" + cpn.ID, cpn.Name, "OK");
                    listViewCNP.SelectedItem = null;
                }
            };
        }

        public List<Cpn> InitTools()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "TSR.testcpn.csv";
            list = new List<Cpn>();

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                //string result = reader.ReadToEnd();

                String line = "";

                if (reader != null)
                {
                    //using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
                    //{
                    while ((line = reader.ReadLine()) != null)
                    {
                        //split
                        String[] tokens = line.Split(';');

                        //read data
                        list.Add(new Cpn
                        {
                            //if(tokens[0].Length>0)
                            ID = tokens.Length >= 2 && tokens[0].Length > 0 ? tokens[0].ToString() : "",
                            Name = tokens.Length >= 2 && tokens[1].Length > 0 ? tokens[1].ToString() : "",
                        });
                        // }
                    }
                }
            }
            return list;
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayActionSheet("Choix de Province", "Annuler", "Supprimer", "Quebec", "Autres");

            await DisplayAlert("Suivant?", "Bouton cliqué", "OK");
        }
    }

    public class Cpn
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}