﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.CampoDeEntradaMultilineControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CampoDeEntradaMultiline : ContentPage
    {
        public CampoDeEntradaMultiline()
        {
            InitializeComponent();
        }

        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            lblFocus.Text = "Campo focado";
        }

        private void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            lblUnfocus.Text = "Foco removido do campo";
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblTextChange.Text = e.NewTextValue + " - " + e.NewTextValue.Length;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            lblComplete.Text = "Preenchimento finalizado";
        }
    }
}