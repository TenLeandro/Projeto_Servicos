namespace Servicos
{
    partial class frmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.gpButtons = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnPosterior = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.gpInsert = new System.Windows.Forms.GroupBox();
            this.cbCustom = new System.Windows.Forms.ComboBox();
            this.tbprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_servicoDataSet = new Servicos.bd_servicoDataSet();
            this.cbDisp = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.txtBoxPreco = new System.Windows.Forms.TextBox();
            this.lblProdPreco = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtBoxProdNm = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.lblProdNome = new System.Windows.Forms.Label();
            this.lblProdDispo = new System.Windows.Forms.Label();
            this.lblProdMarca = new System.Windows.Forms.Label();
            this.lblProdCustom = new System.Windows.Forms.Label();
            this.lblProdID = new System.Windows.Forms.Label();
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
            this.tb_produtoTableAdapter = new Servicos.bd_servicoDataSetTableAdapters.tb_produtoTableAdapter();
            this.gpButtons.SuspendLayout();
            this.gpInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_servicoDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.gpButtons.Location = new System.Drawing.Point(30, 292);
            this.gpButtons.Name = "gpButtons";
            this.gpButtons.Size = new System.Drawing.Size(646, 151);
            this.gpButtons.TabIndex = 4;
            this.gpButtons.TabStop = false;
            this.gpButtons.Text = "Botões";
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
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
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
            // gpInsert
            // 
            this.gpInsert.Controls.Add(this.cbCustom);
            this.gpInsert.Controls.Add(this.cbDisp);
            this.gpInsert.Controls.Add(this.cbMarca);
            this.gpInsert.Controls.Add(this.txtBoxPreco);
            this.gpInsert.Controls.Add(this.lblProdPreco);
            this.gpInsert.Controls.Add(this.textBox5);
            this.gpInsert.Controls.Add(this.txtBoxProdNm);
            this.gpInsert.Controls.Add(this.txtBoxId);
            this.gpInsert.Controls.Add(this.lblProdNome);
            this.gpInsert.Controls.Add(this.lblProdDispo);
            this.gpInsert.Controls.Add(this.lblProdMarca);
            this.gpInsert.Controls.Add(this.lblProdCustom);
            this.gpInsert.Controls.Add(this.lblProdID);
            this.gpInsert.Location = new System.Drawing.Point(30, 68);
            this.gpInsert.Name = "gpInsert";
            this.gpInsert.Size = new System.Drawing.Size(646, 200);
            this.gpInsert.TabIndex = 3;
            this.gpInsert.TabStop = false;
            this.gpInsert.Text = "Produto";
            this.gpInsert.Enter += new System.EventHandler(this.GpInsert_Enter);
            // 
            // cbCustom
            // 
            this.cbCustom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbprodutoBindingSource, "custom", true));
            this.cbCustom.Enabled = false;
            this.cbCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbCustom.FormattingEnabled = true;
            this.cbCustom.Items.AddRange(new object[] {
            "Null",
            "Teclado",
            "Controle",
            "Mouse"});
            this.cbCustom.Location = new System.Drawing.Point(92, 152);
            this.cbCustom.Name = "cbCustom";
            this.cbCustom.Size = new System.Drawing.Size(135, 24);
            this.cbCustom.TabIndex = 24;
            // 
            // tbprodutoBindingSource
            // 
            this.tbprodutoBindingSource.DataMember = "tb_produto";
            this.tbprodutoBindingSource.DataSource = this.bd_servicoDataSet;
            // 
            // bd_servicoDataSet
            // 
            this.bd_servicoDataSet.DataSetName = "bd_servicoDataSet";
            this.bd_servicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbDisp
            // 
            this.cbDisp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbprodutoBindingSource, "dispositivo", true));
            this.cbDisp.Enabled = false;
            this.cbDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbDisp.FormattingEnabled = true;
            this.cbDisp.Items.AddRange(new object[] {
            "Celular",
            "Tablet",
            "Laptop",
            "PC",
            "Playstation",
            "Xbox",
            "Componente",
            "Periférico"});
            this.cbDisp.Location = new System.Drawing.Point(92, 68);
            this.cbDisp.Name = "cbDisp";
            this.cbDisp.Size = new System.Drawing.Size(135, 24);
            this.cbDisp.TabIndex = 23;
            this.cbDisp.SelectedIndexChanged += new System.EventHandler(this.CbDisp_SelectedIndexChanged);
            // 
            // cbMarca
            // 
            this.cbMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbprodutoBindingSource, "marca", true));
            this.cbMarca.Enabled = false;
            this.cbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Null",
            "Samsung",
            "Apple",
            "Huawei",
            "xiammomy",
            "Goggle",
            "Asus",
            "Motorola",
            "Acer",
            "Lenovo",
            "Positivo",
            "LG",
            "Gigabyte",
            "Multilaser",
            "Intel",
            "AMD",
            "Nvidia",
            "XPG",
            "CollerMaster",
            "Corsair",
            "Kingston",
            "WesternDigital",
            "Seagate",
            "Adata",
            "Hyperx",
            "Logitech",
            "Sony",
            "Microsoft"});
            this.cbMarca.Location = new System.Drawing.Point(92, 111);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(135, 24);
            this.cbMarca.TabIndex = 22;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.CbCustom_SelectedIndexChanged);
            // 
            // txtBoxPreco
            // 
            this.txtBoxPreco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbprodutoBindingSource, "preco", true));
            this.txtBoxPreco.Enabled = false;
            this.txtBoxPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPreco.Location = new System.Drawing.Point(346, 32);
            this.txtBoxPreco.Name = "txtBoxPreco";
            this.txtBoxPreco.Size = new System.Drawing.Size(135, 22);
            this.txtBoxPreco.TabIndex = 19;
            // 
            // lblProdPreco
            // 
            this.lblProdPreco.AutoSize = true;
            this.lblProdPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdPreco.Location = new System.Drawing.Point(275, 31);
            this.lblProdPreco.Name = "lblProdPreco";
            this.lblProdPreco.Size = new System.Drawing.Size(65, 24);
            this.lblProdPreco.TabIndex = 18;
            this.lblProdPreco.Text = "Preço:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(92, 156);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(0, 22);
            this.textBox5.TabIndex = 9;
            // 
            // txtBoxProdNm
            // 
            this.txtBoxProdNm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbprodutoBindingSource, "nm_produto", true));
            this.txtBoxProdNm.Enabled = false;
            this.txtBoxProdNm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProdNm.Location = new System.Drawing.Point(92, 31);
            this.txtBoxProdNm.Name = "txtBoxProdNm";
            this.txtBoxProdNm.Size = new System.Drawing.Size(135, 22);
            this.txtBoxProdNm.TabIndex = 6;
            // 
            // txtBoxId
            // 
            this.txtBoxId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbprodutoBindingSource, "pk_produto", true));
            this.txtBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxId.Location = new System.Drawing.Point(594, 15);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(46, 26);
            this.txtBoxId.TabIndex = 5;
            this.txtBoxId.TextChanged += new System.EventHandler(this.TxtBoxId_TextChanged);
            // 
            // lblProdNome
            // 
            this.lblProdNome.AutoSize = true;
            this.lblProdNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdNome.Location = new System.Drawing.Point(10, 27);
            this.lblProdNome.Name = "lblProdNome";
            this.lblProdNome.Size = new System.Drawing.Size(67, 24);
            this.lblProdNome.TabIndex = 4;
            this.lblProdNome.Text = "Nome:";
            // 
            // lblProdDispo
            // 
            this.lblProdDispo.AutoSize = true;
            this.lblProdDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdDispo.Location = new System.Drawing.Point(10, 68);
            this.lblProdDispo.Name = "lblProdDispo";
            this.lblProdDispo.Size = new System.Drawing.Size(63, 24);
            this.lblProdDispo.TabIndex = 3;
            this.lblProdDispo.Text = "Dispo:";
            // 
            // lblProdMarca
            // 
            this.lblProdMarca.AutoSize = true;
            this.lblProdMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdMarca.Location = new System.Drawing.Point(10, 108);
            this.lblProdMarca.Name = "lblProdMarca";
            this.lblProdMarca.Size = new System.Drawing.Size(67, 24);
            this.lblProdMarca.TabIndex = 2;
            this.lblProdMarca.Text = "Marca:";
            // 
            // lblProdCustom
            // 
            this.lblProdCustom.AutoSize = true;
            this.lblProdCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdCustom.Location = new System.Drawing.Point(10, 152);
            this.lblProdCustom.Name = "lblProdCustom";
            this.lblProdCustom.Size = new System.Drawing.Size(79, 24);
            this.lblProdCustom.TabIndex = 1;
            this.lblProdCustom.Text = "Custom:";
            // 
            // lblProdID
            // 
            this.lblProdID.AutoSize = true;
            this.lblProdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdID.Location = new System.Drawing.Point(565, 15);
            this.lblProdID.Name = "lblProdID";
            this.lblProdID.Size = new System.Drawing.Size(32, 24);
            this.lblProdID.TabIndex = 0;
            this.lblProdID.Text = "ID:";
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
            this.menuStrip1.TabIndex = 5;
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
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.AlterarToolStripMenuItem_Click);
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
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click_1);
            // 
            // tb_produtoTableAdapter
            // 
            this.tb_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gpButtons);
            this.Controls.Add(this.gpInsert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.gpButtons.ResumeLayout(false);
            this.gpInsert.ResumeLayout(false);
            this.gpInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_servicoDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpButtons;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnPosterior;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.GroupBox gpInsert;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtBoxProdNm;
        private System.Windows.Forms.Label lblProdNome;
        private System.Windows.Forms.Label lblProdDispo;
        private System.Windows.Forms.Label lblProdMarca;
        private System.Windows.Forms.Label lblProdCustom;
        private System.Windows.Forms.TextBox txtBoxPreco;
        private System.Windows.Forms.Label lblProdPreco;
        private System.Windows.Forms.ComboBox cbDisp;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbCustom;
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
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label lblProdID;
        private bd_servicoDataSet bd_servicoDataSet;
        private System.Windows.Forms.BindingSource tbprodutoBindingSource;
        private bd_servicoDataSetTableAdapters.tb_produtoTableAdapter tb_produtoTableAdapter;
    }
}