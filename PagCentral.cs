using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class PagCentral : Form
    {
        public PagCentral()
        {
            InitializeComponent();
        }

        private void btncli_Click(object sender, EventArgs e)
        {
            new Frm_Cadastro_proprietario().ShowDialog();
        }

        private void btnfunc_Click(object sender, EventArgs e)
        {
            new Frm_Cadastro_funcionario().ShowDialog();
        }

        private void btnpet_Click(object sender, EventArgs e)
        {
            new Frm_Cadastro_Pet().ShowDialog();
        }

        private void btnproced_Click(object sender, EventArgs e)
        {
            new Frm_Procedimento().ShowDialog();
        }
    }
}
