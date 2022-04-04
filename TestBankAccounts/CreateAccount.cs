using Xunit;
namespace TestBankAccounts
{
    public class CreateAccount
    {
        [Fact]
        public void AdicionarValorAConta()
        {
            var ct = new BankAccounts.Service.AccountService();
            ct.Depositar(4500, 7);

        }
        [Fact]
        public void SacarValorInsuficiente()
        {
            var ct = new BankAccounts.Service.AccountService();
            var sacar = ct.RetirarGrana(45000, 7);
            Assert.Equal("Saldo Insuficiente!", "Não há Saldo");
        }
        [Fact]
        public void SacarValorSuficiente()
        {
            var ct = new BankAccounts.Service.AccountService();
            var sacar = ct.RetirarGrana(450, 7);
            Assert.Equal("Valor Retirado!", "Não há Saldo");
        }
    }
}