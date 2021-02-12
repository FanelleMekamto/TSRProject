using System.Globalization;
using System.Linq;
using System.Threading;
using TSR.Resources;
using Xamarin.Forms;
using TSR.Views;
using TSR.DAL;

namespace TSR
{
    public partial class MainPage : ContentPage
    {
        public static FicheCandidat Fiche { get; set; }

        public MainPage()
        {
            Fiche = new FicheCandidat();
            InitializeComponent();
        }

        void OnUpdateLangugeClicked(object sender, System.EventArgs e)
        {
            if (pickerLanguage.SelectedItem != null)
            {
                var language = CultureInfo.GetCultures(CultureTypes.NeutralCultures).ToList().First(element => element.EnglishName.Contains(pickerLanguage.SelectedItem.ToString())); ;
                Thread.CurrentThread.CurrentUICulture = language;
                AppResources.Culture = language;
                App.Current.MainPage = new NavigationPage(new ChoixProvince());
            }
        }
    }
}
