namespace PharmacyOrders
{
    partial class Form2
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMedicamentoLabel = new System.Windows.Forms.Label();
            this.lblMedicamentoValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(63, 72);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(101, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Order Summary";
            // 
            // lblMedicamentoLabel
            // 
            this.lblMedicamentoLabel.AutoSize = true;
            this.lblMedicamentoLabel.Location = new System.Drawing.Point(346, 72);
            this.lblMedicamentoLabel.Name = "lblMedicamentoLabel";
            this.lblMedicamentoLabel.Size = new System.Drawing.Size(73, 16);
            this.lblMedicamentoLabel.TabIndex = 1;
            this.lblMedicamentoLabel.Text = "Medication";
            // 
            // lblMedicamentoValue
            // 
            this.lblMedicamentoValue.AutoSize = true;
            this.lblMedicamentoValue.Location = new System.Drawing.Point(590, 71);
            this.lblMedicamentoValue.Name = "lblMedicamentoValue";
            this.lblMedicamentoValue.Size = new System.Drawing.Size(89, 16);
            this.lblMedicamentoValue.TabIndex = 2;
            this.lblMedicamentoValue.Text = "{placeholder}";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMedicamentoValue);
            this.Controls.Add(this.lblMedicamentoLabel);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMedicamentoLabel;
        private System.Windows.Forms.Label lblMedicamentoValue;
    }
}