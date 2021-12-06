
namespace ProyectoFinalLab2
{
    partial class FormListado
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGVListado = new System.Windows.Forms.DataGridView();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CELULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVListado
            // 
            this.dGVListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.DNI,
            this.CELULAR,
            this.CATEGORIA});
            this.dGVListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVListado.Location = new System.Drawing.Point(0, 0);
            this.dGVListado.Name = "dGVListado";
            this.dGVListado.Size = new System.Drawing.Size(571, 338);
            this.dGVListado.TabIndex = 0;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(ProyectoFinalLab2.Persona);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // Nombre
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            // 
            // DNI
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.DNI.DefaultCellStyle = dataGridViewCellStyle3;
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // CELULAR
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.CELULAR.DefaultCellStyle = dataGridViewCellStyle4;
            this.CELULAR.HeaderText = "CELULAR";
            this.CELULAR.Name = "CELULAR";
            // 
            // CATEGORIA
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.CATEGORIA.DefaultCellStyle = dataGridViewCellStyle5;
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            // 
            // FormListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 338);
            this.Controls.Add(this.dGVListado);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormListado";
            this.Text = "FormListado";
            ((System.ComponentModel.ISupportInitialize)(this.dGVListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVListado;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CELULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
    }
}