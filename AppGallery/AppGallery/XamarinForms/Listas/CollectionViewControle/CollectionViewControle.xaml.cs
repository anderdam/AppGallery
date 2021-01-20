using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.CollectionViewControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewControle : ContentPage
    {
        public CollectionViewControle()
        {
            InitializeComponent();
            
            Colecao01.ItemsSource = GetCategorias();
        }

        private List<Categoria> GetCategorias()
        {
            var categorias = new List<Categoria>();
            
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