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
    public partial class ConectTest : Form
    {
        public ConectTest()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Servicos\\Servicos\\bd_servico.mdf;Connect Timeout = 30";
            SqlConnection conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_cliente;", conexao);
            try
            {
                conexao.Open(); // abre a conexão com o banco 

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(); // da, adapta o banco de dados ao nosso projeto

                DataSet ds = new DataSet();

                da.SelectCommand = cmd; // adapta cmd ao projeto 

                da.Fill(ds); // preenche todas as informações dentro do 


                dgvConecview.DataSource = ds; //Datagridview recebe ds 

                dgvConecview.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Não foi possível conectar: {error.Message}");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void BtnConecprod_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Servicos\\Servicos\\bd_servico.mdf;Connect Timeout = 30";
            SqlConnection conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_produto;", conexao);
            try
            {
                conexao.Open(); // abre a conexão com o banco 

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(); // da, adapta o banco de dados ao nosso projeto

                DataSet ds = new DataSet();

                da.SelectCommand = cmd; // adapta cmd ao projeto 

                da.Fill(ds); // preenche todas as informações dentro do 


                dgvConecview.DataSource = ds; //Datagridview recebe ds 

                dgvConecview.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Não foi possível conectar: {error.Message}");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void Tsmi_Cliente_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCleiton formsSIM = new frmCleiton();
            formsSIM.ShowDialog();
            this.Visible = false;
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

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenu formsSIM = new frmMenu();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void ConectTest_Load(object sender, EventArgs e)
        {
            

        }
    }
}
