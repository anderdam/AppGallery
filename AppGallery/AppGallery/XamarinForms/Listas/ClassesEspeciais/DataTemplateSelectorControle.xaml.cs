using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.ClassesEspeciais
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataTemplateSelectorControle : ContentPage
    {
        public DataTemplateSelectorControle()
        {
            InitializeComponent();

            List01.ItemsSource = GetProdutos();
        }

        private List<Produto> GetProdutos()
        {
            
            return new List<Produto>
            {
                //Mercearia
                new Produto { Nome = "Arroz", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Feijão", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Óleo", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Azeite de oliva", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Vinagre", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Açúcar", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Milho para pipoca", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Farinha de trigo", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Fermento em pó", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Aveia", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Cereais", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Amido de milho", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Farinha de mandioca", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Extrato de tomate", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Macarrão", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Queijo ralado", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Enlatados", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Conservas", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Bolachas", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Petiscos", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Pães", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Maionese", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Ketchup", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Mostarda", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Frios", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Manteiga", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Requeijão", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Geleias ou doces pastosos", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Mel", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Sal", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Temperos secos", Valor = 1.0, Setor = "Mercearia" },
                new Produto { Nome = "Especiarias", Valor = 1.0, Setor = "Mercearia" },
                
                //Feira
                new Produto { Nome = "Ovos", Valor = 1.0, Setor = "Feira" },
                new Produto { Nome = "Verduras", Valor = 1.0, Setor = "Feira" },
                new Produto { Nome = "Legumes", Valor = 1.0, Setor = "Feira" },
                new Produto { Nome = "Vegetais", Valor = 1.0, Setor = "Feira" },
                new Produto { Nome = "Frutas", Valor = 1.0, Setor = "Feira" },
                new Produto { Nome = "Cebola", Valor = 1.0, Setor = "Feira" },
                new Produto { Nome = "Alho", Valor = 1.0, Setor = "Feira" },
                new Produto { Nome = "Ervas e temperos frescos", Valor = 1.0, Setor = "Feira" },

                //Açougue
                new Produto { Nome = "Bifes", Valor = 1.0, Setor = "Açougue" },
                new Produto { Nome = "Carne moída", Valor = 1.0, Setor = "Açougue" },
                new Produto { Nome = "Frango", Valor = 1.0, Setor = "Açougue" },
                new Produto { Nome = "Peixes", Valor = 1.0, Setor = "Açougue" },
                new Produto { Nome = "Bacon", Valor = 1.0, Setor = "Açougue" },
                new Produto { Nome = "Hambúrgueres", Valor = 1.0, Setor = "Açougue" },
                new Produto { Nome = "Linguiças", Valor = 1.0, Setor = "Açougue" },
                new Produto { Nome = "Salsichas", Valor = 1.0, Setor = "Açougue" },

                //Bebidas
                new Produto { Nome = "Café", Valor = 1.0, Setor = "Bebidas" },
                new Produto { Nome = "Chás", Valor = 1.0, Setor = "Bebidas" },
                new Produto { Nome = "Sucos", Valor = 1.0, Setor = "Bebidas" },
                new Produto { Nome = "Iogurtes", Valor = 1.0, Setor = "Bebidas" },
                new Produto { Nome = "Leite", Valor = 1.0, Setor = "Bebidas" },
                new Produto { Nome = "Achocolatado", Valor = 1.0, Setor = "Bebidas" },
                new Produto { Nome = "Refrigerantes", Valor = 1.0, Setor = "Bebidas" },
                new Produto { Nome = "Bebidas alcoólicas", Valor = 1.0, Setor = "Bebidas" },

                //Higiene e Higiene
                new Produto { Nome = "Shampoo", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Condicionador", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Sabonetes", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Sabonete líquido", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Cotonetes", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Algodão", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Papel higiênico", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Pasta de dente", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Escova de dente", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Fio dental", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Antisséptico bucal", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Desodorante", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Detergente", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Desengordurante", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Esponja para louça", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Palha de aço", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Escova de Higiene", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Sabão em barra", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Sabão em pó ou líquido", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Amaciante", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Água sanitária", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Sacos de lixo", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Desinfetante", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Limpador multiuso", Valor = 1.0, Setor = "Higiene" },
                new Produto { Nome = "Álcool", Valor = 1.0, Setor = "Higiene" },

                //Utilidades
                new Produto { Nome = "Papel toalha", Valor = 1.0, Setor = "Utilidades" },
                new Produto { Nome = "Papel alumínio", Valor = 1.0, Setor = "Utilidades" },
                new Produto { Nome = "Filtro para café", Valor = 1.0, Setor = "Utilidades" }
            };
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Setor { get; set; }
    }

    public class SetorDataTemplateSelector : DataTemplateSelector
    {

        public DataTemplate MerceariaTemplate { get; set; }
        public DataTemplate FeiraTemplate { get; set; }
        public DataTemplate AcougueTemplate { get; set; }
        public DataTemplate BebidasTemplate { get; set; }
        public DataTemplate HigieneTemplate { get; set; }
        public DataTemplate UtilidadesTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Produto produto = (Produto)item;

            switch (produto.Setor)
            {
                case "Mercearia":
                    return MerceariaTemplate;
                case "Feira":
                    return FeiraTemplate;
                case "Açougue":
                    return AcougueTemplate;
                case "Bebidas":
                    return BebidasTemplate;
                case "Higiene":
                    return HigieneTemplate;
                case "Utilidades":
                    return UtilidadesTemplate;
                default:
                    return null;
            }

            /*
            if (produto.Setor == "Mercearia")
            {
                return MerceariaTemplate;
            }
            else if (produto.Setor == "Feira")
            {
                return FeiraTemplate;
            }
            else if (produto.Setor == "Açougue")
            {
                return AcougueTemplate;
            }
            else if (produto.Setor == "Bebidas")
            {
                return BebidasTemplate;
            }
            else if (produto.Setor == "Higiene")
            {
                return HigieneTemplate;
            }
            else if (produto.Setor == "Utilidades")
            {
                return UtilidadesTemplate;
            }
            else
            {
                return null;
            }
            */
        }
    }
}