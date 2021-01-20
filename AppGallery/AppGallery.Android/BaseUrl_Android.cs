using AppGallery.XamarinForms.Listas.WebViewControle;

[assembly: Xamarin.Forms.Dependency(typeof(AppGallery.Droid.BaseUrl_Android))]
namespace AppGallery.Droid
{
    public class BaseUrl_Android : IBaseURL
    {
        public string Get()
        {
            return "file:///android_asset/";
        }
    }
}