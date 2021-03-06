﻿
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.DataSelecaoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataSelecao : ContentPage
    {
        public DataSelecao()
        {
            InitializeComponent();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            lblInformativoAntigo.Text = $"Data antiga: {e.OldDate.ToString("dd/MM/yyyy")}";
            lblInformativoNovo.Text = $"Data nova: {e.NewDate.ToString("dd/MM/yyyy")}";
        }
    }
}