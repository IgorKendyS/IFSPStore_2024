using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace IFSPStore.App.Base
{
    public partial class CadastroBase : MaterialForm
    {
        protected bool IsAlteracao = false;
        public CadastroBase()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente cancelar?", @"IFSP Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                baseTabControl.SelectedIndex = 1;
            }
        }

        //eventos CRUD
        protected void LimpaCampos()
        {
            IsAlteracao = false;
            foreach (var control in baseTabControl.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        protected virtual void CarregaGrid()
        {

        }
        protected virtual void Novo()
        {
            LimpaCampos();
            baseTabControl.SelectedIndex = 0;
            baseTabControl.Focus();
        }
        protected virtual void Salvar()
        {

        }
 
        protected virtual void Editar()
        {
            if(dataGridViewConsulta.SelectedRows.Count > 0)
            {
                IsAlteracao = true;
                var linha = dataGridViewConsulta.SelectedRows[0];
                CarregaRegistro(linha);
                baseTabControl.SelectedIndex = 0;
                baseTabControl.Focus();
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!",@"IFPS STORE",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        protected virtual void Deletar(int id)
        {

        }

        protected virtual void CarregaRegistro(DataGridViewRow? linha)
        {

        }
        // END CRUD

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Deseja realmente excluir?", @"IFSP Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridViewConsulta.SelectedRows[0].Cells["Id"].Value;
                    Deletar(id);
                    CarregaGrid();

                }
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro", @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
