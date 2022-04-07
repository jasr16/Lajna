using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using MediaManager;
using Lajna.Model;

namespace Lajna
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void button_film_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("film.mp3");
        }

        private void button_haviri_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("haviri.mp3");
        }

        private void button_hymna_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("hymna.mp3");
        }

        private void button_judging_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("i_doesnt_judge_anyone.mp3");
        }

        private void button_pokuta_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("pokuta.mp3");
        }

        private void button_superb_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("superb.mp3");
        }

        private void button_dobra_parta_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("dobra_parta.mp3");
        }

        private void button_havirov_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("havirov.mp3");
        }

        private void button_jedeme_pres_hradec_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("jedeme_pres_hradec.mp3");
        }

        private void button_panely_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("panely.mp3");
        }

        private void button_postup_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("postup.mp3");
        }

        private void button_zamrzla_voda_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("zamrzla_voda.mp3");
        }
    }
}
