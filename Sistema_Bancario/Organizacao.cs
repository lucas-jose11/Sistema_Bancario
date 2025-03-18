using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.Intrinsics.Arm;

namespace Sistema_Bancario
{
    public class Organizacao : Principal
    {

        //private List<ContaBancaria> listaDeContas = new List<ContaBancaria>();

        private List<ContaCorrente> listaDeContasCorrente = new List<ContaCorrente>
        {
            new ContaCorrente(1, "Wellington", 48174938, 100.50),
            new ContaCorrente(2, "Antônio", 02947281, 400)

        };

        private List<ContaPoupanca> listaDeContasPoupanca = new List<ContaPoupanca>
        {
            new ContaPoupanca(1, "Melo", 38163927, 20.32),
            new ContaPoupanca(2, "Antunes", 38163928, 500)
        };


        public void MenuBanco(int op)
        {
            //Console.WriteLine("O que deseja fazer?");
            //Console.WriteLine("[1] - Criar conta corrente");
            //Console.WriteLine("[2] - Criar conta poupança");
            //Console.WriteLine("[3] - Ver contas cadastradas do tipo corrente");
            //Console.WriteLine("[4] - Ver contas cadastradas do tipo Poupança");
            //Console.WriteLine("[5] - Acessar conta corrente");
            //Console.WriteLine("[6] - Acessar conta poupança");
            //Console.WriteLine("[0] - SAIR");


            switch (op)
            {
                case 1:
                    Console.Clear();
                    CriarContaCorrente();
                    break;

                case 2:
                    Console.Clear();
                    CriarContaPoupanca();
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 0:
                    Console.Clear();
                    Console.WriteLine("Tchau! Saindo...");
                    Thread.Sleep(1500);
                    break;

            }
        }

        public ContaCorrente CriarContaCorrente()
        {
            try
            {
                Console.WriteLine("=======CRIAÇÃO DE CONTA CORRENTE=======");
                Console.WriteLine("Digite seu nome");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o numero da conta");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine("Quanto de saldo você tem? Use o modelo \"XX,XX\".");
                double saldo = double.Parse(Console.ReadLine());

                int id = listaDeContasCorrente.Count + 1;

                ContaCorrente conta_1 = new ContaCorrente(id, nome, numero, saldo);
                //Console.WriteLine(conta_1.NumeroConta);

                // se fosse static tinha que : List<ContaBancaria> listaDeContas = new List<ContaBancaria>();

                listaDeContasCorrente.Add(conta_1);
                
                return conta_1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Criação de conta falhou, tentaremos de novo!");
                Console.WriteLine("Aperte ENTER para tentar de novo.");
                Console.ReadLine();
                Console.Clear();
                return CriarContaCorrente();
            }

        }

        public ContaPoupanca CriarContaPoupanca()
        {
            try
            {
                Console.WriteLine("=======CRIAÇÃO DE CONTA POUPANÇA=======");
                Console.WriteLine("Digite seu nome");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o numero da conta");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine("Quanto de saldo você tem? Use o modelo \"XX,XX\".");
                double saldo = double.Parse(Console.ReadLine());

                int id = listaDeContasPoupanca.Count + 1; 

                ContaPoupanca conta_1 = new ContaPoupanca(id, nome, numero, saldo);
                //Console.WriteLine(conta_1.NumeroConta);

                // se fosse static tinha que : List<ContaBancaria> listaDeContas = new List<ContaBancaria>();

                listaDeContasPoupanca.Add(conta_1);

                return conta_1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Criação de conta falhou, tentaremos de novo!");
                Console.WriteLine("Aperte ENTER para tentar de novo.");
                Console.ReadLine();
                Console.Clear();
                return CriarContaPoupanca();
            }

        }

        //criar conta corrente/poupcança?

        public void MostrarContasCorrentes(List<ContaCorrente> contasCorrentes)
        {
            foreach (ContaCorrente conta in  contasCorrentes)
            {
                Console.WriteLine("===============================================");
                Console.WriteLine($"{conta.Id} - conta corrente de {conta.Titular}");
                Console.WriteLine("===============================================");

            }
        }

        public void MostrarContasPoupancas(List<ContaPoupanca> contasPoupanca)
        {
            foreach (ContaPoupanca conta in contasPoupanca)
            {
                Console.WriteLine("===============================================");
                Console.WriteLine($"{conta.Id} - conta poupança de {conta.Titular}");
                Console.WriteLine("===============================================");
            }
        }


        public void DetalhesdaMinhaConta()
        {
            //trazer como parametro a lista de contas correntes/poupança e o ID da conta que eu quero
        }
    }
}
