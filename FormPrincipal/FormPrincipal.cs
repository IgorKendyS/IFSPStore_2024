using IFSPStore.App.Cadastros;
using IFSPStore.App.Infra;
using IFSPStore.App.Outros;
using IFSPStore.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace IFSPStore.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public static Usuario Usuario { get; set; }
        public FormPrincipal()
        {
            InitializeComponent();
            CarregaLogin();
        }

        private void CarregaLogin()
        {
            var login = ConfigureDI.ServiceProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    lblUsuario.Text = $"Usuario: {Usuario.Nome}";

                }
            }


            private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
            {
                ExibeFormulario<CadastroCidades>();
            }

            private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (e.CloseReason == CloseReason.ApplicationExitCall)
                {
                    e.Cancel = true;
                }
            }

            private void ExibeFormulario<TFormulario>() where TFormulario : Form
            {
                var cad = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
                if (cad != null && !cad.IsDisposed)
                {
                    cad.MdiParent = this;
                    cad.Show();
                }
            }
        }
    }
}