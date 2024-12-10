using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSPStore.App.Cadastros
{
    public partial class CadastroGrupo : CadastroBase
    {
        private readonly IBaseService<Grupo> _grupoService;

        private List<GrupoModel>? grupos;

        public CadastroGrupo(IBaseService<Grupo> grupoService)
        {
            _grupoService = grupoService;
            InitializeComponent();
        }
    }
}
