using Xunit;
namespace TestBankAccounts
{
    public class CreateAccount
    {
        [Fact]
        public void AdicionarValorAConta()
        {
            var ct = new BankAccounts.Service.AccountService();
            var depositar = ct.Depositar(4500, 7);
            Assert.Equal("Valor Depositado!", depositar);

        }
        [Fact]
        public void SacarValorInsuficiente()
        {
            var ct = new BankAccounts.Service.AccountService();
            var sacar = ct.RetirarGrana(45000000, 7);
            Assert.Equal("Saldo Insuficiente!", sacar);
        }
        [Fact]
        public void SacarValorSuficiente()
        {
            var ct = new BankAccounts.Service.AccountService();
            var sacar = ct.RetirarGrana(14, 7);
            Assert.Equal("Valor Retirado!", sacar);
        }

        [Fact]
        public void VerificarSeoUsuarioExistenteParaDeletar()
        {

            var ct = new BankAccounts.Service.AccountService();
            var remove = ct.RemoveAccount(9);
            Assert.True(remove);
        }

        [Fact]
        public void VerificarSeoUsuarioNãoExistenteParaDeletar()
        {

            var ct = new BankAccounts.Service.AccountService();
            var remove = ct.RemoveAccount(9);
            Assert.False(remove);
        }
        [Fact]
        public void AContaExistenteParaAtualizar()
        {

            var ct = new BankAccounts.Service.AccountService();
            BankAccounts.models.Account account = new BankAccounts.models.Account();
            account.Agency = 394;
            var update = ct.UpdateAccount(account, 7);
            Assert.Equal("Dados Bancários Atualizados!", update);
        }
        [Fact]
        public void AContaNaoExistenteParaAtualizar()
        {

            var ct = new BankAccounts.Service.AccountService();
            BankAccounts.models.Account account = new BankAccounts.models.Account();
            account.Agency = 394;
            var update = ct.UpdateAccount(account, 9);
            Assert.Equal("Dados Bancários Atualizados!", update);
        }

        [Fact]
        public void ContaExisteParaCriarUmaContaCorrente()
        {

            var ct = new BankAccounts.Service.ContaCorrenteService();
            BankAccounts.models.ContaCorrente account = new BankAccounts.models.ContaCorrente();
            account.IdAccount = 7;
            account.Tipo = "Comum";
            var cadastro = ct.Cadastrar(account);

            Assert.True(cadastro);
        }
          [Fact]
        public void ContaNaoExisteParaCriarUmaContaCorrente()
        {

            var ct = new BankAccounts.Service.ContaCorrenteService();
            BankAccounts.models.ContaCorrente account = new BankAccounts.models.ContaCorrente();
            account.IdAccount = 70;
            account.Tipo = "Comum";
            var cadastro = ct.Cadastrar(account);

            Assert.False(cadastro);
        }
         [Fact]
        public void ContaExisteParaCriarUmaContaPoupanca()
        {

            var ct = new BankAccounts.Service.ContaPoupancaService();
            BankAccounts.models.ContaPoupanca account = new BankAccounts.models.ContaPoupanca();
            account.IdAccount = 7;
            account.Tipo = "Comum";
            var cadastro = ct.saveAccount(account);

            Assert.True(cadastro);
        }
          [Fact]
        public void ContaNaoExisteParaCriarUmaContaPoupanca()
        {

            var ct = new BankAccounts.Service.ContaPoupancaService();
            BankAccounts.models.ContaPoupanca account = new BankAccounts.models.ContaPoupanca();
            account.IdAccount = 70;
            account.Tipo = "Comum";
            var cadastro = ct.saveAccount(account);

            Assert.False(cadastro);
        }
    }
}