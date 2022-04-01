using Microsoft.AspNetCore.Mvc;

namespace BankAccounts.Controllers
{
    [ApiController]
    [Route("ContaPoupanca")]
    public class ContaPoupancaController
    {
        private Service.ContaPoupancaService service = new Service.ContaPoupancaService();

        [HttpPost]
        public void Salvar(models.ContaPoupanca conta)
        {
            service.saveAccount(conta);
        }

        [HttpGet]
        public List<models.ContaPoupanca> ListAllAccountPoupanca()
        {
            return service.ListAllAccountPoupanca();
        }

        [HttpGet("{id}")]
        public List<models.ContaPoupanca> getById(int id)
        {
            return service.findByID(id);
        }

        [HttpPut("{id}")]
        public void UpdateAccount(models.ContaPoupanca account, int id)
        {

            service.UpdateAccount(account, id);
        }
        [HttpDelete("{id}")]
        public void RemoveAccount(int id)
        {
            service.RemoveAccount(id);
        }
    }
}