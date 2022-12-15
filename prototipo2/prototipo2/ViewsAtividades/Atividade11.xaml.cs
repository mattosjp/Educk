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
    public partial class Atividade11 : ContentPage
    {
        int click = 0;
        public Atividade11()
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
                if (btn.Text == "A) Navegar pelos mares")
                {
                    Btn1.BackgroundColor = Color.Red;
                    Btn1.TextColor = Color.White;

                    Btn2.BackgroundColor = Color.Green;
                    Btn2.TextColor = Color.White;
                }
                else if (btn.Text == "B) Trazer informações desejadas")
                {
                    Btn2.BackgroundColor = Color.Green;
                    Btn2.TextColor = Color.White;

                }
                else if (btn.Text == "C) Ligar para alguém")
                {
                    Btn3.BackgroundColor = Color.Red;
                    Btn3.TextColor = Color.White;

                    Btn2.BackgroundColor = Color.Green;
                    Btn2.TextColor = Color.White;
                }
                else if (btn.Text == "D) Pedir dados pessoais")
                {
                    Btn4.BackgroundColor = Color.Red;
                    Btn4.TextColor = Color.White;

                    Btn2.BackgroundColor = Color.Green;
                    Btn2.TextColor = Color.White;
                }
                BtnContinuar.IsVisible=true;

            }
        }

        private async void BtnContinuar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Atividade12());
        }


    }
}