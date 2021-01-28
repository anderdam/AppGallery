
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.CarouselViewControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewControle : ContentPage
    {
        private ObservableCollection<Colaborador> Colaboradores { get; set; }
        public CarouselViewControle()
        {
            InitializeComponent();

            Colaboradores = GetColaboradores();

            Carousel01.ItemsSource = Colaboradores;
        }

        private ObservableCollection<Colaborador> GetColaboradores()
        {
            return new ObservableCollection<Colaborador>() {
                new Colaborador(){ Nome = "João Ribeiro", Cargo = "Web Designer", Descricao = "Sou Web Designer desde 2010. Conheço CSS, HTML, Adobe Photoshop, Adobe Illustrator e Autodesk 3D MAX" },
                new Colaborador(){ Nome = "Felipe Rodrigues", Cargo = "Programador", Descricao = "Sou Programador Java desde 2010. Trabalhei com JSF, JSP, Java EE, HTML e CSS." },
                new Colaborador(){ Nome = "José Ribeiro", Cargo = "Programador Web", Descricao = "Sou Programador PHP desde 2000. Conheço PHP, Frameworks como Laravel, Codeignite e Zend Framework." },
                new Colaborador(){ Nome = "Maria Ribeiro", Cargo = "Programador PHP", Descricao = "Sou Programador PHP desde 2000. Conheço PHP, Frameworks como Laravel, Codeignite e Zend Framework." },
            };
        }

        private void Carousel01_RemainingItemsThresholdReached(object sender, System.EventArgs e)
        {

            Colaboradores.Add(new Colaborador() { Nome = "Emanoel Rodrigues", Cargo = "Web Designer", Descricao = "Sou Web Designer desde 2010. Conheço CSS, HTML, Adobe Photoshop, Adobe Illustrator e Autodesk 3D MAX" });
            Colaboradores.Add(new Colaborador() { Nome = "Madalena Rodrigues", Cargo = "Web Designer", Descricao = "Sou Web Designer desde 2010. Conheço CSS, HTML, Adobe Photoshop, Adobe Illustrator e Autodesk 3D MAX" });
            Colaboradores.Add(new Colaborador() { Nome = "Jessica Rodrigues", Cargo = "Web Designer", Descricao = "Sou Web Designer desde 2010. Conheço CSS, HTML, Adobe Photoshop, Adobe Illustrator e Autodesk 3D MAX" });

            Carousel01.RemainingItemsThreshold = -1;
        }

        private void Carousel01_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            var colaborador = (Colaborador)e.CurrentItem;
            LblItem.Text = $"Nome: {colaborador.Nome}";
        }

        private void Carousel01_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            LblPosition.Text = "Posição: " + e.CurrentPosition + " - Posição anterior: " + e.PreviousPosition;
        }

        private void Carousel01_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            LblScroll.Text = "Scroll: " + e.HorizontalOffset;
        }
    }

    public class Colaborador 
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Descricao { get; set; }
    }
}