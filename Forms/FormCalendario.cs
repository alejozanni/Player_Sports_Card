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
    public partial class FormCalendario : Form
    {
        public FormCalendario()
        {
            InitializeComponent();

            DateTime torneo1_inicio = new DateTime(2022, 1, 13);
            DateTime torneo1_fin = new DateTime(2022, 1, 16);

            monthCalendar1.SelectionRange = new SelectionRange(torneo1_inicio, torneo1_fin);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int anioInicio = Convert.ToInt32(textBoxAnioInicio.Text);
                int mesInicio = Convert.ToInt32(textBoxMesInicio.Text);
                int diaInicio = Convert.ToInt32(textBoxDiaInicio.Text);
                int anioFin = Convert.ToInt32(textBoxAnioFin.Text);
                int mesFin = Convert.ToInt32(textBoxMesFin.Text);
                int diaFin = Convert.ToInt32(textBoxDiaFin.Text);


                DateTime torneo_inicio = new DateTime(anioInicio, mesInicio, diaInicio);
                DateTime torneo_fin = new DateTime(anioFin, mesFin, diaFin);

                monthCalendar1.SelectionRange = new SelectionRange(torneo_inicio, torneo_fin);

                MessageBox.Show("Fecha del proximo torneo creada con exito");

                textBoxAnioInicio.Text = "";
                textBoxMesInicio.Text = "";
                textBoxDiaInicio.Text = "";
                textBoxAnioFin.Text = "";
                textBoxMesFin.Text = "";
                textBoxDiaFin.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan Datos");
            }
            
          
        }
    }
}
