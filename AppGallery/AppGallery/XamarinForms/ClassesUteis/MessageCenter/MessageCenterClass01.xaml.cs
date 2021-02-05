using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.ClassesUteis.MessageCenter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessageCenterClass01 : ContentPage
    {
        public MessageCenterClass01()
        {
            InitializeComponent();
        }

        private void BtnSalvar(object sender, EventArgs e)
        {
            var nome = EntryNome.Text;
            Pessoa pessoa = new Pessoa() { Nome = nome };

            MessagingCenter.Send(this, "CadastroPessoa", pessoa);
        }
    }
}