using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal.Base
{
    public partial class BaseForm : MaterialForm
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected virtual void Editar()
        {
            if(DataGridViewConsulta.SelectedRows.Count > 0)
            {
                IsAlteracao = true;
                var linha = dataGridViewConsulta.SelectedRows[0];
                CarregaRegistro(linha);
                tabControlCadastro.SelectedIndex = 0;
                tabControlCadastro.Focus();
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!",@"IFPS STORE",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        protected virtual void Deletar()
        {

        }

        protected virtual void CarregaRegistro(DataGridViewRow? linha)
        {

        }
    }
}
