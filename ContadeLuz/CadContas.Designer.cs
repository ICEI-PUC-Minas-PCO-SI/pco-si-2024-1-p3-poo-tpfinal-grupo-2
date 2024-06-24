namespace ContadeLuz
{
    partial class CadContas
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            numMesRef = new NumericUpDown();
            label3 = new Label();
            txtLeitura = new TextBox();
            label4 = new Label();
            btnSalva = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMesRef).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 76);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(10, 39);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(10, 6);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // numMesRef
            // 
            numMesRef.Location = new Point(14, 121);
            numMesRef.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numMesRef.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMesRef.Name = "numMesRef";
            numMesRef.Size = new Size(57, 23);
            numMesRef.TabIndex = 1;
            numMesRef.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 103);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Mes";
            // 
            // txtLeitura
            // 
            txtLeitura.Location = new Point(95, 121);
            txtLeitura.Name = "txtLeitura";
            txtLeitura.Size = new Size(100, 23);
            txtLeitura.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 103);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Leitura";
            label4.Click += label4_Click;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(273, 121);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(75, 23);
            btnSalva.TabIndex = 5;
            btnSalva.Text = "&Salvar";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // CadContas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 165);
            Controls.Add(btnSalva);
            Controls.Add(label4);
            Controls.Add(txtLeitura);
            Controls.Add(label3);
            Controls.Add(numMesRef);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadContas";
            Text = "Cadastro de Contas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMesRef).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private NumericUpDown numMesRef;
        private Label label3;
        private TextBox txtLeitura;
        private Label label4;
        private Button btnSalva;
    }
}