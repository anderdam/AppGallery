
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.TimePickerControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimePickerControle : ContentPage
    {
        public TimePickerControle()
        {
            InitializeComponent();
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Time")
            {
                lblInformativo.Text = "Time alterado";
            }
        }
    }
}