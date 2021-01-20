using AppGallery.XamarinForms.Listas.WebViewControle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(AppGallery.UWP.BaseUrl_UWP))]
namespace AppGallery.UWP
{
    public class BaseUrl_UWP : IBaseURL
    {
        public string Get()
        {
            return "ms-appx-web:///Site/";
        }
    }
}
