using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.CollectionViewControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewControle : ContentPage
    {
        private ObservableCollection<Categoria> categorias { get; set; }
        public CollectionViewControle()
        {
            InitializeComponent();

            Colecao01.ItemsSource = GetCategorias();
        }

        private ObservableCollection<Categoria> GetCategorias()
        {
            categorias = new ObservableCollection<Categoria>();

            var sanduiches = new Categoria()
            {
                new FastFood{ Nome = "Subway", QuantidadeDeFranquias = 45000},
                new FastFood{ Nome = "McDonalds", QuantidadeDeFranquias = 37000},
                new FastFood{ Nome = "KFC", QuantidadeDeFranquias = 19000},
                new FastFood{ Nome = "Burger King", QuantidadeDeFranquias = 15000},
            };
            sanduiches.NomeCategoria = "Sanduiches";

            var restaurantes = new Categoria()
            {
                new FastFood{ Nome = "Starbucks", QuantidadeDeFranquias = 27000},
                new FastFood{ Nome = "Baskin-Robbins", QuantidadeDeFranquias = 7500},
                new FastFood{ Nome = "Taco Bell", QuantidadeDeFranquias = 7000}
            };
            restaurantes.NomeCategoria = "Restaurantes";

            var pizzarias = new Categoria()
            {
                new FastFood{ Nome = "Dominoes", QuantidadeDeFranquias = 30000},
                new FastFood{ Nome = "Pizza Hut", QuantidadeDeFranquias = 37000},
            };
            pizzarias.NomeCategoria = "Pizzarias";

            categorias.Add(sanduiches);
            categorias.Add(restaurantes);
            categorias.Add(pizzarias);

            return categorias;
        }

        private void Colecao01_RemainingItemsThresholdReached(object sender, EventArgs e)
        {
            var diversos = new Categoria()
            {
                new FastFood{ Nome = "Marmitex", QuantidadeDeFranquias = 1000},
                new FastFood{ Nome = "Esfiharia", QuantidadeDeFranquias = 5000},
                new FastFood{ Nome = "Pastelaria", QuantidadeDeFranquias = 2000},
                new FastFood{ Nome = "Churrascaria", QuantidadeDeFranquias = 5000},
                new FastFood{ Nome = "Sushi", QuantidadeDeFranquias = 5000},
                new FastFood{ Nome = "Rodízio", QuantidadeDeFranquias = 5000},
            };
            diversos.NomeCategoria = "Diversos";

            categorias.Add(diversos);

            Colecao01.RemainingItemsThreshold = -1;
        }

        private void Colecao01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (FastFood fastFood in Colecao01.SelectedItems)
            {
                sb.Append(fastFood.Nome + " - ");
            }

            lblSelecao.Text = $"Seleção: " + sb.ToString();
        }
    }

    public class FastFood
    {
        public string Nome { get; set; }
        public int QuantidadeDeFranquias { get; set; }
    }

    public class Categoria : List<FastFood>
    {
        public string NomeCategoria { get; set; }
    }
}