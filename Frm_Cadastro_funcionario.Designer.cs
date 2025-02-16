
namespace PetShop
{
    partial class Frm_Cadastro_funcionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastro_funcionario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtend = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncad = new System.Windows.Forms.Button();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.dgvfuncionario = new System.Windows.Forms.DataGridView();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnapagar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Funcionários";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite seu nome";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(321, 99);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(189, 20);
            this.txtnome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Digite sua data de contratação";
            // 
            // txtend
            // 
            this.txtend.Location = new System.Drawing.Point(370, 137);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(189, 20);
            this.txtend.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Digite seu endereço";
            // 
            // btncad
            // 
            this.btncad.BackColor = System.Drawing.Color.Sienna;
            this.btncad.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncad.Location = new System.Drawing.Point(231, 201);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(133, 33);
            this.btncad.TabIndex = 7;
            this.btncad.Text = "Cadastrar";
            this.btncad.UseVisualStyleBackColor = false;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // txtdt
            // 
            this.txtdt.Location = new System.Drawing.Point(523, 175);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(189, 20);
            this.txtdt.TabIndex = 8;
            this.txtdt.Text = "YYYY-MM-DD";
            // 
            // dgvfuncionario
            // 
            this.dgvfuncionario.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvfuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfuncionario.Location = new System.Drawing.Point(197, 269);
            this.dgvfuncionario.Name = "dgvfuncionario";
            this.dgvfuncionario.Size = new System.Drawing.Size(441, 180);
            this.dgvfuncionario.TabIndex = 9;
            this.dgvfuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfuncionario_CellClick);
            this.dgvfuncionario.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvfuncionario_CellMouseClick_1);
            // 
            // btnatualizar
            // 
            this.btnatualizar.BackColor = System.Drawing.Color.Sienna;
            this.btnatualizar.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizar.Location = new System.Drawing.Point(377, 201);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(133, 33);
            this.btnatualizar.TabIndex = 10;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = false;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            this.btnatualizar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnatualizar_MouseClick_1);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(226, 65);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(189, 20);
            this.txtcodigo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BurlyWood;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Código";
            // 
            // btnapagar
            // 
            this.btnapagar.BackColor = System.Drawing.Color.Sienna;
            this.btnapagar.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapagar.Location = new System.Drawing.Point(516, 201);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(133, 33);
            this.btnapagar.TabIndex = 13;
            this.btnapagar.Text = "Excluir";
            this.btnapagar.UseVisualStyleBackColor = false;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.BurlyWood;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(253, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Funcionários Cadastrados";
            // 
            // Frm_Cadastro_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.dgvfuncionario);
            this.Controls.Add(this.txtdt);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.txtend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Cadastro_funcionario";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Frm_Cadastro_Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.DataGridView dgvfuncionario;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnapagar;
        private System.Windows.Forms.Label label7;
    }
}