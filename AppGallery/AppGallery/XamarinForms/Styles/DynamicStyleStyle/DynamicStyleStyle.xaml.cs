using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Styles.DynamicStyleStyle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicStyleStyle : ContentPage
    {
        public DynamicStyleStyle()
        {
            InitializeComponent();
        }

        private void BtnChangeButtonColorStyle(object sender, EventArgs e)
        {
            Resources["PrimaryColor"] = Color.FromHex(EntryCorHex.Text);
        }
    }
}