﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            /*
            var pagina = new NavigationPage(new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01());
            MainPage = pagina;
            */
            //var pagina = new XamarinForms.Paginas.Modal.Conteudo01();
            /*
            var pagina = new CarouselPage();
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo01());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo02());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo03());
            MainPage = pagina;
            */
            /*
            var pagina = new MasterDetailPage();
            //Menu
            pagina.Master = ;
            //Conteudo
            pagina.Detail = ;
            */

            MainPage = new XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}