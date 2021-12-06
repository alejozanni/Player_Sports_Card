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
    public partial class FormEstadisticas : Form
    {
        string nombre;
        public FormEstadisticas()
        {
            InitializeComponent();
            
            
        }

        public string Nombre { get => nombre; set => nombre = value; }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Jugador jugador = List.Instance.Lista.Find(x => x.DNI == textBoxBusquedaId.Text);
                if (jugador == null)
                {
                    throw new Exception("No se encontro jugador");
                }

                double partidosJugados = Convert.ToDouble(jugador.PartidosJugados);
                double partidosGanados = Convert.ToDouble(jugador.PartidosGanados);
                double torneoJugados = Convert.ToDouble(jugador.TorneosJugados);
                double torneoGanados = Convert.ToDouble(jugador.TorneosGanados);
                pictureBoxJugadorEstadisticas.Image = Image.FromFile(jugador.Imagen);
                nombre = (jugador.NombreCompleto);
                labelNombre.Text = (nombre);

                chart1.Titles.Add("Categoria: " + jugador.CategoriaActual);

                chart1.Series["Partidos Jugados"].Points.Add(partidosJugados);
                chart1.Series["Partidos Ganados"].Points.Add(partidosGanados);
                chart1.Series["Torneos Jugados"].Points.Add(torneoJugados);
                chart1.Series["Torneos Ganados"].Points.Add(torneoGanados);

            } catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }           
        }
    }
}
