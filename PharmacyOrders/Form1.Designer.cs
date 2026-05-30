namespace PharmacyOrders
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.groupBoxContainer = new System.Windows.Forms.GroupBox();
            this.rbCemefar = new System.Windows.Forms.RadioButton();
            this.rbEmpsephar = new System.Windows.Forms.RadioButton();
            this.rbCofarma = new System.Windows.Forms.RadioButton();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.chkPrincipal = new System.Windows.Forms.CheckBox();
            this.chkSecundaria = new System.Windows.Forms.CheckBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBoxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Location = new System.Drawing.Point(124, 67);
            this.lblMedicamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(44, 26);
            this.lblMedicamento.TabIndex = 0;
            this.lblMedicamento.Text = "Nombre\r\n\r\n";
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(127, 82);
            this.txtMedicamento.Margin = new System.Windows.Forms.Padding(2);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(76, 20);
            this.txtMedicamento.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(222, 67);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(29, 17);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.UseCompatibleTextRendering = true;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Analgésico",
            "Analéptico",
            "Anestésico",
            "Antiácido",
            "Antidepresivo",
            "Antibiótico"});
            this.cmbTipo.Location = new System.Drawing.Point(222, 81);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(92, 21);
            this.cmbTipo.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(341, 67);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(344, 82);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(76, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // groupBoxContainer
            // 
            this.groupBoxContainer.Controls.Add(this.rbCemefar);
            this.groupBoxContainer.Controls.Add(this.rbEmpsephar);
            this.groupBoxContainer.Controls.Add(this.rbCofarma);
            this.groupBoxContainer.Location = new System.Drawing.Point(127, 140);
            this.groupBoxContainer.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxContainer.Name = "groupBoxContainer";
            this.groupBoxContainer.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxContainer.Size = new System.Drawing.Size(150, 81);
            this.groupBoxContainer.TabIndex = 6;
            this.groupBoxContainer.TabStop = false;
            this.groupBoxContainer.Text = "Distribuidor";
            // 
            // rbCemefar
            // 
            this.rbCemefar.AutoSize = true;
            this.rbCemefar.Location = new System.Drawing.Point(5, 60);
            this.rbCemefar.Margin = new System.Windows.Forms.Padding(2);
            this.rbCemefar.Name = "rbCemefar";
            this.rbCemefar.Size = new System.Drawing.Size(64, 17);
            this.rbCemefar.TabIndex = 2;
            this.rbCemefar.TabStop = true;
            this.rbCemefar.Text = "Cemefar";
            this.rbCemefar.UseVisualStyleBackColor = true;
            // 
            // rbEmpsephar
            // 
            this.rbEmpsephar.AutoSize = true;
            this.rbEmpsephar.Location = new System.Drawing.Point(5, 40);
            this.rbEmpsephar.Margin = new System.Windows.Forms.Padding(2);
            this.rbEmpsephar.Name = "rbEmpsephar";
            this.rbEmpsephar.Size = new System.Drawing.Size(78, 17);
            this.rbEmpsephar.TabIndex = 1;
            this.rbEmpsephar.TabStop = true;
            this.rbEmpsephar.Text = "Empsephar";
            this.rbEmpsephar.UseVisualStyleBackColor = true;
            // 
            // rbCofarma
            // 
            this.rbCofarma.AutoSize = true;
            this.rbCofarma.Location = new System.Drawing.Point(5, 18);
            this.rbCofarma.Margin = new System.Windows.Forms.Padding(2);
            this.rbCofarma.Name = "rbCofarma";
            this.rbCofarma.Size = new System.Drawing.Size(64, 17);
            this.rbCofarma.TabIndex = 0;
            this.rbCofarma.TabStop = true;
            this.rbCofarma.Text = "Cofarma";
            this.rbCofarma.UseVisualStyleBackColor = true;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(344, 140);
            this.lblSucursal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(51, 13);
            this.lblSucursal.TabIndex = 7;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // chkPrincipal
            // 
            this.chkPrincipal.AutoSize = true;
            this.chkPrincipal.Location = new System.Drawing.Point(346, 158);
            this.chkPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.chkPrincipal.Name = "chkPrincipal";
            this.chkPrincipal.Size = new System.Drawing.Size(66, 17);
            this.chkPrincipal.TabIndex = 8;
            this.chkPrincipal.Text = "Principal";
            this.chkPrincipal.UseVisualStyleBackColor = true;
            // 
            // chkSecundaria
            // 
            this.chkSecundaria.AutoSize = true;
            this.chkSecundaria.Location = new System.Drawing.Point(346, 180);
            this.chkSecundaria.Margin = new System.Windows.Forms.Padding(2);
            this.chkSecundaria.Name = "chkSecundaria";
            this.chkSecundaria.Size = new System.Drawing.Size(80, 17);
            this.chkSecundaria.TabIndex = 9;
            this.chkSecundaria.Text = "Secundaria";
            this.chkSecundaria.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(145, 258);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(106, 32);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(301, 257);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(106, 33);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.chkSecundaria);
            this.Controls.Add(this.chkPrincipal);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.groupBoxContainer);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtMedicamento);
            this.Controls.Add(this.lblMedicamento);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Sistema de Pedidos - Farmacia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxContainer.ResumeLayout(false);
            this.groupBoxContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox groupBoxContainer;
        private System.Windows.Forms.RadioButton rbCofarma;
        private System.Windows.Forms.RadioButton rbCemefar;
        private System.Windows.Forms.RadioButton rbEmpsephar;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.CheckBox chkPrincipal;
        private System.Windows.Forms.CheckBox chkSecundaria;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}

