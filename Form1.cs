using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReplacementCipher
{
    public partial class Form1 : Form
    {
        List<char> Characters = new List<char>();
        List<char> MixedCharacters = new List<char>();
        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i < 256; i++)
            {
                Characters.Add((char)i);
            }
            SubtractiveGenerator r = new SubtractiveGenerator(10);
            MixedCharacters = Characters.OrderBy(x => r.Next()).ToList();
        }

        private void Decoded_TextChanged(object sender, EventArgs e)
        {
            encoded_textBox.Text = string.Empty;
            for (int i = 0; i < decoded_textBox.Text.Length; i++)
            { 
                if (checkBox1.Checked)
                {
                    encoded_textBox.Text += MixedCharacters[Characters.IndexOf(decoded_textBox.Text[i])];
                }
                else
                {
                    encoded_textBox.Text += Characters[MixedCharacters.IndexOf(decoded_textBox.Text[i])];
                }
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e) =>
            Decoded_TextChanged(sender, e);
    }
}
