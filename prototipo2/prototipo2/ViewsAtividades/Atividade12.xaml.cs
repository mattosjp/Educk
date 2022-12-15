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
    public partial class Atividade12 : ContentPage
    {
        int click = 0;
        public Atividade12()
        {
            InitializeComponent();

        }
        async void OnRootPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            if (click == 0)
            {
                click = 1;
                Btn1.BackgroundColor = Color.Red;
                Btn3.Background = Color.Green;
                BtnContinuar.IsVisible = true;

            }
        }
        private void Btn2_Clicked(object sender, EventArgs e)
        {
            if (click == 0)
            {
                click = 1;
                Btn2.BackgroundColor = Color.Red;
                Btn3.Background = Color.Green;
                BtnContinuar.IsVisible = true;

            }
        }
        private void Btn3_Clicked(object sender, EventArgs e)
        {
            if (click == 0)
            {
                click = 1;
                Btn3.Background = Color.Green;
                BtnContinuar.IsVisible = true;

            }
        }
        private void Btn4_Clicked(object sender, EventArgs e)
        {
            if (click == 0)
            {
                click = 1;
                Btn4.BackgroundColor = Color.Red;
                Btn3.Background = Color.Green;
                BtnContinuar.IsVisible = true;

            }
        }

        private async void BtnContinuar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Atividade13());
        }


    }
}