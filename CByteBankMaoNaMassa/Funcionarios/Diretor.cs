﻿using CByteBankMaoNaMassa.Funcionarios;
using System;

namespace CByteBackMaoNaMassa.Funcionarios
{
    class Diretor : Funcionario
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
