using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static float Entre, Mayores;
        private void button1_Click(object sender, EventArgs e)
        {
            int sueldo;
            try
            {
                sueldo = int.Parse(txtSueldo.Text);
                if (sueldo >= 100 && sueldo <= 300)
                {
                    Entre += 1;
                }
                else if (sueldo > 300 && sueldo <= 500)
                {
                    Mayores += 1;
                }
                else if (sueldo > 500 || sueldo < 100)
                {
                    MessageBox.Show("Error, El sueldo tiene que ser mayor a 100 y menor a 500");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSueldo.Text = null;
        }

        private void enviarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbEntre.Text = Convert.ToString(Entre);
            lbMayor.Text = Convert.ToString(Mayores);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
