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
    public partial class Aula2 : ContentPage
    {
        public Aula2()
        {
            InitializeComponent();

            UriVideoSource uriVideoSource = new UriVideoSource()
            {
                Uri = "https://player.vimeo.com/progressive_redirect/playback/781271387/rendition/720p/file.mp4?loc=external&signature=93055585eb55012c675258f8eadd83bb6a5c2de73c8c8bf693324897fabe3e78"
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