using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            DateTime fecha = dtFecha.Value;
            String empresa = this.txtEmpresa.Text;

            int años = DateTime.Today.Year - fecha.Year;
            String condicion="";
            if (años <= 5)
                condicion = "Habilitado";
            if (años >= 5)
                condicion = "Inabilitado";
            ListViewItem file = new ListViewItem(numero.ToString());
            file.SubItems.Add(fecha.ToString("D"));
            file.SubItems.Add(empresa);
            file.SubItems.Add(años.ToString());
            file.SubItems.Add(condicion);
            lvRegistro.Items.Add(file);
            BtnCancelar_Click(sender, e);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            dtFecha.Value = DateTime.Today.Date;
            txtEmpresa.Clear();
            txtNumero.Focus();

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            lvRegistro.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
