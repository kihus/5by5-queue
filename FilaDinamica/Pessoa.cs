using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public Pessoa? Proximo { get; set; }

        public Pessoa()
        {
            Proximo = null;
        }
    }
}
