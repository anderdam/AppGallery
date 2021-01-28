using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Styles.ImplicitStyleLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImplicitStyleLayout : ContentPage
    {
        public ImplicitStyleLayout()
        {
            InitializeComponent();
        }
    }

    public class MeuBotao : Button
    {
        public MeuBotao()
        {
            Text = "Meu Botão";
        }
    }
}