using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProjetoVendaComponente
{
    internal class Componentes
    {
        private string id_componente;
        private string componente;
        private string quantidade;
        private string setor;

        public string Id_componente { get => id_componente; set => id_componente = value; }
        public string Componente { get => componente; set => componente = value; }
        public string Quantidade { get => quantidade; set => quantidade = value; }
        public string Setor { get => setor; set => setor = value; }

        public Componentes(string id_componente, string componente, string quantidade, string setor)
        {
            this.id_componente = id_componente;
            this.componente = componente;
            this.quantidade = quantidade;
            this.setor = setor;
        }
    }
}
