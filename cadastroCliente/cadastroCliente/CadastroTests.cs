using System;
using cadastroCliente.Model;

namespace cadastroCliente
{
    public class CadastroTests
    {
        static List<ClienteModel> clientes = new List<ClienteModel>();

        [Fact]
        public void CadastrarClienteComSucesso()
        {
            string nome = "Martin Anjos";
            DateTime dataNascimento = new DateTime(2004, 05, 06);
            long cpf = 46372678209;
            int cep = 76808226;
            string rua = "Rua Nova Esperança";
            int numero = 378;
            string bairro = "Caladinho";
            string estado = "RO";
            long telefone = 69986746911;
            string email = "martin.anjos@geradornv.com.br";

            //Act
            var cliente = new ClienteModel(nome, dataNascimento, cpf, cep, rua, numero, bairro, estado, telefone, email);

            //Assert  
            Assert.Equal(cliente.nome, nome);
            Assert.Equal(cliente.dataNascimento, dataNascimento);
            Assert.Equal(cliente.cpf, cpf);
            Assert.Equal(cliente.cep, cep);
            Assert.Equal(cliente.rua, rua);
            Assert.Equal(cliente.numero, numero);
            Assert.Equal(cliente.bairro, bairro);
            Assert.Equal(cliente.estado, estado);
            Assert.Equal(cliente.telefone, telefone);
            Assert.Equal(cliente.email, email);
        }

        [Fact]
        public void VisualizarClienteComSucesso()
        {
            foreach (ClienteModel cliente in clientes)
            {
                Console.WriteLine("Informações do Cliente: ");
                Console.WriteLine($"Cliente: {cliente.nome}");
                Console.WriteLine($"Data de nacimento: {cliente.dataNascimento}");
                Console.WriteLine($"CPF: {cliente.cpf}");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Endereço: ");
                Console.WriteLine($"Rua: {cliente.rua}");
                Console.WriteLine($"Numero: {cliente.numero}");
                Console.WriteLine($"Bairro: {cliente.bairro}");
                Console.WriteLine($"Estado: {cliente.estado}");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Contato: ");
                Console.WriteLine($"Telefone: {cliente.telefone}");
                Console.WriteLine($"Email: {cliente.email}");
            }
        }

        [Fact]
        public void EditarClienteComSucesso()
        {
            Console.WriteLine("Digite o nome do cliente que deseja editar: ");
            string nome = "Martin Anjos";

            ClienteModel cliente = clientes.Find(cliente => cliente.nome == nome);

            if (cliente != null)
            {
                string novoEmail = "martin.anjos@gmail.com.br";
                long novoTelefone = 69895378563;
            }
            else
            {
                Console.WriteLine("Cliente não encontrado");
            }
        }
        
        [Fact]
        public void ExcluirClienteComSucesso()
        {
            Console.WriteLine("Digite o nome do cliente que deseja excluir: ");
            string nome = "Martin Anjos";

            ClienteModel cliente = clientes.Find(cliente => cliente.nome == nome);

            if (cliente != null) 
            {
                clientes.Remove(cliente);
                Console.WriteLine("Cliente excluído com sucesso.");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }

        }
    }
}


