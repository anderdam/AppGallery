
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.PassadorControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Passador : ContentPage
    {
        public Passador()
        {
            InitializeComponent();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblInformativo.Text = "Valor antigo" + e.OldValue.ToString() + " - Valor Atual:" + e.NewValue.ToString();
        }
    }
}