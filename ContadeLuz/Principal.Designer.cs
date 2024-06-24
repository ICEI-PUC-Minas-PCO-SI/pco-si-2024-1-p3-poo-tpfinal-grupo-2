namespace ContadeLuz
{
    partial class Principal
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
            menuHead = new MenuStrip();
            menuCadastros = new ToolStripMenuItem();
            itemConsumidores = new ToolStripMenuItem();
            itemContas = new ToolStripMenuItem();
            menuHead.SuspendLayout();
            SuspendLayout();
            // 
            // menuHead
            // 
            menuHead.BackColor = SystemColors.Info;
            menuHead.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            menuHead.Items.AddRange(new ToolStripItem[] { menuCadastros });
            menuHead.Location = new Point(0, 0);
            menuHead.Name = "menuHead";
            menuHead.Size = new Size(800, 33);
            menuHead.TabIndex = 0;
            menuHead.Text = "menuStrip1";
            // 
            // menuCadastros
            // 
            menuCadastros.DropDownItems.AddRange(new ToolStripItem[] { itemConsumidores, itemContas });
            menuCadastros.Name = "menuCadastros";
            menuCadastros.Size = new Size(111, 29);
            menuCadastros.Text = "Cadastros";
            // 
            // itemConsumidores
            // 
            itemConsumidores.BackColor = SystemColors.ControlLight;
            itemConsumidores.Name = "itemConsumidores";
            itemConsumidores.Size = new Size(212, 30);
            itemConsumidores.Text = "Consumidores";
            itemConsumidores.Click += itemConsumidores_Click;
            // 
            // itemContas
            // 
            itemContas.BackColor = SystemColors.ControlLight;
            itemContas.Name = "itemContas";
            itemContas.Size = new Size(212, 30);
            itemContas.Text = "Contas";
            itemContas.Click += itemContas_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuHead);
            Name = "Principal";
            Text = "Gerenciador de Conta de Luz";
            menuHead.ResumeLayout(false);
            menuHead.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuHead;
        private ToolStripMenuItem menuCadastros;
        private ToolStripMenuItem itemConsumidores;
        private ToolStripMenuItem itemContas;
    }
}
