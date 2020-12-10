namespace Proyecto21
{
    partial class FormularioPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inmueblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeBarriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeInmueblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeInmueblesPorBarrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeInmueblesPorPrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inmueblesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inmueblesToolStripMenuItem
            // 
            this.inmueblesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeBarriosToolStripMenuItem,
            this.mantenimientoDeInmueblesToolStripMenuItem,
            this.consultaDeInmueblesPorBarrioToolStripMenuItem,
            this.consultaDeInmueblesPorPrecioToolStripMenuItem});
            this.inmueblesToolStripMenuItem.Name = "inmueblesToolStripMenuItem";
            this.inmueblesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.inmueblesToolStripMenuItem.Text = "Inmuebles";
            // 
            // mantenimientoDeBarriosToolStripMenuItem
            // 
            this.mantenimientoDeBarriosToolStripMenuItem.Name = "mantenimientoDeBarriosToolStripMenuItem";
            this.mantenimientoDeBarriosToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.mantenimientoDeBarriosToolStripMenuItem.Text = "Mantenimiento de Barrios";
            this.mantenimientoDeBarriosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeBarriosToolStripMenuItem_Click);
            // 
            // mantenimientoDeInmueblesToolStripMenuItem
            // 
            this.mantenimientoDeInmueblesToolStripMenuItem.Name = "mantenimientoDeInmueblesToolStripMenuItem";
            this.mantenimientoDeInmueblesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.mantenimientoDeInmueblesToolStripMenuItem.Text = "Mantenimiento de Inmuebles";
            this.mantenimientoDeInmueblesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeInmueblesToolStripMenuItem_Click);
            // 
            // consultaDeInmueblesPorBarrioToolStripMenuItem
            // 
            this.consultaDeInmueblesPorBarrioToolStripMenuItem.Name = "consultaDeInmueblesPorBarrioToolStripMenuItem";
            this.consultaDeInmueblesPorBarrioToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.consultaDeInmueblesPorBarrioToolStripMenuItem.Text = "Consulta de inmuebles por barrio";
            this.consultaDeInmueblesPorBarrioToolStripMenuItem.Click += new System.EventHandler(this.consultaDeInmueblesPorBarrioToolStripMenuItem_Click);
            // 
            // consultaDeInmueblesPorPrecioToolStripMenuItem
            // 
            this.consultaDeInmueblesPorPrecioToolStripMenuItem.Name = "consultaDeInmueblesPorPrecioToolStripMenuItem";
            this.consultaDeInmueblesPorPrecioToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.consultaDeInmueblesPorPrecioToolStripMenuItem.Text = "Consulta de inmuebles por precio";
            this.consultaDeInmueblesPorPrecioToolStripMenuItem.Click += new System.EventHandler(this.consultaDeInmueblesPorPrecioToolStripMenuItem_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 588);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inmueblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeBarriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeInmueblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeInmueblesPorBarrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeInmueblesPorPrecioToolStripMenuItem;
    }
}

