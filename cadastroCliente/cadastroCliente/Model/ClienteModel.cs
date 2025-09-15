using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroCliente.Model
{
    internal class ClienteModel
    {

        public ClienteModel(string nome, DateTime dataNascimento, long cpf, int cep, string rua, int numero, string bairro, string estado, long telefone, string email)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
            this.cep = cep;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.estado = estado;
            this.telefone = telefone;
            this.email = email;
        }

        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public long cpf { get; set; }
        public int cep { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string estado { get; set; }
        public long telefone { get; set; }
        public string email { get; set; }
    }
}
