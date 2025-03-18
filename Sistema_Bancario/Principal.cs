
namespace Sistema_Bancario
{
    public class Principal
    {
        static void Main(string[] args) //melhroar a página inicial
        {

            Organizacao token = new Organizacao(); // precisa instanciar nesse caso
            
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

                aux = NumeroInteiro();

                token.MenuBanco(aux);

            } //se digitar 0 "vai 2 vezes" até sair do programa, arrumar


        }


        static int NumeroInteiro()
        {
            Console.WriteLine("=================\nDigite uma opção válida (0 a 6):");
            string entrada = Console.ReadLine();

            // Verifica se a entrada é um número válido e está no intervalo 0-6
            if (int.TryParse(entrada, out int numero) && numero > -1 && numero < 7)
            {
                return numero; // Retorna o número válido
            }
            else
            {
                Console.WriteLine("Erro! A entrada deve ser um número entre 0 e 6.");

                // Chama o método novamente (recursão)
                return NumeroInteiro();
            }
        }
    }
}

/*
Sistema de Conta Bancária
---------------------------
Contexto
Um banco deseja implementar um sistema para gerenciar diferentes tipos de contas bancárias de seus clientes.
Cada conta tem um saldo e permite operações como depósito e saque. 
Além disso, há diferentes tipos de contas com regras específicas.

Seu desafio é modelar esse sistema utilizando encapsulamento, construtores, getters/setters, this e herança.

Requisitos do Exercício
      1.    Criar a classe base ContaBancaria contendo:
          • Atributos (privados):
              •   numeroConta (int)
              •   titular (string)
              •   saldo (double)
          • Métodos:
              •   Construtor: recebe numeroConta, titular e saldo inicial.
              •   Depositar(double valor): adiciona o valor ao saldo.
              •   Sacar(double valor): reduz o saldo, mas impede saque se não houver saldo suficiente.
              •   ExibirSaldo(): exibe o saldo atual.
      2.    Criar duas classes filhas que herdam de ContaBancaria e possuem regras próprias:
          • ContaCorrente: cobra uma taxa fixa de R$ 5,00 a cada saque.
          •       ContaPoupanca: possui um bônus de 0.5% sobre cada depósito.
      3.    Encapsular os atributos (private) e utilizar Getters e Setters para acessar/modificar titular e saldo.
      4.    Criar um programa principal (Main) que:
          • Instancie pelo menos uma ContaCorrente e uma ContaPoupanca.
          • Faça depósitos e saques em ambas as contas.
          • Exiba os saldos após cada operação.


------------------------
Exemplo de Código (Estrutura Simplificada)

ContaCorrente cc = new ContaCorrente(123, "João Silva", 1000);
cc.Depositar(500);
cc.Sacar(200);
cc.ExibirSaldo();

ContaPoupanca cp = new ContaPoupanca(456, "Maria Souza", 2000);
cp.Depositar(1000);
cp.Sacar(500);
cp.ExibirSaldo();

-----------------------
Saída Esperada:
Conta Corrente - João Silva | Saldo: R$ 1.295,00  
Conta Poupança - Maria Souza | Saldo: R$ 2.505,00  

 */