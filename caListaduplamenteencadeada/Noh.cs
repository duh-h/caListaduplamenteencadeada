using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaduplamenteencadeada
{
    internal class Noh
    {
        public int info { get; set; }
        public Noh proximo { get; set; }

        public Noh anterior { get; set; }

        public Noh(int info)
        {
            this.info = info;
            this.proximo = null;
            this.anterior = null;
        }


    }
}

