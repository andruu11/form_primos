using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inicio, fin, contador;

            inicio = Convert.ToInt32(A.Text);
            fin = Convert.ToInt32(B.Text);
            for (int i = inicio; i <= fin; i++)
            {
                contador = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contador = contador + 1;
                    }
                }
                if (contador == 2)
                {
                    listBox1.Items.Add(i);
                }
                else
                {
                    listBox2.Items.Add(i);
                }

            }
        }
    }
}
