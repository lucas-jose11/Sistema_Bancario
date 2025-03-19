using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.Intrinsics.Arm;
using System.Xml.Schema;

namespace Sistema_Bancario
{
    public class Sistema
    {

        //private List<ContaBancaria> listaDeContas = new List<ContaBancaria>();

        private List<ContaCorrente> listaDeContasCorrente = new List<ContaCorrente>
        {
            new ContaCorrente(1, "Wellington", 48174938, 100.50),
            new ContaCorrente(2, "Antônio", 22947281, 400) //unico problema : n aceita começar com 0, o int n aceita

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
                    Console.WriteLine("Qual conta corrente dentre essas abaixo você quer acessar?");
                    MostrarContasCorrentes(listaDeContasCorrente);
                    Console.WriteLine("");
                    int auxCorrente = EscolherNumeroEntre(1, listaDeContasCorrente.Count);
                    Console.WriteLine("Acessando conta...");
                    Console.WriteLine("Conta acessada!");
                    Console.WriteLine("========================");
                    EntrandoContaCorrente(listaDeContasCorrente, auxCorrente);



                    //falta acessar as contas e poder fazer os métodos
                    Console.Clear();
                    break;

                case 6:
                    Console.WriteLine("Qual conta poupança dentre essas abaixo você quer acessar?");
                    MostrarContasCorrentes(listaDeContasCorrente);
                    Console.WriteLine("");
                    int auxPoupanca = EscolherNumeroEntre(1, listaDeContasCorrente.Count);
                    Console.WriteLine("Acessando conta...");
                    Console.WriteLine("Conta acessada!");
                    Console.WriteLine("========================");
                    EntrandoContaPoupanca(listaDeContasPoupanca, auxPoupanca);



                    //falta acessar as contas e poder fazer os métodos
                    Console.Clear();
                    break;

                case 0:
                    Console.WriteLine("Tchau! Saindo...");
                    Thread.Sleep(1500);
                    break;

            }
        }

        public void EntrandoContaCorrente(List<ContaCorrente> contasCorrentes, int idConta) // passar id, pelo metodo Esoclehndo conta
        {
            //trazer como parametro a lista de contas correntes/poupança e o ID da conta que eu quero
            //entrando nela, conseguir usar os metodos especial da classe e os metodos padrão da contabancaria

            //métodos aqui

            int op = -1;
            while (op != 3)
            {
                ContaCorrente conta = contasCorrentes.First(x => x.Id == idConta);
                Console.WriteLine($"Conta de {conta.Titular}, ID: {conta.Id}.");
                Console.WriteLine($"Saldo atual: R${conta.Saldo}."); //como mostrar no tipo R$XX,XX?

                Console.WriteLine("");
                Console.WriteLine("O que deseja fazer nela?");
                Console.WriteLine("[1] - Saque.");
                Console.WriteLine("[2] - Depósito.");
                Console.WriteLine("[3] - SAIR");
                op = EscolherNumeroEntre(1, 3);

                switch (op)
                {
                    case 1:
                        //qnt quer sacar?
                        //chamar o sacar()
                        break;

                    case 2:
                        break;

                    case 3:
                        Console.Write("Saindo da conta...");
                        break;

                }
            }
            
            

            
        }

        public void FazendoAcoesNaContaCorrente(int op) //tem como juntar os dois metodos?
        {
            //aqui faz
            //if 1 saquetaxado ou saque, 2 depoisto, etc
        }

        public void EntrandoContaPoupanca(List<ContaPoupanca> contasPoupancas, int idConta)
        {
            //trazer como parametro a lista de contas correntes/poupança e o ID da conta que eu quero
            //entrando nela, conseguir usar os metodos especial da classe e os metodos padrão da contabancaria
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
        } // como mostrar ambos os tipos de contas em apenas um metodo?

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



        public int EscolhendoContaCorrente()
        {
            //mandar o MostrarContas aq, e escolher uma
            return 0; // retorna Id da conta
        }

        public int EscolhendoContaPoupanca()//parametro o int que o metodo Esoclhendo deicidr
        {
            //mandar o MostrarContas aq, e escolher uma
            return 0; // retorna Id da conta
        }







        //=================================
        //================================

        static int EscolherNumeroEntre(int a, int b)
        {
            Console.WriteLine($"=================\nDigite uma opção válida, entre {a} e {b}:");
            string entrada = Console.ReadLine();

            // Verifica se a entrada é um número válido e está no intervalo a-b
            if (int.TryParse(entrada, out int numero) && numero > (a - 1) && numero < (b + 1))
            {
                return numero; // Retorna o número válido
            }
            
            Console.WriteLine($"Erro! A entrada deve ser um número entre {a} e {b}.");

            // Chama o método novamente (recursão)
            return EscolherNumeroEntre(a, b);
        }
    }
}