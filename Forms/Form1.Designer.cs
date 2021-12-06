

namespace ProyectoFinalLab2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            FontAwesome.Sharp.IconButton iconButtonCalendario;
            this.panelLeft = new System.Windows.Forms.Panel();
            this.iconButtonEstadisticas = new FontAwesome.Sharp.IconButton();
            this.iconButtonListar = new FontAwesome.Sharp.IconButton();
            this.iconButtonNuevo = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgHome = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.labelInicio = new System.Windows.Forms.Label();
            this.iconPictureInicio = new FontAwesome.Sharp.IconPictureBox();
            this.botonActual = new FontAwesome.Sharp.IconButton();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            iconButtonCalendario = new FontAwesome.Sharp.IconButton();
            this.panelLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButtonCalendario
            // 
            iconButtonCalendario.Dock = System.Windows.Forms.DockStyle.Top;
            iconButtonCalendario.FlatAppearance.BorderSize = 0;
            iconButtonCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButtonCalendario.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            iconButtonCalendario.ForeColor = System.Drawing.Color.Gainsboro;
            iconButtonCalendario.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            iconButtonCalendario.IconColor = System.Drawing.Color.Gainsboro;
            iconButtonCalendario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonCalendario.IconSize = 32;
            iconButtonCalendario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            iconButtonCalendario.Location = new System.Drawing.Point(0, 290);
            iconButtonCalendario.Name = "iconButtonCalendario";
            iconButtonCalendario.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            iconButtonCalendario.Size = new System.Drawing.Size(220, 50);
            iconButtonCalendario.TabIndex = 4;
            iconButtonCalendario.Text = "Calendario";
            iconButtonCalendario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            iconButtonCalendario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButtonCalendario.UseVisualStyleBackColor = true;
            iconButtonCalendario.Click += new System.EventHandler(this.iconButtonCalendario_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelLeft.Controls.Add(iconButtonCalendario);
            this.panelLeft.Controls.Add(this.iconButtonEstadisticas);
            this.panelLeft.Controls.Add(this.iconButtonListar);
            this.panelLeft.Controls.Add(this.iconButtonNuevo);
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.panel);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(220, 447);
            this.panelLeft.TabIndex = 0;
            // 
            // iconButtonEstadisticas
            // 
            this.iconButtonEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonEstadisticas.FlatAppearance.BorderSize = 0;
            this.iconButtonEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEstadisticas.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonEstadisticas.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconButtonEstadisticas.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonEstadisticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEstadisticas.IconSize = 32;
            this.iconButtonEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEstadisticas.Location = new System.Drawing.Point(0, 240);
            this.iconButtonEstadisticas.Name = "iconButtonEstadisticas";
            this.iconButtonEstadisticas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonEstadisticas.Size = new System.Drawing.Size(220, 50);
            this.iconButtonEstadisticas.TabIndex = 3;
            this.iconButtonEstadisticas.Text = "Estadisticas";
            this.iconButtonEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEstadisticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEstadisticas.UseVisualStyleBackColor = true;
            this.iconButtonEstadisticas.Click += new System.EventHandler(this.iconButtonEstadisticas_Click);
            // 
            // iconButtonListar
            // 
            this.iconButtonListar.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonListar.FlatAppearance.BorderSize = 0;
            this.iconButtonListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonListar.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonListar.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconButtonListar.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonListar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonListar.IconSize = 32;
            this.iconButtonListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonListar.Location = new System.Drawing.Point(0, 190);
            this.iconButtonListar.Name = "iconButtonListar";
            this.iconButtonListar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonListar.Size = new System.Drawing.Size(220, 50);
            this.iconButtonListar.TabIndex = 2;
            this.iconButtonListar.Text = "Listado";
            this.iconButtonListar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonListar.UseVisualStyleBackColor = true;
            this.iconButtonListar.Click += new System.EventHandler(this.iconButtonListar_Click);
            // 
            // iconButtonNuevo
            // 
            this.iconButtonNuevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonNuevo.FlatAppearance.BorderSize = 0;
            this.iconButtonNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNuevo.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonNuevo.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconButtonNuevo.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonNuevo.IconSize = 32;
            this.iconButtonNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNuevo.Location = new System.Drawing.Point(0, 140);
            this.iconButtonNuevo.Name = "iconButtonNuevo";
            this.iconButtonNuevo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonNuevo.Size = new System.Drawing.Size(220, 50);
            this.iconButtonNuevo.TabIndex = 1;
            this.iconButtonNuevo.Text = "Nuevo";
            this.iconButtonNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonNuevo.UseVisualStyleBackColor = true;
            this.iconButtonNuevo.Click += new System.EventHandler(this.iconButtonNuevo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imgHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 140);
            this.panel1.TabIndex = 0;
            // 
            // imgHome
            // 
            this.imgHome.Image = global::ProyectoFinalLab2.Properties.Resources.Completo_Claro;
            this.imgHome.Location = new System.Drawing.Point(12, 12);
            this.imgHome.Name = "imgHome";
            this.imgHome.Size = new System.Drawing.Size(191, 103);
            this.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHome.TabIndex = 0;
            this.imgHome.TabStop = false;
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(7, 50);
            this.panel.TabIndex = 6;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelSuperior.Controls.Add(this.labelInicio);
            this.panelSuperior.Controls.Add(this.iconPictureInicio);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(220, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(587, 70);
            this.panelSuperior.TabIndex = 0;
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelInicio.Location = new System.Drawing.Point(56, 30);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(32, 13);
            this.labelInicio.TabIndex = 1;
            this.labelInicio.Text = "Inicio";
            // 
            // iconPictureInicio
            // 
            this.iconPictureInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureInicio.ForeColor = System.Drawing.Color.LimeGreen;
            this.iconPictureInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureInicio.IconColor = System.Drawing.Color.LimeGreen;
            this.iconPictureInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureInicio.Location = new System.Drawing.Point(18, 21);
            this.iconPictureInicio.Name = "iconPictureInicio";
            this.iconPictureInicio.Size = new System.Drawing.Size(32, 32);
            this.iconPictureInicio.TabIndex = 0;
            this.iconPictureInicio.TabStop = false;
            // 
            // botonActual
            // 
            this.botonActual.IconChar = FontAwesome.Sharp.IconChar.None;
            this.botonActual.IconColor = System.Drawing.Color.Black;
            this.botonActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonActual.Location = new System.Drawing.Point(0, 0);
            this.botonActual.Name = "botonActual";
            this.botonActual.Size = new System.Drawing.Size(75, 23);
            this.botonActual.TabIndex = 0;
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(220, 70);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(587, 377);
            this.panelEscritorio.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 447);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgHome;
        private FontAwesome.Sharp.IconButton iconButtonEstadisticas;
        private FontAwesome.Sharp.IconButton iconButtonListar;
        private FontAwesome.Sharp.IconButton iconButtonNuevo;
        private System.Windows.Forms.Panel panelSuperior;
        private FontAwesome.Sharp.IconPictureBox iconPictureInicio;
        private System.Windows.Forms.Label labelInicio;
        private FontAwesome.Sharp.IconButton botonActual;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelEscritorio;
        
    }
}

