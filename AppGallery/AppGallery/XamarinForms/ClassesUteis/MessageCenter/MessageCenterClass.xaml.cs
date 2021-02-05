using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.ClassesUteis.MessageCenter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessageCenterClass : ContentPage
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; }

        public MessageCenterClass()
        {
            InitializeComponent();

            Pessoas = new ObservableCollection<Pessoa>()
            {
                new Pessoa(){ Nome = "José"},
                new Pessoa(){ Nome = "João"}
            };

            Lista01.ItemsSource = Pessoas;

            MessagingCenter.Subscribe<MessageCenterClass01, Pessoa>(this, "CadastroPessoa", (sender, pessoa) => 
            {
                Pessoas.Add(pessoa);
            });
        }

        private void BtnCadastrar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MessageCenterClass01());
        }
    }

    public class Pessoa
    {
        public string Nome { get; set; }
    }
}