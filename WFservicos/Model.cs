using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;
using System.Data;

namespace WFservicos
{
    class Model
    {
        MySqlConnection conecta = new MySqlConnection();
        public MySqlDataReader resultado;
        public Int32 conta = 0;

        public void Runsql(string sql)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = sql;
                comando.Connection = conecta;
                comando.ExecuteNonQuery(); //executa o comando sql passado pelo parametro do metodo                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Execsql(string sql)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = sql;
            comando.Connection = conecta;

            resultado = comando.ExecuteReader();
        }


        public void ExecuteScalar(string sql)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = sql;
                comando.Connection = conecta;

                conta = (Int32)comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void open()
        {
            if (conecta.State == ConnectionState.Closed)
            {
                conecta.ConnectionString = ("Server=localhost;Database=bd_servicos;User=root;Pwd=");
                conecta.Open();
            }
        }

        public void close()
        {
            if (conecta.State == ConnectionState.Open)
            {
                conecta.Close();
            }
        }
    }

    public class ComboCliente
    {
        public string cli { get; set; }
        public string cod { get; set; }

        public override string ToString()
        {
            return cli;
        }
    }

    public class Dados
    {
        public double TotalPago { get; set; }
        public double TotalPagar { get; set; }
    }

}
