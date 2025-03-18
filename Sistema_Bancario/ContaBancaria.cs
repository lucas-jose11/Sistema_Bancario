using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario
{
    public class ContaBancaria
    {

        private int _numeroConta;

        private string _titular;

        private double _saldo;


        public string Titular
        {
            get { return _titular; }
            set
            {
                if ( !(String.IsNullOrEmpty(value)) )
                    _titular = value;
                else
                    throw new Exception("Campo do nome nulo.");
            }
        }

        public int NumeroConta
        {
            get { return _numeroConta; }
            set
            {
                if (value.ToString().Length == 8)
                    _numeroConta = value;
                else
                    throw new Exception("O número da conta deve conter 8 algarismos.");
            }
        }

        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value > 0)
                    _saldo = value;
                else
                    throw new Exception("Precisamos ter um mínimo de 100 reais para abrirmos sua conta!!");
            }
        }

        public ContaBancaria(string titular, int numeroConta, double saldoInicial)
        {
            Titular = titular;
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        public void Depositar(double valorParaDepositar)
        {
            _saldo += valorParaDepositar;
        }

        public void Sacar(double valorParaSacar)
        {
            //reduz o saldo, mas impede o saque se n houver saldo suficiente
            if (valorParaSacar > _saldo)
                Console.WriteLine("Impossível sacar pois o saldo disponível é menor do que a quantia que você quer sacar.");
            else
            {
                _saldo -= valorParaSacar;
                Console.WriteLine("Saque bem-sucedido!");
                ExibirSaldo();
            }
        }

        public void ExibirSaldo()
        {
            //exibe o saldo atual
            Console.WriteLine($"Saldo atual em sua conta: R${_saldo}.");
        }

    }
}
