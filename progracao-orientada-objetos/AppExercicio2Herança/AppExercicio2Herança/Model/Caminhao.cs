using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicio2Herança.Model
{
    public class Caminhao:Veiculo
    {
        private int capacidadeCarga;
        private Int32 numeroEixos;

        public int CapacidadeCarga { get => capacidadeCarga; set => capacidadeCarga = value; }
        public int NumeroEixos { get => numeroEixos; set => numeroEixos = value; }
    }
}
