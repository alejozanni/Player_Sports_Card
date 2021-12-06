
namespace ProyectoFinalLab2
{
    partial class FormCalendario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.iconButtonCrearFecha = new FontAwesome.Sharp.IconButton();
            this.textBoxAnioInicio = new System.Windows.Forms.TextBox();
            this.textBoxDiaInicio = new System.Windows.Forms.TextBox();
            this.textBoxMesInicio = new System.Windows.Forms.TextBox();
            this.textBoxAnioFin = new System.Windows.Forms.TextBox();
            this.textBoxDiaFin = new System.Windows.Forms.TextBox();
            this.textBoxMesFin = new System.Windows.Forms.TextBox();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelAnioInicio = new System.Windows.Forms.Label();
            this.labelMesInicio = new System.Windows.Forms.Label();
            this.labelDiaInicio = new System.Windows.Forms.Label();
            this.labelDiaFin = new System.Windows.Forms.Label();
            this.labelMesFin = new System.Windows.Forms.Label();
            this.labelAnioFin = new System.Windows.Forms.Label();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.labelnuevoTorneo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Black;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // iconButtonCrearFecha
            // 
            this.iconButtonCrearFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCrearFecha.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonCrearFecha.IconColor = System.Drawing.Color.LimeGreen;
            this.iconButtonCrearFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCrearFecha.Location = new System.Drawing.Point(496, 274);
            this.iconButtonCrearFecha.Name = "iconButtonCrearFecha";
            this.iconButtonCrearFecha.Size = new System.Drawing.Size(51, 52);
            this.iconButtonCrearFecha.TabIndex = 1;
            this.iconButtonCrearFecha.UseVisualStyleBackColor = true;
            this.iconButtonCrearFecha.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // textBoxAnioInicio
            // 
            this.textBoxAnioInicio.Location = new System.Drawing.Point(298, 73);
            this.textBoxAnioInicio.Name = "textBoxAnioInicio";
            this.textBoxAnioInicio.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnioInicio.TabIndex = 2;
            // 
            // textBoxDiaInicio
            // 
            this.textBoxDiaInicio.Location = new System.Drawing.Point(298, 147);
            this.textBoxDiaInicio.Name = "textBoxDiaInicio";
            this.textBoxDiaInicio.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiaInicio.TabIndex = 3;
            // 
            // textBoxMesInicio
            // 
            this.textBoxMesInicio.Location = new System.Drawing.Point(298, 111);
            this.textBoxMesInicio.Name = "textBoxMesInicio";
            this.textBoxMesInicio.Size = new System.Drawing.Size(100, 20);
            this.textBoxMesInicio.TabIndex = 4;
            // 
            // textBoxAnioFin
            // 
            this.textBoxAnioFin.Location = new System.Drawing.Point(298, 212);
            this.textBoxAnioFin.Name = "textBoxAnioFin";
            this.textBoxAnioFin.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnioFin.TabIndex = 7;
            // 
            // textBoxDiaFin
            // 
            this.textBoxDiaFin.Location = new System.Drawing.Point(298, 284);
            this.textBoxDiaFin.Name = "textBoxDiaFin";
            this.textBoxDiaFin.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiaFin.TabIndex = 6;
            // 
            // textBoxMesFin
            // 
            this.textBoxMesFin.Location = new System.Drawing.Point(298, 248);
            this.textBoxMesFin.Name = "textBoxMesFin";
            this.textBoxMesFin.Size = new System.Drawing.Size(100, 20);
            this.textBoxMesFin.TabIndex = 5;
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.ForeColor = System.Drawing.Color.White;
            this.labelFechaInicio.Location = new System.Drawing.Point(376, 45);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(92, 16);
            this.labelFechaInicio.TabIndex = 8;
            this.labelFechaInicio.Text = "Fecha Inicio";
            // 
            // labelAnioInicio
            // 
            this.labelAnioInicio.AutoSize = true;
            this.labelAnioInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnioInicio.ForeColor = System.Drawing.Color.White;
            this.labelAnioInicio.Location = new System.Drawing.Point(419, 78);
            this.labelAnioInicio.Name = "labelAnioInicio";
            this.labelAnioInicio.Size = new System.Drawing.Size(31, 15);
            this.labelAnioInicio.TabIndex = 9;
            this.labelAnioInicio.Text = "Año";
            // 
            // labelMesInicio
            // 
            this.labelMesInicio.AutoSize = true;
            this.labelMesInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMesInicio.ForeColor = System.Drawing.Color.White;
            this.labelMesInicio.Location = new System.Drawing.Point(419, 116);
            this.labelMesInicio.Name = "labelMesInicio";
            this.labelMesInicio.Size = new System.Drawing.Size(34, 15);
            this.labelMesInicio.TabIndex = 10;
            this.labelMesInicio.Text = "Mes";
            // 
            // labelDiaInicio
            // 
            this.labelDiaInicio.AutoSize = true;
            this.labelDiaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaInicio.ForeColor = System.Drawing.Color.White;
            this.labelDiaInicio.Location = new System.Drawing.Point(419, 152);
            this.labelDiaInicio.Name = "labelDiaInicio";
            this.labelDiaInicio.Size = new System.Drawing.Size(29, 15);
            this.labelDiaInicio.TabIndex = 11;
            this.labelDiaInicio.Text = "Dia";
            // 
            // labelDiaFin
            // 
            this.labelDiaFin.AutoSize = true;
            this.labelDiaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaFin.ForeColor = System.Drawing.Color.White;
            this.labelDiaFin.Location = new System.Drawing.Point(419, 289);
            this.labelDiaFin.Name = "labelDiaFin";
            this.labelDiaFin.Size = new System.Drawing.Size(29, 15);
            this.labelDiaFin.TabIndex = 14;
            this.labelDiaFin.Text = "Dia";
            // 
            // labelMesFin
            // 
            this.labelMesFin.AutoSize = true;
            this.labelMesFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMesFin.ForeColor = System.Drawing.Color.White;
            this.labelMesFin.Location = new System.Drawing.Point(419, 253);
            this.labelMesFin.Name = "labelMesFin";
            this.labelMesFin.Size = new System.Drawing.Size(34, 15);
            this.labelMesFin.TabIndex = 13;
            this.labelMesFin.Text = "Mes";
            // 
            // labelAnioFin
            // 
            this.labelAnioFin.AutoSize = true;
            this.labelAnioFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnioFin.ForeColor = System.Drawing.Color.White;
            this.labelAnioFin.Location = new System.Drawing.Point(419, 215);
            this.labelAnioFin.Name = "labelAnioFin";
            this.labelAnioFin.Size = new System.Drawing.Size(31, 15);
            this.labelAnioFin.TabIndex = 12;
            this.labelAnioFin.Text = "Año";
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFin.ForeColor = System.Drawing.Color.White;
            this.labelFechaFin.Location = new System.Drawing.Point(376, 183);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(76, 16);
            this.labelFechaFin.TabIndex = 15;
            this.labelFechaFin.Text = "Fecha Fin";
            // 
            // labelnuevoTorneo
            // 
            this.labelnuevoTorneo.AutoSize = true;
            this.labelnuevoTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnuevoTorneo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelnuevoTorneo.Location = new System.Drawing.Point(323, 9);
            this.labelnuevoTorneo.Name = "labelnuevoTorneo";
            this.labelnuevoTorneo.Size = new System.Drawing.Size(193, 25);
            this.labelnuevoTorneo.TabIndex = 16;
            this.labelnuevoTorneo.Text = "NUEVO TORNEO";
            // 
            // FormCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(571, 338);
            this.Controls.Add(this.labelnuevoTorneo);
            this.Controls.Add(this.labelFechaFin);
            this.Controls.Add(this.labelDiaFin);
            this.Controls.Add(this.labelMesFin);
            this.Controls.Add(this.labelAnioFin);
            this.Controls.Add(this.labelDiaInicio);
            this.Controls.Add(this.labelMesInicio);
            this.Controls.Add(this.labelAnioInicio);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.textBoxAnioFin);
            this.Controls.Add(this.textBoxDiaFin);
            this.Controls.Add(this.textBoxMesFin);
            this.Controls.Add(this.textBoxMesInicio);
            this.Controls.Add(this.textBoxDiaInicio);
            this.Controls.Add(this.textBoxAnioInicio);
            this.Controls.Add(this.iconButtonCrearFecha);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "FormCalendario";
            this.Text = "FormCalendario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private FontAwesome.Sharp.IconButton iconButtonCrearFecha;
        private System.Windows.Forms.TextBox textBoxAnioInicio;
        private System.Windows.Forms.TextBox textBoxDiaInicio;
        private System.Windows.Forms.TextBox textBoxMesInicio;
        private System.Windows.Forms.TextBox textBoxAnioFin;
        private System.Windows.Forms.TextBox textBoxDiaFin;
        private System.Windows.Forms.TextBox textBoxMesFin;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelAnioInicio;
        private System.Windows.Forms.Label labelMesInicio;
        private System.Windows.Forms.Label labelDiaInicio;
        private System.Windows.Forms.Label labelDiaFin;
        private System.Windows.Forms.Label labelMesFin;
        private System.Windows.Forms.Label labelAnioFin;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.Label labelnuevoTorneo;
    }
}