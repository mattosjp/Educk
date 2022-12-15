using prototipo2.ViewsAtividades;
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
    public partial class Atividades : ContentPage
    {
        public Atividades()
        {
            InitializeComponent();
        }

        private async void BtAtividade1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Atividade11());
        }
    }
}