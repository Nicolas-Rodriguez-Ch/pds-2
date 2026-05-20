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
                MessageBox.Show("Medication name cannot be empty");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCantidad.Text) || int.TryParse(txtCantidad.Text, out  int))
            {
                
            }

        }
    }
}
