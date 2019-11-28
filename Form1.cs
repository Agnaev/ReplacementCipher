using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReplacementCipher
{
    public partial class Form1 : Form
    {
        readonly List<char> Characters = new List<char>();
        readonly List<char> MixedCharacters = new List<char>();
        public Form1()
        {
            InitializeComponent();
            for(char i = 'а'; i <= 'я'; i++)
            {
                Characters.Add(i);
            }
            Characters.Add(' ');
            SubtractiveGenerator r = new SubtractiveGenerator(10);
            MixedCharacters = Characters.OrderBy(x => r.Next()).ToList();
            string path = Directory.GetCurrentDirectory() + "\\Characters.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < Characters.Count(); i++)
                {
                    writer.WriteLine($"{Characters[i]} {MixedCharacters[i]}");
                }
            }
            System.Diagnostics.Process.Start(path);
        }

        private void Decoded_TextChanged(object sender, EventArgs e)
        {
            try
            {
                encoded_textBox.Text = string.Empty;
                for (int i = 0; i < decoded_textBox.Text.Length; i++)
                {
                    if (IsEncoding.Checked)
                    {
                        if (Characters.Contains(decoded_textBox.Text[i]))
                        {
                            encoded_textBox.Text += MixedCharacters[Characters.IndexOf(decoded_textBox.Text[i])];
                        }
                    }
                    else
                    {
                        encoded_textBox.Text += Characters[MixedCharacters.IndexOf(decoded_textBox.Text[i])];
                    }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message + exc.InnerException?.InnerException?.Message);
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e) =>
            Decoded_TextChanged(sender, e);
    }
}
