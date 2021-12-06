using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoFinalLab2
{
    public class List
    {
        private static List instance;
        private List<Jugador> lista;
        public static List Instance
        {
            get
            {
                if (instance == null)
                
                    instance = new List();
                
                return instance;
            }
        }

        public List<Jugador> Lista { get => lista; set => lista = value; }

        public List()
        {
            nuevaLista();
        }

        public void nuevaLista()
        {
            lista = new List<Jugador>();
        }

        public void agregarJugador (Jugador nuevoJugador)
        {
            lista.Add(nuevoJugador);
            Actualizar();           
        }

        private void Actualizar()
        {
            FormListado.instance.Actualizar(lista);
        }                
    }
}
