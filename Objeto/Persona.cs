using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalLab2
{
    public abstract class Persona
    {
        private int _id;
        private string _nombreCompleto;
        private string _DNI;
        private int _celular;
        private string _imagen;
        
        public Persona() { }
        public Persona(int id, string nombreCompleto, string DNI, int celular, string imagen)
        {
            _id = id;
            _nombreCompleto = nombreCompleto;
            _DNI = DNI;
            _celular = celular;
            _imagen = imagen;
        }

        public int Id { get => _id; set => _id = value; }
        public string NombreCompleto { get => this._nombreCompleto; set => this._nombreCompleto = value; }
        public string DNI { get => this._DNI; set => this._DNI = value; }
        public int Celular { get => this._celular; set => this._celular = value; }
        public string Imagen { get => _imagen; set => _imagen = value; }
    }
}
