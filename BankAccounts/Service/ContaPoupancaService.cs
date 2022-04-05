namespace BankAccounts.Service
{
    public class ContaPoupancaService
    {
        private models.BankAccountContext ctx = new models.BankAccountContext();

        public bool saveAccount(models.ContaPoupanca conta)
        {
            var id_verify = ctx.Accounts.Find(conta.IdAccount);
            if (id_verify != null)
            {
                ctx.Add(conta);
                ctx.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<models.ContaPoupanca> ListAllAccountPoupanca()
        {
            List<models.ContaPoupanca> accounts = ctx.ContaPoupancas.ToList();
            return accounts;
        }
        public List<models.ContaPoupanca> findByID(int id)
        {

            List<models.ContaPoupanca> accounts = ctx.ContaPoupancas.Where(x => x.IdContaPoupanca == id).ToList();
            return accounts;
        }

        public void UpdateAccount(models.ContaPoupanca account, int id)
        {

            models.ContaPoupanca current = ctx.ContaPoupancas.First(x => x.IdContaPoupanca == id);
            current.IdAccount = account.IdAccount;
            current.Tipo = account.Tipo;
            current.Tax = account.Tax;
            ctx.SaveChanges();
        }

        public void RemoveAccount(int id)
        {
            models.ContaPoupanca account = ctx.ContaPoupancas.First(x => x.IdContaPoupanca == id);
            ctx.Remove(account);
            ctx.SaveChanges();
        }
    }
}