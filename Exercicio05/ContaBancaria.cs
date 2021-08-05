using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class ContaBancaria
    {
        private string _nome;
        public int Conta { get; set; }
        public double Saldo { get; private set; }
        
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length >= 3)
                {
                    _nome = value;
                }
            }
        }
        public ContaBancaria()
        {
        }
        public ContaBancaria(string nome, int conta)
        {
            Nome = nome;
            Conta = conta;
        }

        public Boolean CheckDeposit(string valid)
        {
            if (valid.Equals("s"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Deposit(double value)
        {
            if(value > 0)
            {
                Saldo += value;
            }
        }

        public double Withdraw(double value)
        {
            return  Saldo -= (value + 5.00);
        }

        public override string ToString()
        {
            return "Conta: "
                   + Conta
                   + ", Titular :"
                   + Nome
                   + ", Saldo $ "
                   + Saldo.ToString("F2");
        }
    }
}
