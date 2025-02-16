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
    public partial class Frm_Cadastro_Pet : Form
    {
		string conexao = ConfigurationManager.ConnectionStrings["bd_tobias_pet"].ConnectionString;

		public Frm_Cadastro_Pet()
        {
            InitializeComponent();
        }

        private void btncad_Click(object sender, EventArgs e)
        {
			try
			{
				MySqlConnection con = new MySqlConnection(conexao);

				string nome, especie, raca, porte;
				string proprietario_id, idade;


				nome = txtnome.Text;
				especie = txtesp.Text;
				raca = txtrac.Text;
				porte = txtport.Text;
				proprietario_id = txtproid.Text;
				idade = txtidade.Text;



				string sql_insert = @"insert into tb_pet
                  (
                  
					TB_PET_NOME,   
					TB_PET_ESPECIE,  
					TB_PET_PORTE,  
					TB_PET_RACA,  
					TB_PET_IDADE,  
					TB_PROPRIETARIO_ID  )  

                  values (
                  @pet_nome,
                  @pet_especie,
				  @pet_porte,
				  @pet_raca,
				  @pet_idade,
				  @pet_proprietario_id
 
                         )
                 ";

				MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

				executacmdMySql_insert.Parameters.AddWithValue("@pet_nome", nome);
				executacmdMySql_insert.Parameters.AddWithValue("@pet_especie", especie);
				executacmdMySql_insert.Parameters.AddWithValue("@pet_porte", porte);
				executacmdMySql_insert.Parameters.AddWithValue("@pet_raca", raca);
				executacmdMySql_insert.Parameters.AddWithValue("@pet_idade", idade);
				executacmdMySql_insert.Parameters.AddWithValue("@pet_proprietario_id", proprietario_id);

				con.Open();
				executacmdMySql_insert.ExecuteNonQuery();

				if (nome == string.Empty || raca == string.Empty || porte == string.Empty
					|| especie == string.Empty || idade == string.Empty || proprietario_id == string.Empty)
				{
					MessageBox.Show("Não foi possivel realizar o cadastro");
				}
				else
				{
					string sql_select_pet = "select*from tb_pet";
					MySqlCommand executacmdMySql_select_pet = new MySqlCommand(sql_select_pet, con);
					executacmdMySql_select_pet.ExecuteNonQuery();

					DataTable tabela_pet = new DataTable();
					MySqlDataAdapter da_pet = new MySqlDataAdapter(executacmdMySql_select_pet);
					da_pet.Fill(tabela_pet);

					dgv_pet.DataSource = tabela_pet;



					MessageBox.Show("Cadastrado!");
				}

				
					con.Close();
				
				// txtnome.Text=string.Empty;//
				txtnome.Text = string.Empty;
				txtesp.Text = string.Empty;
				txtidade.Text = string.Empty;
				txtport.Text = string.Empty;
				txtproid.Text = string.Empty;
				txtrac.Text = string.Empty;


			}
			catch (Exception erro)
			{
				MessageBox.Show("Erro: " + erro);


			}

		}

		

        private void Cadastro_Pet_Load(object sender, EventArgs e)
        {
			MySqlConnection con = new MySqlConnection(conexao);

			con.Open();




			string sql_select_pet = "select*from tb_pet";
			MySqlCommand executacmdMySql_select_pet = new MySqlCommand(sql_select_pet, con);
			executacmdMySql_select_pet.ExecuteNonQuery();

			DataTable tabela_pet = new DataTable();
			MySqlDataAdapter da_pet = new MySqlDataAdapter(executacmdMySql_select_pet);
			da_pet.Fill(tabela_pet);

			dgv_pet.DataSource = tabela_pet;

			//Muda o nome da tabela no dgv
			dgv_pet.Columns["tb_pet_id"].HeaderText = "ID";
			dgv_pet.Columns["tb_pet_nome"].HeaderText = "Nome";
			dgv_pet.Columns["tb_pet_especie"].HeaderText = "Especie";
			dgv_pet.Columns["tb_pet_porte"].HeaderText = "Porte";
			dgv_pet.Columns["tb_pet_raca"].HeaderText = "Raça";
			dgv_pet.Columns["tb_pet_idade"].HeaderText = "Idade";
			dgv_pet.Columns["tb_proprietario_id"].HeaderText = "ID do Proprietário";


			con.Close();
		}


		private void dgv_pet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			txtcodigo.Text = dgv_pet.CurrentRow.Cells[0].Value.ToString();
			txtnome.Text = dgv_pet.CurrentRow.Cells[1].Value.ToString();
			txtesp.Text = dgv_pet.CurrentRow.Cells[2].Value.ToString();
			txtport.Text = dgv_pet.CurrentRow.Cells[3].Value.ToString();
			txtrac.Text = dgv_pet.CurrentRow.Cells[4].Value.ToString();
			txtidade.Text = dgv_pet.CurrentRow.Cells[5].Value.ToString();
			txtproid.Text = dgv_pet.CurrentRow.Cells[6].Value.ToString();
		}




		private void btnatualizar_Click(object sender, EventArgs e)
        {
			
				int codigo;
			string nome, especie, raca, porte;
			string proprietario_id, idade;

			codigo = int.Parse(txtcodigo.Text);
			nome = txtnome.Text;
			especie = txtesp.Text;
			raca = txtrac.Text;
			porte = txtport.Text;
			proprietario_id = txtproid.Text;
			idade = txtidade.Text;

	


				MySqlConnection con = new MySqlConnection(conexao);
				con.Open();

				//variavel strig que ira receber comando sql
				string sql_update_pet = @"update tb_pet
                        set tb_pet_nome=@nome,
                tb_pet_especie=@especie, 
                    tb_pet_raca=@raca,
					 tb_pet_porte=@porte,
					tb_pet_idade=@idade,
					 tb_proprietario_id=@pet_proprietario_id
                where tb_pet_id=@id";

				MySqlCommand executacmdMySql_update_pet = new MySqlCommand(sql_update_pet, con);

			executacmdMySql_update_pet.Parameters.AddWithValue("@id", codigo);
			executacmdMySql_update_pet.Parameters.AddWithValue("@nome", nome);
			executacmdMySql_update_pet.Parameters.AddWithValue("@especie", especie);
			executacmdMySql_update_pet.Parameters.AddWithValue("@raca", raca);
			executacmdMySql_update_pet.Parameters.AddWithValue("@porte", porte);
			executacmdMySql_update_pet.Parameters.AddWithValue("@idade", idade);
			executacmdMySql_update_pet.Parameters.AddWithValue("@pet_proprietario_id", proprietario_id);


			executacmdMySql_update_pet.ExecuteNonQuery();

				string sql_select_pet = "select*from tb_pet";
				MySqlCommand executacmdMySql_select_pet = new MySqlCommand(sql_select_pet, con);
			executacmdMySql_select_pet.ExecuteNonQuery();

				DataTable tabela_pet = new DataTable();
				MySqlDataAdapter da_pet = new MySqlDataAdapter(executacmdMySql_select_pet);
			da_pet.Fill(tabela_pet);

			dgv_pet.DataSource = tabela_pet;


				MessageBox.Show("Atualização realizada com sucesso");

				con.Close();
			txtnome.Text = string.Empty;
			txtesp.Text = string.Empty;
			txtidade.Text = string.Empty;
			txtport.Text = string.Empty;
			txtproid.Text = string.Empty;
			txtrac.Text = string.Empty;
			txtcodigo.Text = string.Empty;

			}


		private void dgv_pet_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
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
				string sql_delete_procedimento = @"delete from tb_procedimento where tb_pet_id=@codigo";
				MySqlCommand executacmdMySql_delete_procedimento = new MySqlCommand(sql_delete_procedimento, con);
				executacmdMySql_delete_procedimento.Parameters.AddWithValue("@codigo", codigo);

				string sql_delete_pet = @"delete from tb_pet where tb_pet_id=@codigo";
				MySqlCommand executacmdMySql_delete_pet = new MySqlCommand(sql_delete_pet, con);
				executacmdMySql_delete_pet.Parameters.AddWithValue("@codigo", codigo);
				executacmdMySql_delete_pet.ExecuteNonQuery();
				MessageBox.Show("Cliente deletado co sucesso");

				string sql_select_pet = "select*from tb_pet";
				MySqlCommand executacmdMySql_select_pet = new MySqlCommand(sql_select_pet, con);
				executacmdMySql_select_pet.ExecuteNonQuery();

				DataTable tabela_pet = new DataTable();
				MySqlDataAdapter da_pet = new MySqlDataAdapter(executacmdMySql_select_pet);
				da_pet.Fill(tabela_pet);
				con.Close();


				dgv_pet.DataSource = tabela_pet;
			}

			else if (dialogResult == DialogResult.No)
			{
				//do something else
			}
			txtnome.Text = string.Empty;
			txtesp.Text = string.Empty;
			txtidade.Text = string.Empty;
			txtport.Text = string.Empty;
			txtproid.Text = string.Empty;
			txtrac.Text = string.Empty;
			txtcodigo.Text = string.Empty;

		}

         
    }
    }

        
