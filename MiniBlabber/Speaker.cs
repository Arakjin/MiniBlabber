using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace MiniBlabber
{
    class Speaker
    {
        bool isSpeaking = false;
        CancellationTokenSource cts;
        public async Task SpeakNowDefaultSettings(string text)
        {
            cts = new CancellationTokenSource();
            var locales = await TextToSpeech.GetLocalesAsync();

            // Grab the first locale
            var locale = locales.FirstOrDefault();

            var settings = new SpeechOptions()
            {
                Locale = locale
            };
            try
            {
                await TextToSpeech.SpeakAsync(text, settings, cancelToken: cts.Token);
                isSpeaking = true;
            }
            catch (Exception)
            {
                //    throw;
            }
            // This method will block until utterance finishes.
        }
        public void CancelSpeech()
        {
            if (isSpeaking)
            {
                if (cts?.IsCancellationRequested ?? false)
                    return;

                cts.Cancel();
                isSpeaking = false;
            }
        }
    }
}
