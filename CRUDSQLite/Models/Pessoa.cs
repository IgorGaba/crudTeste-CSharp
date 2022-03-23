using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDSQLite.Models
{
    public class Pessoa
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

        public string Tipo { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string CEP { get; set; }

        public int Numero { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }
    }
}
