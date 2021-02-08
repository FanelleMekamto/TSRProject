using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TSR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgePage : ContentPage
    {
        public AgePage()
        {
            InitializeComponent();

            listAge.ItemsSource = new List<string>
            {
                "Selectionner...",
                "17 ans ou moins",
                "18 ans",
                "19 ans",
                "Entre 20 et 29 ans",
                "30 ans",
                "31 ans",
                "32 ans",
                "33 ans",
                "34 ans",
                "35 ans",
                "36 ans",
                "37 ans",
                "38 ans",
                "39 ans",
                "40 ans",
                "41 ans",
                "42 ans",
                "43 ans",
                "44 ans",
                "45 ans ou plus"
            };
        }

        public ListView AgeDetails { get { return listAge; } }
    }
}