using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.SearchBarControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarControle : ContentPage
    {
        public SearchBarControle()
        {
            InitializeComponent();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblTextChanged.Text = $"{e.NewTextValue.Length} - {e.NewTextValue}";
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            lblSearchButtonPressed.Text = "Botão de pesquisa clicado.";
        }
    }
}