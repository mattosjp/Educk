using prototipo2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prototipo2.ViewsAtividades
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Atividade13 : ContentPage
    {
        int click = 0;
        public Atividade13()
        {
            InitializeComponent();
        }
        async void OnRootPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private void Bt_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (click == 0)
            {
                click = 1;
                if (btn.Text == "A) Mostrar imagens aleatórias")
                {
                    Btn1.BackgroundColor = Color.Red;
                    Btn1.TextColor = Color.White;

                    Btn4.BackgroundColor = Color.Green;
                    Btn4.TextColor = Color.White;
                }
                else if (btn.Text == "B) Mostrar sua localização")
                {
                    Btn2.BackgroundColor = Color.Red;
                    Btn2.TextColor = Color.White;

                    Btn4.BackgroundColor = Color.Green;
                    Btn4.TextColor = Color.White;
                }
                else if (btn.Text == "C) Mostrar produtos à venda")
                {
                    Btn3.BackgroundColor = Color.Red;
                    Btn3.TextColor = Color.White;

                    Btn4.BackgroundColor = Color.Green;
                    Btn4.TextColor = Color.White;
                }
                else if (btn.Text == "D) Mostrar imagens relacionadas à pesquisa")
                {
                    Btn4.BackgroundColor = Color.Green;
                    Btn4.TextColor = Color.White;
                }
                BtnContinuar.IsVisible = true;

            }
        }

        private async void BtnContinuar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();

        }


    }
}