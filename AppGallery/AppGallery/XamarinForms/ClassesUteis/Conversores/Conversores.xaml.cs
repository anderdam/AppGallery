using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.ClassesUteis.Conversores
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conversores : ContentPage
    {
        public Conversores()
        {
            InitializeComponent();

            List01.ItemsSource = new List<Veiculo>
            {
                new Veiculo {Marca = "Fiat", Modelo = "Uno", Opcionais = "1, 2, 3", Valor = 35000.00},
                new Veiculo {Marca = "Ford", Modelo = "Fiesta", Opcionais = "1, 2, 3", Valor = 40000.00},
                new Veiculo {Marca = "VW", Modelo = "Polo", Opcionais = "1, 2, 3", Valor = 45000.00}
            };
        }
    }

    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Opcionais { get; set; }
        public double Valor { get; set; }

    }
}