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
            new ContaCorrente(2, "Antônio", 22947281, 400) //unico problema : n aceita começar com 0

        };

        private List<ContaPoupanca> listaDeContasPoupanca = new List<ContaPoupanca>
        {
            new ContaPoupanca(1, "Melo", 38163927, 250.32),
            new ContaPoupanca(2, "Antunes", 38163928, 500)
        };


        public void MenuBanco(int op)
        {
            //Console.WriteLine("Bem-vindo ao Banco Regional of Blumenau.");

            //Console.WriteLine("O que deseja fazer?");
            //Console.WriteLine("[1] - Criar conta corrente");
            //Console.WriteLine("[2] - Criar conta poupança");
            //Console.WriteLine("[3] - Ver contas cadastradas do tipo corrente");
            //Console.WriteLine("[4] - Ver contas cadastradas do tipo Poupança");
            //Console.WriteLine("[5] - Acessar conta corrente");
            //Console.WriteLine("[6] - Acessar conta poupança");
            //Console.WriteLine("[0] - SAIR");

            Console.Clear();

            switch (op)
            {
                case 1:
                    CriarContaCorrente();
                    Console.Clear();
                    break;

                case 2:
                    CriarContaPoupanca();
                    Console.Clear();
                    break;

                case 3:
                    MostrarContasCorrentes(listaDeContasCorrente);
                    Console.WriteLine("Pressione ENTER para voltar ao Menu.");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 4:
                    MostrarContasPoupancas(listaDeContasPoupanca); 
                    Console.WriteLine("Pressione ENTER para voltar ao Menu.");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 5:
                    //falta acessar as contas e poder fazer os métodos
                    Console.Clear();
                    break;

                case 6:
                    //falta acessar as contas e poder fazer os métodos
                    Console.Clear();
                    break;

                case 0:
                    Console.WriteLine("Tchau! Saindo...");
                    Thread.Sleep(1500);
                    break;

            }
        }

        public void CriarContaCorrente()
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

                ContaCorrente conta_nova = new ContaCorrente(id, nome, numero, saldo);
                //Console.WriteLine(conta_1.NumeroConta);

                // se fosse static tinha que : List<ContaBancaria> listaDeContas = new List<ContaBancaria>();

                listaDeContasCorrente.Add(conta_nova);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Criação de conta falhou, tentaremos de novo!");
                Console.WriteLine("Aperte ENTER para tentar de novo.");
                Console.ReadLine();
                Console.Clear();
                CriarContaCorrente();
            }

        }

        public void CriarContaPoupanca()
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

                ContaPoupanca conta_nova = new ContaPoupanca(id, nome, numero, saldo);
                //Console.WriteLine(conta_1.NumeroConta);

                // se fosse static tinha que : List<ContaBancaria> listaDeContas = new List<ContaBancaria>();

                listaDeContasPoupanca.Add(conta_nova);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Criação de conta falhou, tentaremos de novo!");
                Console.WriteLine("Aperte ENTER para tentar de novo.");
                Console.ReadLine();
                Console.Clear();
                CriarContaPoupanca();
            }

        }

        public void MostrarContasCorrentes(List<ContaCorrente> contasCorrentes)
        {
            Console.WriteLine("CONTAS CORRENTES:");
            Console.WriteLine("");
            foreach (ContaCorrente conta in contasCorrentes)
            {
                Console.WriteLine($"{conta.Id} - conta corrente de {conta.Titular}");
                Console.WriteLine("===============================================");

            }
        }

        public void MostrarContasPoupancas(List<ContaPoupanca> contasPoupanca)
        {
            Console.WriteLine("CONTAS POUPANÇAS:");
            Console.WriteLine("");
            foreach (ContaPoupanca conta in contasPoupanca)
            {
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