using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PharmacyOrders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtMedicamento.Text = "";
            cmbTipo.SelectedIndex = -1;
            txtCantidad.Text = "";
            rbCofarma.Checked = false;
            rbCemefar.Checked = false;
            rbEmpsephar.Checked = false;
            chkPrincipal.Checked = false;
            chkSecundaria.Checked = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMedicamento.Text))
            {
                MessageBox.Show("El nombre del medicamento no puede estar vacío.");
                return;
            }
            if (!Regex.IsMatch(txtMedicamento.Text.Trim(), @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("El nombre del medicamento sólo puede contener letras y números.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("La cantidad no puede estar vacía.");
                return;
            }
            if (!int.TryParse(txtCantidad.Text, out int numero) || numero <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero positivo.");
                return;
            }
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un tipo de medicamento.");
                return;
            }
            if (!rbCofarma.Checked && !rbEmpsephar.Checked && !rbCemefar.Checked)
            {
                MessageBox.Show("Por favor, selecciona un distribuidor.");
                return;
            }
            if (!chkPrincipal.Checked && !chkSecundaria.Checked)
            {
                MessageBox.Show("Por favor, selecciona al menos una sucursal.");
                return;
            }
            string distribuidor = "";

            if (rbCofarma.Checked)
                distribuidor = "Cofarma";
            else if (rbEmpsephar.Checked)
                distribuidor = "Empsephar";
            else if (rbCemefar.Checked)
                distribuidor = "Cemefar";

            string direccion = "";
            if (chkPrincipal.Checked && chkSecundaria.Checked)
                direccion = "Para la farmacia situada en Calle de la Rosa n.28 y para la situada en Calle Alcazabilla n.3";
            else if (chkPrincipal.Checked)
                direccion = "Para la farmacia situada en Calle de la Rosa n. 28";
            else if (chkSecundaria.Checked)
                direccion = "Para la farmacia situada en Calle Alcazabilla n. 3";

            string medicamento = txtMedicamento.Text.Trim();
            string tipo = cmbTipo.SelectedItem.ToString();
            int cantidad = int.Parse(txtCantidad.Text);

            new Form2(distribuidor, medicamento, tipo, cantidad, direccion).ShowDialog();
        }
    }
}
