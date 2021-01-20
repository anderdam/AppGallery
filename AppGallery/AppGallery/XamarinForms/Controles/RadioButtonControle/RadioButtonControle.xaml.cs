using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.RadioButtonControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RadioButtonControle : ContentPage
    {
        public RadioButtonControle()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            lblInformativo.Text = ((RadioButton)sender).Content + ": " + e.Value;
        }
    }
}