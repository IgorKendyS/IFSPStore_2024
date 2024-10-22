using IFSPStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Domain.Entities
{
    public class Produto : BaseEntity<int>
    {
        public Produto(int id, string nome, float preco, int quantidade, DateOnly dataCompra, string unidadeVenda, Grupo grupo) {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            DataCompra = dataCompra;
            Preco = preco;
            UnidadeVenda = unidadeVenda;
            Grupo = grupo;
        }

        public string? Nome { get; set; }
        public float? Preco { get; set; }
        public int? Quantidade { get; set; }
        public DateOnly? DataCompra { get; set; }
        public string UnidadeVenda { get; set; }
        public virtual Grupo? Grupo { get; set; }
    }
}
