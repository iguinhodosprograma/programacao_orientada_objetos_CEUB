using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicio2Herança.Model
{
    public class Moto:Veiculo
    {
        private int cilindrada;
        private bool temPartidaEletrica;

        public int Cilindrada { get => cilindrada; set => cilindrada = value; }
        public bool TemPartidaEletrica { get => temPartidaEletrica; set => temPartidaEletrica = value; }
    }
}
