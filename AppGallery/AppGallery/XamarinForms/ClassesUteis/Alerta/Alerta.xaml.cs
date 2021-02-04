using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.ClassesUteis.Alerta
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Alerta : ContentPage
    {
        public Alerta()
        {
            InitializeComponent();
        }

        private void BtnDisplayAlert(object sender, EventArgs e)
        {
            DisplayAlert("Título", "Mensagem", "Ok");
        }

        private async void BtnDisplayActionSheet(object sender, EventArgs e)
        {
            string resultado = await DisplayActionSheet("Escolha as opções:", "Ok", null, "Opção 1", "Opção 2", "Opção 3");
        }

        private async void BtnDisplayPrompt(object sender, EventArgs e)
        {
            string nome = await DisplayPromptAsync("Entrada de dados", "Entre o dado"); 
        }
    }
}