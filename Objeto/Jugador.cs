using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalLab2
{
    public class Jugador : Persona
    {      
        private int _partidosJugados;
        private int _partidosGanados;
        private int _categoriaActual;
        private int _torneosJugados;
        private int _torneosGanados;
 
        public Jugador(int partidosJugados, int partidosGanados, int categoriaActual, int torneosJugados, int torneosGanados)
        {
            _partidosJugados = partidosJugados;
            _partidosGanados = partidosGanados;
            _categoriaActual = categoriaActual;
            _torneosJugados = torneosJugados;
            _torneosGanados = torneosGanados;
        }

       
        public Jugador(int id, string nombreCompleto, string DNI, int celular, string imagen, int partidosJugados, int partidosGanados, int categoriaActual,int torneosJugados, int torneosGanados)
            :base (id, nombreCompleto, DNI, celular, imagen)
        {
            _partidosJugados = partidosJugados;
            _partidosGanados = partidosGanados;
            _categoriaActual = categoriaActual;
            _torneosJugados = torneosJugados;
            _torneosGanados = torneosGanados;
        }

        
       public int PartidosJugados { get => _partidosJugados; set => _partidosJugados = value; }
       public int PartidosGanados { get => _partidosGanados; set => _partidosGanados = value; }
       public int CategoriaActual { get => _categoriaActual; set => _categoriaActual = value; }
       public int TorneosJugados { get => _torneosJugados; set => _torneosJugados = value; }
       public int TorneosGanados { get => _torneosGanados; set => _torneosGanados = value; }
       
    }
}
