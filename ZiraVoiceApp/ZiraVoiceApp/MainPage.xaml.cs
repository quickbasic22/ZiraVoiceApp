using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace ZiraVoiceApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ZiraTalk_Clicked(object sender, EventArgs e)
        {
            var sO = new SpeechOptions();
            sO.Pitch = 1.5f;
            Xamarin.Essentials.TextToSpeech.SpeakAsync(TextTalk.Text, sO);
           
        }
    }
}
