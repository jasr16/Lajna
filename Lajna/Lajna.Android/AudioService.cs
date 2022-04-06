using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lajna.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(AudioService))]
namespace Lajna.Droid
{
    public class AudioService : Model.IAudio
    {
        public MediaPlayer MediaPlayer;
        public AudioService()
        {
            MediaPlayer = new MediaPlayer();
        }

        public void PlayAudioFile(string fileName)
        {
            if (MediaPlayer.IsPlaying)
            {
                MediaPlayer.Stop();
            }
            MediaPlayer.Reset();
            var fd = global::Android.App.Application.Context.Assets.OpenFd(fileName);
            MediaPlayer.Prepared += (s, e) =>
            {
                MediaPlayer.Start();
            };
            MediaPlayer.SetDataSource(fd.FileDescriptor, fd.StartOffset, fd.Length);
            MediaPlayer.Prepare();
        }

    }
}