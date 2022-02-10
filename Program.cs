using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 1000, 500, "Jonatas Stein Ribeiro II");
            Conta contaDois = new Conta(TipoConta.PessoaFisica, 500, 500, "Jonatas Stein");

            Console.WriteLine(minhaConta.ToString());

            minhaConta.Depositar(500);

            Console.WriteLine(minhaConta.ToString());

            minhaConta.Sacar(900);
            Console.WriteLine(minhaConta.ToString());
            minhaConta.Transferir(700, contaDois);
            minhaConta.Sacar(300);
            Console.WriteLine(minhaConta.ToString());
            Console.WriteLine(contaDois.ToString());
        }
    }
}
