using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd_loja
{
    public partial class Login : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_loja"].ConnectionString;

        public Login()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string email, senha;

                email = txtemail.Text;
                senha = txtsenha.Text;

                string sql = @"select * from tb_usuarios where email = @email and senha = @senha";

                MySqlCommand executacmd = new MySqlCommand(sql, con);

                executacmd.Parameters.AddWithValue("@email", email);
                executacmd.Parameters.AddWithValue("@senha", senha);

                con.Open();

                MySqlDataReader dr = executacmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Bem vindos ao sistema");
                }
                else
                {
                    MessageBox.Show("Dados incorretos, tente novamente");
                }
                con.Close();
            }
            catch (Exception erro)

            {
                MessageBox.Show("Ocorreu o erro:" + erro);

            }
        }
    }
    }

