namespace ContadeLuz
{
    partial class Contas
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
            txtCpfCnpj = new TextBox();
            label2 = new Label();
            btnPesquisa = new Button();
            panel1 = new Panel();
            txtMesRef = new TextBox();
            label12 = new Label();
            txtValorSemImpostoUltimoMes = new TextBox();
            label11 = new Label();
            txtValorUltimoMes = new TextBox();
            label10 = new Label();
            txtConsumoUltimoMes = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            lblCidade = new Label();
            lblCEP = new Label();
            lblUF = new Label();
            lblBairro = new Label();
            lblNumero = new Label();
            lblLog = new Label();
            lblTipo = new Label();
            lblNome = new Label();
            lblConsumoUltimoMês = new Label();
            lblInstalacao = new Label();
            btnCadConta = new Button();
            lblCGC = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Location = new Point(12, 27);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(208, 23);
            txtCpfCnpj.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 6;
            label2.Text = "CPF / CNPJ";
            // 
            // btnPesquisa
            // 
            btnPesquisa.Location = new Point(235, 27);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(75, 23);
            btnPesquisa.TabIndex = 8;
            btnPesquisa.Text = "&Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = true;
            btnPesquisa.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtMesRef);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtValorSemImpostoUltimoMes);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtValorUltimoMes);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtConsumoUltimoMes);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblCidade);
            panel1.Controls.Add(lblCEP);
            panel1.Controls.Add(lblUF);
            panel1.Controls.Add(lblBairro);
            panel1.Controls.Add(lblNumero);
            panel1.Controls.Add(lblLog);
            panel1.Controls.Add(lblTipo);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(lblConsumoUltimoMês);
            panel1.Location = new Point(12, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 258);
            panel1.TabIndex = 9;
            // 
            // txtMesRef
            // 
            txtMesRef.Location = new Point(608, 211);
            txtMesRef.Name = "txtMesRef";
            txtMesRef.ReadOnly = true;
            txtMesRef.Size = new Size(142, 23);
            txtMesRef.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(608, 193);
            label12.Name = "label12";
            label12.Size = new Size(142, 15);
            label12.TabIndex = 24;
            label12.Text = "Último Mês de Referência";
            // 
            // txtValorSemImpostoUltimoMes
            // 
            txtValorSemImpostoUltimoMes.Location = new Point(412, 211);
            txtValorSemImpostoUltimoMes.Name = "txtValorSemImpostoUltimoMes";
            txtValorSemImpostoUltimoMes.ReadOnly = true;
            txtValorSemImpostoUltimoMes.Size = new Size(123, 23);
            txtValorSemImpostoUltimoMes.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(412, 193);
            label11.Name = "label11";
            label11.Size = new Size(106, 15);
            label11.TabIndex = 22;
            label11.Text = "Valor Sem Imposto";
            label11.Click += label11_Click;
            // 
            // txtValorUltimoMes
            // 
            txtValorUltimoMes.Location = new Point(210, 211);
            txtValorUltimoMes.Name = "txtValorUltimoMes";
            txtValorUltimoMes.ReadOnly = true;
            txtValorUltimoMes.Size = new Size(123, 23);
            txtValorUltimoMes.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(210, 193);
            label10.Name = "label10";
            label10.Size = new Size(112, 15);
            label10.TabIndex = 20;
            label10.Text = "Valor Total da Conta";
            // 
            // txtConsumoUltimoMes
            // 
            txtConsumoUltimoMes.Location = new Point(15, 211);
            txtConsumoUltimoMes.Name = "txtConsumoUltimoMes";
            txtConsumoUltimoMes.ReadOnly = true;
            txtConsumoUltimoMes.Size = new Size(123, 23);
            txtConsumoUltimoMes.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 148);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 17;
            label9.Text = "CEP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(684, 102);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 16;
            label8.Text = "UF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(362, 102);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 15;
            label7.Text = "Cidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 102);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 14;
            label6.Text = "Bairro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(633, 58);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 13;
            label5.Text = "Numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 58);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 12;
            label4.Text = "Logradouro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(584, 12);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 11;
            label3.Text = "Tipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 10;
            label1.Text = "Nome";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCidade.Location = new Point(362, 117);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(0, 19);
            lblCidade.TabIndex = 7;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCEP.Location = new Point(14, 163);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(0, 19);
            lblCEP.TabIndex = 6;
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblUF.Location = new Point(684, 117);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(0, 19);
            lblUF.TabIndex = 5;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblBairro.Location = new Point(14, 117);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(0, 19);
            lblBairro.TabIndex = 4;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumero.Location = new Point(653, 73);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(0, 19);
            lblNumero.TabIndex = 3;
            // 
            // lblLog
            // 
            lblLog.AutoSize = true;
            lblLog.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblLog.Location = new Point(14, 73);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(0, 19);
            lblLog.TabIndex = 2;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.Location = new Point(584, 27);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(0, 19);
            lblTipo.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(14, 27);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(0, 19);
            lblNome.TabIndex = 0;
            // 
            // lblConsumoUltimoMês
            // 
            lblConsumoUltimoMês.AutoSize = true;
            lblConsumoUltimoMês.Location = new Point(15, 193);
            lblConsumoUltimoMês.Name = "lblConsumoUltimoMês";
            lblConsumoUltimoMês.Size = new Size(123, 15);
            lblConsumoUltimoMês.TabIndex = 18;
            lblConsumoUltimoMês.Text = "Consumo Último Mês";
            // 
            // lblInstalacao
            // 
            lblInstalacao.AutoSize = true;
            lblInstalacao.Location = new Point(685, 9);
            lblInstalacao.Name = "lblInstalacao";
            lblInstalacao.Size = new Size(60, 15);
            lblInstalacao.TabIndex = 18;
            lblInstalacao.Text = "Instalacao";
            lblInstalacao.Visible = false;
            // 
            // btnCadConta
            // 
            btnCadConta.Enabled = false;
            btnCadConta.Location = new Point(12, 506);
            btnCadConta.Name = "btnCadConta";
            btnCadConta.Size = new Size(117, 31);
            btnCadConta.TabIndex = 12;
            btnCadConta.Text = "Cadastrar Conta";
            btnCadConta.UseVisualStyleBackColor = true;
            btnCadConta.Click += btnCadConta_Click;
            // 
            // lblCGC
            // 
            lblCGC.AutoSize = true;
            lblCGC.Location = new Point(698, 42);
            lblCGC.Name = "lblCGC";
            lblCGC.Size = new Size(31, 15);
            lblCGC.TabIndex = 19;
            lblCGC.Text = "CGC";
            lblCGC.Visible = false;
            // 
            // Contas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(lblCGC);
            Controls.Add(lblInstalacao);
            Controls.Add(btnCadConta);
            Controls.Add(panel1);
            Controls.Add(btnPesquisa);
            Controls.Add(txtCpfCnpj);
            Controls.Add(label2);
            Name = "Contas";
            Text = "Contas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCpfCnpj;
        private Label label2;
        private Button btnPesquisa;
        private Panel panel1;
        private Label lblTipo;
        private Label lblNome;
        private Label lblNumero;
        private Label lblLog;
        private Label lblCEP;
        private Label lblUF;
        private Label lblBairro;
        private Label lblCidade;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnCadConta;
        private Label lblInstalacao;
        private Label lblCGC;
        private TextBox txtConsumoUltimoMes;
        private Label lblConsumoUltimoMês;
        private TextBox txtValorSemImpostoUltimoMes;
        private Label label11;
        private TextBox txtValorUltimoMes;
        private Label label10;
        private TextBox txtMesRef;
        private Label label12;
    }
}