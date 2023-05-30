namespace Login.Charging
{
    partial class ArchivoCSV
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.dgdLectura = new System.Windows.Forms.DataGridView();
            this.Dato1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dato2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dato3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtDato1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnupload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdLectura)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(354, 16);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(123, 13);
            this.lbl2.TabIndex = 14;
            this.lbl2.Text = "Visualización del archivo";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(455, 248);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(153, 35);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar archivo";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(278, 248);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(153, 35);
            this.btnLeer.TabIndex = 12;
            this.btnLeer.Text = "Leer archivo";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // dgdLectura
            // 
            this.dgdLectura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdLectura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dato1,
            this.Dato2,
            this.Dato3});
            this.dgdLectura.Location = new System.Drawing.Point(267, 45);
            this.dgdLectura.Name = "dgdLectura";
            this.dgdLectura.Size = new System.Drawing.Size(341, 188);
            this.dgdLectura.TabIndex = 11;
            // 
            // Dato1
            // 
            this.Dato1.HeaderText = "Dato1";
            this.Dato1.Name = "Dato1";
            // 
            // Dato2
            // 
            this.Dato2.HeaderText = "Dato2";
            this.Dato2.Name = "Dato2";
            // 
            // Dato3
            // 
            this.Dato3.HeaderText = "Dato3";
            this.Dato3.Name = "Dato3";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(23, 222);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(153, 35);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear y Cargar";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtDato1
            // 
            this.txtDato1.Location = new System.Drawing.Point(11, 55);
            this.txtDato1.Margin = new System.Windows.Forms.Padding(4);
            this.txtDato1.Multiline = true;
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(200, 160);
            this.txtDato1.TabIndex = 9;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(57, 16);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(105, 18);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Ingrese Datos";
            // 
            // btnupload
            // 
            this.btnupload.Location = new System.Drawing.Point(23, 262);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(153, 35);
            this.btnupload.TabIndex = 15;
            this.btnupload.Text = "Subir Archivo";
            this.btnupload.UseVisualStyleBackColor = true;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // ArchivoCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 309);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.dgdLectura);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtDato1);
            this.Controls.Add(this.lbl1);
            this.Name = "ArchivoCSV";
            this.Text = "ArchivoCSV";
            ((System.ComponentModel.ISupportInitialize)(this.dgdLectura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.DataGridView dgdLectura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato3;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnupload;
    }
}