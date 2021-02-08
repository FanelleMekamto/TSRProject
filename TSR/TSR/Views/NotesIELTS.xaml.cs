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
    public partial class NotesIELTS : ContentPage
    {
        public NotesIELTS()
        {
            InitializeComponent();

            listNotesEOEE.ItemsSource = new List<string>
            {
                "Selectionner...",
                "7.5 - 9.0",
                "7.0",
                "6.5",
                "6.0",
                "5.5",
                "5.0",
                "4.0 - 4.5",
                "0 - 3.5"
            };
        }

        public ListView NotesCELPIPGDetails { get { return listNotesEOEE; } }
    }
}