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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio1Form ejerci1Form = new Ejercicio1Form(); 
            ejerci1Form.MdiParent = this;
            ejerci1Form.Show();
           
            








        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio2Form ejerci2Form = new Ejercicio2Form();
            ejerci2Form.MdiParent = this;           
            ejerci2Form.Show();



        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio3Form ejerci3Form = new Ejercicio3Form();
            ejerci3Form.MdiParent = this;
            ejerci3Form.Show();

          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
