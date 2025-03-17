using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario
{
    public class ContaBancaria
    {

        private long _numeroConta;

        private string _titular;

        private double _saldo;

        //quais mais atributos?


        public void DefinirNumeroConta()
        {
            _numeroConta = Organizacao.PaginaConfirmacao();
        }

        public ContaBancaria(string titular, double saldoInicial)
        {
            _titular = titular;
            _saldo = saldoInicial;
        }

        public string NomeConta()
        {
            return _titular;
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
