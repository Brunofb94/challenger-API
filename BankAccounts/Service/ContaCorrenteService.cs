namespace BankAccounts.Service
{
    public class ContaCorrenteService
    {
        private models.BankAccountContext ctx = new models.BankAccountContext();

        public bool Cadastrar(models.ContaCorrente conta)
        {
            var id_verify = ctx.Accounts.Find(conta.IdAccount);
            if(id_verify != null) {
                ctx.Add(conta);
                ctx.SaveChanges();
                return true;
            }
            else {
                return false;
            }
            
        }
         public List<models.ContaCorrente> ListAllAccountCorrente()
        {
            List<models.ContaCorrente> accounts = ctx.ContaCorrentes.ToList();
            return accounts;
        }
        public List<models.ContaCorrente> findByID(int id)
        {

            List<models.ContaCorrente> accounts = ctx.ContaCorrentes.Where(x => x.IdContaCorrente == id).ToList();
            return accounts;
        }

        public void UpdateAccount(models.ContaCorrente account, int id)
        {

            models.ContaCorrente current = ctx.ContaCorrentes.First(x => x.IdContaCorrente == id);
            current.IdAccount = account.IdAccount;
            current.Tipo = account.Tipo;
            ctx.SaveChanges();
        }

        public void RemoveAccount(int id)
        {
            models.ContaCorrente account = ctx.ContaCorrentes.First(x => x.IdContaCorrente == id);
            ctx.Remove(account);
            ctx.SaveChanges();
        }
    }
}