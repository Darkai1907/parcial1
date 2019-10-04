using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial1
{
    public partial class Form1 : Form
    {

        private int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int n = dgtvparcial.Rows.Add();

            dgtvparcial.Rows[n].Cells[0].Value = txtnombre.Text;
            dgtvparcial.Rows[n].Cells[1].Value = txtapellido.Text;
            dgtvparcial.Rows[n].Cells[2].Value = txtfechanacimiento.Text;
            dgtvparcial.Rows[n].Cells[3].Value = txtedad.Text;
            dgtvparcial.Rows[n].Cells[4].Value = txtsexo.Text;
            dgtvparcial.Rows[n].Cells[5].Value = txtestado.Text;


            txtnombre.Text = "";
            txtapellido.Text = "";
            txtfechanacimiento.Text = "";
            txtedad.Text = "";
            txtsexo.Text = "";
            txtestado.Text = "";
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(n!= -1)
            {
                dgtvparcial.Rows.RemoveAt(n);


            }
        }
    }
}
