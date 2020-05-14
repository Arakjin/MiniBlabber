using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Reflection;

namespace MiniBlabber
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuickMsg : ContentPage
    {
        Speaker speaker = new Speaker();

        bool dontSpeak;

        List<Button> buttons = new List<Button>();
        public QuickMsg()
        {
            InitializeComponent();
            
            buttons.Add(Btn_Quick_1);
            buttons.Add(Btn_Quick_2);
            buttons.Add(Btn_Quick_3);
            buttons.Add(Btn_Quick_4);
            buttons.Add(Btn_Quick_5);
            buttons.Add(Btn_Quick_6);
            buttons.Add(Btn_Quick_7);
            buttons.Add(Btn_Quick_8);
            buttons.Add(Btn_Quick_9);
            buttons.Add(Btn_Quick_10);
            buttons.Add(Btn_Quick_11);
            buttons.Add(Btn_Quick_12);
            buttons.Add(Btn_Quick_13);
            buttons.Add(Btn_Quick_14);

            for (int i = 0; i < buttons.Count; i++)
            {
                if (Application.Current.Properties.ContainsKey("quickBtn" + i))
                {
                    buttons[i].Text = Application.Current.Properties["quickBtn" + i] as string;
                }
                else
                {
                    buttons[i].Text = "Tyhjä";
                }
            }

            DependencyService.Get<IAudio>().PrepareAudioFile();
        }

        public void AudioPlayer()
        {
            DependencyService.Get<IAudio>().PlayAudioFile();
        }

        private void Btn_Enter_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
            AudioPlayer();
        }

        private async void Btn_Yes_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (dontSpeak != true)
                {
                    await speaker.SpeakNowDefaultSettings("Kyllä");
                    dontSpeak = false;
                }
            }
            catch (Exception)
            {

            }
        }

        private async void Btn_No_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (dontSpeak != true)
                {
                    await speaker.SpeakNowDefaultSettings("Ei");
                    dontSpeak = false;
                }
            }
            catch (Exception)
            {

            }
        }
        private void Btn_No_Pressed(object sender, EventArgs e)
        {
            DesignMode();
        }
        private void Btn_Yes_Pressed(object sender, EventArgs e)
        {
            DesignMode();
        }
        private async void DesignMode()
        {
            if (Btn_No.IsPressed && Btn_Yes.IsPressed)
            {
                dontSpeak = true;
                await Task.Delay(3000);
                if (Btn_No.IsPressed && Btn_Yes.IsPressed)
                {
                    App.Current.MainPage = new QuickMsgEditor();
                    AudioPlayer();
                    await Task.Delay(2000);
                }
                dontSpeak = false;
            }
        }

        private async void Btn_Quick_1_Clicked(object sender, EventArgs e)
        {
            await speaker.SpeakNowDefaultSettings(Btn_Quick_1.Text);
        }
        private async void Btn_Quick_2_Clicked(object sender, EventArgs e)
        {
            await speaker.SpeakNowDefaultSettings(Btn_Quick_2.Text);
        }
        private async void Btn_Quick_3_Clicked(object sender, EventArgs e)
        {
            await speaker.SpeakNowDefaultSettings(Btn_Quick_3.Text);
        }
        private async void Btn_Quick_4_Clicked(object sender, EventArgs e)
        {
            await speaker.SpeakNowDefaultSettings(Btn_Quick_4.Text);
        }
        private async void Btn_Quick_5_Clicked(object sender, EventArgs e)
        {
            await speaker.SpeakNowDefaultSettings(Btn_Quick_5.Text);
        }
        private async void Btn_Quick_6_Clicked(object sender, EventArgs e)
        {
            await speaker.SpeakNowDefaultSettings(Btn_Quick_6.Text);
        }
        private async void Btn_Quick_7_Clicked(object sender, EventArgs e)
        {
            await speaker.SpeakNowDefaultSettings(Btn_Quick_7.Text);
        }
        private async void Btn_Quick_8_Clicked(object sender, EventArgs e)
        {
            await speaker.SpeakNowDefaultSettings(Btn_Quick_8.Text);
        }
        private async void Btn_Quick_9_Clicked(object sender, EventArgs e)
        {
            await speaker.SpeakNowDefaultSettings(Btn_Quick_9.Text);
        }
        private async void Btn_Quick_10_Clicked(object sender, EventArgs e)
        {
            await speaker.SpeakNowDefaultSettings(Btn_Quick_10.Text);
        }
        private async void Btn_Quick_11_Clicked(object sender, EventArgs e)
        {
            await speaker.SpeakNowDefaultSettings(Btn_Quick_11.Text);
        }
        private async void Btn_Quick_12_Clicked(object sender, EventArgs e)
        {
            await speaker.SpeakNowDefaultSettings(Btn_Quick_12.Text);
        }
        private async void Btn_Quick_13_Clicked(object sender, EventArgs e)
        {
            await speaker.SpeakNowDefaultSettings(Btn_Quick_13.Text);
        }
        private async void Btn_Quick_14_Clicked(object sender, EventArgs e)
        {
            await speaker.SpeakNowDefaultSettings(Btn_Quick_14.Text);
        }
    }
}