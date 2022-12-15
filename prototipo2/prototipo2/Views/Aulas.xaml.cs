using prototipo2.ViewsAulas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prototipo2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aulas : ContentPage
    {
        public Aulas()
        {
            InitializeComponent();
        }

        private async void BtAula1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Aula1());
           

        }

        private async void BtAula2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Aula2());


        }
    }
}