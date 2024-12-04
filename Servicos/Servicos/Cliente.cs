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
    public partial class frmCleiton : Form
    {
        public bool cadastrarOuAlterar = false;
        public frmCleiton()
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
            txtBoxNmCli.Enabled = true;
            txtBoxEmail.Enabled = true;
            mtbCpf.Enabled = true;
            cbGenero.Enabled = true;

            btnAnterior.Enabled = false;
            btnPosterior.Enabled = false;
            btnPrimeiro.Enabled = false;
            btnUltimo.Enabled = false;

            btnLimpar.Enabled = true;
            btnSalvar.Enabled = true;
            btnSair.Enabled = true;

            btnCadastrar.Enabled = false;
        }
        private void desabilitar()
        {
            txtBoxNmCli.Enabled = false;
            txtBoxEmail.Enabled = false;
            mtbCpf.Enabled = false;
            cbGenero.Enabled = false;

            btnAnterior.Enabled = true;
            btnPosterior.Enabled = true;
            btnPrimeiro.Enabled = true;
            btnUltimo.Enabled = true;

            btnLimpar.Enabled = false;
            btnSalvar.Enabled = false;
            btnSair.Enabled = false;

            btnCadastrar.Enabled = true;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.CancelEdit();
            desabilitar();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenu formsSIM = new frmMenu();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            habilitar();
            tbclienteBindingSource.AddNew();

            SqlConnection strcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Servicos\\Servicos\\bd_servico.mdf;Connect Timeout = 30");
            strcon.Open();
            string queryMax = "SELECT MAX(pk_cliente) FROM tb_cliente";
            string queryCount = "SELECT COUNT(*) FROM tb_cliente";

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

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.MovePrevious();
        }

        private void BtnPosterior_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.MoveNext();
        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.MoveFirst();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (tbclienteBindingSource.Count > 0)
            {
                habilitar();
                cadastrarOuAlterar = false;
            }
        }

        private void FrmCleiton_Load(object sender, EventArgs e)
        {
            this.tb_clienteTableAdapter.Fill(this.bd_servicoDataSet.tb_cliente);

        }

        private void Tsmi_Test_Click(object sender, EventArgs e)
        {

        }

        private void GpInsert_Enter(object sender, EventArgs e)
        {

        }

        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Tsmi_Clie_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmProduto formsSIM = new frmProduto();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void Tsmi_Prod_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConectTest formsSIM = new ConectTest();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void Tsmi_Ende_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCleiton formsSIM = new frmCleiton();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (cadastrarOuAlterar == false)
            {
                SqlConnection strcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Servicos\\Servicos\\bd_servico.mdf;Connect Timeout = 30");

                strcon.Open();
                string cmd = "UPDATE tb_cliente SET nm_cliente = '" + txtBoxNmCli.Text + "', email = '" + txtBoxEmail.Text + "', cpf = '" + mtbCpf.Text.Where(char.IsDigit).ToArray() + "', gn_cliente = '" + cbGenero.SelectedItem.ToString() + "' WHERE pk_cliente = '" + txtBoxId.Text + "'";

                using (SqlCommand Command = new SqlCommand(cmd, strcon)) { Command.ExecuteNonQuery(); }
                strcon.Close();

                cadastrarOuAlterar = true;
                desabilitar();
            }
            else
            {
                SqlConnection strcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Servicos\\Servicos\\bd_servico.mdf;Connect Timeout = 30");

                strcon.Open();
                string cmd = "INSERT into tb_cliente VALUES ('" + txtBoxNmCli.Text + "', '" + txtBoxEmail.Text + "', '" + mtbCpf.Text + "', '" + cbGenero.SelectedItem.ToString() + "')";

                using (SqlCommand Command = new SqlCommand(cmd, strcon)) { Command.ExecuteNonQuery(); }

                strcon.Close();

                desabilitar();
            }
        }

        private void TxtBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.MoveLast();
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

                int findPosition = tbclienteBindingSource.Find("pk_cliente", id);
                tbclienteBindingSource.Position = findPosition;

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
        private void limparForms()
        {
            txtBoxNmCli.Text = "";
            txtBoxEmail.Text = "";
            mtbCpf.Text = "";
            txtBoxEmail.Text = "";
            cbGenero.SelectedIndex = -1;
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limparForms();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            SqlConnection strcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Servicos\\Servicos\\bd_servico.mdf;Connect Timeout = 30");

            strcon.Open();
            string cmd = "DELETE FROM tb_cliente WHERE pk_cliente = '" + txtBoxId.Text + "'";

            using (SqlCommand Command = new SqlCommand(cmd, strcon)) { Command.ExecuteNonQuery(); }

            strcon.Close();

            desabilitar();
            limparForms();
        }

        private void MtbCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
