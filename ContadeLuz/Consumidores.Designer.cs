namespace ContadeLuz
{
    partial class Consumidores
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
            btnNovo = new Button();
            btnConsultar = new Button();
            label1 = new Label();
            textNome = new TextBox();
            textCGC = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnSalvar = new Button();
            groupBox2 = new GroupBox();
            textCEP = new TextBox();
            label8 = new Label();
            comboUF = new ComboBox();
            label7 = new Label();
            textCidade = new TextBox();
            label6 = new Label();
            textBairro = new TextBox();
            label5 = new Label();
            textNum = new TextBox();
            label4 = new Label();
            textLog = new TextBox();
            label3 = new Label();
            btnPesquisar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(12, 12);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "&Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(93, 12);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // textNome
            // 
            textNome.Enabled = false;
            textNome.Location = new Point(12, 69);
            textNome.Name = "textNome";
            textNome.Size = new Size(380, 23);
            textNome.TabIndex = 3;
            // 
            // textCGC
            // 
            textCGC.Enabled = false;
            textCGC.Location = new Point(12, 116);
            textCGC.Name = "textCGC";
            textCGC.Size = new Size(208, 23);
            textCGC.TabIndex = 5;
            textCGC.Leave += textBox1_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "CPF / CNPJ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(250, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(218, 41);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de Consumidor";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Enabled = false;
            radioButton2.Location = new Point(128, 16);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(84, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Residencial";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Enabled = false;
            radioButton1.Location = new Point(9, 15);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(79, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Comercial";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleRight;
            btnSalvar.Location = new Point(84, 377);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Visible = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textCEP);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(comboUF);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textCidade);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBairro);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textNum);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textLog);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(700, 204);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Endereço";
            // 
            // textCEP
            // 
            textCEP.Enabled = false;
            textCEP.Location = new Point(6, 156);
            textCEP.Name = "textCEP";
            textCEP.Size = new Size(137, 23);
            textCEP.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 138);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 14;
            label8.Text = "CEP";
            // 
            // comboUF
            // 
            comboUF.FormattingEnabled = true;
            comboUF.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "EX", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" });
            comboUF.Location = new Point(556, 100);
            comboUF.Name = "comboUF";
            comboUF.Size = new Size(66, 23);
            comboUF.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(556, 82);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 12;
            label7.Text = "UF";
            // 
            // textCidade
            // 
            textCidade.Enabled = false;
            textCidade.Location = new Point(238, 100);
            textCidade.Name = "textCidade";
            textCidade.Size = new Size(294, 23);
            textCidade.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(238, 82);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 10;
            label6.Text = "Cidade";
            // 
            // textBairro
            // 
            textBairro.Enabled = false;
            textBairro.Location = new Point(6, 100);
            textBairro.Name = "textBairro";
            textBairro.Size = new Size(202, 23);
            textBairro.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 82);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 8;
            label5.Text = "Bairro";
            // 
            // textNum
            // 
            textNum.Enabled = false;
            textNum.Location = new Point(473, 46);
            textNum.Name = "textNum";
            textNum.Size = new Size(59, 23);
            textNum.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(473, 28);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 6;
            label4.Text = "Nº";
            // 
            // textLog
            // 
            textLog.Enabled = false;
            textLog.Location = new Point(6, 46);
            textLog.Name = "textLog";
            textLog.Size = new Size(450, 23);
            textLog.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 28);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Logradouro";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(220, 377);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Visible = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // Consumidores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 418);
            Controls.Add(btnPesquisar);
            Controls.Add(groupBox2);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            Controls.Add(textCGC);
            Controls.Add(label2);
            Controls.Add(textNome);
            Controls.Add(label1);
            Controls.Add(btnConsultar);
            Controls.Add(btnNovo);
            Name = "Consumidores";
            Text = "Consumidores";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovo;
        private Button btnConsultar;
        private Label label1;
        private TextBox textNome;
        private TextBox textCGC;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button btnSalvar;
        private GroupBox groupBox2;
        private TextBox textLog;
        private Label label3;
        private TextBox textNum;
        private Label label4;
        private TextBox textCEP;
        private Label label8;
        private ComboBox comboUF;
        private Label label7;
        private TextBox textCidade;
        private Label label6;
        private TextBox textBairro;
        private Label label5;
        private Button btnPesquisar;
    }
}