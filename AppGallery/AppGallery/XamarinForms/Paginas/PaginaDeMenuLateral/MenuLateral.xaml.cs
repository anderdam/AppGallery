using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.PaginaDeMenuLateral
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuLateral : MasterDetailPage
    {
        public MenuLateral()
        {
            InitializeComponent();
        }

        private void AbrirPagina01(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Conteudo01());
        }

        private void AbrirPagina02(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Conteudo02());
        }

        private void AbrirPagina03(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Conteudo03());
        }
    }
}