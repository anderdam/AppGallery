using System;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.WebViewControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewControle : ContentPage
    {
        public WebViewControle()
        {
            InitializeComponent();

            var webViewHtmlSource = new HtmlWebViewSource
            {
                Html = @"<html>
                            <body>
                                <h1>Sou uma página</h1>
                                <h2>dentro do WebView</h2>
                                <p>
                                    Teste de renderização de HTML e <span style = 'color: red; text-decoration: underline; font-weight: bold;'> CSS </span> no WebView
                                </p>
                            </body>
                        </html>"
            };

            WebView1.Source = webViewHtmlSource;

            //DependencyService - Xamarin.Forms: caminho onde se encontra os arquivos do site
            var BaseURL = DependencyService.Get<IBaseURL>().Get();
            var endereco = new UrlWebViewSource
            {
                Url = Path.Combine(BaseURL, "index.html")
            };


            WebView2.Source = endereco;
        }

        private void btnVoltar(object sender, EventArgs e)
        {
            if (WebView2.CanGoBack)
            {
                WebView2.GoBack();
            }
        }

        private void btnAtualizar(object sender, EventArgs e)
        {
            WebView2.Reload();
        }

        private void btnProxima(object sender, EventArgs e)
        {
            if (WebView2.CanGoForward)
            {
                WebView2.GoForward();
            }
        }

        private void Carregado(object sender, WebNavigatedEventArgs e)
        {
            lblStatus.Text = "Carregado";
        }

        private void Carregando(object sender, WebNavigatingEventArgs e)
        {
            lblStatus.Text = "Carregando...";
            lblUrl.Text = e.Url;
        }
    }
}