using Microsoft.AspNetCore.Mvc;

namespace BankAccounts.Controllers
{
    [ApiController]
    [Route("ContaBancaria")]
    public class AccountController
    {
        private Service.AccountService service = new Service.AccountService();

        [HttpPost]
        public void Salvar(models.Account conta)
        {
            service.saveAccount(conta);
        }

        [HttpGet]
        public List<models.Account> ListAllAccount()
        {
            return service.ListAllAccount();
        }

        [HttpGet("{id}")]
        public List<models.Account> getById(int id)
        {
            return service.findByID(id);
        }

        [HttpPut("{id}")]
        public void UpdateAccount(models.Account account, int id)
        {

            service.UpdateAccount(account, id);
        }
        [HttpPut("sacar/{id}")]
        public void Sacar(models.Account account, int id)
        {
            service.RetirarGrana(account, id);
        }
        [HttpPut("depositar/{id}")]
        public void Depositar(models.Account account, int id)
        {
            service.Depositar(account, id);
        }
        [HttpDelete("{id}")]
        public void RemoveAccount(int id)
        {
            service.RemoveAccount(id);
        }
    }
}