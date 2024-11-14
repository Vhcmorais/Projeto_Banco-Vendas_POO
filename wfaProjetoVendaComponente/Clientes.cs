using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProjetoVendaComponente
{
    internal class Clientes
    {
        private string nome_cliente;
        private string id_cliente;
        private string cpf_cliente;
        private string data_cadastro;

        public string Nome_cliente { get => nome_cliente; set => nome_cliente = value; }
        public string Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Cpf_cliente { get => cpf_cliente; set => cpf_cliente = value; }
        public string Data_cadastro { get => data_cadastro; set => data_cadastro = value; }

        public Clientes(string nome_cliente, string id_cliente, string cpf_cliente, string data_cadastro) 
        {
            this.nome_cliente = nome_cliente;
            this.id_cliente = id_cliente;
            this.cpf_cliente = cpf_cliente;
            this.data_cadastro = data_cadastro;
        }
    }
}
