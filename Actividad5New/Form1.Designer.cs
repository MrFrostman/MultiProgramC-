namespace Actividad5New
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.numerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaDeMultiplicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generadorDeNumerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numerosParesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numerosInparesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numerosPrimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numerosToolStripMenuItem,
            this.conversionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // numerosToolStripMenuItem
            // 
            this.numerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaDeMultiplicarToolStripMenuItem,
            this.generadorDeNumerosToolStripMenuItem,
            this.numerosParesToolStripMenuItem,
            this.numerosInparesToolStripMenuItem,
            this.numerosPrimosToolStripMenuItem});
            this.numerosToolStripMenuItem.Name = "numerosToolStripMenuItem";
            this.numerosToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.numerosToolStripMenuItem.Text = "Numeros";
            // 
            // tablaDeMultiplicarToolStripMenuItem
            // 
            this.tablaDeMultiplicarToolStripMenuItem.Name = "tablaDeMultiplicarToolStripMenuItem";
            this.tablaDeMultiplicarToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.tablaDeMultiplicarToolStripMenuItem.Text = "Tabla de Multiplicar";
            this.tablaDeMultiplicarToolStripMenuItem.Click += new System.EventHandler(this.tablaDeMultiplicarToolStripMenuItem_Click);
            // 
            // generadorDeNumerosToolStripMenuItem
            // 
            this.generadorDeNumerosToolStripMenuItem.Name = "generadorDeNumerosToolStripMenuItem";
            this.generadorDeNumerosToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.generadorDeNumerosToolStripMenuItem.Text = "Generador De numeros";
            this.generadorDeNumerosToolStripMenuItem.Click += new System.EventHandler(this.generadorDeNumerosToolStripMenuItem_Click);
            // 
            // numerosParesToolStripMenuItem
            // 
            this.numerosParesToolStripMenuItem.Name = "numerosParesToolStripMenuItem";
            this.numerosParesToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.numerosParesToolStripMenuItem.Text = "Numeros Pares";
            this.numerosParesToolStripMenuItem.Click += new System.EventHandler(this.numerosParesToolStripMenuItem_Click);
            // 
            // numerosInparesToolStripMenuItem
            // 
            this.numerosInparesToolStripMenuItem.Name = "numerosInparesToolStripMenuItem";
            this.numerosInparesToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.numerosInparesToolStripMenuItem.Text = "Numeros Inpares";
            this.numerosInparesToolStripMenuItem.Click += new System.EventHandler(this.numerosInparesToolStripMenuItem_Click);
            // 
            // numerosPrimosToolStripMenuItem
            // 
            this.numerosPrimosToolStripMenuItem.Name = "numerosPrimosToolStripMenuItem";
            this.numerosPrimosToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.numerosPrimosToolStripMenuItem.Text = "Numeros Primos";
            this.numerosPrimosToolStripMenuItem.Click += new System.EventHandler(this.numerosPrimosToolStripMenuItem_Click);
            // 
            // conversionesToolStripMenuItem
            // 
            this.conversionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monedasToolStripMenuItem,
            this.gradosToolStripMenuItem});
            this.conversionesToolStripMenuItem.Name = "conversionesToolStripMenuItem";
            this.conversionesToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.conversionesToolStripMenuItem.Text = "Conversiones";
            this.conversionesToolStripMenuItem.Click += new System.EventHandler(this.conversionesToolStripMenuItem_Click);
            // 
            // monedasToolStripMenuItem
            // 
            this.monedasToolStripMenuItem.Name = "monedasToolStripMenuItem";
            this.monedasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.monedasToolStripMenuItem.Text = "Monedas";
            this.monedasToolStripMenuItem.Click += new System.EventHandler(this.monedasToolStripMenuItem_Click);
            // 
            // gradosToolStripMenuItem
            // 
            this.gradosToolStripMenuItem.Name = "gradosToolStripMenuItem";
            this.gradosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gradosToolStripMenuItem.Text = "Grados";
            this.gradosToolStripMenuItem.Click += new System.EventHandler(this.gradosToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem numerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaDeMultiplicarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generadorDeNumerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numerosParesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numerosInparesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numerosPrimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monedasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradosToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

