using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirContentPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)Application.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeConteudo.Conteudo01();
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirNavigationPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01());
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirCarouselPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeCarrossel.Carrossel();
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirTabbedPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeAbas.Abas();
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirMasterDetailPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral();
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirPaginaModal(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.Modal.Conteudo01();
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirStackLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.LayoutPilha.Pilha();
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirGridLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.LayoutGrid.Grade();
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirAbsolutLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.LayoutAbsoluto.Absoluto();
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirRelativeLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.LayoutRelativo.Relativo();
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirFlexLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.LayoutRelativo.Relativo();
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirScrollView(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.LayoutBarraDeRolagem.BarraDeRolagem();
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirContentView(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.LayoutControle.Controle();
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirFrame(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Layouts.LayoutQuadrado.Quadrado());
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirBoxView(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.CaixaControle.Caixa());
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirLabel(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.Rotulo.Rotulo());
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirBotao(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.BotaoControle.Botao());
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirImageButton(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.BotaoImagemControle.BotaoImagem());
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirImageControl(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.ImagemControle.Imagem());
            ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
        }
    }
}