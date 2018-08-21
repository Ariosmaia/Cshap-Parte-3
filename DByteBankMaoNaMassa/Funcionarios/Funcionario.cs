using System;

namespace DByteBankMaoNaMassa.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            TotalDeFuncionarios++;
            Console.WriteLine("Construtor de FUNCIONARIO");

            CPF = cpf;
            Salario = Salario;
        }

        public abstract void AumentarSalario();
       

        public abstract double GetBonificacao();
       
    }
}
