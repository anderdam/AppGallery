using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.ListViewControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewControle : ContentPage
    {
        public ListViewControle()
        {
            InitializeComponent();

            Lista01.ItemsSource = GetMarcas();
        }

        private List<Marca> GetMarcas()
        {
            return new List<Marca>()
            {
                GetListaCarrosMarca(),
                GetListaCarrosMarca2(),
                GetListaCarrosMarca3()
            };
        }

        private Marca GetListaCarrosMarca()
        {
            var Marca1 = new Marca()
            {
                new Carro
                {
                    Nome = "Carro 01",
                    Motorizacao = "1.0",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                },

                new Carro
                {
                    Nome = "Carro 02",
                    Motorizacao = "1.6",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                },

                new Carro
                {
                    Nome = "Carro 03",
                    Motorizacao = "2.0",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                },

                new Carro
                {
                    Nome = "Carro 04",
                    Motorizacao = "2.0",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                },

                new Carro
                {
                    Nome = "Carro 05",
                    Motorizacao = "2.0",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                }
            };

            Marca1.NomeMarca = "Marca 01";

            return Marca1;
        }

        private Marca GetListaCarrosMarca2()
        {
            var Marca2 = new Marca()
            {
                new Carro
                {
                    Nome = "Carro 01",
                    Motorizacao = "1.0",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                },

                new Carro
                {
                    Nome = "Carro 02",
                    Motorizacao = "1.6",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                },

                new Carro
                {
                    Nome = "Carro 03",
                    Motorizacao = "2.0",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                },

                new Carro
                {
                    Nome = "Carro 04",
                    Motorizacao = "2.0",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                },

                new Carro
                {
                    Nome = "Carro 05",
                    Motorizacao = "2.0",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                }
            };

            Marca2.NomeMarca = "Marca 02";

            return Marca2;
        }

        private Marca GetListaCarrosMarca3()
        {
            var Marca3 = new Marca()
            {
                new Carro
                {
                    Nome = "Carro 01",
                    Motorizacao = "1.0",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                },

                new Carro
                {
                    Nome = "Carro 02",
                    Motorizacao = "1.6",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                },

                new Carro
                {
                    Nome = "Carro 03",
                    Motorizacao = "2.0",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                },

                new Carro
                {
                    Nome = "Carro 04",
                    Motorizacao = "2.0",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                },

                new Carro
                {
                    Nome = "Carro 05",
                    Motorizacao = "2.0",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                }
            };

            Marca3.NomeMarca = "Marca 03";

            return Marca3;
        }

        private Marca GetListaCarrosMarca4()
        {
            var Marca4 = new Marca()
            {
                new Carro
                {
                    Nome = "Carro 04",
                    Motorizacao = "1.0",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                },

                new Carro
                {
                    Nome = "Carro 05",
                    Motorizacao = "1.6",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                },

                new Carro
                {
                    Nome = "Carro 06",
                    Motorizacao = "2.0",
                    Descricao = "Loren Ipsun",
                    ItemsDeSerie = "Item 1, Item2, Item3"
                }
            };
            Marca4.NomeMarca = "Marca 04";

            return Marca4;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var parametro = ((MenuItem)sender).CommandParameter;
            var carro = (Carro)parametro;

            DisplayAlert("Clicou em visualizar", $"Registro: {carro.Nome}", "OK");
        }

        private void Lista01_Refreshing(object sender, EventArgs e)
        {
            var marca = new List<Marca>()
            {
                GetListaCarrosMarca4()
            };
            Lista01.ItemsSource = marca;
            Lista01.IsRefreshing = false;
        }

        private void Lista01_Scrolled(object sender, ScrolledEventArgs e)
        {
            lblScroll.Text = $"X: {e.ScrollX} e Y: {e.ScrollY} ";
        }

        private void MoverParaMarca3(object sender, EventArgs e)
        {
            var marcas = (List<Marca>)Lista01.ItemsSource;
            Marca marca3 = marcas[2];
            var carro1 = marca3[0];
            Lista01.ScrollTo(carro1, ScrollToPosition.Start, true);
        }

        private void Lista01_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Selecionado", "Item selecionado", "OK");
        }

        private void Lista01_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Tocado", "Item tocado", "OK");
        }
    }

    public class Carro
    {
        public string Nome { get; set; }
        public string Motorizacao { get; set; }
        public string Cor { get; set; }
        public string Descricao { get; set; }
        public string ItemsDeSerie { get; set; }
    }

    public class Marca : List<Carro>
    {
        public String NomeMarca { get; set; }
    }
}