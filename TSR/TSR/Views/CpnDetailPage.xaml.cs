using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TSR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CpnDetailPage : ContentPage
    {
        //String filename = @"C:\Users\Fanelle\source\repos\TSR\TSR\TSR\testcpn.csv";

        public List<Cpn> list;
        public ListView CpnDetails { get { return listViewCNP; } }

        public CpnDetailPage()
        {
            InitializeComponent();

            InitTools();

            listViewCNP.ItemsSource = list;
        }

        public List<Cpn> InitTools()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "TSR.testcpn.csv";
            list = new List<Cpn>();

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                String line = "";

                if (reader != null)
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        //split
                        String[] tokens = line.Split(';');

                        list.Add(new Cpn
                        {
                            ID = tokens.Length >= 2 && tokens[0].Length > 0 ? tokens[0].ToString() : "",
                            Name = tokens.Length >= 2 && tokens[1].Length > 0 ? tokens[1].ToString() : "",
                        });
                    }
                }
            }
            return list;
        }
    }
    public class Cpn
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}