using System;
using Xamarin.Forms;
using MiniBlabber.Droid;
using Android.Media;
using Android.Content.Res;
using Android.OS;
using Android.Views;
using Android.Content;

[assembly: Dependency(typeof(AudioService))]
namespace MiniBlabber.Droid
{
    public class AudioService : IAudio
    {
        public AudioService()
        { }

        private MediaPlayer player;

        public void PrepareAudioFile()
        {
            if (player == null)
            {
                player = new MediaPlayer();
            }
            player = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.tic);
        }

        public void PlayAudioFile()
        {
            player.Start();
        }
    }
}