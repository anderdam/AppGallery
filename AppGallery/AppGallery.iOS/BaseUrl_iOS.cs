using AppGallery.XamarinForms.Listas.WebViewControle;
using Foundation;

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