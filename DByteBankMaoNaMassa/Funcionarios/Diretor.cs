using DByteBankMaoNaMassa.Funcionarios;
using DByteBankMaoNaMassa.Sistemas;
using System;

namespace DByteBackMaoNaMassa.Funcionarios
{
    class Diretor : Autenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Construtor de DIRETOR");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.50;
        }
    }
}
