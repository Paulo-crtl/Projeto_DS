namespace ProjetoDS_EAD
{
    partial class Form5
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHomeAdm = new System.Windows.Forms.TabPage();
            this.tabVendas = new System.Windows.Forms.TabPage();
            this.tabProdutos = new System.Windows.Forms.TabPage();
            this.tabFuncionarios = new System.Windows.Forms.TabPage();
            this.tabRelatorios = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabHomeAdm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHomeAdm);
            this.tabControl1.Controls.Add(this.tabVendas);
            this.tabControl1.Controls.Add(this.tabProdutos);
            this.tabControl1.Controls.Add(this.tabFuncionarios);
            this.tabControl1.Controls.Add(this.tabRelatorios);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 401);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHomeAdm
            // 
            this.tabHomeAdm.Controls.Add(this.label2);
            this.tabHomeAdm.Controls.Add(this.label1);
            this.tabHomeAdm.Location = new System.Drawing.Point(4, 22);
            this.tabHomeAdm.Name = "tabHomeAdm";
            this.tabHomeAdm.Padding = new System.Windows.Forms.Padding(3);
            this.tabHomeAdm.Size = new System.Drawing.Size(769, 375);
            this.tabHomeAdm.TabIndex = 0;
            this.tabHomeAdm.Text = "Home";
            this.tabHomeAdm.UseVisualStyleBackColor = true;
            // 
            // tabVendas
            // 
            this.tabVendas.Location = new System.Drawing.Point(4, 22);
            this.tabVendas.Name = "tabVendas";
            this.tabVendas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVendas.Size = new System.Drawing.Size(769, 375);
            this.tabVendas.TabIndex = 1;
            this.tabVendas.Text = "Vendas";
            this.tabVendas.UseVisualStyleBackColor = true;
            // 
            // tabProdutos
            // 
            this.tabProdutos.Location = new System.Drawing.Point(4, 22);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.Size = new System.Drawing.Size(769, 375);
            this.tabProdutos.TabIndex = 2;
            this.tabProdutos.Text = "Produtos";
            this.tabProdutos.UseVisualStyleBackColor = true;
            // 
            // tabFuncionarios
            // 
            this.tabFuncionarios.Location = new System.Drawing.Point(4, 22);
            this.tabFuncionarios.Name = "tabFuncionarios";
            this.tabFuncionarios.Size = new System.Drawing.Size(769, 375);
            this.tabFuncionarios.TabIndex = 3;
            this.tabFuncionarios.Text = "Funcionarios";
            this.tabFuncionarios.UseVisualStyleBackColor = true;
            // 
            // tabRelatorios
            // 
            this.tabRelatorios.Location = new System.Drawing.Point(4, 22);
            this.tabRelatorios.Name = "tabRelatorios";
            this.tabRelatorios.Size = new System.Drawing.Size(769, 375);
            this.tabRelatorios.TabIndex = 4;
            this.tabRelatorios.Text = "Relatórios";
            this.tabRelatorios.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHomeAdm.ResumeLayout(false);
            this.tabHomeAdm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHomeAdm;
        private System.Windows.Forms.TabPage tabVendas;
        private System.Windows.Forms.TabPage tabProdutos;
        private System.Windows.Forms.TabPage tabFuncionarios;
        private System.Windows.Forms.TabPage tabRelatorios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}