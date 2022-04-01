using Microsoft.AspNetCore.Mvc;

namespace BankAccounts.Controllers
{
    [ApiController]
    [Route("ContaCorrente")]
    public class ContaCorrenteController : ControllerBase
    {
        private Service.ContaCorrenteService service = new Service.ContaCorrenteService();

        [HttpPost]
        public void Salvar(models.ContaCorrente conta)
        {
            service.Cadastrar(conta);
        }
        
        [HttpGet]
        public List<models.ContaCorrente> ListAllAccountCorrente()
        {
            return service.ListAllAccountCorrente();
        }

        [HttpGet("{id}")]
        public List<models.ContaCorrente> getById(int id)
        {
            return service.findByID(id);
        }

        [HttpPut("{id}")]
        public void UpdateAccount(models.ContaCorrente account, int id)
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