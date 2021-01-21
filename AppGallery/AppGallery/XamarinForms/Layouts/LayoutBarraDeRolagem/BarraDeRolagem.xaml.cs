using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Layouts.LayoutBarraDeRolagem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarraDeRolagem : ContentPage
    {
        public BarraDeRolagem()
        {
            InitializeComponent();
        }

        private void RolarParaSegundaLabel(object sender, EventArgs e)
        {
            BarraDeRolagemScroll.ScrollToAsync(SegundaLabel, ScrollToPosition.Start, true);
        }

        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            Posicao.Text = e.ScrollX + " - " + e.ScrollY;
        }
    }
}