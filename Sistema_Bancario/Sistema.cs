using System.Globalization;
using System.Security.Cryptography;

namespace Sistema_Bancario
{
    public class Sistema
    {

        private List<ContaCorrente> listaDeContasCorrente = new List<ContaCorrente>
        {
            new ContaCorrente(1, "Wellington", 48174938, 100.50),
            new ContaCorrente(2, "Antônio", 22947281, 400)

        };

        private List<ContaPoupanca> listaDeContasPoupanca = new List<ContaPoupanca>
        {
            new ContaPoupanca(1, "Melo", 38163927, 250.32),
            new ContaPoupanca(2, "Antunes", 38163928, 500)
        };


        public void Executar()
        {
            int aux = -1;
            while (aux != 0)
            {
                Console.WriteLine("Bem-vindo ao Banco Regional of Blumenau.");

                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("[1] - Criar conta corrente");
                Console.WriteLine("[2] - Criar conta poupança");
                Console.WriteLine("[3] - Ver contas cadastradas do tipo corrente");
                Console.WriteLine("[4] - Ver contas cadastradas do tipo Poupança");
                Console.WriteLine("[5] - Acessar conta corrente");
                Console.WriteLine("[6] - Acessar conta poupança");
                Console.WriteLine("[0] - SAIR");

                aux = EscolherNumeroEntre(0, 6);

                MenuBanco(aux);
            }
        }

        public void MenuBanco(int op)
        {
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
                    Console.WriteLine("");
                    Console.WriteLine("Pressione ENTER para voltar ao Menu.");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 4:
                    MostrarContasPoupanca(listaDeContasPoupanca);
                    Console.WriteLine("");
                    Console.WriteLine("Pressione ENTER para voltar ao Menu.");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 5:
                    Console.WriteLine("Qual conta corrente dentre essas abaixo você quer acessar?");
                    MostrarContasCorrentes(listaDeContasCorrente);
                    

                    Console.WriteLine("");
                    
                    int auxCorrente = EscolherNumeroEntre(1, listaDeContasCorrente.Count);
                    Console.WriteLine("");
                    Console.WriteLine("Acessando conta...");
                    Console.WriteLine("Conta acessada!");
                   
                    EntrandoContaCorrente(listaDeContasCorrente, auxCorrente);
                    Console.Clear();
                    break;

                case 6:
                    Console.WriteLine("Qual conta poupança dentre essas abaixo você quer acessar?");
                    MostrarContasPoupanca(listaDeContasPoupanca);
                    
                    Console.WriteLine("");
                    
                    int auxPoupanca = EscolherNumeroEntre(1, listaDeContasPoupanca.Count);
                    Console.WriteLine("");
                    Console.WriteLine("Acessando conta...");
                    Console.WriteLine("Conta acessada!");
                   
                    EntrandoContaPoupanca(listaDeContasPoupanca, auxPoupanca);
                    Console.Clear();
                    break;

                case 0:
                    Console.WriteLine("Tchau! Saindo...");
                    Thread.Sleep(1000);
                    break;
            }
        }


        public void CriarContaCorrente()
        {
            try
            {
                Console.WriteLine("=======CRIAÇÃO DE CONTA CORRENTE=======");
                Console.WriteLine("Digite seu nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("Digite o número da conta, ele é composto de 8 dígitos, sendo que o primeiro não pode ser 0:");
                int numero = int.Parse(Console.ReadLine());
                
                Console.WriteLine("");
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
                Console.WriteLine("Digite seu nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("Digite o número da conta, ele é composto de 8 dígitos, sendo que o primeiro não pode ser 0:");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine("");
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
                Console.WriteLine($"ID - {conta.Id} || CONTA CORRENTE de: {conta.Titular}");
                Console.WriteLine("===============================================");
            }
        }

        public void MostrarContasPoupanca(List<ContaPoupanca> contasPoupanca)
        {
            Console.WriteLine("CONTAS POUPANÇAS:");
            Console.WriteLine("");
            foreach (ContaPoupanca conta in contasPoupanca)
            {
                Console.WriteLine($"ID - {conta.Id} || CONTA POUPANÇA de: {conta.Titular}");
                Console.WriteLine("===============================================");
            }
        }


        public void EntrandoContaCorrente(List<ContaCorrente> contasCorrentes, int idConta)
        {
            int op = -1;
            while (op != 3)
            {
                ContaCorrente conta = contasCorrentes.First(x => x.Id == idConta);
                Console.WriteLine($"Conta CORRENTE de {conta.Titular}, ID: {conta.Id}.");
                Console.WriteLine($"Saldo atual: {conta.Saldo.ToString("C2", new CultureInfo("pt-BR"))}.");

                Console.WriteLine("");
                Console.WriteLine("O que deseja fazer nela?");
                Console.WriteLine("[1] - Saque.");
                Console.WriteLine("[2] - Depósito.");
                Console.WriteLine("[3] - SAIR");
                op = EscolherNumeroEntre(1, 3);

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Quanto você quer sacar?");
                        double valorPraSacar = double.Parse(Console.ReadLine());
                        
                        conta.SaqueTaxado(valorPraSacar);
                        break;

                    case 2:
                        Console.WriteLine("Quanto você quer depositar?");
                        double valorPraDepositar = double.Parse(Console.ReadLine());

                        conta.Depositar(valorPraDepositar);
                        break;

                    case 3:
                        Console.Write("Saindo da conta...");
                        break;
                }
            }
        }

        public void EntrandoContaPoupanca(List<ContaPoupanca> contasPoupancas, int idConta)
        {
            int op = -1;
            while (op != 3)
            {
                ContaPoupanca conta = contasPoupancas.First(x => x.Id == idConta);
                Console.WriteLine($"Conta POUPANÇA de {conta.Titular}, ID: {conta.Id}.");
                Console.WriteLine($"Saldo atual: {conta.Saldo.ToString("C2", new CultureInfo("pt-BR"))}.");

                Console.WriteLine("");
                Console.WriteLine("O que deseja fazer nela?");
                Console.WriteLine("[1] - Saque.");
                Console.WriteLine("[2] - Depósito.");
                Console.WriteLine("[3] - SAIR");
                op = EscolherNumeroEntre(1, 3);

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Quanto você quer sacar?");
                        double valorPraSacar = double.Parse(Console.ReadLine());

                        conta.Sacar(valorPraSacar);
                        break;

                    case 2:
                        Console.WriteLine("Quanto você quer depositar?");
                        double valorPraDepositar = double.Parse(Console.ReadLine());

                        conta.DepositoComBonus(valorPraDepositar);
                        break;

                    case 3:
                        Console.Write("Saindo da conta...");
                        break;
                }
            }
        }


        //=================================
        //================================

        static int EscolherNumeroEntre(int a, int b)
        {
            Console.WriteLine("=================");
            Console.WriteLine($"Digite uma opção válida, entre {a} e {b}:");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero) && numero > (a - 1) && numero < (b + 1))
            {
                return numero;
            }
            
            Console.WriteLine($"Erro! A entrada deve ser um número entre {a} e {b}.");
            return EscolherNumeroEntre(a, b);
        }

    }
}