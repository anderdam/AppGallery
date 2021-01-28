using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.ClassesEspeciais
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class INotifyPropertyChangedControle : ContentPage
    {
        public INotifyPropertyChangedControle()
        {
            InitializeComponent();

            List01.ItemsSource = new List<Carro>
            {
                new Carro(){Nome = "Ford Fiesta", Motor = "2.0" }
            };
        }

        private void BtnSalvar(object sender, EventArgs e)
        {
            string nome = Nome.Text;
            string motor = Motor.Text;

            var lista = (List<Carro>)List01.ItemsSource;

            lista[0].Nome = nome;
            lista[0].Motor = motor;
        }
    }

    public class Carro : INotifyPropertyChanged
    {
        private string _nome;
        private string _motor;

        public string Nome
        {
            get { return _nome; }
            set 
            {
                _nome = value;
                RaisePropertyChanged(nameof(Nome));
            }
        }
        public string Motor
        {
            get { return _motor; }
            set 
            {
                _motor = value;
                RaisePropertyChanged(nameof(Motor));

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            /*if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));*/
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}