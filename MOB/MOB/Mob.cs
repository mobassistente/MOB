using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis; // namespace

namespace MOB
{
    public class Mob
    {
        private static SpeechSynthesizer sp = new SpeechSynthesizer();
        public static void Fala(string text)
        {
            // se ele estiver falando
            if (sp.State == SynthesizerState.Speaking)
                sp.SpeakAsyncCancelAll();
            sp.SpeakAsync(text);
        }

        public static void Fala(params string[] texts) // maximizar e minimizar assistente
        {
            Random rnd = new Random();
            Fala(texts[rnd.Next(0, texts.Length)]);
        }
        // alterando a voz
        public static void selecionar(string voice)
        {
            try
            {
                sp.SelectVoice(voice);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro em execultar voz: " + ex.Message);
            }
        }

    }
}
