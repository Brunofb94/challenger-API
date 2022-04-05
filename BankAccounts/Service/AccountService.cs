namespace BankAccounts.Service
{
    public class AccountService
    {
        private models.BankAccountContext ctx = new models.BankAccountContext();
        public void saveAccount(models.Account conta)
        {
            ctx.Add(conta);
            ctx.SaveChanges();

        }
        public List<models.Account> ListAllAccount()
        {

            List<models.Account> accounts = ctx.Accounts.ToList();
            return accounts;
        }
        public List<models.Account> findByID(int id)
        {

            List<models.Account> accounts = ctx.Accounts.Where(x => x.Id == id).ToList();
            return accounts;
        }

        public string UpdateAccount(models.Account account, int id)
        {

            var id_verify = ctx.Accounts.Find(id);
            if (id_verify != null)
            {
                models.Account current = ctx.Accounts.First(x => x.Id == id);
                current.Agency = account.Agency;
                current.StartAccount = account.StartAccount;
                current.NumberAccount = account.NumberAccount;
                current.Balance = account.Balance;
                current.ContaPoupancas = account.ContaPoupancas;
                current.ContaCorrentes = account.ContaCorrentes;
                ctx.SaveChanges();
                return "Dados Bancários Atualizados!";

            }
            else
            {
                return "Conta não Existente!";
            }



        }

        public bool RemoveAccount(int id)
        {
            var id_verify = ctx.Accounts.Find(id);
            if (id_verify != null)
            {
                models.Account account = ctx.Accounts.First(x => x.Id == id);
                ctx.Remove(account);
                ctx.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public string RetirarGrana(double valor, int id)
        {
            models.Account current = ctx.Accounts.First(x => x.Id == id);

            if (valor > current.Balance)
            {
                return "Saldo Insuficiente!";
            }
            else
            {
                current.Balance = current.Balance - valor;

                ctx.SaveChanges();
                return "Valor Retirado!";
            }
        }
        public string Depositar(double valor, int id)
        {
            models.Account current = ctx.Accounts.First(x => x.Id == id);
            current.Balance = current.Balance + valor;
            ctx.SaveChanges();
            return "Valor Depositado!";

        }
    }
}