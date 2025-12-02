using Microsoft.AspNetCore.Mvc;
using WebApiExercicio6POO.Model;

namespace WebApiExercicio6POO.Controllers
{
    public class CarroController : Controller
    {
        [HttpGet("ImprimirDadosVeiculo")]
        public string ImprimirDadosVeiculo(string marcaCarro, string modeloCarro, string placaCarro, string corCarro, 
                                           Int32 numerMarchasCarro, Int32 anoFabricacaoCarro, Int32 anoModeloCarro)
        {
            Carro carro = new Carro();
            carro.marca = marcaCarro;
            carro.modelo = modeloCarro;
            carro.placa = placaCarro;
            carro.cor = corCarro;
            carro.numeroMarchas = numerMarchasCarro;
            carro.anoFabricacao = anoFabricacaoCarro;
            carro.anoModelo = anoModeloCarro;

            return $"Marca: {carro.marca}\r\n" +
                   $"Modelo: {carro.modelo}\r\n" +
                   $"Placa: {carro.placa}\r\n" +
                   $"Cor: {carro.cor}";
        }
        [HttpGet("Buzinar")]
        public string Buzinar()
        {
            Carro carro = new Carro();
            return carro.Buzinar();
        }

        [HttpGet("LigarCarro")]
        public string LigarCarro()
        {
            string resultado;
            Carro carro = new Carro();
            if (carro.ligar)
            {
                resultado = "O carro já está ligado!!!";
            }
            else
            {
                resultado = "O carro foi ligado!!!";
            }
            return resultado;
        }
    }
}
