using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Cadastroclientes
{
    internal class Program
    {
        static List<Cliente> clientes = new List<Cliente>();

        static void Main(string[] args)
        {
            bool executando = true;

            while (executando)
            {
                Console.WriteLine("digite a opção desejada:");
                Console.WriteLine("1 - Adicionar Cliente");
                Console.WriteLine("2 - Visualizar Clientes");
                Console.WriteLine("3 - Editar Cliente");
                Console.WriteLine("4 - Excluir Cliente");
                Console.WriteLine("5 - Sair");
            }


        }

    }
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}




