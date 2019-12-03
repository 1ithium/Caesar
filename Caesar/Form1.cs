using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = Location;
            f2.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cipher = new RUCaesarCipher();
            var message = richTextBox1.Text;
            var key = Convert.ToInt32(numericUpDown1.Value);
            var encryptedText = cipher.Encrypt(message, key);
            richTextBox2.Text = encryptedText;
            var decryptedText = cipher.Decrypt(encryptedText, key);
            richTextBox3.Text = decryptedText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cipher = new RUCaesarCipher();
            richTextBox1.Text = "";
            var key = Convert.ToInt32(numericUpDown1.Value);
            var encryptedText = richTextBox2.Text;
            var decryptedText = cipher.Decrypt(encryptedText, key);
            richTextBox3.Text = decryptedText;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно открыть ссылку.");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://github.com/1ithium/Caesar");
        }
    }
}
