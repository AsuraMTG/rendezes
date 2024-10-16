using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rendezes
{
    public partial class Form1 : Form
    {
        int[] szamok = new int[20];
        int counter = 0;
        int seged = 0;
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(1, 101);
            }

            for (int k = 0; k < szamok.Length; k++)
            {
                for (int i = 0; i < szamok.Length; i++)
                {
                    counter = 0;
                    for (int j = 0; j < szamok.Length; j++)
                    {
                        if (szamok[i] > szamok[j])
                        {
                            counter++;
                        }
                    }
                    seged = szamok[i];
                    szamok[i] = szamok[counter];
                    szamok[counter] = seged;
                }
            }

            for (int i = 0; i < szamok.Length; i++)
            {
                label1.Text += $"{szamok[i]} ";
            }

        }
    }
}
