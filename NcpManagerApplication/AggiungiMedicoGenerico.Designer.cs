namespace NcpManagerApplication
{
    partial class AggiungiMedicoGenerico
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPulisci = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(173, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            this.txtNome.Validated += new System.EventHandler(this.txtNome_Validated);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.btnPulisci);
            this.groupBox1.Controls.Add(this.btnSalva);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCognome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 250);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserisci Medico Generico";
            // 
            // btnPulisci
            // 
            this.btnPulisci.Location = new System.Drawing.Point(154, 174);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(80, 36);
            this.btnPulisci.TabIndex = 5;
            this.btnPulisci.Text = "Pulisci";
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(9, 174);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(80, 36);
            this.btnSalva.TabIndex = 4;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(64, 105);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(173, 20);
            this.txtCognome.TabIndex = 3;
            this.txtCognome.Validating += new System.ComponentModel.CancelEventHandler(this.txtCognome_Validating);
            this.txtCognome.Validated += new System.EventHandler(this.txtCognome_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AggiungiMedicoGenerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 455);
            this.Controls.Add(this.groupBox1);
            this.Name = "AggiungiMedicoGenerico";
            this.Text = "AggiungiMedicoGenerico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPulisci;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}