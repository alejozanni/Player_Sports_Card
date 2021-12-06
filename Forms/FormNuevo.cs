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
    public partial class FormNuevo : Form
    {
        public FormNuevo()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click_1(object sender, EventArgs e)
        {

            try
            {
                int.TryParse(textBoxID.Text, out int id);
                if (id <= 0) throw new Exception("No se puede poner un ID menor a 1");
                string nombre = textBoxNombreCompleto.Text;
                string dni = textBoxDNI.Text;
                int.TryParse(textBoxCelular.Text, out int celular);
                int.TryParse(textBoxPartidosJugados.Text, out int jugados);
                int.TryParse(textBoxPartidosGanados.Text, out int ganados);
                int.TryParse(textBoxCategoria.Text, out int categoria);
                if (categoria <= 0 || categoria > 8) throw new Exception("La categoria no puede ser menor a 0 o mayor a 8");
                int.TryParse(textBoxTorneosJugados.Text, out int torneosJugados);
                int.TryParse(textBoxTorneosGanados.Text, out int torneosGanados);
                string imagen = openFileDialog1.FileName;

                Jugador jugador = List.Instance.Lista.Find(x => x.Id == id);

                if (jugador != null)
                {
                    throw new Exception("Ya existe ese ID");
                }

                Jugador Padel = new Jugador(id, nombre, dni, celular, imagen, jugados, ganados, categoria, torneosJugados, torneosGanados);

                List.Instance.agregarJugador(Padel);               

                MessageBox.Show("Jugador: " + nombre + " creado con exito");

                textBoxID.Text = "";
                textBoxNombreCompleto.Text = "";
                textBoxDNI.Text = "";
                textBoxCelular.Text = "";
                textBoxPartidosJugados.Text = "";
                textBoxPartidosGanados.Text = "";
                textBoxCategoria.Text = "";
                textBoxTorneosJugados.Text = "";
                textBoxTorneosGanados.Text = "";
              
            } 
            catch (FormatException)
            {
                MessageBox.Show("Los datos estan incorrectos o faltan datos");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }                  
        }

        private void buttonCargarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBoxNuevo.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen valido");
            }
        }
    }
}
