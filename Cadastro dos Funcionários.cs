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
    public partial class Form2 : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_loja"].ConnectionString;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection con = new MySqlConnection(conexao);
                string nome, rg, cpf, email, senha, cargo, nível_acesso, telefone, celular, cep, endereco, complemento, bairro, 
                    cidade, estado;

                int numero;

                nome = txtnome.Text;
                rg = txtrg.Text;
                cpf = txtcpf.Text;
                email = txtemail.Text;
                senha = txtsenha.Text;
                cargo = txtcargo.Text;
                nível_acesso = txtnivelacesso.Text;
                telefone = txttel.Text;
                celular = txtcel.Text;
                cep = txtcep.Text;
                endereco = txtendereco.Text;
                complemento = txtcomplemento.Text;
                bairro = txtbairro.Text;
                cidade = txtcidade.Text;
                estado = txtestado.Text;
                numero = int.Parse(txtnumero.Text);

                string mysql_insertinto = @"insert into funcionarios (nome_funcionario, rg_funcionario, cpf_funcionario, 
                                           email_funcionario, senha_funcionario, cargo_funcionario, nivel_acesso_funcionario,
                                           tel_funcionario, cel_funcionario, cep_funcionario, endereco_funcionario, numero_funcionario,
                                            complemento_funcionario,bairro_funcionario, cidade_funcionario, estado_funcionario)

                                                                        values

                                                 (@nome_funcionario, @rg_funcionario, @cpf_funcionario, @email_funcionario, 
                                                  @senha_funcionario, @cargo_funcionario, @nivel_acesso_funcionario,
                                                  @tel_funcionario, @cel_funcionario, @cep_funcionario, @endereco_funcionario,
                                                 @numero_funcionario, @complemento_funcionario, @bairro_funcionario,
                                                 @cidade_funcionario, @estado_funcionario)";

                MySqlCommand executainsertinto = new MySqlCommand(mysql_insertinto, con);

                executainsertinto.Parameters.AddWithValue("@nome_funcionario", nome);
                executainsertinto.Parameters.AddWithValue("@rg_funcionario", rg);
                executainsertinto.Parameters.AddWithValue("@cpf_funcionario", cpf);
                executainsertinto.Parameters.AddWithValue("@email_funcionario", email);
                executainsertinto.Parameters.AddWithValue("@senha_funcionario", senha);
                executainsertinto.Parameters.AddWithValue("@cargo_funcionario", cargo);
                executainsertinto.Parameters.AddWithValue("@nivel_acesso_funcionario", nível_acesso);
                executainsertinto.Parameters.AddWithValue("@tel_funcionario", telefone);
                executainsertinto.Parameters.AddWithValue("@cel_funcionario", celular);
                executainsertinto.Parameters.AddWithValue("@cep_funcionario", cep);
                executainsertinto.Parameters.AddWithValue("@endereco_funcionario", endereco);
                executainsertinto.Parameters.AddWithValue("@numero_funcionario", numero);
                executainsertinto.Parameters.AddWithValue("@complemento_funcionario", complemento);
                executainsertinto.Parameters.AddWithValue("@bairro_funcionario", bairro);
                executainsertinto.Parameters.AddWithValue("@cidade_funcionario", cidade);
                executainsertinto.Parameters.AddWithValue("@estado_funcionario", estado);
                con.Open();

                executainsertinto.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Cadastro efetuado com sucesso!!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro " + erro);
            }


            }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    }