using Microsoft.AspNetCore.Mvc;

namespace WebApiOperadoresAritimeticos.Controllers
{
    public class Exercicio4Controller : Controller
    {
        [HttpGet("Media1semestre")]
        public string Media1semestre(double prova1, double prova2, double prova3, double prova4)
        {
            double media;

            media = (prova1 + prova2 + prova3 + prova4)/4;
            return $"A media do 1º semestre foi: {media}";
        }
    }
}
