using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class Form_CaesarCipher : Form
    {
        public Form_CaesarCipher()
        {
            InitializeComponent();
        }

        private static string Encrypt(string text, int shift)
        {
            var result = string.Empty;
            var firstCharCode = 'A';
            var offset = ('z' - 'A') + 1;

            foreach ( var c in text )
            {
                var newChar = ' ';

                if ( c != ' ')
                {
                    var Old = c - firstCharCode;
                    var Shifted = Old + shift;

                    while (Shifted < 0) Shifted = offset + Shifted;

                    var New = Shifted % offset;
                    newChar = (char)(firstCharCode + New);
                }

                result += newChar;

            }

            return result;

        }

        private static string Decrypt(string text, int shift)
        {
            return Encrypt(text, shift * -1);
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            var text = txtbox_Plaintext.Text;
            txtbox_Encrypted.Text = Encrypt(text, Convert.ToInt32(shift_Value.Value));
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            txtbox_Plaintext.Text = Decrypt(txtbox_Encrypted.Text, Convert.ToInt32(shift_Value.Value));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exitMessage = MessageBox.Show("Are you sure you want to quit?", "Warning", MessageBoxButtons.YesNo);

            if(exitMessage == DialogResult.Yes)
            {
                e.Cancel = false;
                Environment.Exit(0);
            }
            else if (exitMessage == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
