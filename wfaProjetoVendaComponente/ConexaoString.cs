using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProjetoVendaComponente
{
    internal class ConexaoString
    {
        string serverName = "localhost";
        string port = "5432";
        string userName = "postgres";
        string password = "228710";
        string dataBaseName = "bdMateriaisEletronicos";

        public string ConnString()
        {
            var connString = "Server =" + serverName + ";Port =" + port + ";Username =" + userName + 
                ";Password = " + password + ";Database =" + dataBaseName + ";";

            return connString;
        }
    }
}
