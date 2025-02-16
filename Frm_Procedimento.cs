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
    public partial class Frm_Procedimento : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_tobias_pet"].ConnectionString;

        public Frm_Procedimento()
        {
            InitializeComponent();
        }

        private void btncad_Click(object sender, EventArgs e)
        {
			try
			{
				MySqlConnection con = new MySqlConnection(conexao);

				string dth, desc, val, func_id, pet_id;
				


				dth = txtdth.Text;
				desc = txtdesc.Text;
				val = txtval.Text;
				func_id = txtfunc_id.Text;
				pet_id = txtpet_id.Text;
			



				string sql_insert = @"insert into tb_procedimento
                  (
                  
					TB_PROCEDIMENTO_DT,  
					TB_PROCEDIMENTO_DESC,  
					TB_PROCEDIMENTO_VALOR,  
					TB_PET_ID, 
					TB_FUNCIONARIO_ID )  

                  values (
                  @procedimento_dt,
                  @procedimento_desc,
				  @procedimento_valor,
				  @procedimento_pet_id,
				  @procedimento_funcionario_id
				 
 
                         )
                 ";

				MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

				executacmdMySql_insert.Parameters.AddWithValue("@procedimento_dt", dth);
				executacmdMySql_insert.Parameters.AddWithValue("@procedimento_desc", desc);
				executacmdMySql_insert.Parameters.AddWithValue("@procedimento_valor", val);
				executacmdMySql_insert.Parameters.AddWithValue("@procedimento_pet_id", pet_id);
				executacmdMySql_insert.Parameters.AddWithValue("@procedimento_funcionario_id", func_id);
				

				con.Open();
				executacmdMySql_insert.ExecuteNonQuery();

				if (val == string.Empty || desc == string.Empty || pet_id == string.Empty
					|| func_id == string.Empty || dth == string.Empty)
				{
					MessageBox.Show("Não foi possivel realizar o cadastro");
				}
				else
				{
					string sql_select_procedimento = "select*from tb_procedimento";
					MySqlCommand executacmdMySql_select_procedimento = new MySqlCommand(sql_select_procedimento, con);
					executacmdMySql_select_procedimento.ExecuteNonQuery();

					DataTable tabela_procedimento = new DataTable();
					MySqlDataAdapter da_procedimento = new MySqlDataAdapter(executacmdMySql_select_procedimento);
					da_procedimento.Fill(tabela_procedimento);

					dgv_procedimento.DataSource = tabela_procedimento;

					MessageBox.Show("Cadastrado!");
				}

				


				con.Close();
				
				// txtnome.Text=string.Empty;//
				txtval.Text = string.Empty;
				txtpet_id.Text = string.Empty;
				txtfunc_id.Text = string.Empty;
				txtdth.Text = txtdth.Text = ("YYYY - MM - DD HH:MM:SS"); 
				txtdesc.Text = string.Empty;
				 


			}
			catch (Exception erro)
			{
				MessageBox.Show("Erro: " + erro);


			}

		}

		 

        private void Frm_Procedimento_Load_1(object sender, EventArgs e)
        {
			MySqlConnection con = new MySqlConnection(conexao);

			con.Open();

			string sql_select_procedimento = "select*from tb_procedimento";
			MySqlCommand executacmdMySql_select_procedimento = new MySqlCommand(sql_select_procedimento, con);
			executacmdMySql_select_procedimento.ExecuteNonQuery();

			DataTable tabela_procedimento = new DataTable();
			MySqlDataAdapter da_procedimento = new MySqlDataAdapter(executacmdMySql_select_procedimento);
			da_procedimento.Fill(tabela_procedimento);

			dgv_procedimento.DataSource = tabela_procedimento;


			//Muda o nome da tabela no dgv
			dgv_procedimento.Columns["tb_procedimento_id"].HeaderText = "ID";
			dgv_procedimento.Columns["tb_procedimento_dt"].HeaderText = "Data e Hora do Procedimento";
			dgv_procedimento.Columns["tb_procedimento_desc"].HeaderText = "Descrição";
			dgv_procedimento.Columns["tb_procedimento_valor"].HeaderText = "Valor";
			dgv_procedimento.Columns["tb_funcionario_id"].HeaderText = "ID do Funcionário";
			dgv_procedimento.Columns["tb_pet_id"].HeaderText = "ID do Pet";



			con.Close();
		}

		private void dgv_procedimento_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtcodigo.Text = dgv_procedimento.CurrentRow.Cells[0].Value.ToString();
			txtdth.Text = dgv_procedimento.CurrentRow.Cells[1].Value.ToString();
			txtdesc.Text = dgv_procedimento.CurrentRow.Cells[2].Value.ToString();
			txtval.Text = dgv_procedimento.CurrentRow.Cells[3].Value.ToString();
			txtfunc_id.Text = dgv_procedimento.CurrentRow.Cells[5].Value.ToString();
			txtpet_id.Text = dgv_procedimento.CurrentRow.Cells[4].Value.ToString();
			
			
		}

		 




		private void btnatualizar_Click(object sender, EventArgs e)
        {

				int codigo;
			string dth, desc, val, func_id, pet_id;

			codigo = int.Parse(txtcodigo.Text);
			dth = txtdth.Text;
			desc = txtdesc.Text;
			val = txtval.Text;
			func_id = txtfunc_id.Text;
			pet_id = txtpet_id.Text;



				MySqlConnection con = new MySqlConnection(conexao);
				con.Open();

				//variavel strig que ira receber comando sql
				string sql_update_procedimento = @"update tb_procedimento
                        set tb_procedimento_dt=@dt,
                tb_procedimento_desc=@desc, 
                    tb_procedimento_valor=@valor,
					 tb_funcionario_id=@procedimento_funcionario_id,
					 tb_pet_id=@procedimento_pet_id
                where tb_procedimento_id=@id";

				MySqlCommand executacmdMySql_update_procedimento = new MySqlCommand(sql_update_procedimento, con);

			executacmdMySql_update_procedimento.Parameters.AddWithValue("@id", codigo);
			executacmdMySql_update_procedimento.Parameters.AddWithValue("@dt", dth);
			executacmdMySql_update_procedimento.Parameters.AddWithValue("@desc", desc);
			executacmdMySql_update_procedimento.Parameters.AddWithValue("@valor", val);
			executacmdMySql_update_procedimento.Parameters.AddWithValue("@procedimento_funcionario_id", func_id);
			executacmdMySql_update_procedimento.Parameters.AddWithValue("@procedimento_pet_id", pet_id);


			executacmdMySql_update_procedimento.ExecuteNonQuery();

				string sql_select_procedimento = "select*from tb_procedimento";
				MySqlCommand executacmdMySql_select_procedimento = new MySqlCommand(sql_select_procedimento, con);
			executacmdMySql_select_procedimento.ExecuteNonQuery();

				DataTable tabela_procedimento = new DataTable();
				MySqlDataAdapter da_procedimento = new MySqlDataAdapter(executacmdMySql_select_procedimento);
			da_procedimento.Fill(tabela_procedimento);

			dgv_procedimento.DataSource = tabela_procedimento;


				MessageBox.Show("Atualização realizada com sucesso");

				con.Close();
					txtval.Text = string.Empty;
				txtpet_id.Text = string.Empty;
				txtfunc_id.Text = string.Empty;
			txtdth.Text = ("YYYY - MM - DD HH:MM:SS");
				txtdesc.Text = string.Empty;
			txtcodigo.Text = string.Empty;

			}


			 

			 

        private void dgv_procedimento_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
			btncad.Enabled = false;
        }

        private void btnatualizar_MouseClick(object sender, MouseEventArgs e)
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
				string sql_delete_procedimento = @"delete from tb_procedimento where tb_procedimento_id=@codigo";
				MySqlCommand executacmdMySql_delete_procedimento = new MySqlCommand(sql_delete_procedimento, con);
				executacmdMySql_delete_procedimento.Parameters.AddWithValue("@codigo", codigo);
				executacmdMySql_delete_procedimento.ExecuteNonQuery();
				MessageBox.Show("Cliente deletado co sucesso");

				string sql_select_procedimento = "select*from tb_procedimento";
				MySqlCommand executacmdMySql_select_procedimento = new MySqlCommand(sql_select_procedimento, con);
				executacmdMySql_select_procedimento.ExecuteNonQuery();

				DataTable tabela_procedimento = new DataTable();
				MySqlDataAdapter da_procedimento = new MySqlDataAdapter(executacmdMySql_select_procedimento);
				da_procedimento.Fill(tabela_procedimento);
				con.Close();


				dgv_procedimento.DataSource = tabela_procedimento;
			}

			else if (dialogResult == DialogResult.No)
			{
				//do something else
			}
			txtval.Text = string.Empty;
			txtpet_id.Text = string.Empty;
			txtfunc_id.Text = string.Empty;
			txtdth.Text = ("YYYY - MM - DD HH:MM:SS");
			txtdesc.Text = string.Empty;
			txtcodigo.Text = string.Empty;
		}
    }
    }

        

        
