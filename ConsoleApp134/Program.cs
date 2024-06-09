using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta Conta;
            Console.Write("Digite numero da conta: ");
            int numeroconta = int.Parse(Console.ReadLine());
            Console.Write("Digite titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial s/n: ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S'){
                Console.Write("Qual valor do deposito inicial:  ");
                double depositoini = double.Parse(Console.ReadLine());
                Conta = new Conta(numeroconta, nome, depositoini);
            }
            else
            {
                Conta = new Conta(numeroconta, nome);
            }
            
            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(Conta);
            Console.WriteLine();

            Console.Write("Entre com valor de deposito: ");
            double DepositoAdicional = double.Parse(Console.ReadLine());
            Conta.DepositoAd(DepositoAdicional);

            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados: ");
            Console.Write(Conta);

            Console.WriteLine();

            Console.Write("Entre com valor de saque: ");
            double saque = double.Parse(Console.ReadLine());
            Conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.Write(Conta);
            Console.WriteLine(" , Taxa de saque 5,00 reais!");




            Console.ReadLine();
        }
    }
}
