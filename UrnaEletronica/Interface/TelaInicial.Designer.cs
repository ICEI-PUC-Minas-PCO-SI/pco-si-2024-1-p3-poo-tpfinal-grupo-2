namespace Interface
{
    partial class TelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(79, 38);
            label1.Name = "label1";
            label1.Size = new Size(627, 37);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Gerenciamento de Urnas Eletrônicas";
            // 
            // button1
            // 
            button1.Location = new Point(91, 127);
            button1.Name = "button1";
            button1.Size = new Size(155, 50);
            button1.TabIndex = 1;
            button1.Text = "Gerenciamento";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(528, 127);
            button2.Name = "button2";
            button2.Size = new Size(155, 50);
            button2.TabIndex = 2;
            button2.Text = "Votação Legislativo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(307, 127);
            button3.Name = "button3";
            button3.Size = new Size(155, 50);
            button3.TabIndex = 3;
            button3.Text = "Votação Executivo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(91, 290);
            label2.Name = "label2";
            label2.Size = new Size(144, 105);
            label2.TabIndex = 4;
            label2.Text = "Desenvolvido por:\r\nEvaldo Duarte\r\nFelipe Ferreira\r\nGabriel Amorim\r\nLara Chaves";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(349, 332);
            label3.Name = "label3";
            label3.Size = new Size(334, 63);
            label3.TabIndex = 5;
            label3.Text = "Disciplina: Programação Orientada a Objetos\r\nProfessor: Fábio Cordeiro\r\nPUC Contagem - Junho 2024";
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "TelaInicial";
            Text = "Tela Inicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
    }
}