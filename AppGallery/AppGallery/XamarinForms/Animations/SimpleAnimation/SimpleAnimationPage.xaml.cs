using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Animations.SimpleAnimation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleAnimationPage : ContentPage
    {
        public SimpleAnimationPage()
        {
            InitializeComponent();
        }

        private async void BtnTranslate(object sender, EventArgs e)
        {
            await BoxAnimated.TranslateTo(100, 50, 500, Easing.Linear);
            await Task.Delay(500);
            await BoxAnimated.TranslateTo(0, 0, 1000, Easing.BounceOut);

        }

        private async void BtnRotation(object sender, EventArgs e)
        {
            await BoxAnimated.RotateTo(90, 1000, Easing.SpringOut);
            await Task.Delay(500);
            await BoxAnimated.RotateTo(0, 1000, Easing.CubicOut);
        }

        private async void BtnScale(object sender, EventArgs e)
        {
            await BoxAnimated.ScaleTo(2, 500, Easing.CubicInOut);
            await Task.Delay(500);
            await BoxAnimated.ScaleTo(1, 1000, Easing.Linear);
        }

        private async void BtnOpacity(object sender, EventArgs e)
        {
            await BoxAnimated.FadeTo(0.2, 500, Easing.Linear);
            await Task.Delay(500);
            await BoxAnimated.FadeTo(1, 1000, Easing.Linear);
        }

        private async void BtnAnimacaoCombinada(object sender, EventArgs e)
        {
            await Task.WhenAll(
                BoxAnimated.TranslateTo(0,150, 1000, Easing.SpringOut), 
                BoxAnimated.ScaleTo(1.5, 1000, Easing.Linear),
                BoxAnimated.RotateTo(45, 1000, Easing.BounceOut)            
                );

            await Task.Delay(1000);

            await Task.WhenAll(
                BoxAnimated.RotateTo(0, 1000, Easing.BounceOut),
                BoxAnimated.ScaleTo(1, 1000, Easing.Linear),
                BoxAnimated.TranslateTo(0, 0, 1000, Easing.SpringOut)
                );
        }

        private async void BtnAnimacaoPersonalizada(object sender, EventArgs e)
        {
            var animacao = new Animation(v => BoxAnimated.CornerRadius = v, 5, 30, Easing.Linear);
            animacao.Commit(BoxAnimated, "CornerAnimation", 300, 1000, Easing.Linear, null, () => false);

            await Task.Delay(3000);

            var animacao2 = new Animation(v => BoxAnimated.CornerRadius = v, 100, 0, Easing.Linear);
            animacao.Commit(BoxAnimated, "CornerAnimation", 300, 1000, Easing.Linear, null, () => false);
        }
    }
}