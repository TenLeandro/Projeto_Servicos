namespace Servicos
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btn_cleiton = new System.Windows.Forms.Button();
            this.btn_produto = new System.Windows.Forms.Button();
            this.btn_conecsao = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cleiton
            // 
            this.btn_cleiton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_cleiton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cleiton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_cleiton.FlatAppearance.BorderSize = 3;
            this.btn_cleiton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btn_cleiton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_cleiton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cleiton.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cleiton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cleiton.Location = new System.Drawing.Point(12, 12);
            this.btn_cleiton.Name = "btn_cleiton";
            this.btn_cleiton.Size = new System.Drawing.Size(221, 70);
            this.btn_cleiton.TabIndex = 0;
            this.btn_cleiton.Text = "CLEITOON";
            this.btn_cleiton.UseVisualStyleBackColor = false;
            this.btn_cleiton.Click += new System.EventHandler(this.Btn_cleiton_Click);
            // 
            // btn_produto
            // 
            this.btn_produto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_produto.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_produto.FlatAppearance.BorderSize = 3;
            this.btn_produto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btn_produto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produto.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_produto.Location = new System.Drawing.Point(12, 88);
            this.btn_produto.Name = "btn_produto";
            this.btn_produto.Size = new System.Drawing.Size(221, 70);
            this.btn_produto.TabIndex = 1;
            this.btn_produto.Text = "PRODUTO";
            this.btn_produto.UseVisualStyleBackColor = false;
            this.btn_produto.Click += new System.EventHandler(this.Btn_produto_Click);
            // 
            // btn_conecsao
            // 
            this.btn_conecsao.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_conecsao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_conecsao.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_conecsao.FlatAppearance.BorderSize = 3;
            this.btn_conecsao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btn_conecsao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_conecsao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conecsao.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conecsao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_conecsao.Location = new System.Drawing.Point(12, 164);
            this.btn_conecsao.Name = "btn_conecsao";
            this.btn_conecsao.Size = new System.Drawing.Size(221, 70);
            this.btn_conecsao.TabIndex = 3;
            this.btn_conecsao.Text = "CONEXÃO";
            this.btn_conecsao.UseVisualStyleBackColor = false;
            this.btn_conecsao.Click += new System.EventHandler(this.Btn_conecsao_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_sair.FlatAppearance.BorderSize = 3;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sair.Location = new System.Drawing.Point(12, 240);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(221, 70);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "FECHAR";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(245, 319);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_conecsao);
            this.Controls.Add(this.btn_produto);
            this.Controls.Add(this.btn_cleiton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cleiton;
        private System.Windows.Forms.Button btn_produto;
        private System.Windows.Forms.Button btn_conecsao;
        private System.Windows.Forms.Button btn_sair;
    }
}

