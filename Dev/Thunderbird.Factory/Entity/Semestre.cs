using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunderbird.Factory.Entity
{
    public class Semestre
    {
        public virtual int Codigo { get; set; }

        public virtual string Ano { get; set; }

        public virtual string NomeSemestre { get; set; }
    }
}
