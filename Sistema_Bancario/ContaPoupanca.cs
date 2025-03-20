
namespace Sistema_Bancario
{
    public class ContaPoupanca : ContaBancaria 
    {

        private int _id;
        
        public ContaPoupanca(int id, string titular, int numeroConta, double saldo) : base(titular, numeroConta, saldo) 
        {
            Id = id;
        }


        public int Id 
        {
            get { return _id; }
            set { _id = value; }
        }

        public void DepositoComBonus(double valorPraDepositar)
        {
            Saldo += valorPraDepositar + (valorPraDepositar * 0.05);
            Console.WriteLine("Pelo depósito em sua conta poupança, você ganhou um bônus de 0,5%.");
            ExibirSaldo();
        }

    }
}
