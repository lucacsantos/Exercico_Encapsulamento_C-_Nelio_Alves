using System.Globalization;

namespace questao1
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public ContaBancaria(int numeroConta, string nome, double depositoInicial) : this(numeroConta, nome)
        {
             Deoposito(depositoInicial);
        }

        public void Deoposito(double quantia)
        {
             Saldo += quantia;
            
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.00;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta
                + ", Titular: " + Nome +
                ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
