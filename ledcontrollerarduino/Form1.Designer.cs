
namespace ledcontrollerarduino
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.valor = new System.Windows.Forms.Label();
            this.puerto = new System.Windows.Forms.TextBox();
            this.baudios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conectarBoton = new System.Windows.Forms.Button();
            this.desconectar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(11, 124);
            this.trackBar1.Maximum = 1023;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(170, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(187, 156);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(0, 13);
            this.valor.TabIndex = 1;
            this.valor.Click += new System.EventHandler(this.label1_Click);
            // 
            // puerto
            // 
            this.puerto.Location = new System.Drawing.Point(86, 12);
            this.puerto.Name = "puerto";
            this.puerto.Size = new System.Drawing.Size(61, 20);
            this.puerto.TabIndex = 2;
            // 
            // baudios
            // 
            this.baudios.Location = new System.Drawing.Point(86, 39);
            this.baudios.Name = "baudios";
            this.baudios.Size = new System.Drawing.Size(61, 20);
            this.baudios.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baudios";
            // 
            // conectarBoton
            // 
            this.conectarBoton.Location = new System.Drawing.Point(72, 65);
            this.conectarBoton.Name = "conectarBoton";
            this.conectarBoton.Size = new System.Drawing.Size(75, 23);
            this.conectarBoton.TabIndex = 6;
            this.conectarBoton.Text = "Conectar";
            this.conectarBoton.UseVisualStyleBackColor = true;
            this.conectarBoton.Click += new System.EventHandler(this.conectarBoton_Click);
            // 
            // desconectar
            // 
            this.desconectar.Enabled = false;
            this.desconectar.Location = new System.Drawing.Point(154, 65);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(83, 23);
            this.desconectar.TabIndex = 7;
            this.desconectar.Text = "Desconectar";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.desconectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 201);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.conectarBoton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baudios);
            this.Controls.Add(this.puerto);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.TextBox puerto;
        private System.Windows.Forms.TextBox baudios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button conectarBoton;
        private System.Windows.Forms.Button desconectar;
    }
}

