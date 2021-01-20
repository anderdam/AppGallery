using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.ProgressBarControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgressBarControle : ContentPage
    {
        double valorProgressBar = 0.0;
        public ProgressBarControle()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            valorProgressBar += 0.1;
            BarraDeProgresso.ProgressTo(valorProgressBar, 500, Easing.BounceOut); 
        }
    }
}