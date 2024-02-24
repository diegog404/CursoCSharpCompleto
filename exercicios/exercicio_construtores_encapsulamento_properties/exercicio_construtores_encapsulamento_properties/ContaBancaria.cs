using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_construtores_encapsulamento_properties
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nome, double saldo)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
        }

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public void Deposito(double quantidade)
        {
            Saldo += quantidade;
        }

        public void Saque(double quantidade)
        {
            Saldo = Saldo - quantidade - 5;
        }

        public override string ToString()
        {
            return "Conta: " + Numero + ", Titular: " + Nome + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
