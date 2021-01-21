using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.SwipeViewControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipeViewControle : ContentPage
    {
        public SwipeViewControle()
        {
            InitializeComponent();
        }

        private void Detalhe(object sender, EventArgs e)
        {
            lblDetalhe.Text = $"Acionado Detalhe: {DateTime.Now:HH:mm:ss}";
        }

        private void Editar(object sender, EventArgs e)
        {
            lblEditar.Text = $"Acionado Editar: {DateTime.Now:HH:mm:ss}";
        }

        private void Excluir(object sender, EventArgs e)
        {
            lblExcluir.Text = $"Acionado Excluir: {DateTime.Now:HH:mm:ss}";
        }

        private void SwipeStarted(object sender, SwipeStartedEventArgs e)
        {
            lblStarted.Text = $"Acionado Started: {DateTime.Now:HH:mm:ss} - {e.SwipeDirection}";
        }

        private void SwipeChanging(object sender, SwipeChangingEventArgs e)
        {
            lblChanging.Text = $"Acionado Changing: {DateTime.Now:HH:mm:ss} - {e.SwipeDirection}: {e.Offset}";
        }

        private void SwipeEnded(object sender, SwipeEndedEventArgs e)
        {
            lblEnded.Text = $"Acionado Ended: {DateTime.Now:HH:mm:ss} - {e.SwipeDirection}";
        }

        private void CloseSwipeView(object sender, EventArgs e)
        {
            lblClose.Text = $"Acionado Close: {DateTime.Now:HH:mm:ss}";
        }
    }
}