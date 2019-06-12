using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "0")
            {
                Inserir();
            }
            else
            {
                Alterar();
            }
        }

        private void Alterar()
        {
            Carro carro = new Carro();
            carro.Id = Convert.ToInt32(lblId.Text);
            carro.Modelo = txtModelo.Text;
            carro.Cor = cbCor.SelectedItem.ToString();
            carro.Ano = Convert.ToInt32(nudAno.Value);
            carro.Preco = Convert.ToDecimal(mtbPreco.Text);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Eduardo.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE carros SET modelo = @MODELO, cor = @COR, ano = @ANO, preco = @PRECO WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", carro.Id);
            comando.Parameters.AddWithValue("@COR", carro.Cor);
            comando.Parameters.AddWithValue("@MODELO", carro.Modelo);
            comando.Parameters.AddWithValue("@ANO", carro.Ano);
            comando.Parameters.AddWithValue("@PRECO", carro.Preco);
            comando.ExecuteNonQuery();
            conexao.Close();
            AtualizarTabela();
            LimparCampos();
        }

        private void Inserir()
        {
            Carro carro = new Carro();
            carro.Modelo = txtModelo.Text;
            carro.Ano = Convert.ToInt32(nudAno.Value);
            carro.Preco = Convert.ToDecimal(mtbPreco.Text);
            carro.Cor = cbCor.SelectedItem.ToString();

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Eduardo.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO carros (modelo, ano, preco, cor) VALUES (@MODELO, @ANO, @PRECO, @COR)";
            comando.Parameters.AddWithValue("@MODELO", carro.Modelo);
            comando.Parameters.AddWithValue("@ANO", carro.Ano);
            comando.Parameters.AddWithValue("@PRECO", carro.Preco);
            comando.Parameters.AddWithValue("@COR", carro.Cor);
            comando.ExecuteNonQuery();

            MessageBox.Show("Registro criado com sucesso");
            LimparCampos();
            conexao.Close();
            AtualizarTabela();

        }

        private void LimparCampos()
        {
            lblId.Text = " 0";
            txtModelo.Clear();
            nudAno.Value = DateTime.Now.Year;
            cbCor.SelectedIndex = -1;
            mtbPreco.Clear();
        }

        private void AtualizarTabela()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Eduardo.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT id, modelo, cor, preco, ano FROM carros";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            dataGridView1.RowCount = 0;
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linhas = tabela.Rows[i];
                Carro carro = new Carro();
                carro.Id = Convert.ToInt32(linhas["id"]);
                carro.Modelo = linhas["modelo"].ToString();
                carro.Cor = linhas["cor"].ToString();
                carro.Preco = Convert.ToDecimal(linhas["preco"]);
                carro.Ano = Convert.ToInt32(linhas["ano"]);
                dataGridView1.Rows.Add(new string[]{
                    carro.Id.ToString(), carro.Modelo, carro.Cor, carro.Preco.ToString(), carro.Ano.ToString()
                });
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cadastre um carro");
                return;
            }

            DialogResult caixaDialogo = MessageBox.Show("Desejá realmente apagar?", "AVISO", MessageBoxButtons.YesNo);

            if (caixaDialogo == DialogResult.Yes)
            {

                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Eduardo.mdf;Integrated Security=True;Connect Timeout=30";
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "DELETE FROM carros WHERE id = @ID";

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();

                conexao.Close();
                AtualizarTabela();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Eduardo.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.CommandText = @"SELECT id, modelo, cor, preco, ano FROM carros WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.Connection = conexao;

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            DataRow linha = tabela.Rows[0];
            Carro carro = new Carro();
            carro.Id = Convert.ToInt32(linha["id"]);
            carro.Modelo = linha["modelo"].ToString();
            carro.Cor = linha["cor"].ToString();
            carro.Preco = Convert.ToDecimal(linha["preco"]);
            carro.Ano = Convert.ToInt32(linha["ano"]);

            lblId.Text = carro.Id.ToString();
            txtModelo.Text = carro.Modelo;
            cbCor.SelectedItem = carro.Cor;
            nudAno.Value = carro.Ano;
            mtbPreco.Text = carro.Preco.ToString();

            conexao.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}
