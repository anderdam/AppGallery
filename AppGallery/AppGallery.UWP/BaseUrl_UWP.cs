using AppGallery.XamarinForms.Listas.WebViewControle;

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
