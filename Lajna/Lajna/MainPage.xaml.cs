using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            CrossMediaManager.Current.Init();
            InitializeComponent();
        }

        async private void button_play_Clicked(object sender, EventArgs e)
        {
            bool isPlaying = CrossMediaManager.Current.IsPlaying();
            if (isPlaying)
            {
                await CrossMediaManager.Current.Stop();
            }
            else
            {
                string soundPathAlive = "/storage/emulated/0/Android/Music/Alive.mp3";
                string[] songs = FilePicking.FindAllMp3s();
                _ = await CrossMediaManager.Current.Play(songs);
            }
            
            
            //PickOptions options = new PickOptions();
            //options = null;
            //Task<FileResult> res = FilePicking.PickAndShow(options);
            //if (res != null)
            //{
            //    // await CrossMediaManager.Current.Play(res.Result.FileName);
            //}
        }

        private void button_play_two_Clicked(object sender, EventArgs e)
        {
            button_play_Clicked(sender, e);
        }

        private void button_play_three_Clicked(object sender, EventArgs e)
        {
            button_play_Clicked(sender, e);
        }

        private void button_d1_Clicked(object sender, EventArgs e)
        {

        }

        private void button_haviri_Clicked(object sender, EventArgs e)
        {

        }

        private void button_hymna_Clicked(object sender, EventArgs e)
        {

        }

        private void button_judging_Clicked(object sender, EventArgs e)
        {

        }

        private void button_pokuta_Clicked(object sender, EventArgs e)
        {

        }

        private void button_superb_Clicked(object sender, EventArgs e)
        {

        }
    }
}
