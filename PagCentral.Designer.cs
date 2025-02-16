
namespace PetShop
{
    partial class PagCentral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagCentral));
            this.btncli = new System.Windows.Forms.Button();
            this.btnfunc = new System.Windows.Forms.Button();
            this.btnpet = new System.Windows.Forms.Button();
            this.btnproced = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncli
            // 
            this.btncli.BackColor = System.Drawing.Color.Sienna;
            this.btncli.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncli.Location = new System.Drawing.Point(142, 132);
            this.btncli.Name = "btncli";
            this.btncli.Size = new System.Drawing.Size(219, 69);
            this.btncli.TabIndex = 0;
            this.btncli.Text = "Cadastrar Clientes";
            this.btncli.UseVisualStyleBackColor = false;
            this.btncli.Click += new System.EventHandler(this.btncli_Click);
            // 
            // btnfunc
            // 
            this.btnfunc.BackColor = System.Drawing.Color.Sienna;
            this.btnfunc.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfunc.Location = new System.Drawing.Point(416, 132);
            this.btnfunc.Name = "btnfunc";
            this.btnfunc.Size = new System.Drawing.Size(223, 69);
            this.btnfunc.TabIndex = 1;
            this.btnfunc.Text = "Cadastrar Funcionários";
            this.btnfunc.UseVisualStyleBackColor = false;
            this.btnfunc.Click += new System.EventHandler(this.btnfunc_Click);
            // 
            // btnpet
            // 
            this.btnpet.BackColor = System.Drawing.Color.Sienna;
            this.btnpet.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpet.Location = new System.Drawing.Point(142, 244);
            this.btnpet.Name = "btnpet";
            this.btnpet.Size = new System.Drawing.Size(219, 72);
            this.btnpet.TabIndex = 2;
            this.btnpet.Text = "Cadastrar Pets";
            this.btnpet.UseVisualStyleBackColor = false;
            this.btnpet.Click += new System.EventHandler(this.btnpet_Click);
            // 
            // btnproced
            // 
            this.btnproced.BackColor = System.Drawing.Color.Sienna;
            this.btnproced.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproced.Location = new System.Drawing.Point(415, 249);
            this.btnproced.Name = "btnproced";
            this.btnproced.Size = new System.Drawing.Size(224, 67);
            this.btnproced.TabIndex = 3;
            this.btnproced.Text = "Procedimentos";
            this.btnproced.UseVisualStyleBackColor = false;
            this.btnproced.Click += new System.EventHandler(this.btnproced_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pet Shop";
            // 
            // PagCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnproced);
            this.Controls.Add(this.btnpet);
            this.Controls.Add(this.btnfunc);
            this.Controls.Add(this.btncli);
            this.Name = "PagCentral";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncli;
        private System.Windows.Forms.Button btnfunc;
        private System.Windows.Forms.Button btnpet;
        private System.Windows.Forms.Button btnproced;
        private System.Windows.Forms.Label label1;
    }
}