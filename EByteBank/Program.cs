using EByteBank.Funcionarios;
using EByteBank.Sistemas;
using System;

namespace EByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //CalculaBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeContas camila = new GerenteDeContas("326.95.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";


            sistemaInterno.Logar(parceiro, "123456");
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
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
