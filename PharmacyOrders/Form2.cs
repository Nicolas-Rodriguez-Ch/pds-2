using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyOrders
{
    public partial class Form2 : Form
    {
        public Form2(string distribuidor, string medicamento, string tipo, int cantidad, string direccion)
        {
            InitializeComponent();
            this.Text = "Pedido al distribuidor " + distribuidor;

            string unidades = cantidad == 1 ? "unidad" : "unidades";
            lblMedicamento.Text = cantidad + " " + unidades + " del " + tipo.ToLower() + " " + medicamento;

            lblDireccion.Text = direccion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido enviado");
            this.Close();
        }
    }
}
