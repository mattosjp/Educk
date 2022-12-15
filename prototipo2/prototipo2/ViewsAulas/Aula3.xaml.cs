using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xam.Forms.VideoPlayer;

namespace prototipo2.ViewsAulas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aula3 : ContentPage
    {
        public Aula3()
        {
            InitializeComponent();

            UriVideoSource uriVideoSource = new UriVideoSource()
            {
                Uri = "http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4"
            };

            videoPlayer.Source = uriVideoSource;
        }

        async void OnRootPageButtonClicked(object sender, EventArgs e)
        {
            videoPlayer.Pause();
            await Navigation.PopToRootAsync();
        }

        private async void VideoPlayer_PlayError(object sender, VideoPlayer.PlayErrorEventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void videoPlayer_PlayCompletion(System.Object sender, System.EventArgs e)
        {
            await DisplayAlert("Vídeo", "Aula concluída", "OK");
        }
    }
}