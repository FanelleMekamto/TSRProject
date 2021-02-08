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
    public partial class NotesCELPIPG : ContentPage
    {
        public NotesCELPIPG()
        {
            InitializeComponent();

            listNotesCELPIPG.ItemsSource = new List<string>
            {
                "Selectionner...",
                "10-12",
                "9",
                "8",
                "7",
                "6",
                "5",
                "4",
                "M, 0-3"
            };
        }

        public ListView NotesCELPIPGDetails { get { return listNotesCELPIPG; } }
    }
}