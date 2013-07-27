using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunderbird.Factory.Entity
{
    public class Aluno
    {
        public virtual int Codigo { get; set; }

        public virtual string Nome { get; set; }

        public virtual bool Ativo { get; set; }
    }
}
