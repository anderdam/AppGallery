
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.CaixaDeMarcacaoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CaixaDeMarcacao : ContentPage
    {
        public CaixaDeMarcacao()
        {
            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            lblChecked.Text = caixaMarcacao.IsChecked ? "Marcado" : "Desmarcado";
            //lblChecked.Text = e.Value ? "Marcado" : "Desmarcado";
        }
    }
}