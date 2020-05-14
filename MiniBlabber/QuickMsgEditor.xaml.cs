using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiniBlabber
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuickMsgEditor : ContentPage
    {
        Speaker speaker = new Speaker();

        List<Button> buttons = new List<Button>();

        public QuickMsgEditor()
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
            App.Current.MainPage = new QuickMsg();
            AudioPlayer();
        }

        private void Btn_Quick_1_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new EditorKeyboard(0, Btn_Quick_1.Text);
            AudioPlayer();
        }
        private void Btn_Quick_2_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new EditorKeyboard(1, Btn_Quick_2.Text);
            AudioPlayer();
        }
        private void Btn_Quick_3_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new EditorKeyboard(2, Btn_Quick_3.Text);
            AudioPlayer();
        }
        private void Btn_Quick_4_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new EditorKeyboard(3, Btn_Quick_4.Text);
            AudioPlayer();
        }
        private void Btn_Quick_5_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new EditorKeyboard(4, Btn_Quick_5.Text);
            AudioPlayer();
        }
        private void Btn_Quick_6_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new EditorKeyboard(5, Btn_Quick_6.Text);
            AudioPlayer();
        }
        private void Btn_Quick_7_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new EditorKeyboard(6, Btn_Quick_7.Text);
            AudioPlayer();
        }
        private void Btn_Quick_8_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new EditorKeyboard(7, Btn_Quick_8.Text);
            AudioPlayer();
        }
        private void Btn_Quick_9_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new EditorKeyboard(8, Btn_Quick_9.Text);
            AudioPlayer();
        }
        private void Btn_Quick_10_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new EditorKeyboard(9, Btn_Quick_10.Text);
            AudioPlayer();
        }
        private void Btn_Quick_11_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new EditorKeyboard(10, Btn_Quick_11.Text);
            AudioPlayer();
        }
        private void Btn_Quick_12_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new EditorKeyboard(11, Btn_Quick_12.Text);
            AudioPlayer();
        }
        private void Btn_Quick_13_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new EditorKeyboard(12, Btn_Quick_13.Text);
            AudioPlayer();
        }
        private void Btn_Quick_14_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new EditorKeyboard(13, Btn_Quick_14.Text);
            AudioPlayer();
        }
    }
}