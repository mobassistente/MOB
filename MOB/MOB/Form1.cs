using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition; // namespace usado pra o reconhecimento de voz, Microsoft Speech Server 11 SDK pt-BR

namespace MOB
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        private SpeechRecognitionEngine engine; // reconhecimento da voz

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadSpeech()


        {
            try
            {

                engine = new SpeechRecognitionEngine(); // instancia
                engine.SetInputToDefaultAudioDevice(); // entrada do audio Microfone

                string[] words = {"ola"}; // palavras
                Choices palavras = new Choices();
                Grammar wordlist = new Grammar(new GrammarBuilder(palavras));


                // carregar a gramatica
                engine.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(words))));

                engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec);
                engine.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(audioLevel);
                

                engine.RecognizeAsync(RecognizeMode.Multiple); // iniciar reconhecimento
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu no LoadSpeech(): " + ex.Message);
            }


        }

            private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void rec(object s, SpeechRecognizedEventArgs e)
        {


            // resultado do audio
            // MessageBox.Show(e.Result.Text);
            string speech = e.Result.Text; // mostrar palavra reconhecida
            int Num = rnd.Next(1, 10);
            String QEvent;
            float conf = e.Result.Confidence;
        }

        private void audioLevel(object s, AudioLevelUpdatedEventArgs e)
        {
            this.progressBar1.Maximum = 100;
            this.progressBar1.Value = e.AudioLevel;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mob.Fala("Olá, eu sou o mób, e ainda estou em desenvolvimento");
            Mob.Fala("Logo terei muitas novidades");
        }
    }
}
