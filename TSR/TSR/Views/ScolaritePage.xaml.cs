using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSR.DAL;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TSR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class ScolaritePage : ContentPage
    {
        FicheCandidat fiche = MainPage.Fiche;

        public Model model;
        public ScolaritePage()
        {
            InitializeComponent();

            //pickerEtudeComplete.ItemsSource = Data.ListNiveauScolarite;

            model = new Model();
            this.BindingContext = model;
        }

        private void pickerEtudeComplete_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerEtudeComplete.SelectedIndex;

            fiche.EtudeComplete = statutSelectedIndex;            
        }

        private void pickerObtentionDiplome_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerObtentionDiplome.SelectedIndex;

            if (statutSelectedIndex == 1)
            {
                choixDiplomeCanadien.IsVisible = true;
                fiche.AObtenuDiplomeCanadien = true;
            }
            else if (statutSelectedIndex == 2)
            {
                choixDiplomeCanadien.IsVisible = false;
                fiche.AObtenuDiplomeCanadien = false;
            }
        }

        private void pickerDiplomeCanadien_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statutSelectedIndex = pickerDiplomeCanadien.SelectedIndex;

            fiche.DescriptionEtudeCanadien = statutSelectedIndex;
        }

        async private void nextScolaritePage_Clicked(object sender, EventArgs e)
        {
            // rajouter le champ descriptionDiplome Canadien dans la methode de scolarite
            fiche.pointageNiveauDeScolarite(fiche.AObtenuDiplomeCanadien, fiche.EtudeComplete, fiche.ConjointAccompagne);

            await DisplayAlert("Point total actuel", MainPage.Fiche.PointTotal.ToString(), "OK");

            await this.Navigation.PushAsync(new LanguePage());
        }
    }

    public class Model : INotifyPropertyChanged
    {

        public Model()
        {
            _listData = Data.ListNiveauScolarite; 
            _selectedLevel = _listData[0];                  //Look at this Line !
        }

        private List<string> _listData;
        public List<string> ListData
        {
            get
            {
                return _listData;
            }
            set
            {
                _listData = value;
                OnPropertyChanged(nameof(ListData));
            }
        }

        private string _selectedLevel;
        public string SelectedLevel
        {
            get
            {
                return _selectedLevel;
            }
            set
            {
                _selectedLevel = value;
                OnPropertyChanged(nameof(SelectedLevel));

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
 }