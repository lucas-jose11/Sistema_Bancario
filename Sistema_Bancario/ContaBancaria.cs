using System.Globalization;

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
            ExibirSaldo();
        }

        public void Sacar(double valorParaSacar)
        {
            if (valorParaSacar > _saldo)
                Console.WriteLine($"Impossível sacar pois o saldo disponível (R${valorParaSacar}) é menor do que a quantia que você quer sacar (R${_saldo}).");
            else
            {
                _saldo -= valorParaSacar;
                Console.WriteLine("Saque bem-sucedido!");
                ExibirSaldo();
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual em sua conta: {_saldo.ToString("C2", new CultureInfo("pt-BR"))}.");
        }

    }
}
