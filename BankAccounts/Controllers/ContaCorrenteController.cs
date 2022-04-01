using Microsoft.AspNetCore.Mvc;

namespace BankAccounts.Controllers
{
    [ApiController]
    [Route("ContaCorrente")]
    public class ContaCorrenteController : ControllerBase
    {
        private Service.ContaCorrenteService service = new Service.ContaCorrenteService();

        [HttpPost]
        public string Salvar(models.ContaCorrente conta)
        {
            if (conta.IdAccount == null || conta.IdAccount.Equals(" "))
            {
                return "Informe um ID válido";
            }
            else
            {
                service.Cadastrar(conta);
                return "Conta corrente Criada com Sucesso!";
            }

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