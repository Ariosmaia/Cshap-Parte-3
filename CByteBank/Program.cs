

using CByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            CalculaBonificacao();

            Console.ReadLine();
        }

        public static void CalculaBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeContas camila = new GerenteDeContas("326.95.628-89");
            camila.Nome = "Camila";

            Desenvolvedor allan = new Desenvolvedor("456.175.650-80");
            allan.Nome = "Allan";


            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);
            gerenciador.Registrar(allan);


            Console.WriteLine($"Total de bonificações {gerenciador.GetTotalBonificacao()}");
        }
    }
}
