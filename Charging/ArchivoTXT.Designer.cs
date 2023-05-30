namespace Login.Charging
{
    partial class ArchivoTXT
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.rtbLectura = new System.Windows.Forms.RichTextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.lblupload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(369, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Visualización del archivo";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(61, 51);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(130, 22);
            this.lbl1.TabIndex = 12;
            this.lbl1.Text = "Ingrese Datos";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(504, 270);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(127, 36);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar archivo";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.Location = new System.Drawing.Point(326, 270);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(114, 36);
            this.btnLeer.TabIndex = 10;
            this.btnLeer.Text = "Leer archivo";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // rtbLectura
            // 
            this.rtbLectura.Location = new System.Drawing.Point(267, 51);
            this.rtbLectura.Name = "rtbLectura";
            this.rtbLectura.Size = new System.Drawing.Size(412, 198);
            this.rtbLectura.TabIndex = 9;
            this.rtbLectura.Text = "";
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(55, 270);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(139, 36);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear y Carga";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtDato
            // 
            this.txtDato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato.Location = new System.Drawing.Point(38, 76);
            this.txtDato.Margin = new System.Windows.Forms.Padding(4);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(188, 158);
            this.txtDato.TabIndex = 7;
            // 
            // lblupload
            // 
            this.lblupload.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupload.Location = new System.Drawing.Point(55, 350);
            this.lblupload.Name = "lblupload";
            this.lblupload.Size = new System.Drawing.Size(139, 36);
            this.lblupload.TabIndex = 14;
            this.lblupload.Text = "Subir archivo";
            this.lblupload.UseVisualStyleBackColor = true;
            this.lblupload.Click += new System.EventHandler(this.lblupload_Click);
            // 
            // ArchivoTXT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.lblupload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.rtbLectura);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtDato);
            this.Name = "ArchivoTXT";
            this.Text = "ArchivoTXT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.RichTextBox rtbLectura;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button lblupload;
    }
}