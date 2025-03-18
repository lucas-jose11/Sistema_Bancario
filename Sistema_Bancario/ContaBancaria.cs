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
                if (value.ToString().Length == 8)
                    _numeroConta = value;
                else
                    throw new Exception("Minimo 8 caracteres");
            }
        }
      

        public string Titular
        {
            get { return _titular; }
            set
            {
                if (value.ToString().Length == 8)
                    _numeroConta = value;
                else
                    throw new Exception("Minimo 8 caracteres");
            }
        }

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public ContaBancaria(int numeroConta, string titular, double saldoInicial)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldoInicial;
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
