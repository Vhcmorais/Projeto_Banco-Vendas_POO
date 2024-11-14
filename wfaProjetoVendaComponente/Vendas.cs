using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProjetoVendaComponente
{
    class Vendas
    {
        private string id_venda;
        private string dia_venda;
        private string valor_total;
        private string nome_vendedor;

        public string Id_venda { get => id_venda; set => id_venda = value; }
        public string Dia_venda { get => dia_venda; set => dia_venda = value; }
        public string Valor_total { get => valor_total; set => valor_total = value; }
        public string Nome_vendedor { get => nome_vendedor; set => nome_vendedor = value; }

        public Vendas(string id_venda, string dia_venda, string valor_total, string nome_vendedor)
        {
            this.id_venda = id_venda;
            this.dia_venda = dia_venda;
            this.valor_total = valor_total;
            this.nome_vendedor = nome_vendedor;
        }
    }
}
