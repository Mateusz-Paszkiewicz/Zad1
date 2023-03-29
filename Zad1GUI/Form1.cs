using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zad1;

namespace Zad1GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox2.Text, out int itemCount))
            {
                if (int.TryParse(textBox3.Text, out int seed))
                {
                    Backpack backpack = new Backpack(itemCount, seed);

                    textBox1.Text = backpack.ToString();
                    textBox1.Text += "\n";
                    textBox1.Text += backpack.solveProblem();              
                }
            }

        }
    }
}
