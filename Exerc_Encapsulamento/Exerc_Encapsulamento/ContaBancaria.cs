

namespace Exerc_Encapsulamento {
    class ContaBancaria {
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string titular) {
            Conta = conta;
            Titular = titular;
        }
        public ContaBancaria(int conta, string titular, double saldo) : this(conta, titular) {
            Saldo = saldo;
        }
        public void deposito(double quantia) {
            Saldo += quantia;
        }
        public void saque(double quantia) {
            Saldo = Saldo - quantia - 5.0;
        }
        public override string ToString() {
            return "Conta "
                + Conta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo;
        }
    }
}
