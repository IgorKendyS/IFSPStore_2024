using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Domain.Base
{
    //uma classe abstrata não pode ser instanciada (criar outro objeto a partir dela [new "className])
    public abstract class BaseEntity<TID>
    {
        protected BaseEntity() { }

        protected BaseEntity(TID id) { //não obrigatório
            Id = id;
        }
        public TID? Id { get; set; }
    }
}
