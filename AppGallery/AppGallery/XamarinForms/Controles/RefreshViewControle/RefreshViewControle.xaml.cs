using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.RefreshViewControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RefreshViewControle : ContentPage
    {
        public RefreshViewControle()
        {
            InitializeComponent();
        }

        private void RefreshView_Refreshing(object sender, EventArgs e)
        {
            lblStatus.Text = $"Atualizado: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} ";
            ((RefreshView)sender).IsRefreshing = false;
        }
    }
}