
namespace TrabajoLibrosPOO.Windows
{
    partial class FrmListaDeLibros
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FiltrarTtoolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empersandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atlantidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarmanotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corregidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dunkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filosofiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cienciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.economiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.literaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.paginasAscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paginasDescToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ContadorRegistrosLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DatosDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ContadorRegistrosLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 378;
            this.splitContainer1.TabIndex = 0;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.AllowUserToResizeColumns = false;
            this.DatosDataGridView.AllowUserToResizeRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colEditorial,
            this.colTema,
            this.colPaginas,
            this.colIsbn,
            this.colAutor});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 54);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(800, 324);
            this.DatosDataGridView.TabIndex = 1;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colEditorial
            // 
            this.colEditorial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEditorial.HeaderText = "Editorial";
            this.colEditorial.Name = "colEditorial";
            this.colEditorial.ReadOnly = true;
            this.colEditorial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTema
            // 
            this.colTema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTema.HeaderText = "Tema";
            this.colTema.Name = "colTema";
            this.colTema.ReadOnly = true;
            this.colTema.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colPaginas
            // 
            this.colPaginas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPaginas.HeaderText = "Paginas";
            this.colPaginas.Name = "colPaginas";
            this.colPaginas.ReadOnly = true;
            this.colPaginas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colIsbn
            // 
            this.colIsbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIsbn.HeaderText = "ISBN";
            this.colIsbn.Name = "colIsbn";
            this.colIsbn.ReadOnly = true;
            this.colIsbn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colAutor
            // 
            this.colAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAutor.HeaderText = "Autor";
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            this.colAutor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.BorrarToolStripButton,
            this.EditarToolStripButton,
            this.toolStripSeparator1,
            this.FiltrarTtoolStripButton,
            this.OrdenarToolStripButton,
            this.ActualizarToolStripButton,
            this.toolStripSeparator2,
            this.SalirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 54);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = global::TrabajoLibrosPOO.Windows.Properties.Resources.Nuevo_32;
            this.NuevoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(46, 51);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.Image = global::TrabajoLibrosPOO.Windows.Properties.Resources.Borrar_32;
            this.BorrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(43, 51);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = global::TrabajoLibrosPOO.Windows.Properties.Resources.Editar_32;
            this.EditarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(41, 51);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarToolStripButton.Click += new System.EventHandler(this.EditarToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // FiltrarTtoolStripButton
            // 
            this.FiltrarTtoolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temaToolStripMenuItem,
            this.editorialToolStripMenuItem});
            this.FiltrarTtoolStripButton.Image = global::TrabajoLibrosPOO.Windows.Properties.Resources.Filtrar_32;
            this.FiltrarTtoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiltrarTtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrarTtoolStripButton.Name = "FiltrarTtoolStripButton";
            this.FiltrarTtoolStripButton.Size = new System.Drawing.Size(50, 51);
            this.FiltrarTtoolStripButton.Text = "Filtrar";
            this.FiltrarTtoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alicionToolStripMenuItem,
            this.empersandToolStripMenuItem,
            this.atlantidaToolStripMenuItem,
            this.ayarmanotToolStripMenuItem,
            this.corregidorToolStripMenuItem,
            this.dunkenToolStripMenuItem});
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.temaToolStripMenuItem.Text = "Ediotorial";
            // 
            // alicionToolStripMenuItem
            // 
            this.alicionToolStripMenuItem.Name = "alicionToolStripMenuItem";
            this.alicionToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.alicionToolStripMenuItem.Text = "Alicion";
            this.alicionToolStripMenuItem.Click += new System.EventHandler(this.alicionToolStripMenuItem_Click);
            // 
            // empersandToolStripMenuItem
            // 
            this.empersandToolStripMenuItem.Name = "empersandToolStripMenuItem";
            this.empersandToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.empersandToolStripMenuItem.Text = "Empersand";
            this.empersandToolStripMenuItem.Click += new System.EventHandler(this.empersandToolStripMenuItem_Click);
            // 
            // atlantidaToolStripMenuItem
            // 
            this.atlantidaToolStripMenuItem.Name = "atlantidaToolStripMenuItem";
            this.atlantidaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.atlantidaToolStripMenuItem.Text = "Atlantida";
            this.atlantidaToolStripMenuItem.Click += new System.EventHandler(this.atlantidaToolStripMenuItem_Click);
            // 
            // ayarmanotToolStripMenuItem
            // 
            this.ayarmanotToolStripMenuItem.Name = "ayarmanotToolStripMenuItem";
            this.ayarmanotToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ayarmanotToolStripMenuItem.Text = "Ayarmanot";
            this.ayarmanotToolStripMenuItem.Click += new System.EventHandler(this.ayarmanotToolStripMenuItem_Click);
            // 
            // corregidorToolStripMenuItem
            // 
            this.corregidorToolStripMenuItem.Name = "corregidorToolStripMenuItem";
            this.corregidorToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.corregidorToolStripMenuItem.Text = "Corregidor";
            this.corregidorToolStripMenuItem.Click += new System.EventHandler(this.corregidorToolStripMenuItem_Click);
            // 
            // dunkenToolStripMenuItem
            // 
            this.dunkenToolStripMenuItem.Name = "dunkenToolStripMenuItem";
            this.dunkenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dunkenToolStripMenuItem.Text = "Dunken";
            this.dunkenToolStripMenuItem.Click += new System.EventHandler(this.dunkenToolStripMenuItem_Click);
            // 
            // editorialToolStripMenuItem
            // 
            this.editorialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filosofiaToolStripMenuItem,
            this.cienciasToolStripMenuItem,
            this.economiaToolStripMenuItem,
            this.informaticaToolStripMenuItem,
            this.literaturaToolStripMenuItem});
            this.editorialToolStripMenuItem.Name = "editorialToolStripMenuItem";
            this.editorialToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.editorialToolStripMenuItem.Text = "Tema";
            // 
            // filosofiaToolStripMenuItem
            // 
            this.filosofiaToolStripMenuItem.Name = "filosofiaToolStripMenuItem";
            this.filosofiaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.filosofiaToolStripMenuItem.Text = "Filosofia";
            this.filosofiaToolStripMenuItem.Click += new System.EventHandler(this.filosofiaToolStripMenuItem_Click);
            // 
            // cienciasToolStripMenuItem
            // 
            this.cienciasToolStripMenuItem.Name = "cienciasToolStripMenuItem";
            this.cienciasToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.cienciasToolStripMenuItem.Text = "Ciencias";
            this.cienciasToolStripMenuItem.Click += new System.EventHandler(this.cienciasToolStripMenuItem_Click);
            // 
            // economiaToolStripMenuItem
            // 
            this.economiaToolStripMenuItem.Name = "economiaToolStripMenuItem";
            this.economiaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.economiaToolStripMenuItem.Text = "Economia";
            this.economiaToolStripMenuItem.Click += new System.EventHandler(this.economiaToolStripMenuItem_Click);
            // 
            // informaticaToolStripMenuItem
            // 
            this.informaticaToolStripMenuItem.Name = "informaticaToolStripMenuItem";
            this.informaticaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.informaticaToolStripMenuItem.Text = "Informatica";
            this.informaticaToolStripMenuItem.Click += new System.EventHandler(this.informaticaToolStripMenuItem_Click);
            // 
            // literaturaToolStripMenuItem
            // 
            this.literaturaToolStripMenuItem.Name = "literaturaToolStripMenuItem";
            this.literaturaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.literaturaToolStripMenuItem.Text = "Literatura";
            this.literaturaToolStripMenuItem.Click += new System.EventHandler(this.literaturaToolStripMenuItem_Click);
            // 
            // OrdenarToolStripButton
            // 
            this.OrdenarToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginasAscToolStripMenuItem,
            this.paginasDescToolStripMenuItem});
            this.OrdenarToolStripButton.Image = global::TrabajoLibrosPOO.Windows.Properties.Resources.Ordenar_32;
            this.OrdenarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OrdenarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdenarToolStripButton.Name = "OrdenarToolStripButton";
            this.OrdenarToolStripButton.Size = new System.Drawing.Size(63, 51);
            this.OrdenarToolStripButton.Text = "Ordenar";
            this.OrdenarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // paginasAscToolStripMenuItem
            // 
            this.paginasAscToolStripMenuItem.Name = "paginasAscToolStripMenuItem";
            this.paginasAscToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.paginasAscToolStripMenuItem.Text = "Paginas Asc";
            this.paginasAscToolStripMenuItem.Click += new System.EventHandler(this.paginasAscToolStripMenuItem_Click);
            // 
            // paginasDescToolStripMenuItem
            // 
            this.paginasDescToolStripMenuItem.Name = "paginasDescToolStripMenuItem";
            this.paginasDescToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.paginasDescToolStripMenuItem.Text = "Paginas Desc";
            this.paginasDescToolStripMenuItem.Click += new System.EventHandler(this.paginasDescToolStripMenuItem_Click);
            // 
            // ActualizarToolStripButton
            // 
            this.ActualizarToolStripButton.Image = global::TrabajoLibrosPOO.Windows.Properties.Resources.Actualizar_32;
            this.ActualizarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizarToolStripButton.Name = "ActualizarToolStripButton";
            this.ActualizarToolStripButton.Size = new System.Drawing.Size(63, 51);
            this.ActualizarToolStripButton.Text = "Actualizar";
            this.ActualizarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ActualizarToolStripButton.Click += new System.EventHandler(this.ActualizarToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // SalirToolStripButton
            // 
            this.SalirToolStripButton.Image = global::TrabajoLibrosPOO.Windows.Properties.Resources.Salir_32;
            this.SalirToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton.Name = "SalirToolStripButton";
            this.SalirToolStripButton.Size = new System.Drawing.Size(36, 51);
            this.SalirToolStripButton.Text = "Salir";
            this.SalirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripButton.Click += new System.EventHandler(this.SalirToolStripButton_Click);
            // 
            // ContadorRegistrosLabel
            // 
            this.ContadorRegistrosLabel.AutoSize = true;
            this.ContadorRegistrosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContadorRegistrosLabel.Location = new System.Drawing.Point(140, 22);
            this.ContadorRegistrosLabel.Name = "ContadorRegistrosLabel";
            this.ContadorRegistrosLabel.Size = new System.Drawing.Size(14, 13);
            this.ContadorRegistrosLabel.TabIndex = 0;
            this.ContadorRegistrosLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contador de registros:";
            // 
            // FrmListaDeLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmListaDeLibros";
            this.Text = "FrmListaDeLibros";
            this.Load += new System.EventHandler(this.FrmListaDeLibros_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ActualizarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.Label ContadorRegistrosLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripDropDownButton FiltrarTtoolStripButton;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empersandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atlantidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarmanotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corregidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dunkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filosofiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cienciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem economiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem literaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton OrdenarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem paginasAscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paginasDescToolStripMenuItem;
    }
}