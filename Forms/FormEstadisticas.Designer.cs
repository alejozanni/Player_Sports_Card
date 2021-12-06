
namespace ProyectoFinalLab2
{
    partial class FormEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBoxBusquedaId = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBoxJugadorEstadisticas = new System.Windows.Forms.PictureBox();
            this.labelNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJugadorEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(203, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(111, 20);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Busqueda por DNI";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // textBoxBusquedaId
            // 
            this.textBoxBusquedaId.Location = new System.Drawing.Point(12, 12);
            this.textBoxBusquedaId.Name = "textBoxBusquedaId";
            this.textBoxBusquedaId.Size = new System.Drawing.Size(173, 20);
            this.textBoxBusquedaId.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 71);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Partidos Jugados";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Partidos Ganados";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Torneos Jugados";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Torneos Ganados";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(342, 255);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // pictureBoxJugadorEstadisticas
            // 
            this.pictureBoxJugadorEstadisticas.Location = new System.Drawing.Point(402, 29);
            this.pictureBoxJugadorEstadisticas.Name = "pictureBoxJugadorEstadisticas";
            this.pictureBoxJugadorEstadisticas.Size = new System.Drawing.Size(135, 138);
            this.pictureBoxJugadorEstadisticas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxJugadorEstadisticas.TabIndex = 4;
            this.pictureBoxJugadorEstadisticas.TabStop = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(399, 182);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(0, 16);
            this.labelNombre.TabIndex = 5;
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(571, 338);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.pictureBoxJugadorEstadisticas);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBoxBusquedaId);
            this.Controls.Add(this.iconButton1);
            this.Name = "FormEstadisticas";
            this.Text = "FormEstadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJugadorEstadisticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textBoxBusquedaId;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBoxJugadorEstadisticas;
        private System.Windows.Forms.Label labelNombre;
    }
}