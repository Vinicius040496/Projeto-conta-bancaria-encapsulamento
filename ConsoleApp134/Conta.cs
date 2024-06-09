using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp134
{
    internal class Conta
    {
        public int NumeroConta { get; private set; }
        public string Nome;
        public double DepositoIni {  get; private set; }

        public Conta(int numeroconta, string nome, double depositoini)
        {
            NumeroConta = numeroconta;
            Nome = nome;
            DepositoIni = depositoini;
        }

        public Conta(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public void DepositoAd( double DepositoAdicional)
        {
            DepositoIni += DepositoAdicional;
        }

        public void Saque(double saque)
        {
            DepositoIni -= saque + 5.00;
               
        }
        public override string ToString()
        {
            return "Conta: " + NumeroConta + " , Titular: " + Nome + " , Saldo: " + " R$"+DepositoIni.ToString("f2");
        }
       
    }
}
