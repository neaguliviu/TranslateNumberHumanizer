using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Humanizer;

namespace NumberTranslation
{
    public partial class TranslateNumber : Form
    {
        public TranslateNumber()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            bool result = int.TryParse(textBox1.Text, out num);
            if (result == true)
            {
                string language; 
                language = comboBox1.Text;
                if(language.Equals("English"))textBox2.Text = num.ToWords(new CultureInfo("en"));
                if(language.Equals("French")) textBox2.Text = num.ToWords(new CultureInfo("fr"));
                if(language.Equals("German")) textBox2.Text = num.ToWords(new CultureInfo("de"));
                if(language.Equals("Spanish")) textBox2.Text = num.ToWords(new CultureInfo("es"));
            }
            else
            {
                textBox2.Text = "!";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
