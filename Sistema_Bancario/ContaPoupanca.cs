
namespace Sistema_Bancario
{

    public class ContaPoupanca : ContaBancaria // extend, estende a ContaBancaria
    {

        private int _id;
        
        public ContaPoupanca(int id, string titular, int numeroConta, double saldo) : base(titular, numeroConta, saldo) // Chama o construtor da classe pai
        { //só precisa do super construtor se a pai tem construtor
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
            Saldo += valorPraDepositar + (valorPraDepositar * 0.05);
            Console.WriteLine("Pelo depósito em sua conta poupança, você ganhou um bônus de 0,5%.");
            ExibirSaldo();
        }

    }
}
