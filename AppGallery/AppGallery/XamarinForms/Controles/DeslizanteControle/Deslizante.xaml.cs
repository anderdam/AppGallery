using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.DeslizanteControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Deslizante : ContentPage
    {
        public Deslizante()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblValueChanged.Text = "Valor antigo: " + e.OldValue + " Valor atual: " + e.NewValue;
        }

        private void Slider_DragStarted(object sender, EventArgs e)
        {
            lblDragStarted.Text = "Iniciou arrasto";
        }

        private void Slider_DragCompleted(object sender, EventArgs e)
        {
            lblDragCompleted.Text = "Arrasto completo";
        }
        private void Slider_ValueChanged_Step(object sender, ValueChangedEventArgs e)
        {
            int steps = 1;
            int newStep = (int)Math.Round(e.NewValue / steps);
            ((Slider)sender).Value = newStep * steps;
            lblValueChangedStep.Text = newStep.ToString();
        }
    }
}