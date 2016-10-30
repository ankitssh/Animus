using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Animus
{

    public partial class textform : Form
    {
        SpeechSynthesizer speaker = new SpeechSynthesizer();
        public textform()
        {
            InitializeComponent();
        }

        private void textform_Load(object sender, EventArgs e)
        {
            
            IReadOnlyCollection<InstalledVoice> InstalledVoices = speaker.GetInstalledVoices();

            speaker.SelectVoice("IVONA 2 Brian");

            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
           DialogResult dr= openFileDialog1.ShowDialog();
          
            // Process input if the user clicked OK.
            if (dr==DialogResult.OK)
            
            {
                string file = openFileDialog1.FileName;
                richTextBox1.LoadFile(file,RichTextBoxStreamType.PlainText);
                speaker.SpeakAsync(richTextBox1.Text);
               
                

        

               
            }

            if (dr == DialogResult.Cancel)
            {
                this.Dispose();
            
            
            }

                
        }


void textform_FormClosing(object sender, FormClosingEventArgs e)
{

}

private void textform_FormClosing_1(object sender, FormClosingEventArgs e)
{
    


    if (e.CloseReason == CloseReason.UserClosing)
    {
        speaker.Dispose();
    }
    // Prompt user to save his data

    if (e.CloseReason == CloseReason.WindowsShutDown)
    { }
    // Autosave and clear up ressources

}


    }
}
