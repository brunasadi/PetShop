
namespace PetShop
{
    partial class Frm_Procedimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Procedimento));
            this.label1 = new System.Windows.Forms.Label();
            this.txtval = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpet_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfunc_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btncad = new System.Windows.Forms.Button();
            this.dgv_procedimento = new System.Windows.Forms.DataGridView();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnapagar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_procedimento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Procedimentos";
            // 
            // txtval
            // 
            this.txtval.Location = new System.Drawing.Point(333, 147);
            this.txtval.Name = "txtval";
            this.txtval.Size = new System.Drawing.Size(189, 20);
            this.txtval.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BurlyWood;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Valor do procedimento";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(369, 118);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(189, 20);
            this.txtdesc.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(348, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Descrição do Procedimento";
            // 
            // txtdth
            // 
            this.txtdth.Location = new System.Drawing.Point(407, 96);
            this.txtdth.Name = "txtdth";
            this.txtdth.Size = new System.Drawing.Size(189, 20);
            this.txtdth.TabIndex = 20;
            this.txtdth.Text = "YYYY-MM-DD HH:MM:SS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Data e Hora do procedimento";
            // 
            // txtpet_id
            // 
            this.txtpet_id.Location = new System.Drawing.Point(252, 202);
            this.txtpet_id.Name = "txtpet_id";
            this.txtpet_id.Size = new System.Drawing.Size(189, 20);
            this.txtpet_id.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Digite o id do pet";
            // 
            // txtfunc_id
            // 
            this.txtfunc_id.Location = new System.Drawing.Point(353, 176);
            this.txtfunc_id.Name = "txtfunc_id";
            this.txtfunc_id.Size = new System.Drawing.Size(189, 20);
            this.txtfunc_id.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BurlyWood;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Digite o id do funcionário";
            // 
            // btncad
            // 
            this.btncad.BackColor = System.Drawing.Color.Sienna;
            this.btncad.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncad.Location = new System.Drawing.Point(225, 228);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(125, 33);
            this.btncad.TabIndex = 29;
            this.btncad.Text = "Cadastrar";
            this.btncad.UseVisualStyleBackColor = false;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // dgv_procedimento
            // 
            this.dgv_procedimento.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgv_procedimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_procedimento.Location = new System.Drawing.Point(88, 299);
            this.dgv_procedimento.Name = "dgv_procedimento";
            this.dgv_procedimento.Size = new System.Drawing.Size(648, 150);
            this.dgv_procedimento.TabIndex = 30;
            this.dgv_procedimento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_procedimento_CellClick);
            this.dgv_procedimento.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_procedimento_CellMouseClick);
            // 
            // btnatualizar
            // 
            this.btnatualizar.BackColor = System.Drawing.Color.Sienna;
            this.btnatualizar.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizar.Location = new System.Drawing.Point(356, 228);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(112, 33);
            this.btnatualizar.TabIndex = 31;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = false;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            this.btnatualizar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnatualizar_MouseClick);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(143, 63);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(189, 20);
            this.txtcodigo.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.BurlyWood;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Código";
            // 
            // btnapagar
            // 
            this.btnapagar.BackColor = System.Drawing.Color.Sienna;
            this.btnapagar.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapagar.Location = new System.Drawing.Point(474, 228);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(112, 33);
            this.btnapagar.TabIndex = 34;
            this.btnapagar.Text = "Excluir";
            this.btnapagar.UseVisualStyleBackColor = false;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.BurlyWood;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(297, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(326, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "Procedimentos realizados";
            // 
            // Frm_Procedimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.dgv_procedimento);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.txtpet_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfunc_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtval);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Procedimento";
            this.Load += new System.EventHandler(this.Frm_Procedimento_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_procedimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpet_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfunc_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.DataGridView dgv_procedimento;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnapagar;
        private System.Windows.Forms.Label label8;
    }
}