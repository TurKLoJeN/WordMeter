using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordMeter_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Split sentence in text box into word list
            string[] words = textBox1.Text.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            // Calculate word fulfill and print on label
            label2.Text = "Word Meter: " + words.Length;
        }
    }
}
