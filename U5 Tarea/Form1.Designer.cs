namespace U5_Tarea
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.listBoxArchivos = new System.Windows.Forms.ListBox();
            this.richTextBoxContenido = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(55, 91);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(162, 22);
            this.txtBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(223, 89);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // listBoxArchivos
            // 
            this.listBoxArchivos.FormattingEnabled = true;
            this.listBoxArchivos.ItemHeight = 16;
            this.listBoxArchivos.Location = new System.Drawing.Point(332, 89);
            this.listBoxArchivos.Name = "listBoxArchivos";
            this.listBoxArchivos.Size = new System.Drawing.Size(289, 356);
            this.listBoxArchivos.TabIndex = 2;
            this.listBoxArchivos.SelectedIndexChanged += new System.EventHandler(this.listBoxArchivos_SelectedIndexChanged);
            // 
            // richTextBoxContenido
            // 
            this.richTextBoxContenido.Location = new System.Drawing.Point(640, 89);
            this.richTextBoxContenido.Name = "richTextBoxContenido";
            this.richTextBoxContenido.Size = new System.Drawing.Size(309, 354);
            this.richTextBoxContenido.TabIndex = 3;
            this.richTextBoxContenido.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 483);
            this.Controls.Add(this.richTextBoxContenido);
            this.Controls.Add(this.listBoxArchivos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox listBoxArchivos;
        private System.Windows.Forms.RichTextBox richTextBoxContenido;
    }
}

