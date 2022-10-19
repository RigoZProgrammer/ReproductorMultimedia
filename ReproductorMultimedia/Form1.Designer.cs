namespace ReproductorMultimedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_lista_archivo = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mpmediaplayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.mpmediaplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_lista_archivo
            // 
            this.lb_lista_archivo.FormattingEnabled = true;
            this.lb_lista_archivo.Location = new System.Drawing.Point(471, 2);
            this.lb_lista_archivo.Name = "lb_lista_archivo";
            this.lb_lista_archivo.Size = new System.Drawing.Size(313, 329);
            this.lb_lista_archivo.TabIndex = 1;
            this.lb_lista_archivo.SelectedIndexChanged += new System.EventHandler(this.lb_lista_archivo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(697, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Abrir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mpmediaplayer
            // 
            this.mpmediaplayer.Enabled = true;
            this.mpmediaplayer.Location = new System.Drawing.Point(4, 2);
            this.mpmediaplayer.Name = "mpmediaplayer";
            this.mpmediaplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpmediaplayer.OcxState")));
            this.mpmediaplayer.Size = new System.Drawing.Size(464, 362);
            this.mpmediaplayer.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(789, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_lista_archivo);
            this.Controls.Add(this.mpmediaplayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mpmediaplayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mpmediaplayer;
        private System.Windows.Forms.ListBox lb_lista_archivo;
        private System.Windows.Forms.Button button1;
    }
}

