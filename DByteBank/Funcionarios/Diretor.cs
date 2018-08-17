using DByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DByteBank.Funcionarios
{
    public class Diretor : Autenticavel
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
