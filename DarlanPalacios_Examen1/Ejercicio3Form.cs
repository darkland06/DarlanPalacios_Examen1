using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarlanPalacios_Examen1
{
    public partial class Ejercicio3Form : Form
    {
        public Ejercicio3Form()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Multip();
        }
        private static void Multip()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    MessageBox.Show("Darlan Palacios");
                }
                else if (i % 3 == 0)
                {
                    MessageBox.Show("Darlan");
                }
                else if (i % 5 == 0)
                {
                    MessageBox.Show("Palacios");
                }
                else
                {
                    MessageBox.Show("" + i);
                   
                }
            }
        } 
    }
}
