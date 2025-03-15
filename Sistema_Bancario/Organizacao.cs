using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.Intrinsics.Arm;

namespace Sistema_Bancario
{
    public class Organizacao
    {

        //atributos?


        public static long PaginaConfirmacao()
        {
            long numeroConta = 0;
            bool confirmacaoFeita = false;
            while (!confirmacaoFeita)
            {
                try
                {

                    Console.WriteLine("================================================");
                    Console.WriteLine("AVISO: CONFIRMAÇÃO DE NÚEMRO DA CONTA NECESSÁRIO");
                    Console.WriteLine("================================================");
                    Console.WriteLine("");
                    Console.WriteLine("++++++Checagem de 2 etapas, é necessário que você confirme seu número da conta para avançar++++++");
                    Console.Write("Por favor, escreva seu número de conta:");

                    if (!long.TryParse(Console.ReadLine(), out numeroConta))
                        throw new Exception("Escreva seu número de conta, sem letras ou vírgulas");

                    if (numeroConta.ToString().Length < 8)
                        throw new Exception("Um número de conta tem no mínimo 8 números");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Gostaria de sair ou tentar de novo a confirmação do número da conta? Digite sim para voltar para a página de login");
                    string resposta = Console.ReadLine();
                    if (VoltarAoLogin(resposta))
                    {
                        LoginSenha();
                        Console.Clear();
                    }
                    else
                        Console.Clear();
                }
                confirmacaoFeita = true;
            }
            return numeroConta;
        }

        public static void LoginSenha()
        {

            bool loginEfetuado = false;
            while (!loginEfetuado)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("==========PÁGINA DE LOGIN==========");
                    Console.WriteLine("[Z] - PARA SAIR\n-------------");

                    Console.Write("Nome do titular: ");
                    string nomeTitular = Console.ReadLine();

                    if (nomeTitular == "Z")
                        //fazer que possa ser Z ou z e tbm que volte pra tela inicial kkkkk

                        if (string.IsNullOrEmpty(nomeTitular) || ContemNumero(nomeTitular))
                            throw new Exception("!!Falha ao tentar logar!!\n!!Campo nulo ou com algarismo(s) detectado!!\n-------------------------\n");

                    Console.Write("Senha do titula: ");
                    string senhaTitular = Console.ReadLine();
                    if (string.IsNullOrEmpty(senhaTitular))
                        throw new Exception("\n!!Falha ao tentar logar!!\n!!Campo nulo detectado!!\n-------------------------\n");

                    if (senhaTitular.Length < 8)
                        throw new Exception("\n!!Sua senha tem ao menos 8 caracteres!!");

                    //se nome for nulo ou tiver numero
                    //se senha for nula
                    //while

                    ContaBancaria dadosTitular = new ContaBancaria(nomeTitular, 10000);
                    loginEfetuado = true;
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Aperte enter para voltar à tela de login para tentar novamente.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            MenuConta();
        }

        public static void MenuConta()
        {
            int escolhaMenuConta = -1;
            while (escolhaMenuConta != 4)
            {
                try
                {
                    Console.WriteLine("=================MENU DA CONTA=================");
                    Console.WriteLine("[1] - ENTRAR NA CONTA CORRENTE");
                    Console.WriteLine("[2] - ENTRAR NA CONTA POUPANÇA");
                    Console.WriteLine("[3] - DETALHES DA MINHA CONTA");
                    Console.WriteLine("[4] - SAIR (FAZER LOGOUT)");

                    if (!int.TryParse(Console.ReadLine(), out escolhaMenuConta) || (escolhaMenuConta < 1 || escolhaMenuConta > 4))
                    {
                        throw new Exception("\n!!!OPÇÃO INVÁLIDA!!!\nPor favor, digite uma opção válida.\nEspere um momento...");

                    }

                    switch (escolhaMenuConta)
                    {
                        case 1:
                            break;

                        case 2:
                            break;

                        case 3:
                            break;

                        case 4:
                            Console.Clear();
                            LoginSenha();
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Thread.Sleep(1500);
                    Console.Clear();
                    Console.WriteLine("++++++++++SELECIONE UMA OPÇÃO VÁLIDA++++++++++");
                }
            }
        }

        public static void DetalhesMinhaConta()
        {
            Console.WriteLine("==========DETALHES DA MINHA CONTA==========");
            Console.WriteLine("\nNome do Titular: {}");
            Console.WriteLine("Número da conta: {}"); //fazer ela só se visivel se clicar?
            Console.WriteLine("Data de criação da conta: 14/03/2025");
            Console.WriteLine("===========================================");
            Console.WriteLine("\nAperte ENTER para voltar ao Menu da sua Conta Bancária.");
            Console.ReadLine();

            MenuConta();
        }

        public static void MenuContaCorrente()
        {
            Console.WriteLine("==========DETALHES DA MINHA CONTA CORRENTE==========");
            Console.WriteLine("====================================================");

            //opção pra sacar
            //opção para depositar
            //saldo à mostra

        }

        public static void MenuContaPoupança()
        {
            Console.WriteLine("==========DETALHES DA MINHA CONTA POUPANÇA==========");
            Console.WriteLine("====================================================");

            //opção pra sacar
            //opção para depositar
            //saldo à mostra
            //opção pra ver qnt rende dps de um tempo? kkkk
        }

        public static bool ContemNumero(string texto)
        {
            bool fraseContemNumero = false;
            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                    fraseContemNumero = true;
                }
            }
            return fraseContemNumero;// ou usar Regex.IsMatch(texto, @"\d");
        }

        public static bool VoltarAoLogin(string texto)
        {
            return texto.Equals("sim", StringComparison.OrdinalIgnoreCase); //já volta vdd ou falso, n precisa de mais um booleano
        }
    }
}
