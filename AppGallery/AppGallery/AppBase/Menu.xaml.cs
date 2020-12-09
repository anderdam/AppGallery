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
    public partial class Menu : FlyoutPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirContentPage(object sender, EventArgs e)
        {
            ((FlyoutPage)Application.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeConteudo.Conteudo01();
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirNavigationPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirCarouselPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeCarrossel.Carrossel();
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirTabbedPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeAbas.Abas();
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirFlyoutPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral();
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirPaginaModal(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.Modal.Conteudo01();
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirStackLayout(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.LayoutPilha.Pilha();
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirGridLayout(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.LayoutGrid.Grade();
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirAbsolutLayout(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.LayoutAbsoluto.Absoluto();
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirRelativeLayout(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.LayoutRelativo.Relativo();
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirFlexLayout(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.LayoutRelativo.Relativo();
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirScrollView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.LayoutBarraDeRolagem.BarraDeRolagem();
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirContentView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.LayoutControle.Controle();
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirFrame(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Layouts.LayoutQuadrado.Quadrado());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirBoxView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.CaixaControle.Caixa());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirLabel(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.Rotulo.Rotulo());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirBotao(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.BotaoControle.Botao());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirImageButton(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.BotaoImagemControle.BotaoImagem());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirImageControl(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.ImagemControle.Imagem());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirEntry(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.CampoDeEntradaSimplesControle.CampoDeEntradaSimples());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirEditor(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.CampoDeEntradaMultilineControle.CampoDeEntradaMultiline());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirCheckbox(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.CaixaDeMarcacaoControle.CaixaDeMarcacao());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirRadioButton(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.RadioButtonControle.RadioButtonControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }
    }
}