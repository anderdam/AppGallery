using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.ClassesUteis.OnPlatformAndOnIdiom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnPlatformAndOnIdiom : ContentPage
    {
        public OnPlatformAndOnIdiom()
        {
            InitializeComponent();

            /*
            if (Device.RuntimePlatform == Device.Android)
            {

            }
            */

            /*
            if (Device.Idiom == TargetIdiom.Phone)
            {

            }
            */
        }
    }
}