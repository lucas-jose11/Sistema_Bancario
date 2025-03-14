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


        public ContaBancaria(int numeroConta, string titular, double saldoInicial)
        {
            _numeroConta = numeroConta;
            _titular = titular;
            _saldo = saldoInicial;
        }

        public void Depositar(double valorParaDepositar)
        {
            //saldo inicial += valorParaDepositar
        }

        public void Sacar(double valorParaSacar)
        {
            //reduz o saldo, mas impede o saque se n houver saldo suficiente
        }

        public void ExibirSaldo()
        {
            //exibe o saldo atual
        }
    }
}
