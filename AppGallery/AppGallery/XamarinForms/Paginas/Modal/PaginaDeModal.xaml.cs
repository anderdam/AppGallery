using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.Modal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaDeModal : ContentPage
    {
        public PaginaDeModal()
        {
            InitializeComponent();
        }

        private void Fechar(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}