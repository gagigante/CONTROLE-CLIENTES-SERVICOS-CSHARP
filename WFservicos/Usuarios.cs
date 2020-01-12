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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        Model model = new Model();
        string sql = "";

        public void carregaGrid()
        {
            DGusuarios.Rows.Clear();
            if (model.resultado.HasRows)
            {
                while (model.resultado.Read())
                {
                    DGusuarios.Rows.Add(
                                      model.resultado["usuario"].ToString(),
                                      model.resultado["senha"].ToString()
                                       );
                }
            }
        }

        private void BTsair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            sql = "select * from tb_login order by usuario";
            model.open();
            model.Execsql(sql);
            carregaGrid();
            model.close();

            DGusuarios.ClearSelection();
        }

        private void BTadicionar_Click(object sender, EventArgs e)
        {
            bool duplicata = false;
            if (TXTusuario.Text != "" && TXTsenha.Text != "")
            {
                sql = "select * from tb_login where usuario='"+TXTusuario.Text+"'";
                model.open();
                model.Execsql(sql);
                if (model.resultado.HasRows)
                {
                    duplicata = true;
                }
                model.close();

                if(duplicata == true)
                {
                    MessageBox.Show("Já existe um usuário com este nome");
                }
                else
                {
                    sql = "INSERT INTO `tb_login` (`usuario`, `senha`) VALUES ('" + TXTusuario.Text + "', '" + TXTsenha.Text + "');";
                    model.open();
                    model.Runsql(sql);
                    model.close();

                    sql = "select * from tb_login order by usuario";
                    model.open();
                    model.Execsql(sql);
                    carregaGrid();
                    model.close();

                    DGusuarios.ClearSelection();                    
                }

                TXTusuario.Text = "";
                TXTsenha.Text = "";

                duplicata = false;
            }
            else
            {
                MessageBox.Show("Preencha os campos");
            }
        }

        private void BTremover_Click(object sender, EventArgs e)
        {
            string cod = DGusuarios.CurrentRow.Cells[1].Value.ToString();

            if (DGusuarios.RowCount > 1)
            {

                if(MessageBox.Show(("Deseja apagar este usuário?"), "Apagar usuário", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    sql = "DELETE FROM `tb_login` WHERE  `senha`='" + cod + "';";
                    model.open();
                    model.Runsql(sql);
                    model.close();
                }                
            }
            else
            {
                MessageBox.Show("Não é possível apagar todos usuários");
            }

            sql = "select * from tb_login order by usuario";
            model.open();
            model.Execsql(sql);
            carregaGrid();
            model.close();

            DGusuarios.ClearSelection();
        }

        private void TXTusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39 || e.KeyChar == (char)34)
            {
                e.Handled = true;
            }
        }

        private void TXTsenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39 || e.KeyChar == (char)34)
            {
                e.Handled = true;
            }
        }
    }
}
