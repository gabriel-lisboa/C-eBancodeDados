using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace bd_loja
{
    public partial class Form1 : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_loja"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

      

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome_fornecedor, cnpj_fornecedor, email_fornecedor, tel_fornecedor, cel_fornecedor,
                    cep_fornecedor, endereco_fornecedor, complemento_fornecedor,
                    bairro_fornecedor, cidade_fornecedor, estado_fornecedor;

                int numero_fornecedor;

                nome_fornecedor = txtnome.Text;
                cnpj_fornecedor = txtcnpj.Text;
                email_fornecedor = txtemail.Text;
                tel_fornecedor = txttel.Text;
                cel_fornecedor = txtcel.Text;
                cep_fornecedor = txtcep.Text;
                endereco_fornecedor = txtendereco.Text;
                complemento_fornecedor = txtcomplemento.Text;
                bairro_fornecedor = txtbairro.Text;
                cidade_fornecedor = txtcidade.Text;
                estado_fornecedor = txtestado.Text;

                numero_fornecedor = int.Parse(txtnumero.Text);


                string sql_insertinto = @"insert into fornecedores(nome_fornecedor,cnpj_fornecedor,email_fornecedor,tel_fornecedor,
                                          cel_fornecedor,cep_fornecedor, endereco_fornecedor, numero_fornecedor, complemento_fornecedor,
                                             bairro_fornecedor,cidade_fornecedor,estado_fornecedor)

                                                 values

                                               (@nome_fornecedor, @cnpj_fornecedor, @email_fornecedor, @tel_fornecedor,
                                          @cel_fornecedor, @cep_fornecedor, @endereco_fornecedor, @numero_fornecedor,@complemento_fornecedor,
                                             @bairro_fornecedor, @cidade_fornecedor, @estado_fornecedor)";

                MySqlCommand executamysqlinsert = new MySqlCommand(sql_insertinto, con);

                executamysqlinsert.Parameters.AddWithValue("@nome_fornecedor", nome_fornecedor);
                executamysqlinsert.Parameters.AddWithValue("@cnpj_fornecedor", cnpj_fornecedor);
                executamysqlinsert.Parameters.AddWithValue("@email_fornecedor", email_fornecedor);
                executamysqlinsert.Parameters.AddWithValue("@tel_fornecedor", tel_fornecedor);
                executamysqlinsert.Parameters.AddWithValue("@cel_fornecedor", cel_fornecedor);
                executamysqlinsert.Parameters.AddWithValue("@cep_fornecedor", cep_fornecedor);
                executamysqlinsert.Parameters.AddWithValue("@endereco_fornecedor", endereco_fornecedor);
                executamysqlinsert.Parameters.AddWithValue("@numero_fornecedor", numero_fornecedor);
                executamysqlinsert.Parameters.AddWithValue("@complemento_fornecedor", complemento_fornecedor );
                executamysqlinsert.Parameters.AddWithValue("@bairro_fornecedor", bairro_fornecedor );
                executamysqlinsert.Parameters.AddWithValue("@cidade_fornecedor", cidade_fornecedor);
                executamysqlinsert.Parameters.AddWithValue("@estado_fornecedor", estado_fornecedor);
                con.Open();
                executamysqlinsert.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Cadastro concluído com sucesso!!");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);
            }
        }
    }
}
