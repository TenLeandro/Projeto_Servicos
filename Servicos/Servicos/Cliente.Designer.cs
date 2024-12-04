namespace Servicos
{
    partial class frmCleiton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCleiton));
            this.gpInsert = new System.Windows.Forms.GroupBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.tbclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_servicoDataSet = new Servicos.bd_servicoDataSet();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxNmCli = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.lblCliNome = new System.Windows.Forms.Label();
            this.lblCliCPF = new System.Windows.Forms.Label();
            this.lblCliEmail = new System.Windows.Forms.Label();
            this.lblCliGenero = new System.Windows.Forms.Label();
            this.lblCliID = new System.Windows.Forms.Label();
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
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPosterior = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpButtons = new System.Windows.Forms.GroupBox();
            this.tb_clienteTableAdapter = new Servicos.bd_servicoDataSetTableAdapters.tb_clienteTableAdapter();
            this.gpInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_servicoDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpInsert
            // 
            this.gpInsert.Controls.Add(this.cbGenero);
            this.gpInsert.Controls.Add(this.mtbCpf);
            this.gpInsert.Controls.Add(this.textBox5);
            this.gpInsert.Controls.Add(this.txtBoxEmail);
            this.gpInsert.Controls.Add(this.txtBoxNmCli);
            this.gpInsert.Controls.Add(this.txtBoxId);
            this.gpInsert.Controls.Add(this.lblCliNome);
            this.gpInsert.Controls.Add(this.lblCliCPF);
            this.gpInsert.Controls.Add(this.lblCliEmail);
            this.gpInsert.Controls.Add(this.lblCliGenero);
            this.gpInsert.Controls.Add(this.lblCliID);
            this.gpInsert.Location = new System.Drawing.Point(30, 61);
            this.gpInsert.Name = "gpInsert";
            this.gpInsert.Size = new System.Drawing.Size(646, 200);
            this.gpInsert.TabIndex = 0;
            this.gpInsert.TabStop = false;
            this.gpInsert.Text = "Cliente";
            this.gpInsert.Enter += new System.EventHandler(this.GpInsert_Enter);
            // 
            // cbGenero
            // 
            this.cbGenero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbclienteBindingSource, "gn_cliente", true));
            this.cbGenero.Enabled = false;
            this.cbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Homem",
            "Mulher",
            "Não Binário",
            "N3K0",
            "Panzerkampfwagen VI Tiger",
            "Rock n Roll"});
            this.cbGenero.Location = new System.Drawing.Point(92, 152);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(135, 24);
            this.cbGenero.TabIndex = 17;
            // 
            // tbclienteBindingSource
            // 
            this.tbclienteBindingSource.DataMember = "tb_cliente";
            this.tbclienteBindingSource.DataSource = this.bd_servicoDataSet;
            // 
            // bd_servicoDataSet
            // 
            this.bd_servicoDataSet.DataSetName = "bd_servicoDataSet";
            this.bd_servicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mtbCpf
            // 
            this.mtbCpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbclienteBindingSource, "cpf", true));
            this.mtbCpf.Enabled = false;
            this.mtbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpf.Location = new System.Drawing.Point(92, 68);
            this.mtbCpf.Mask = "000.000.000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(135, 22);
            this.mtbCpf.TabIndex = 16;
            this.mtbCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MtbCpf_MaskInputRejected);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(92, 156);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(0, 22);
            this.textBox5.TabIndex = 9;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbclienteBindingSource, "email", true));
            this.txtBoxEmail.Enabled = false;
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(92, 111);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(135, 22);
            this.txtBoxEmail.TabIndex = 8;
            // 
            // txtBoxNmCli
            // 
            this.txtBoxNmCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbclienteBindingSource, "nm_cliente", true));
            this.txtBoxNmCli.Enabled = false;
            this.txtBoxNmCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNmCli.Location = new System.Drawing.Point(92, 31);
            this.txtBoxNmCli.Name = "txtBoxNmCli";
            this.txtBoxNmCli.Size = new System.Drawing.Size(135, 22);
            this.txtBoxNmCli.TabIndex = 6;
            // 
            // txtBoxId
            // 
            this.txtBoxId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbclienteBindingSource, "pk_cliente", true));
            this.txtBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxId.Location = new System.Drawing.Point(594, 15);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(46, 26);
            this.txtBoxId.TabIndex = 5;
            this.txtBoxId.TextChanged += new System.EventHandler(this.TxtBoxId_TextChanged);
            // 
            // lblCliNome
            // 
            this.lblCliNome.AutoSize = true;
            this.lblCliNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliNome.Location = new System.Drawing.Point(10, 27);
            this.lblCliNome.Name = "lblCliNome";
            this.lblCliNome.Size = new System.Drawing.Size(67, 24);
            this.lblCliNome.TabIndex = 4;
            this.lblCliNome.Text = "Nome:";
            // 
            // lblCliCPF
            // 
            this.lblCliCPF.AutoSize = true;
            this.lblCliCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliCPF.Location = new System.Drawing.Point(10, 68);
            this.lblCliCPF.Name = "lblCliCPF";
            this.lblCliCPF.Size = new System.Drawing.Size(52, 24);
            this.lblCliCPF.TabIndex = 3;
            this.lblCliCPF.Text = "CPF:";
            // 
            // lblCliEmail
            // 
            this.lblCliEmail.AutoSize = true;
            this.lblCliEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliEmail.Location = new System.Drawing.Point(10, 108);
            this.lblCliEmail.Name = "lblCliEmail";
            this.lblCliEmail.Size = new System.Drawing.Size(62, 24);
            this.lblCliEmail.TabIndex = 2;
            this.lblCliEmail.Text = "Email:";
            // 
            // lblCliGenero
            // 
            this.lblCliGenero.AutoSize = true;
            this.lblCliGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliGenero.Location = new System.Drawing.Point(10, 152);
            this.lblCliGenero.Name = "lblCliGenero";
            this.lblCliGenero.Size = new System.Drawing.Size(79, 24);
            this.lblCliGenero.TabIndex = 1;
            this.lblCliGenero.Text = "Gênero:";
            // 
            // lblCliID
            // 
            this.lblCliID.AutoSize = true;
            this.lblCliID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliID.Location = new System.Drawing.Point(565, 15);
            this.lblCliID.Name = "lblCliID";
            this.lblCliID.Size = new System.Drawing.Size(32, 24);
            this.lblCliID.TabIndex = 0;
            this.lblCliID.Text = "ID:";
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
            this.menuStrip1.TabIndex = 2;
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
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.CadastrarToolStripMenuItem_Click);
            // 
            // tsmi_Cliente
            // 
            this.tsmi_Cliente.Name = "tsmi_Cliente";
            this.tsmi_Cliente.Size = new System.Drawing.Size(208, 28);
            this.tsmi_Cliente.Text = "Cliente";
            this.tsmi_Cliente.Click += new System.EventHandler(this.Tsmi_Ende_Click);
            // 
            // tsmi_Produto
            // 
            this.tsmi_Produto.Name = "tsmi_Produto";
            this.tsmi_Produto.Size = new System.Drawing.Size(208, 28);
            this.tsmi_Produto.Text = "Produto";
            this.tsmi_Produto.Click += new System.EventHandler(this.Tsmi_Clie_Click);
            // 
            // tsmi_Conectest
            // 
            this.tsmi_Conectest.Name = "tsmi_Conectest";
            this.tsmi_Conectest.Size = new System.Drawing.Size(208, 28);
            this.tsmi_Conectest.Text = "Teste de Conexão";
            this.tsmi_Conectest.Click += new System.EventHandler(this.Tsmi_Prod_Click);
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
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.White;
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAnterior.FlatAppearance.BorderSize = 2;
            this.btnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAnterior.Location = new System.Drawing.Point(13, 32);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(98, 41);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // btnPosterior
            // 
            this.btnPosterior.BackColor = System.Drawing.Color.White;
            this.btnPosterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPosterior.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPosterior.FlatAppearance.BorderSize = 2;
            this.btnPosterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPosterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPosterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosterior.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnPosterior.Location = new System.Drawing.Point(117, 32);
            this.btnPosterior.Name = "btnPosterior";
            this.btnPosterior.Size = new System.Drawing.Size(98, 41);
            this.btnPosterior.TabIndex = 1;
            this.btnPosterior.Text = "Posterior";
            this.btnPosterior.UseVisualStyleBackColor = false;
            this.btnPosterior.Click += new System.EventHandler(this.BtnPosterior_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.BackColor = System.Drawing.Color.White;
            this.btnPrimeiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimeiro.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPrimeiro.FlatAppearance.BorderSize = 2;
            this.btnPrimeiro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrimeiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrimeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeiro.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnPrimeiro.Location = new System.Drawing.Point(221, 32);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(98, 41);
            this.btnPrimeiro.TabIndex = 2;
            this.btnPrimeiro.Text = "Primeiro";
            this.btnPrimeiro.UseVisualStyleBackColor = false;
            this.btnPrimeiro.Click += new System.EventHandler(this.BtnPrimeiro_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.White;
            this.btnUltimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUltimo.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnUltimo.FlatAppearance.BorderSize = 2;
            this.btnUltimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUltimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnUltimo.Location = new System.Drawing.Point(325, 32);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(98, 41);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = "Ultimo";
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnBuscar.Location = new System.Drawing.Point(429, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 41);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Enabled = false;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnLimpar.Location = new System.Drawing.Point(533, 32);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 41);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnCadastrar.Location = new System.Drawing.Point(13, 83);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(98, 41);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.White;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRemover.FlatAppearance.BorderSize = 2;
            this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnRemover.Location = new System.Drawing.Point(117, 83);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(98, 41);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAlterar.FlatAppearance.BorderSize = 2;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAlterar.Location = new System.Drawing.Point(221, 83);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(98, 41);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnSalvar.Location = new System.Drawing.Point(325, 83);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 41);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.White;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimir.FlatAppearance.BorderSize = 2;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnImprimir.Location = new System.Drawing.Point(429, 83);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(98, 41);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Enabled = false;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSair.FlatAppearance.BorderSize = 2;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnSair.Location = new System.Drawing.Point(533, 83);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 41);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.Button6_Click);
            // 
            // gpButtons
            // 
            this.gpButtons.Controls.Add(this.btnSair);
            this.gpButtons.Controls.Add(this.btnImprimir);
            this.gpButtons.Controls.Add(this.btnSalvar);
            this.gpButtons.Controls.Add(this.btnAlterar);
            this.gpButtons.Controls.Add(this.btnRemover);
            this.gpButtons.Controls.Add(this.btnCadastrar);
            this.gpButtons.Controls.Add(this.btnLimpar);
            this.gpButtons.Controls.Add(this.btnBuscar);
            this.gpButtons.Controls.Add(this.btnUltimo);
            this.gpButtons.Controls.Add(this.btnPrimeiro);
            this.gpButtons.Controls.Add(this.btnPosterior);
            this.gpButtons.Controls.Add(this.btnAnterior);
            this.gpButtons.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpButtons.Location = new System.Drawing.Point(30, 285);
            this.gpButtons.Name = "gpButtons";
            this.gpButtons.Size = new System.Drawing.Size(646, 151);
            this.gpButtons.TabIndex = 1;
            this.gpButtons.TabStop = false;
            this.gpButtons.Text = "Botões";
            // 
            // tb_clienteTableAdapter
            // 
            this.tb_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmCleiton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.gpButtons);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gpInsert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCleiton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCleiton_Load);
            this.gpInsert.ResumeLayout(false);
            this.gpInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_servicoDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpInsert;
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
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxNmCli;
        private System.Windows.Forms.Label lblCliNome;
        private System.Windows.Forms.Label lblCliCPF;
        private System.Windows.Forms.Label lblCliEmail;
        private System.Windows.Forms.Label lblCliGenero;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label lblCliID;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPosterior;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gpButtons;
        private bd_servicoDataSet bd_servicoDataSet;
        private System.Windows.Forms.BindingSource tbclienteBindingSource;
        private bd_servicoDataSetTableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter;
    }
}