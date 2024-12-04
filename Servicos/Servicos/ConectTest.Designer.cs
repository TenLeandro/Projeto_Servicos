namespace Servicos
{
    partial class ConectTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConectTest));
            this.gbConec = new System.Windows.Forms.GroupBox();
            this.btnConecprod = new System.Windows.Forms.Button();
            this.dgvConecview = new System.Windows.Forms.DataGridView();
            this.btnConecuser = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Produto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Conectest = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bd_servicoDataSet = new Servicos.bd_servicoDataSet();
            this.tbclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_clienteTableAdapter = new Servicos.bd_servicoDataSetTableAdapters.tb_clienteTableAdapter();
            this.bdservicoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbConec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConecview)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_servicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdservicoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConec
            // 
            this.gbConec.BackColor = System.Drawing.Color.Snow;
            this.gbConec.Controls.Add(this.btnConecprod);
            this.gbConec.Controls.Add(this.dgvConecview);
            this.gbConec.Controls.Add(this.btnConecuser);
            this.gbConec.Location = new System.Drawing.Point(12, 40);
            this.gbConec.Name = "gbConec";
            this.gbConec.Size = new System.Drawing.Size(680, 360);
            this.gbConec.TabIndex = 4;
            this.gbConec.TabStop = false;
            this.gbConec.Text = "Verificar conexão";
            // 
            // btnConecprod
            // 
            this.btnConecprod.BackColor = System.Drawing.Color.White;
            this.btnConecprod.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnConecprod.FlatAppearance.BorderSize = 3;
            this.btnConecprod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConecprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConecprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConecprod.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConecprod.Location = new System.Drawing.Point(6, 184);
            this.btnConecprod.Name = "btnConecprod";
            this.btnConecprod.Size = new System.Drawing.Size(211, 89);
            this.btnConecprod.TabIndex = 2;
            this.btnConecprod.Text = "Produto";
            this.btnConecprod.UseVisualStyleBackColor = false;
            this.btnConecprod.Click += new System.EventHandler(this.BtnConecprod_Click);
            // 
            // dgvConecview
            // 
            this.dgvConecview.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvConecview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConecview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConecview.Location = new System.Drawing.Point(223, 19);
            this.dgvConecview.Name = "dgvConecview";
            this.dgvConecview.Size = new System.Drawing.Size(451, 335);
            this.dgvConecview.TabIndex = 1;
            // 
            // btnConecuser
            // 
            this.btnConecuser.BackColor = System.Drawing.Color.White;
            this.btnConecuser.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnConecuser.FlatAppearance.BorderSize = 3;
            this.btnConecuser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConecuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConecuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConecuser.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConecuser.Location = new System.Drawing.Point(6, 89);
            this.btnConecuser.Name = "btnConecuser";
            this.btnConecuser.Size = new System.Drawing.Size(211, 89);
            this.btnConecuser.TabIndex = 0;
            this.btnConecuser.Text = "Usuário";
            this.btnConecuser.UseVisualStyleBackColor = false;
            this.btnConecuser.Click += new System.EventHandler(this.Button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.removerToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 8, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(704, 37);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Cliente,
            this.tsmi_Produto,
            this.tsmi_Conectest});
            this.cadastrarToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.cadastrarToolStripMenuItem.Image = global::Servicos.Properties.Resources.sign_up_icon;
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(117, 27);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // tsmi_Cliente
            // 
            this.tsmi_Cliente.Name = "tsmi_Cliente";
            this.tsmi_Cliente.Size = new System.Drawing.Size(208, 28);
            this.tsmi_Cliente.Text = "Cliente";
            this.tsmi_Cliente.Click += new System.EventHandler(this.Tsmi_Cliente_Click);
            // 
            // tsmi_Produto
            // 
            this.tsmi_Produto.Name = "tsmi_Produto";
            this.tsmi_Produto.Size = new System.Drawing.Size(208, 28);
            this.tsmi_Produto.Text = "Produto";
            this.tsmi_Produto.Click += new System.EventHandler(this.Tsmi_Produto_Click);
            // 
            // tsmi_Conectest
            // 
            this.tsmi_Conectest.Name = "tsmi_Conectest";
            this.tsmi_Conectest.Size = new System.Drawing.Size(208, 28);
            this.tsmi_Conectest.Text = "Teste de Conexão";
            this.tsmi_Conectest.Click += new System.EventHandler(this.Tsmi_Conectest_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.removerToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.removerToolStripMenuItem.Image = global::Servicos.Properties.Resources.remove_icon;
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(112, 27);
            this.removerToolStripMenuItem.Text = "Remover";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.buscarToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.buscarToolStripMenuItem.Image = global::Servicos.Properties.Resources.search_icon;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.alterarToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.alterarToolStripMenuItem.Image = global::Servicos.Properties.Resources.edit_icon;
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(93, 27);
            this.alterarToolStripMenuItem.Text = "Alterar";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.imprimirToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.imprimirToolStripMenuItem.Image = global::Servicos.Properties.Resources.print_icon;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(103, 27);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.salvarToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.salvarToolStripMenuItem.Image = global::Servicos.Properties.Resources.save_icon;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(92, 27);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.sairToolStripMenuItem.Image = global::Servicos.Properties.Resources.exit_icon;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(76, 27);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // bd_servicoDataSet
            // 
            this.bd_servicoDataSet.DataSetName = "bd_servicoDataSet";
            this.bd_servicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbclienteBindingSource
            // 
            this.tbclienteBindingSource.DataMember = "tb_cliente";
            this.tbclienteBindingSource.DataSource = this.bd_servicoDataSet;
            // 
            // tb_clienteTableAdapter
            // 
            this.tb_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // bdservicoDataSetBindingSource
            // 
            this.bdservicoDataSetBindingSource.DataSource = this.bd_servicoDataSet;
            this.bdservicoDataSetBindingSource.Position = 0;
            // 
            // ConectTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(704, 412);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbConec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConectTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ConectTest_Load);
            this.gbConec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConecview)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_servicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdservicoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbConec;
        private System.Windows.Forms.Button btnConecprod;
        private System.Windows.Forms.DataGridView dgvConecview;
        private System.Windows.Forms.Button btnConecuser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Cliente;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Produto;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Conectest;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private bd_servicoDataSet bd_servicoDataSet;
        private System.Windows.Forms.BindingSource tbclienteBindingSource;
        private bd_servicoDataSetTableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter;
        private System.Windows.Forms.BindingSource bdservicoDataSetBindingSource;
    }
}