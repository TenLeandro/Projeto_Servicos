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
    public partial class frmMenu : Form
    {
        public frmMenu()
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
        private void Btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_cleiton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCleiton formsSIM = new frmCleiton();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void Btn_produto_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmProduto formsSIM = new frmProduto();
            formsSIM.ShowDialog();
            this.Visible = false;
        }

        private void Btn_conecsao_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConectTest formsSIM = new ConectTest();
            formsSIM.ShowDialog();
            this.Visible = false;
        }
    }
}
