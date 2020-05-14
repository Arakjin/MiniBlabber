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
    public partial class EditorKeyboard : ContentPage
    {

        int btnId;
        private bool toggle = true;
        List<Button> buttons = new List<Button>();

        public EditorKeyboard(int id, string str)
        {
            InitializeComponent();

            btnId = id;

            buttons.Add(Btn_Q);
            buttons.Add(Btn_W);
            buttons.Add(Btn_E);
            buttons.Add(Btn_R);
            buttons.Add(Btn_T);
            buttons.Add(Btn_Y);
            buttons.Add(Btn_U);
            buttons.Add(Btn_I);
            buttons.Add(Btn_O);
            buttons.Add(Btn_P);
            buttons.Add(Btn_AO);
            buttons.Add(Btn_A);
            buttons.Add(Btn_S);
            buttons.Add(Btn_D);
            buttons.Add(Btn_F);
            buttons.Add(Btn_G);
            buttons.Add(Btn_H);
            buttons.Add(Btn_J);
            buttons.Add(Btn_K);
            buttons.Add(Btn_L);
            buttons.Add(Btn_OE);
            buttons.Add(Btn_AE);
            buttons.Add(Btn_Z);
            buttons.Add(Btn_X);
            buttons.Add(Btn_C);
            buttons.Add(Btn_V);
            buttons.Add(Btn_B);
            buttons.Add(Btn_N);
            buttons.Add(Btn_M);

            TextField1.Text = str;

            DependencyService.Get<IAudio>().PrepareAudioFile();
        }

        public void AudioPlayer()
        {
            DependencyService.Get<IAudio>().PlayAudioFile();
        }

        private void Btn_Save_Clicked(object sender, EventArgs e)
        {
            // Save info to button
            Application.Current.Properties["quickBtn" + btnId] = TextField1.Text;

            App.Current.MainPage = new QuickMsgEditor();
        }

        private void Btn_Q_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_Q.Text;
            AudioPlayer();
        }

        private void Btn_W_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_W.Text;
            AudioPlayer();
        }

        private void Btn_E_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_E.Text;
            AudioPlayer();
        }

        private void Btn_R_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_R.Text;
            AudioPlayer();
        }

        private void Btn_T_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_T.Text;
            AudioPlayer();
        }

        private void Btn_Y_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_Y.Text;
            AudioPlayer();
        }

        private void Btn_U_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_U.Text;
            AudioPlayer();
        }

        private void Btn_I_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_I.Text;
            AudioPlayer();
        }

        private void Btn_O_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_O.Text;
            AudioPlayer();
        }

        private void Btn_P_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_P.Text;
            AudioPlayer();
        }

        private void Btn_AO_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_AO.Text;
            AudioPlayer();
        }

        private void Btn_A_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_A.Text;
            AudioPlayer();
        }

        private void Btn_S_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_S.Text;
            AudioPlayer();
        }

        private void Btn_D_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_D.Text;
            AudioPlayer();
        }

        private void Btn_F_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_F.Text;
            AudioPlayer();
        }

        private void Btn_G_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_G.Text;
            AudioPlayer();
        }

        private void Btn_H_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_H.Text;
            AudioPlayer();
        }

        private void Btn_J_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_J.Text;
            AudioPlayer();
        }

        private void Btn_K_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_K.Text;
            AudioPlayer();
        }

        private void Btn_L_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_L.Text;
            AudioPlayer();
        }

        private void Btn_OE_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_OE.Text;
            AudioPlayer();
        }

        private void Btn_AE_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_AE.Text;
            AudioPlayer();
        }

        private void Btn_Z_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_Z.Text;
            AudioPlayer();
        }

        private void Btn_X_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_X.Text;
            AudioPlayer();
        }

        private void Btn_C_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_C.Text;
            AudioPlayer();
        }

        private void Btn_V_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_V.Text;
            AudioPlayer();
        }

        private void Btn_B_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_B.Text;
            AudioPlayer();
        }

        private void Btn_N_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_N.Text;
            AudioPlayer();
        }

        private void Btn_M_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_M.Text;
            AudioPlayer();
        }

        private void Btn_Comma_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += ",";
            AudioPlayer();
        }

        private void Btn_Dot_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += ".";
            AudioPlayer();
        }

        private void Btn_Space_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += " ";
            AudioPlayer();
        }

        private void Btn_Enter_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new QuickMsgEditor();
            AudioPlayer();
        }

        private void Btn_Clear_Clicked(object sender, EventArgs e)
        {
            TextField1.Text = "";
            AudioPlayer();
        }

        private void Btn_1_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_1.Text;
            AudioPlayer();
        }

        private void Btn_2_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_2.Text;
            AudioPlayer();
        }

        private void Btn_3_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_3.Text;
            AudioPlayer();
        }

        private void Btn_4_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_4.Text;
            AudioPlayer();
        }

        private void Btn_5_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_5.Text;
            AudioPlayer();
        }

        private void Btn_6_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_6.Text;
            AudioPlayer();
        }

        private void Btn_7_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_7.Text;
            AudioPlayer();
        }

        private void Btn_8_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_8.Text;
            AudioPlayer();
        }

        private void Btn_9_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_9.Text;
            AudioPlayer();
        }

        private void Btn_0_Clicked(object sender, EventArgs e)
        {
            TextField1.Text += Btn_0.Text;
            AudioPlayer();
        }

        private void Btn_toggle_Clicked(object sender, EventArgs e)
        {
            if (toggle == true)
            {
                for (int i = 0; i < buttons.Count; i++)
                {
                    buttons[i].Text = buttons[i].Text.ToLower();

                    Btn_0.Text = "!";
                    Btn_1.Text = "+";
                    Btn_2.Text = "-";
                    Btn_3.Text = "*";
                    Btn_4.Text = "/";
                    Btn_5.Text = "%";
                    Btn_6.Text = "€";
                    Btn_7.Text = "@";
                    Btn_8.Text = "#";
                    Btn_9.Text = "?";
                }
                toggle = false;
            }
            else
            {
                for (int i = 0; i < buttons.Count; i++)
                {
                    buttons[i].Text = buttons[i].Text.ToUpper();

                    Btn_0.Text = "0";
                    Btn_1.Text = "1";
                    Btn_2.Text = "2";
                    Btn_3.Text = "3";
                    Btn_4.Text = "4";
                    Btn_5.Text = "5";
                    Btn_6.Text = "6";
                    Btn_7.Text = "7";
                    Btn_8.Text = "8";
                    Btn_9.Text = "9";
                }
                toggle = true;
            }
            AudioPlayer();
        }
        private void Btn_Back_Clicked(object sender, EventArgs e)
        {
            if (TextField1.Text.Length > 0)
            {
                TextField1.Text = TextField1.Text.Remove(TextField1.Text.Length - 1);
            }
            AudioPlayer();
        }

        private void Btn_DelWord_Clicked(object sender, EventArgs e)
        {
            string oldString = TextField1.Text;
            int lastIndex = oldString.LastIndexOf(" ");
            string newString = oldString;
            if (lastIndex != -1)
            {
                newString = oldString.Remove(lastIndex).Trim();
            }
            else
            {
                newString = "";
            }
            TextField1.Text = newString;
            AudioPlayer();
        }
    }
}