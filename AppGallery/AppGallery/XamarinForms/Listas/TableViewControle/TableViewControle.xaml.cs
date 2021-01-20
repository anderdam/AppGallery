using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.TableViewControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TableViewControle : ContentPage
    {
        public TableViewControle()
        {
            InitializeComponent();
        }

        private void TextCell_Tapped(object sender, EventArgs e)
        {
            ((TextCell)sender).Text += "(Clicado)";
        }

        /*
        private void EntryCell_Completed(object sender, EventArgs e)
        {

        }
        
        private void Tocado(object sender, EventArgs e)
        {
            
        }
        */
    }
}