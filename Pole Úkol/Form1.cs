using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pole_Úkol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int N = int.Parse(textBox1.Text);
                int[] pole = new int[N];
                for (int i = 0; i < N; i++)
                {
                    int C = rnd.Next(1, 50);
                    listBox1.Items.Add(C);
                    pole[i] = C;

                }
                for (int i = 0; i < N; i++)
                {
                    if (radioButton1.Checked)
                    {
                        pole = pole.OrderByDescending(c => c).ToArray();
                        listBox2.Items.Add(pole[i]);
                    }
                    if (radioButton2.Checked)
                    {
                        pole = pole.OrderByDescending(c => c).ToArray();
                        Array.Reverse(pole);
                        listBox2.Items.Add(pole[i]);
                    }
                }
                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Nevybral jsi, zda chceš pole seřadit sestupně nebo vzestupně.", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Zadal jsi špatnou hodnotu.", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
