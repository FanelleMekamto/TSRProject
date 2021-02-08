using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TSR.Extensions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LangueCell : ViewCell
    {
        public static readonly BindableProperty LabelTextProperty =
            BindableProperty.Create("LabelText",typeof(string),typeof(LangueCell));
        public string LabelText 
        { 
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); } 
        }

        /*public Picker pickerComOralValue;
        public Picker pickerComEcritValue;
        public Picker pickerExpEcriteValue;
        public Picker pickerExpOraleValue;*/
        public string NamePicker { get; set; }
        public LangueCell()
        {
            InitializeComponent();
            BindingContext = this;

            /*pickerComOralValue = new Picker();
      
            pickerComEcritValue = new Picker();
            pickerExpEcriteValue = new Picker();
            pickerExpOraleValue = new Picker();*/
    }

        private void pickerExpOraleValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*var ExpOraleValue = pickerExpOraleValue.Items[pickerExpOraleValue.SelectedIndex];
            var statutSelectedIndex = pickerExpOraleValue.SelectedIndex;*/
        }
    }
}