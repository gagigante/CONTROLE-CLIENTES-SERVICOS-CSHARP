using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFservicos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Model model = new Model();
        string sql = "";

        public void VerificaUsuario()
        {
            if (TXTusuario.Text != string.Empty && TXTsenha.Text != string.Empty)
            {
                sql = "select * from tb_login where usuario = '" + TXTusuario.Text + "' and senha = '" + TXTsenha.Text + "'";
                model.open();
                model.Execsql(sql);

                if (model.resultado.HasRows)
                {
                    this.Hide();
                    Home ini = new Home();
                    ini.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos");
                }
                model.close();
            }
            else
            {
                MessageBox.Show("Preencha os campos");
            }
        }

        private void BTsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTentrar_Click(object sender, EventArgs e)
        {
            VerificaUsuario();
        }

        private void TXTusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39 || e.KeyChar == (char)34)
            {
                e.Handled = true;
            }
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                VerificaUsuario();
            }
        }

        private void TXTsenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39 || e.KeyChar == (char)34)
            {
                e.Handled = true;
            }
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                VerificaUsuario();
            }
        }
    }
}
