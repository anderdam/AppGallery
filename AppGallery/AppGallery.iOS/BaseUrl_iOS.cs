using AppGallery.XamarinForms.Listas.WebViewControle;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(AppGallery.iOS.BaseUrl_iOS))]
namespace AppGallery.iOS
{
    public class BaseUrl_iOS : IBaseURL
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}