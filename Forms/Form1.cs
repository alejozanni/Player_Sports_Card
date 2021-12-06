using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FontAwesome.Sharp;
using System.Windows.Forms;




namespace ProyectoFinalLab2
{
    public partial class Form1 : Form
    {      
        public Form1()
        {
            InitializeComponent();

            this.panel = new Panel();
            panel.Size = new Size(7, 50);
            panelLeft.Controls.Add(panel);
        }

        FormNuevo formNuevo = new FormNuevo();
        FormListado formListado = new FormListado();
        FormEstadisticas formEstadisticas = new FormEstadisticas();
        FormCalendario formCalendario = new FormCalendario();
        private void activarBoton(object senderBtn, Color customColor)
        {
            if (senderBtn != null)
            {
                desactivarBoton();

                botonActual = (IconButton)senderBtn;
                botonActual.BackColor = Color.FromArgb(37, 36, 81);
                botonActual.ForeColor = customColor;
                botonActual.IconColor = customColor;
                botonActual.TextAlign = ContentAlignment.MiddleCenter;
                botonActual.ImageAlign = ContentAlignment.MiddleRight;
                botonActual.TextImageRelation = TextImageRelation.TextBeforeImage;

                panel.BackColor = customColor;
                panel.Location = new Point(0, botonActual.Location.Y);
                panel.Visible = true;
                panel.BringToFront();

                iconPictureInicio.IconChar = botonActual.IconChar;
                iconPictureInicio.IconColor = customColor;
            }
        }

        private void desactivarBoton()
        {
            if (botonActual != null)
            {
                botonActual.BackColor = Color.FromArgb(31, 30, 68);
                botonActual.ForeColor = Color.Gainsboro;
                botonActual.IconColor = Color.Gainsboro;
                botonActual.TextAlign = ContentAlignment.MiddleLeft;
                botonActual.ImageAlign = ContentAlignment.MiddleLeft;
                botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private void iconButtonNuevo_Click(object sender, EventArgs e)
        {
            activarBoton(sender, Color.FromArgb(172, 126, 241));
            formNuevo.TopLevel = false;
            formNuevo.FormBorderStyle = FormBorderStyle.None;
            formNuevo.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(formNuevo);
            panelEscritorio.Tag = formNuevo;
            formNuevo.BringToFront();
            formNuevo.Show();
            labelInicio.Text = "Nuevo Jugador";
        }

        private void iconButtonListar_Click(object sender, EventArgs e)
        {
            activarBoton(sender, Color.FromArgb(249, 118, 176));
            formListado.TopLevel = false;
            formListado.FormBorderStyle = FormBorderStyle.None;
            formListado.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(formListado);
            panelEscritorio.Tag = formListado;
            formListado.BringToFront();
            formListado.Show();
            labelInicio.Text = "Listado de jugadores";
        }

        private void iconButtonEstadisticas_Click(object sender, EventArgs e)
        {
            activarBoton(sender, Color.FromArgb(253,138,114));
            formEstadisticas.TopLevel = false;
            formEstadisticas.FormBorderStyle = FormBorderStyle.None;
            formEstadisticas.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(formEstadisticas);
            panelEscritorio.Tag = formEstadisticas;
            formEstadisticas.BringToFront();
            formEstadisticas.Show();
            labelInicio.Text = "Estadisticas";
        }

        private void iconButtonCalendario_Click(object sender, EventArgs e)
        {
            activarBoton(sender, Color.FromArgb(24, 161, 251));
            formCalendario.TopLevel = false;
            formCalendario.FormBorderStyle = FormBorderStyle.None;
            formCalendario.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(formCalendario);
            panelEscritorio.Tag = formCalendario;
            formCalendario.BringToFront();
            formCalendario.Show();
            labelInicio.Text = "Calendario";
        }

        

    }
}
