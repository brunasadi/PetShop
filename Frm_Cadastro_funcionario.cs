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
	public partial class Frm_Cadastro_funcionario : Form
	{
		
		string conexao = ConfigurationManager.ConnectionStrings["bd_tobias_pet"].ConnectionString;
		public Frm_Cadastro_funcionario()
		{
			InitializeComponent();
		}

		private void btncad_Click(object sender, EventArgs e)
		{

			try
			{
				MySqlConnection con = new MySqlConnection(conexao);

				string nome;
				string endereco;
				string dtcontrat;

				nome = txtnome.Text;
				endereco = txtend.Text;
				dtcontrat =txtdt.Text;




				string sql_insert = @"insert into tb_funcionario
                  (
                  
					TB_FUNCIONARIO_NOME,  
					TB_FUNCIONARIO_ENDERECO,  
					TB_FUNCIONARIO_DT_CONT  )  

                  values (
                  @funcionario_nome,
                  @funcionario_endereco,
				  @funcionario_dt_cont
                  
 
                         )
                 ";

				MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

				executacmdMySql_insert.Parameters.AddWithValue("@funcionario_nome", nome);
				executacmdMySql_insert.Parameters.AddWithValue("@funcionario_endereco", endereco);
				executacmdMySql_insert.Parameters.AddWithValue("@funcionario_dt_cont", dtcontrat);


				con.Open();
				executacmdMySql_insert.ExecuteNonQuery();
				if (nome == string.Empty || endereco == string.Empty || dtcontrat == string.Empty)
				{
					MessageBox.Show("Não foi possivel realizar o cadastro");
				}
				else
				{

					string sql_select_funcionario = "select*from tb_funcionario";
					MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
					executacmdMySql_select_funcionario.ExecuteNonQuery();

					DataTable tabela_funcionario = new DataTable();
					MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
					da_funcionario.Fill(tabela_funcionario);

					dgvfuncionario.DataSource = tabela_funcionario;

					MessageBox.Show("Cadastrado!");
				}



				con.Close();
				
				// txtnome.Text=string.Empty;//
				txtnome.Text = string.Empty;
				txtend.Text = string.Empty;
				txtdt.Text = ("YYYY - MM - DD");

			}
			catch (Exception erro)
			{
				MessageBox.Show("Erro: " + erro);


			}

		}

		
			
private void Frm_Cadastro_Funcionario_Load(object sender, EventArgs e)
        {
			MySqlConnection con = new MySqlConnection(conexao);

			con.Open();

			string sql_select_funcionario = "select*from tb_funcionario";
			MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
			executacmdMySql_select_funcionario.ExecuteNonQuery();

			DataTable tabela_funcionario = new DataTable();
			MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
			da_funcionario.Fill(tabela_funcionario);

			dgvfuncionario.DataSource = tabela_funcionario;


			//Muda o nome da tabela no dgv
			dgvfuncionario.Columns["tb_funcionario_id"].HeaderText = "ID";
			dgvfuncionario.Columns["tb_funcionario_nome"].HeaderText = "Nome";
			dgvfuncionario.Columns["tb_funcionario_endereco"].HeaderText = "Endereço";
			dgvfuncionario.Columns["tb_funcionario_dt_cont"].HeaderText = "Data de Contratação";
			



			con.Close();
		}



	
			private void dgvfuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
			{
			txtcodigo.Text = dgvfuncionario.CurrentRow.Cells[0].Value.ToString();
			txtnome.Text = dgvfuncionario.CurrentRow.Cells[1].Value.ToString();
			txtend.Text = dgvfuncionario.CurrentRow.Cells[2].Value.ToString();
			txtdt.Text = dgvfuncionario.CurrentRow.Cells[3].Value.ToString();
			
			}
		
		



		private void btnatualizar_Click(object sender, EventArgs e)
        {
			int codigo;
			string nome;
			string endereco;
			string dtcontrat;

			codigo = int.Parse(txtcodigo.Text);
		

			nome = txtnome.Text;
			endereco = txtend.Text;
			dtcontrat = txtdt.Text;


			MySqlConnection con = new MySqlConnection(conexao);
			con.Open();

			//variavel strig que ira receber comando sql
			string sql_update_funcionario = @"update tb_funcionario
                        set tb_funcionario_nome=@nome,
                    tb_funcionario_endereco=@endereco,
					 tb_funcionario_dt_cont=@funcionario_dt_cont
                where tb_funcionario_id=@id";

			MySqlCommand executacmdMySql_update_funcionario = new MySqlCommand(sql_update_funcionario, con);

			executacmdMySql_update_funcionario.Parameters.AddWithValue("@id", codigo);
			executacmdMySql_update_funcionario.Parameters.AddWithValue("@nome", nome);
			executacmdMySql_update_funcionario.Parameters.AddWithValue("@endereco", endereco);
			executacmdMySql_update_funcionario.Parameters.AddWithValue("@funcionario_dt_cont", dtcontrat);
			executacmdMySql_update_funcionario.ExecuteNonQuery();

			string sql_select_funcionario = "select*from tb_funcionario";
			MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
			executacmdMySql_select_funcionario.ExecuteNonQuery();

			DataTable tabela_funcionario = new DataTable();
			MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
			da_funcionario.Fill(tabela_funcionario);

			dgvfuncionario.DataSource = tabela_funcionario;


			MessageBox.Show("Atualização realizada com sucesso");

			con.Close();
			txtnome.Text = string.Empty;
			txtend.Text = string.Empty;
			
			txtdt.Text= ("YYYY - MM - DD");
			txtcodigo.Text = string.Empty;

		}








		

		 
        private void dgvfuncionario_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
			btncad.Enabled = false;
		}

        private void btnatualizar_MouseClick_1(object sender, MouseEventArgs e)
        {
			btncad.Enabled = true;
		}

        private void btnapagar_Click(object sender, EventArgs e)
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
				string sql_delete_procedimento = @"delete from tb_procedimento where tb_funcionario_id=@codigo";
				MySqlCommand executacmdMySql_delete_procedimento = new MySqlCommand(sql_delete_procedimento, con);
				executacmdMySql_delete_procedimento.Parameters.AddWithValue("@codigo", codigo);
				executacmdMySql_delete_procedimento.ExecuteNonQuery();

				string sql_delete_funcionario = @"delete from tb_funcionario where tb_funcionario_id=@codigo";
				MySqlCommand executacmdMySql_delete_funcionario = new MySqlCommand(sql_delete_funcionario, con);
				executacmdMySql_delete_funcionario.Parameters.AddWithValue("@codigo", codigo);
				executacmdMySql_delete_funcionario.ExecuteNonQuery();
				MessageBox.Show("Cliente deletado co sucesso");

				string sql_select_funcionario = "select*from tb_funcionario";
				MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
				executacmdMySql_select_funcionario.ExecuteNonQuery();

				DataTable tabela_funcionario = new DataTable();
				MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
				da_funcionario.Fill(tabela_funcionario);
				con.Close();


				dgvfuncionario.DataSource = tabela_funcionario;
			}

			else if (dialogResult == DialogResult.No)
			{
				//do something else
			}
			txtnome.Text = string.Empty;
			txtend.Text = string.Empty;

			txtdt.Text = ("YYYY - MM - DD");
			txtcodigo.Text = string.Empty;
		}

         
    }
    }
 
	

