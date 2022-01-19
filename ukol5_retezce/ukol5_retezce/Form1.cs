using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol5_retezce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text;
                int pocetslov = 0;
                input = input.Trim();
                string[] rozdeleno = input.Split(' ');
                foreach (string lol in rozdeleno)
                { 
                    if (lol != "")
                    {
                        pocetslov++;
                    }
                    label3.Text = pocetslov.ToString();
                }
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ' && input[i - 1] == ' ')
                {
                    input = input.Remove(i, 1);
                    i--;
                }
                MessageBox.Show("", input);
            }

        }
    }
}