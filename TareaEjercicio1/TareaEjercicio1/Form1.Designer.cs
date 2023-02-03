namespace TareaEjercicio1
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
            this.Ingreseunvalorlabel = new System.Windows.Forms.Label();
            this.IngreseunvalortextBox = new System.Windows.Forms.TextBox();
            this.Obtenerbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Resultadolabel = new System.Windows.Forms.Label();
            this.Resultadolabel2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Reiniciarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ingreseunvalorlabel
            // 
            this.Ingreseunvalorlabel.Location = new System.Drawing.Point(32, 98);
            this.Ingreseunvalorlabel.Name = "Ingreseunvalorlabel";
            this.Ingreseunvalorlabel.Size = new System.Drawing.Size(244, 28);
            this.Ingreseunvalorlabel.TabIndex = 0;
            this.Ingreseunvalorlabel.Text = "Ingrese un valor Entero:";
            // 
            // IngreseunvalortextBox
            // 
            this.IngreseunvalortextBox.Location = new System.Drawing.Point(260, 98);
            this.IngreseunvalortextBox.Name = "IngreseunvalortextBox";
            this.IngreseunvalortextBox.Size = new System.Drawing.Size(257, 34);
            this.IngreseunvalortextBox.TabIndex = 1;
            // 
            // Obtenerbutton
            // 
            this.Obtenerbutton.Location = new System.Drawing.Point(91, 237);
            this.Obtenerbutton.Name = "Obtenerbutton";
            this.Obtenerbutton.Size = new System.Drawing.Size(120, 43);
            this.Obtenerbutton.TabIndex = 2;
            this.Obtenerbutton.Text = "Obtener";
            this.Obtenerbutton.UseVisualStyleBackColor = true;
            this.Obtenerbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Resultadolabel
            // 
            this.Resultadolabel.AutoSize = true;
            this.Resultadolabel.Location = new System.Drawing.Point(102, 161);
            this.Resultadolabel.Name = "Resultadolabel";
            this.Resultadolabel.Size = new System.Drawing.Size(0, 26);
            this.Resultadolabel.TabIndex = 4;
            // 
            // Resultadolabel2
            // 
            this.Resultadolabel2.AutoSize = true;
            this.Resultadolabel2.Location = new System.Drawing.Point(285, 161);
            this.Resultadolabel2.Name = "Resultadolabel2";
            this.Resultadolabel2.Size = new System.Drawing.Size(0, 26);
            this.Resultadolabel2.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Reiniciarbutton
            // 
            this.Reiniciarbutton.Location = new System.Drawing.Point(290, 237);
            this.Reiniciarbutton.Name = "Reiniciarbutton";
            this.Reiniciarbutton.Size = new System.Drawing.Size(117, 41);
            this.Reiniciarbutton.TabIndex = 6;
            this.Reiniciarbutton.Text = "Reiniciar";
            this.Reiniciarbutton.UseVisualStyleBackColor = true;
            this.Reiniciarbutton.Click += new System.EventHandler(this.Reiniciarbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(533, 356);
            this.Controls.Add(this.Reiniciarbutton);
            this.Controls.Add(this.Resultadolabel2);
            this.Controls.Add(this.Resultadolabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Obtenerbutton);
            this.Controls.Add(this.IngreseunvalortextBox);
            this.Controls.Add(this.Ingreseunvalorlabel);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tarea 1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ingreseunvalorlabel;
        private System.Windows.Forms.TextBox IngreseunvalortextBox;
        private System.Windows.Forms.Button Obtenerbutton;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Resultadolabel;
        private System.Windows.Forms.Label Resultadolabel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Reiniciarbutton;
    }
}

