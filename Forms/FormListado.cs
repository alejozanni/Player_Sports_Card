using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalLab2
{
    public partial class FormListado : Form
    {
        
        public static FormListado instance;
        

        public FormListado()
        {
            InitializeComponent();
            instance = this;
        }

        public void Actualizar(List<Jugador> datos)
        {
            dGVListado.Rows.Clear();
            foreach(Jugador jugador in datos)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = jugador.Id });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = jugador.NombreCompleto });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = jugador.DNI });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = jugador.Celular });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = jugador.CategoriaActual });
                dGVListado.Rows.Add(fila);
            }
        }

    }
}
