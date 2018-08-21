using EByteBank.Sistemas;
using System;

namespace EByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
       


        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando diretor");
        }

        
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            //return Salario + base.GetBonificacao();
            return Salario * 0.50;
        }
    }
}
