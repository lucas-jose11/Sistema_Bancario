
namespace Sistema_Bancario
{
    public class ContaCorrente : ContaBancaria
    {
        private int _id;

        public ContaCorrente(int id, string titular, int numeroConta, double saldo) : base(titular, numeroConta, saldo) // Chama o construtor da classe pai
        {
            Id = id;
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public void SaqueTaxado(double valorPraSacar)
        {
            if (valorPraSacar > Saldo)
            {
                Console.WriteLine($"Impossível sacar, pois há não saldo suficiente para fazer o saque " +
                                  $"desejado de R${valorPraSacar}, pois o saldo atual é de R${Saldo}.");
            }
            else
            {
                Saldo -= valorPraSacar + 5;
                Console.WriteLine("Foi cobrado uma taxa de R$5,00 para fazer esse saque em sua conta corrente.");
                ExibirSaldo();
            }
        }

    }
}
