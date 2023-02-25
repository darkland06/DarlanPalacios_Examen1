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
    public partial class Ejercicio1Form : Form
    {
        public Ejercicio1Form()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }
         
        private void btnMes_Click(object sender, EventArgs e)
        {
            Decimal efectivo;
            Decimal interes;
            Decimal calculo;
            Decimal meses;
            Decimal Total;
            efectivo = 20000000;
            interes = 1.5m;

           
          
            

            calculo = (efectivo * interes) / 100;
            Total = (efectivo + calculo);
            meses = calculo / 12;
            this.listBox1.Items.Add("Total generado mas intereses es igual a:" + Total);
            this.listBox1.Items.Add("la tasa de intereses es:" + calculo);
            this.listBox1.Items.Add("Total de intereses generados en ENERO:" + meses);
            this.listBox1.Items.Add("Total de intereses generados en FEBRERO:" + meses);
            this.listBox1.Items.Add("Total de intereses generados en MARZO:" + meses);
            this.listBox1.Items.Add("Total de intereses generados en ABRIL:" + meses);
            this.listBox1.Items.Add("Total de intereses generados en MAYO:" + meses);
            this.listBox1.Items.Add("Total de intereses generados en JUNIO:" + meses);
            this.listBox1.Items.Add("Total de intereses generados en JULIO:" + meses);
            this.listBox1.Items.Add("Total de intereses generados en AGOSTO:" + meses);
            this.listBox1.Items.Add("Total de intereses generados en SEPTIEMBRE:" + meses);
            this.listBox1.Items.Add("Total de intereses generados en OCTUBRE:" + meses);
            this.listBox1.Items.Add("Total de intereses generados en NOVIEMBRE:" + meses);
            this.listBox1.Items.Add("Total de intereses generados en DICIEMBRE:" + meses);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
