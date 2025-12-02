using Microsoft.AspNetCore.Mvc;

namespace WebApiOperadoresAritimeticos.Controllers
{
    public class Exercicio5Controller : Controller
    {
        [HttpGet("Aplicacao")]
        public string AplicacaoReajuste(double aplicacao)
        {
            double aplicacaoReajuste;
            aplicacaoReajuste = (aplicacao*1/100)+aplicacao;
            return $"A sua aplicacao é de {aplicacao} e após o reajuste de 1% foi para {aplicacaoReajuste}";
        }
    }
}
