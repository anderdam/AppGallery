using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Styles.VSM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vsm : ContentPage
    {
        public Vsm()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var view = (Entry)sender;
            if (e.NewTextValue.StartsWith("#"))
            {
                //BtnValid
                VisualStateManager.GoToState(view, "Valid");
            }
            else
            {
                //BtnInvalid
                VisualStateManager.GoToState(view, "Invalid");
            }
        }

        private void BtnAtivarDesativar(object sender, EventArgs e)
        {
            TxtHex.IsEnabled = !TxtHex.IsEnabled;
        }
    }
}