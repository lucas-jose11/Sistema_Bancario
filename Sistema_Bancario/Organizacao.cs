using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario
{
    public class Organizacao
    {



        public static void LoginSenha()
        {

            bool loginEfetuado = false;
            while (!loginEfetuado)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("==========PÁGINA DE LOGIN==========");

                    Console.Write("Nome do titular: ");
                    string nomeTitular = Console.ReadLine();
                    if (string.IsNullOrEmpty(nomeTitular))
                        throw new Exception("!!Falha ao tentar logar!!\n!!Campo nulo detectado!!\n-------------------------\n");


                    Console.Write("Senha do titula: ");
                    string senhaTitular = Console.ReadLine();
                    if (string.IsNullOrEmpty(senhaTitular))
                        throw new Exception("\n!!Falha ao tentar logar!!\n!!Campo nulo detectado!!\n-------------------------\n");

                    //se nome for nulo ou tiver numero
                    //se senha for nula
                    //while


                    ContaBancaria dadosTitular = new ContaBancaria(123456789, nomeTitular, 10000);
                    loginEfetuado = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Aperte enter para voltar à tela de login para tentar novamente.");
                    Console.ReadLine();
                }
            }

            MenuConta();
        }

        public static void MenuConta()
        {
            Console.WriteLine("=================MENU DA CONTA=================");
            Console.WriteLine("[1] - ENRTAR NA CONTA CORRENTE");
            Console.WriteLine("[2] - ENRTAR NA CONTA POUPANÇA");
            Console.WriteLine("[3] - DETALHES DA MINHA CONTA");
            Console.WriteLine("[4] - SAIR (FAZER LOGOUT)");

            //e se digitar algo invalido, numero fora de ordem ou letra ou nulo?
            int escolhaMenuConta = int.Parse(Console.ReadLine());

            switch (escolhaMenuConta)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    LoginSenha();
                    break;
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
    }
}
