using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicos
{
    public partial class frmProduto : Form
    {
        public bool cadastrarOuAlterar = true;
        public frmProduto()
        {
            InitializeComponent();
            SplashScreen SplashScreen = new SplashScreen();

            SplashScreen.ShowDialog();
            Thread.Sleep(1);
        }

        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }
        private void habilitar()
        {
            txtBoxProdNm.Enabled = true;
            txtBoxPreco.Enabled = true;
            cbDisp.Enabled = true;
            cbMarca.Enabled = true;
            cbCustom.Enabled = true;

            btnLimpar.Enabled = true;
            btnSalvar.Enabled = true;
            btnSair.Enabled = true;

            btnCadastrar.Enabled = false;
        }
        private void desabilitar()
        {
            txtBoxProdNm.Enabled = false;
            txtBoxPreco.Enabled = false;
            cbDisp.Enabled = false;
            cbMarca.Enabled = false;
            cbCustom.Enabled = false;

            btnLimpar.Enabled = false;
            btnSalvar.Enabled = false;
            btnSair.Enabled = false;

            btnCadastrar.Enabled = true;
        }
        private void CbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbDisp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbCustom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            habilitar();
            tbprodutoBindingSource.AddNew();

            SqlConnection strcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Servicos\\Servicos\\bd_servico.mdf;Connect Timeout = 30");
            strcon.Open();
            string queryMax = "SELECT MAX(pk_produto) FROM tb_produto";
            string queryCount = "SELECT COUNT(*) FROM tb_produto";

            using (SqlCommand command = new SqlCommand(queryCount, strcon))
            {
                int recordCount = (int)command.ExecuteScalar();

                if (recordCount > 0)
                {
                    using (SqlCommand commando = new SqlCommand(queryMax, strcon))
                    {
                        object result = commando.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            int lastId = Convert.ToInt32(result) + 1;
                            txtBoxId.Text = $"{lastId}";
                        }
                        else
                        {
                            MessageBox.Show("A tabela está vazia.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    };
                }
                else
                {
                    int idPog = int.Parse(txtBoxId.Text);
                    if (idPog < 0)
                    {
                        idPog = idPog * (-1);
                    }
                    txtBoxId.Text = $"{idPog}";
                }
            }

            strcon.Close();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            tbprodutoBindingSource.CancelEdit();
            desabilitar();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenu formsSIM = new frmMenu();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void AlterarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Tsmi_Cliente_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCleiton formsSIM = new frmCleiton();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void GpInsert_Enter(object sender, EventArgs e)
        {

        }

        private void Tsmi_Produto_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmProduto formsSIM = new frmProduto();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void Tsmi_Conectest_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConectTest formsSIM = new ConectTest();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void SairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenu formsSIM = new frmMenu();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_servicoDataSet.tb_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_produtoTableAdapter.Fill(this.bd_servicoDataSet.tb_produto);

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (cadastrarOuAlterar == false)
            {
                SqlConnection strcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Servicos\\Servicos\\bd_servico.mdf;Connect Timeout = 30");

                strcon.Open();
                string cmd = "UPDATE tb_produto SET nm_produto = '" + txtBoxProdNm.Text + "', dispositivo = '" + cbDisp.SelectedItem.ToString() + "', marca = '" + cbMarca.SelectedItem.ToString() + "', custom = '" + cbCustom.SelectedItem.ToString() + "', preco = '" + int.Parse(txtBoxPreco.Text) + "' WHERE pk_produto = '" + txtBoxId.Text + "'";

                using (SqlCommand Command = new SqlCommand(cmd, strcon)) { Command.ExecuteNonQuery(); }
                strcon.Close();

                cadastrarOuAlterar = true;
                desabilitar();
            }
            else
            {
                SqlConnection strcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Servicos\\Servicos\\bd_servico.mdf;Connect Timeout = 30");

                strcon.Open();
                string cmd = "insert into tb_produto values ('" + txtBoxProdNm.Text + "', '" + cbDisp.SelectedItem.ToString() + "', '" + cbMarca.SelectedItem.ToString() + "', '" + cbCustom.SelectedItem.ToString() + "','" + int.Parse(txtBoxPreco.Text) + "')";

                using (SqlCommand Command = new SqlCommand(cmd, strcon)) { Command.ExecuteNonQuery(); }

                strcon.Close();

                desabilitar();
            }

        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            tbprodutoBindingSource.MovePrevious();
        }

        private void BtnPosterior_Click(object sender, EventArgs e)
        {
            tbprodutoBindingSource.MoveNext();
        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            tbprodutoBindingSource.MoveFirst();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            tbprodutoBindingSource.MoveLast();
        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (tbprodutoBindingSource.Count > 0)
            {
                habilitar();
                cadastrarOuAlterar = false;
            }
        }
        private void limparForms()
        {
            txtBoxProdNm.Text = "";
            cbDisp.SelectedIndex = -1;
            cbMarca.SelectedIndex = -1;
            cbCustom.SelectedIndex = -1;
            txtBoxPreco.Text = "";
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limparForms();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            SqlConnection strcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Servicos\\Servicos\\bd_servico.mdf;Connect Timeout = 30");

            strcon.Open();
            string cmd = "DELETE FROM tb_produto WHERE pk_produto = '"+ txtBoxId.Text +"'";

            using (SqlCommand Command = new SqlCommand(cmd, strcon)) { Command.ExecuteNonQuery(); }

            strcon.Close();

            desabilitar();
            limparForms();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBoxId.ReadOnly == true) // ativar modo de busca
            {
                txtBoxId.ReadOnly = false;

                btnAnterior.Enabled = false;
                btnPosterior.Enabled = false;
                btnPrimeiro.Enabled = false;
                btnUltimo.Enabled = false;

                btnLimpar.Enabled = false;
                btnSalvar.Enabled = false;
                btnSair.Enabled = false;
                btnCadastrar.Enabled = false;
                btnAlterar.Enabled = false;
                btnRemover.Enabled = false;
            }
            else // buscar pelo id
            {
                int id = int.Parse(txtBoxId.Text);

                int findPosition = tbprodutoBindingSource.Find("pk_produto", id);
                tbprodutoBindingSource.Position = findPosition;

                txtBoxId.ReadOnly = true;

                btnAnterior.Enabled = true;
                btnPosterior.Enabled = true;
                btnPrimeiro.Enabled = true;
                btnUltimo.Enabled = true;

                btnLimpar.Enabled = true;
                btnSalvar.Enabled = true;
                btnSair.Enabled = true;
                btnCadastrar.Enabled = true;
                btnAlterar.Enabled = true;
                btnRemover.Enabled = true;
            }
        }
    }
}
