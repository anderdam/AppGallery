using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Styles.ChangeTheme
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangeThemePage : ContentPage
    {
        private bool ThemeLight = false;
        public ChangeThemePage()
        {
            InitializeComponent();
        }

        private void BtnChangeTheme(object sender, EventArgs e)
        {
            Resources = !ThemeLight ? new LightThemePage() : (ResourceDictionary)new DarkThemePage();

            ThemeLight = !ThemeLight;

            /*Alterar o tema global:
             * App.Current.Resources = new LightTheme();
             */

        }
    }
}