using AppGallery.AppBase.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            MainPage = new AppBase.Menu();
        }

        public List<PageCollection> PagesCollection
        { 
            get 
            {
                var paginas = new PageCollection()
                {
                    new Pagina(){ Name = "ContentPage", Description = "Página de Conteúdo", PageFile = typeof(XamarinForms.Paginas.PaginaDeConteudo.Conteudo01), IsNavigation = false},
                    new Pagina() { Name = "NavigationPage", Description = "Estrutura de navegação", PageFile = typeof(XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01), IsNavigation = true },
                    new Pagina() { Name = "CarouselPage", Description = "Navegue entre páginas lado a lado", PageFile = typeof(XamarinForms.Paginas.PaginaDeCarrossel.Carrossel), IsNavigation = false },
                    new Pagina() { Name = "TabbedPage", Description = "Navegação em abas", PageFile = typeof(XamarinForms.Paginas.PaginaDeAbas.Abas), IsNavigation = false },
                    new Pagina() { Name = "MasterDetailPage", Description = "Navegue com menu hamburgue", PageFile = typeof(XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral), IsNavigation = false },
                    new Pagina() { Name = "Modal", Description = "Abra páginas no estilo Modal", PageFile = typeof(XamarinForms.Paginas.Modal.Conteudo01), IsNavigation = false },
                };

                paginas.Name = "Páginas";

                var Layouts = new PageCollection()
                {
                    new Pagina() { Name = "StackLayout", Description = "Organize o conteúdo em pilha", PageFile = typeof(XamarinForms.Layouts.LayoutPilha.Pilha), IsNavigation = true },
                    new Pagina() { Name = "Grid", Description = "Organize o conteúdo em tabela", PageFile = typeof(XamarinForms.Layouts.LayoutGrid.Grade), IsNavigation = true },
                    new Pagina() { Name = "AbsoluteLayout", Description = "Posicione o conteúdo em qualquer lugar", PageFile = typeof(XamarinForms.Layouts.LayoutAbsoluto.Absoluto), IsNavigation = true },
                    new Pagina() { Name = "RelativeLayout", Description = "Posicione o conteúdo em relação a outro elemento", PageFile = typeof(XamarinForms.Layouts.LayoutRelativo.Relativo), IsNavigation = true },
                    new Pagina() { Name = "FlexLayout", Description = "Posicione o conteúdo em caixas flexíveis", PageFile = typeof(XamarinForms.Layouts.LayoutFlexivel.Flexivel), IsNavigation = true },
                    new Pagina() { Name = "ScrollView", Description = "Adicione barra de rolagem ao seu conteúdo", PageFile = typeof(XamarinForms.Layouts.LayoutBarraDeRolagem.BarraDeRolagem), IsNavigation = true },
                    new Pagina() { Name = "ContentView", Description = "Organize o conteúdo dentro de outro elemento", PageFile = typeof(XamarinForms.Layouts.LayoutControle.Controle), IsNavigation = true },
                    new Pagina() { Name = "Frame", Description = "Quadro de conteúdo", PageFile = typeof(XamarinForms.Layouts.LayoutQuadrado.Quadrado), IsNavigation = true },
                };
                Layouts.Name = "Layouts";

                var Listas = new PageCollection()
                {
                    new Pagina() { Name = "BoxView", Description = "Crie quadrados, retângulo e até circulo", PageFile = typeof(XamarinForms.Listas.CaixaControle.Caixa), IsNavigation = true },
                    new Pagina() { Name = "Label", Description = "Rótulo - Componente para apresentar texto", PageFile = typeof(XamarinForms.Listas.Rotulo.Rotulo), IsNavigation = true },
                    new Pagina() { Name = "Button", Description = "Botão - Exibe um botão com texto e ação", PageFile = typeof(XamarinForms.Listas.BotaoControle.Botao), IsNavigation = true },
                    new Pagina() { Name = "ImageButton", Description = "Botão com imagem - Exibe uma imagem com ação de botão", PageFile = typeof(XamarinForms.Listas.BotaoImagemControle.BotaoImagem), IsNavigation = true },
                    new Pagina() { Name = "Image", Description = "Imagem - Componente para apresentar um bitmap (imagem)", PageFile = typeof(XamarinForms.Listas.ImagemControle.Imagem), IsNavigation = true },
                    new Pagina() { Name = "Entry", Description = "Controle de entrada de texto em uma única linha", PageFile = typeof(XamarinForms.Listas.CampoDeEntradaSimplesControle.CampoDeEntradaSimples), IsNavigation = true },
                    new Pagina() { Name = "Editor", Description = "Controle de entrada de texto em várias linhas", PageFile = typeof(XamarinForms.Listas.CampoDeEntradaMultilineControle.CampoDeEntradaMultiline), IsNavigation = true },
                    new Pagina() { Name = "Checkbox", Description = "Componente de valor booleano permite marca ou desmarca a opção", PageFile = typeof(XamarinForms.Listas.CaixaDeMarcacaoControle.CaixaDeMarcacao), IsNavigation = true },
                    new Pagina() { Name = "RadioButton", Description = "Componente permite marca uma opção entre várias", PageFile = typeof(XamarinForms.Listas.RadioButtonControle.RadioButtonControle), IsNavigation = true },
                    new Pagina() { Name = "Switch", Description = "Controle em formato de chave com valor booleano", PageFile = typeof(XamarinForms.Listas.InterruptorControle.Interruptor), IsNavigation = true },
                    new Pagina() { Name = "Stepper", Description = "Controle passador de valores em double", PageFile = typeof(XamarinForms.Listas.PassadorControle.Passador), IsNavigation = true },
                    new Pagina() { Name = "Slider", Description = "Controle deslizante com valor em double", PageFile = typeof(XamarinForms.Listas.DeslizanteControle.Deslizante), IsNavigation = true },
                    new Pagina() { Name = "Picker", Description = "Exibe uma lista de opções para seleção", PageFile = typeof(XamarinForms.Listas.SelecaoControle.Selecao), IsNavigation = true },
                    new Pagina() { Name = "DatePicker", Description = "Controle permite selecionar data", PageFile = typeof(XamarinForms.Listas.DataSelecaoControle.DataSelecao), IsNavigation = true },
                    new Pagina() { Name = "TimePicker", Description = "Controle permite selecionar horário", PageFile = typeof(XamarinForms.Listas.TimePickerControle.TimePickerControle), IsNavigation = true },
                    new Pagina() { Name = "ActivityIndicator", Description = "Exibe um indicador de atividade sem indicador de progresso", PageFile = typeof(XamarinForms.Listas.ActivityIndicatorControle.ActivityIndicatorControle), IsNavigation = true },
                    new Pagina() { Name = "ProgressBar", Description = "Exibe um indicador de atividade com indicador de progresso", PageFile = typeof(XamarinForms.Listas.ProgressBarControle.ProgressBarControle), IsNavigation = true },
                    new Pagina() { Name = "SearchBar", Description = "Área de digitação com botão de pesquisa", PageFile = typeof(XamarinForms.Listas.SearchBarControle.SearchBarControle), IsNavigation = true },
                    new Pagina() { Name = "RefreshView", Description = "Componente com ação de pull (Puxar) utilizado para atualização de uma tela ou componente", PageFile = typeof(XamarinForms.Listas.RefreshViewControle.RefreshViewControle), IsNavigation = true },
                    new Pagina() { Name = "SwipeView", Description = "Componente de exibição de opções após realizar um gesto", PageFile = typeof(XamarinForms.Listas.SwipeViewControle.SwipeViewControle), IsNavigation = true },
                    new Pagina() { Name = "WebView", Description = "Navegador - Exibe um conteúdo HTML", PageFile = typeof(XamarinForms.Listas.WebViewControle.WebViewControle), IsNavigation = true },
                    new Pagina() { Name = "MediaElement", Description = "Player de música e vídeo", PageFile = typeof(XamarinForms.Listas.MediaElementControle.MediaElementControle), IsNavigation = true },
                };
                Listas.Name = "Listas";

                var listas = new PageCollection()
                {
                    new Pagina() { Name = "TableView", Description = "Exibe uma lista de linhas com tipos de células", PageFile = typeof(XamarinForms.Listas.TableViewControle.TableViewControle), IsNavigation = true },
                    new Pagina() { Name = "ListView", Description = "Exibe elementos em lista", PageFile = typeof(XamarinForms.Listas.ListViewControle.ListViewControle), IsNavigation = true },
                    new Pagina() { Name = "CollectionView", Description = "Exibe elementos em lista.", PageFile = typeof(XamarinForms.Listas.CollectionViewControle.CollectionViewControle), IsNavigation = true },
                    new Pagina() { Name = "CarouselView", Description = "Exibe elementos lado a lado", PageFile = typeof(XamarinForms.Listas.CarouselViewControle.CarouselViewControle), IsNavigation = true },
                    new Pagina() { Name = "IndicatorView", Description = "Exibe um indicador de posição", PageFile = typeof(XamarinForms.Listas.IndicatorViewControle.IndicatorViewControle), IsNavigation = true },
                    new Pagina() { Name = "ObservableCollection", Description = "Classe que atualiza os Listas de lista automaticamente", PageFile = typeof(XamarinForms.Listas.ClassesEspeciais.ObservableCollectionClass), IsNavigation = true },
                    new Pagina() { Name = "INotifyPropertyChanged", Description = "Classe que atualiza os Listas de lista automaticamente", PageFile = typeof(XamarinForms.Listas.ClassesEspeciais.INotifyPropertyChangedControle), IsNavigation = true },
                    new Pagina() { Name = "DataTemplateSelector", Description = "Classe que permite escolher o layout de cada linha da lista", PageFile = typeof(XamarinForms.Listas.ClassesEspeciais.DataTemplateSelectorControle), IsNavigation = true },
                };
                listas.Name = "Listas";

                var estilos = new PageCollection()
                {
                    new Pagina() { Name = "ExplicitStyle", Description = "Forma explicita de adicionar estilo", PageFile = typeof(XamarinForms.Styles.ExplicitStyleControle.ExplicitStyleControle), IsNavigation = true },
                    new Pagina() { Name = "ImplicitStyle", Description = "Forma implicita de adicionar estilo", PageFile = typeof(XamarinForms.Styles.ImplicitStyleLayout.ImplicitStyleLayout), IsNavigation = true },
                    new Pagina() { Name = "GlobalStyle", Description = "Estilo global", PageFile = typeof(XamarinForms.Styles.GlobalStyleStyle.GlobalStyleStyle), IsNavigation = true },
                    new Pagina() { Name = "InheritStyle", Description = "Criar estilos a partir de outros", PageFile = typeof(XamarinForms.Styles.InheritStyleStyle.InheritStyleStyle), IsNavigation = true },
                    new Pagina() { Name = "DynamicStyle", Description = "Estilo que pode mudar em tempo de execução", PageFile = typeof(XamarinForms.Styles.DynamicStyleStyle.DynamicStyleStyle), IsNavigation = true },
                    new Pagina() { Name = "StyleClass", Description = "Forma de Namear estilos", PageFile = typeof(XamarinForms.Styles.StyleClassStyle.StyleClassStyle), IsNavigation = true },
                    new Pagina() { Name = "VisualStateManager", Description = "Apresentação visual diferente em situações(state) do componente", PageFile = typeof(XamarinForms.Styles.VSM.Vsm), IsNavigation = true },
                    new Pagina() { Name = "MaterialDesign", Description = "Aplicar Google Material Design no app", PageFile = typeof(XamarinForms.Styles.MaterialDesign.MaterialDesignIO), IsNavigation = true },
                    new Pagina() { Name = "Font", Description = "Adicionar fonte personalizada", PageFile = typeof(XamarinForms.Styles.CustomFonts.CustomFonsPage), IsNavigation = true },
                    new Pagina() { Name = "ChangeTheme", Description = "Mudar o tema do App", PageFile = typeof(XamarinForms.Styles.ChangeTheme.ChangeThemePage), IsNavigation = true },
                    new Pagina() { Name = "LightDarkTheme", Description = "Reagir a mudança de Tema do Android", PageFile = typeof(XamarinForms.Styles.DarkLightTheme.DarkLightPage), IsNavigation = true },
                };
                estilos.Name = "Estilos";

                var animacao = new PageCollection()
                {
                    new Pagina() { Name = "Animações simples", Description = "Anime quase tudo no Xamarin Forms, de Layouts a Listas", PageFile = typeof(XamarinForms.Animations.SimpleAnimation.SimpleAnimationPage), IsNavigation = true },
                };
                animacao.Name = "Animação";

                var gestos = new PageCollection()
                {
                    new Pagina() { Name = "Gestos simples", Description = "Detecte gestos feito pelo usuário", PageFile = typeof(XamarinForms.Gestos.Gestos), IsNavigation = true },
                };
                gestos.Name = "Gestos";

                var classesuteis = new PageCollection()
                {
                    new Pagina() { Name = "Display", Description = "Apresente Pop-ups para o usuário", PageFile = typeof(XamarinForms.ClassesUteis.Alerta.Alerta), IsNavigation = true },
                    new Pagina() { Name = "Converter", Description = "Mude/Converte a informação da tela", PageFile = typeof(XamarinForms.ClassesUteis.Conversores.Conversores), IsNavigation = true },
                    new Pagina() { Name = "MessageCenter", Description = "Troque mensagens entre telas de forma elegante", PageFile = typeof(XamarinForms.ClassesUteis.MessageCenter.MessageCenterClass), IsNavigation = true },
                    new Pagina() { Name = "OnPlatform/OnIdiom", Description = "Detecte sistema operacional, dispositivo e personalize sua interface", PageFile = typeof(XamarinForms.ClassesUteis.OnPlatformAndOnIdiom.OnPlatformAndOnIdiom), IsNavigation = true },
                };
                classesuteis.Name = "Classes úteis";

                return new List<PageCollection>()
                {
                    paginas,
                    Layouts,
                    Listas,
                    listas,
                    estilos,
                    animacao,
                    gestos,
                    classesuteis
                };
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}