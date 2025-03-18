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

        public int NumeroConta
        {
            get { return _numeroConta; }
            set
            {
                if (!(value.ToString().Length == 8))
                    _numeroConta = value;
                else
                    NumeroConta();
            }
        }

        public int 

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
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
