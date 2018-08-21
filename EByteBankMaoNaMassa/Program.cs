using EByteBankMaoNaMassa.Funcionarios;
using System;

namespace EByteBackMaoNaMassa
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";
            

            gerenciador.Registrar(roberta);

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            Console.ReadLine();
        }
    }
}
