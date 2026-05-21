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
                MessageBox.Show("Medication name cannot be empty.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Medication quantity can't be empty.");
                return;
            }
            if (!int.TryParse(txtCantidad.Text, out int numero) || numero <= 0)
            {
                MessageBox.Show("Medication must be a number grater than 0");
                return;
            }
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Pleaase select a medication type");
                return;
            }
            if (!rbCofarma.Checked && !rbEmpsephar.Checked && !rbCemefar.Checked)
            {
                MessageBox.Show("Please select a distributor");
                return;
            }
            if (!chkPrincipal.Checked && !chkSecundaria.Checked)
            {
                MessageBox.Show("Please select at least one branch");
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
                direccion = "Calle de la Rosa n. 28 and the one located at Calle Alcazabilla n. 3";
            else if (chkPrincipal.Checked)
                direccion = "Calle de la Rosa n. 28";
            else if (chkSecundaria.Checked)
                direccion = "Calle Alcazabilla n. 3";

            string medicamento = txtMedicamento.Text.Trim();
            string tipo = cmbTipo.SelectedItem.ToString();
            int cantidad = int.Parse(txtCantidad.Text);
        }
    }
}
