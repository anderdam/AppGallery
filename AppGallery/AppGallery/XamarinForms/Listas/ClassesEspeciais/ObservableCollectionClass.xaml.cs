using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.ClassesEspeciais
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObservableCollectionClass : ContentPage
    {
        public ObservableCollection<Pessoa> ListaDePessoas { get; set; }
        public ObservableCollectionClass()
        {
            InitializeComponent();

            ListaDePessoas = GetListaPessoas();
            List01.ItemsSource = ListaDePessoas;
        }

        private ObservableCollection<Pessoa> GetListaPessoas()
        {
            return new ObservableCollection<Pessoa>()
            {
                new Pessoa {Nome = "Anderson", Sobrenome = "Damasceno"}
            };
        }

        private void BtnAdicionar(object sender, EventArgs e)
        {
            ListaDePessoas.Add(new Pessoa { Nome = "Fulano", Sobrenome = "da Silva" });
        }

        private void BtnRemover(object sender, EventArgs e)
        {
            ListaDePessoas.RemoveAt(0);
        }
    }

    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}