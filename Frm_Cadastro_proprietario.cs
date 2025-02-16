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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PetShop
{
	public partial class Frm_Cadastro_proprietario : Form
	{
		string conexao = ConfigurationManager.ConnectionStrings["bd_tobias_pet"].ConnectionString;


		public Frm_Cadastro_proprietario()
		{
			InitializeComponent();
		}

		private void Btncadcli_Click(object sender, EventArgs e)
		{
			try
			{
				MySqlConnection con = new MySqlConnection(conexao);

				string nome;
				string telefone;
				string email;
				string endereco;

				nome = txtnome.Text;
				telefone = txttelefone.Text;
				email = txtemail.Text;
				endereco = txtendereco.Text;




				string sql_insert = @"insert into tb_proprietario
                  (
                  
					TB_PROPRIETARIO_NOME,
					TB_PROPRIETARIO_TELEFONE,
					TB_PROPRIETARIO_ENDERECO,
					TB_PROPRIETARIO_EMAIL  )  

                  values (
                  @proprietario_nome,
                  @proprietario_tel,
				  @proprietario_endereco,
                  @proprietario_email
 
                         )
                 ";

				MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

				executacmdMySql_insert.Parameters.AddWithValue("@proprietario_nome", nome);
				executacmdMySql_insert.Parameters.AddWithValue("@proprietario_tel", telefone);
				executacmdMySql_insert.Parameters.AddWithValue("@proprietario_endereco", endereco);
				executacmdMySql_insert.Parameters.AddWithValue("@proprietario_email", email);


				con.Open();
				executacmdMySql_insert.ExecuteNonQuery();

				if (nome == string.Empty || email == string.Empty || telefone == string.Empty || endereco == string.Empty)
				{
					MessageBox.Show("Não foi possivel realizar o cadastro");
				}
				else
				{
					string sql_select_proprietario = "select*from tb_proprietario";
					MySqlCommand executacmdMySql_select_proprietario = new MySqlCommand(sql_select_proprietario, con);
					executacmdMySql_select_proprietario.ExecuteNonQuery();

					DataTable tabela_proprietario = new DataTable();
					MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_proprietario);
					da_cliente.Fill(tabela_proprietario);



					dgv_proprietario.DataSource = tabela_proprietario;


					MessageBox.Show("Cadastrado!");
				}

				

				con.Close();
				
				txtnome.Text = string.Empty;
				txttelefone.Text = string.Empty;
				txtendereco.Text = string.Empty;
				txtemail.Text = string.Empty;

			}
			catch (Exception erro)
			{
				MessageBox.Show("Erro: " + erro);


			}

		}

		   private void Frm_Cadastro_proprietario_Load_1(object sender, EventArgs e)
        {

			MySqlConnection con = new MySqlConnection(conexao);

			con.Open();

			string sql_select_proprietario = "select*from tb_proprietario";
			MySqlCommand executacmdMySql_select_proprietario = new MySqlCommand(sql_select_proprietario, con);
			executacmdMySql_select_proprietario.ExecuteNonQuery();

			DataTable tabela_proprietario = new DataTable();
			MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_proprietario);
			da_cliente.Fill(tabela_proprietario);

			dgv_proprietario.DataSource = tabela_proprietario;


			//Muda o nome da tabela no dgv
			dgv_proprietario.Columns["tb_proprietario_id"].HeaderText = "ID";
			dgv_proprietario.Columns["tb_proprietario_nome"].HeaderText = "Nome";
			dgv_proprietario.Columns["tb_proprietario_telefone"].HeaderText = "Telefone";
			dgv_proprietario.Columns["tb_proprietario_endereco"].HeaderText = "Endereço";
			dgv_proprietario.Columns["tb_proprietario_email"].HeaderText = "Email";







			con.Close();
		}

		private void dgv_proprietario_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			txtcodigo.Text = dgv_proprietario.CurrentRow.Cells[0].Value.ToString();
			txtnome.Text = dgv_proprietario.CurrentRow.Cells[1].Value.ToString();
			txttelefone.Text = dgv_proprietario.CurrentRow.Cells[2].Value.ToString();
			txtendereco.Text = dgv_proprietario.CurrentRow.Cells[3].Value.ToString();
			txtemail.Text = dgv_proprietario.CurrentRow.Cells[4].Value.ToString();

      

		}


		
	
		

        private void btnatualizar_Click(object sender, EventArgs e)
        {
			int codigo;
			string nome, telefone, email, endereco;

			codigo = int.Parse(txtcodigo.Text);
			nome = txtnome.Text;
			telefone = txttelefone.Text;
			email = txtemail.Text;
			endereco = txtendereco.Text;


			MySqlConnection con = new MySqlConnection(conexao);
			con.Open();

			//variavel strig que ira receber comando sql
			string sql_update_proprietario = @"update tb_proprietario
                        set tb_proprietario_nome=@nome,
                tb_proprietario_telefone=@telefone, 
                    tb_proprietario_endereco=@endereco,
					 tb_proprietario_email=@email
                where tb_proprietario_id=@id";

			MySqlCommand executacmdMySql_update_proprietario = new MySqlCommand(sql_update_proprietario, con);

			executacmdMySql_update_proprietario.Parameters.AddWithValue("@id", codigo);
			executacmdMySql_update_proprietario.Parameters.AddWithValue("@nome", nome);
			executacmdMySql_update_proprietario.Parameters.AddWithValue("@telefone", telefone);
			executacmdMySql_update_proprietario.Parameters.AddWithValue("@endereco", endereco);
			executacmdMySql_update_proprietario.Parameters.AddWithValue("@email", email);
			executacmdMySql_update_proprietario.ExecuteNonQuery();

			string sql_select_proprietario = "select*from tb_proprietario";
			MySqlCommand executacmdMySql_select_proprietario = new MySqlCommand(sql_select_proprietario, con);
			executacmdMySql_select_proprietario.ExecuteNonQuery();

			DataTable tabela_proprietario = new DataTable();
			MySqlDataAdapter da_proprietario = new MySqlDataAdapter(executacmdMySql_select_proprietario);
			da_proprietario.Fill(tabela_proprietario);

			dgv_proprietario.DataSource = tabela_proprietario;


			MessageBox.Show("Atualização realizada com sucesso");

			con.Close();
			txtnome.Text = string.Empty;
			txttelefone.Text = string.Empty;
			txtemail.Text = string.Empty;
			txtendereco.Text = string.Empty;
			txtcodigo.Text = string.Empty;

		}

        private void dgv_proprietario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
			btncadcli.Enabled = false;

		}

        private void btnatualizar_MouseClick(object sender, MouseEventArgs e)
        {
			btncadcli.Enabled = true;
		}

        private void btnexcluir_Click(object sender, EventArgs e)
        {
				string codigo;
				codigo = (txtcodigo.Text);


				if (txtcodigo.Text == String.Empty)
				{
					MessageBox.Show("Não é possivel apagar campos vazios");
				}





				DialogResult dialogResult = MessageBox.Show("Deseja Apagar?", "Deseja Apagar?", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					MySqlConnection con = new MySqlConnection(conexao);
					con.Open();

				string sql_delete_pet = @"delete from tb_pet where tb_proprietario_id=@codigo";
				MySqlCommand executacmdMySql_delete_pet = new MySqlCommand(sql_delete_pet, con);
				executacmdMySql_delete_pet.Parameters.AddWithValue("@codigo", codigo);
				executacmdMySql_delete_pet.ExecuteNonQuery();

				string sql_delete_proprietario = @"delete from tb_proprietario where tb_proprietario_id=@codigo";
					MySqlCommand executacmdMySql_delete_proprietario = new MySqlCommand(sql_delete_proprietario, con);
				executacmdMySql_delete_proprietario.Parameters.AddWithValue("@codigo", codigo);
				executacmdMySql_delete_proprietario.ExecuteNonQuery();
				MessageBox.Show("Cliente deletado co sucesso");

				string sql_select_proprietario = "select*from tb_proprietario";
					MySqlCommand executacmdMySql_select_proprietario = new MySqlCommand(sql_select_proprietario, con);
				executacmdMySql_select_proprietario.ExecuteNonQuery();

					DataTable tabela_proprietario = new DataTable();
					MySqlDataAdapter da_proprietario = new MySqlDataAdapter(executacmdMySql_select_proprietario);
				da_proprietario.Fill(tabela_proprietario);
					con.Close();


				dgv_proprietario.DataSource = tabela_proprietario;
				}

				else if (dialogResult == DialogResult.No)
				{
					//do something else
				}

			txtnome.Text = string.Empty;
			txttelefone.Text = string.Empty;
			txtemail.Text = string.Empty;
			txtendereco.Text = string.Empty;
			txtcodigo.Text = string.Empty;
		}


		}
	}

 

