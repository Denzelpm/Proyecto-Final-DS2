
namespace _NCrypt_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblLogo = new System.Windows.Forms.Label();
            this.rbEncriptar = new System.Windows.Forms.RadioButton();
            this.rbDesencriptar = new System.Windows.Forms.RadioButton();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogo.Font = new System.Drawing.Font("Druk Wide Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLogo.Size = new System.Drawing.Size(582, 353);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "(N)Crypt";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLogo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // rbEncriptar
            // 
            this.rbEncriptar.AutoSize = true;
            this.rbEncriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEncriptar.Location = new System.Drawing.Point(258, 167);
            this.rbEncriptar.Name = "rbEncriptar";
            this.rbEncriptar.Size = new System.Drawing.Size(98, 24);
            this.rbEncriptar.TabIndex = 1;
            this.rbEncriptar.Text = "Encriptar";
            this.rbEncriptar.UseVisualStyleBackColor = true;
            this.rbEncriptar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbDesencriptar
            // 
            this.rbDesencriptar.AutoSize = true;
            this.rbDesencriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDesencriptar.Location = new System.Drawing.Point(362, 167);
            this.rbDesencriptar.Name = "rbDesencriptar";
            this.rbDesencriptar.Size = new System.Drawing.Size(127, 24);
            this.rbDesencriptar.TabIndex = 2;
            this.rbDesencriptar.Text = "Desencriptar";
            this.rbDesencriptar.UseVisualStyleBackColor = true;
            this.rbDesencriptar.CheckedChanged += new System.EventHandler(this.rbDesencriptar_CheckedChanged);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(12, 127);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(477, 22);
            this.txtUbicacion.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(495, 126);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 27);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(7, 99);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(197, 25);
            this.lblUbicacion.TabIndex = 5;
            this.lblUbicacion.Text = "Ubicacion del archivo";
            this.lblUbicacion.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.DarkRed;
            this.lblContraseña.Location = new System.Drawing.Point(8, 207);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(122, 25);
            this.lblContraseña.TabIndex = 6;
            this.lblContraseña.Text = "Contraseña*";
            this.lblContraseña.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(136, 207);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(353, 22);
            this.txtContraseña.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(136, 250);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 50);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(389, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.rbDesencriptar);
            this.Controls.Add(this.rbEncriptar);
            this.Controls.Add(this.lblLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "(N)Crypt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.RadioButton rbEncriptar;
        private System.Windows.Forms.RadioButton rbDesencriptar;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
    }
}

