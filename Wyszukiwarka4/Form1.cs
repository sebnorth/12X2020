using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyszukiwarka4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            // Jeśli tekst w górnej kontrolce znajduje się w tekście z 
            // dużej kontrolki to uaktualnij komunikat na dole(label2)

            // Jeśli tekst w dużej kontrolce zawiera tekst w górnej kontrolce to
            // uaktualnij komunikat na dole(label2)

            if (textBox2.Text.Contains(textBox1.Text)) {
                label2.Text = "Znaleziono" + textBox1.Text;
            }

            else

            {
                label2.Text = "Nie znaleziono";
            }
        }
    }
}
