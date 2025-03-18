using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario
{

    //herda da ContaBancaria

    public class ContaPoupanca : ContaBancaria
    {

        private int _id;
        
        public ContaPoupanca(int id, string titular, int numeroConta, double saldo) : base(titular, numeroConta, saldo) // Chama o construtor da classe pai
        {
            Id = id;
        }

        public int Id // +algo aq?
        {
            get { return _id; }
            set { _id = value; }
        }

        public void DepositoComBonus(double valorPraDepositar)
        {
            //possui um bônus de 0,5% para cada depósito
            Saldo += valorPraDepositar + (valorPraDepositar * 0.5);
            Console.WriteLine("Pelo depósito em sua conta poupança, você ganhou um bônus de 0,5%.");
            ExibirSaldo();
        }

    }
}
