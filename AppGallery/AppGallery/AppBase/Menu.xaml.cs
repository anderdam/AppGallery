using System;
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
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.CaixaControle.Caixa());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirLabel(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.Rotulo.Rotulo());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirBotao(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.BotaoControle.Botao());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirImageButton(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.BotaoImagemControle.BotaoImagem());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirImageControl(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.ImagemControle.Imagem());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirEntry(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.CampoDeEntradaSimplesControle.CampoDeEntradaSimples());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirEditor(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.CampoDeEntradaMultilineControle.CampoDeEntradaMultiline());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirCheckbox(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.CaixaDeMarcacaoControle.CaixaDeMarcacao());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirRadioButton(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.RadioButtonControle.RadioButtonControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirSwitch(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.InterruptorControle.Interruptor());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirStepper(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.PassadorControle.Passador());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirSlider(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.DeslizanteControle.Deslizante());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirPicker(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.SelecaoControle.Selecao());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirDatePicker(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.DataSelecaoControle.DataSelecao());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirTimePicker(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.TimePickerControle.TimePickerControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirActivityIndicator(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.ActivityIndicatorControle.ActivityIndicatorControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirProgressBar(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.ProgressBarControle.ProgressBarControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirSearchBar(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.SearchBarControle.SearchBarControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirRefreshView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.RefreshViewControle.RefreshViewControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirSwipeView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.SwipeViewControle.SwipeViewControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirWebView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.WebViewControle.WebViewControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirMediaElement(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.MediaElementControle.MediaElementControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirExpander(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.ExpanderControle.ExpanderControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }        

        //LISTAS

        private void AbrirTableView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new
                XamarinForms.Listas.TableViewControle.TableViewControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirListView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.ListViewControle.ListViewControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirCollectionView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.CollectionViewControle.CollectionViewControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirCarouselView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.CarouselViewControle.CarouselViewControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirIndicatorView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.IndicatorViewControle.IndicatorViewControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirObservableCollection(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.ClassesEspeciais.ObservableCollectionClass());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirINotifyPropertyChanged(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.ClassesEspeciais.INotifyPropertyChangedControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirDataTemplateSelector(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Listas.ClassesEspeciais.DataTemplateSelectorControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        //Estilos

        private void AbrirExplicitStyle(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Styles.ExplicitStyleControle.ExplicitStyleControle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirImplicitStyle(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Styles.ImplicitStyleLayout.ImplicitStyleLayout());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirGlobalStyle(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Styles.GlobalStyleStyle.GlobalStyleStyle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirInheritStyle(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Styles.InheritStyleStyle.InheritStyleStyle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirDynamicStyle(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Styles.DynamicStyleStyle.DynamicStyleStyle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirStyleClass(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Styles.StyleClassStyle.StyleClassStyle());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirVSM(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Styles.VSM.Vsm());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirMaterialDesignIO(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Styles.MaterialDesign.MaterialDesignIO());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirCustomFontsPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Styles.CustomFonts.CustomFonsPage());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }

        private void AbrirChangeThemePage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Styles.ChangeTheme.ChangeThemePage());
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }
    }
}