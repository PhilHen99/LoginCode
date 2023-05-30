namespace Login.Charging
{
    partial class frmentrada
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.rdbArchivoTXT = new System.Windows.Forms.RadioButton();
            this.rdbArchivoXML = new System.Windows.Forms.RadioButton();
            this.rdbArchivoCSV = new System.Windows.Forms.RadioButton();
            this.rdbArchivoRTF = new System.Windows.Forms.RadioButton();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(13, 25);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(162, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Seleccione el archivo que desea";
            // 
            // rdbArchivoTXT
            // 
            this.rdbArchivoTXT.AutoSize = true;
            this.rdbArchivoTXT.Location = new System.Drawing.Point(16, 56);
            this.rdbArchivoTXT.Margin = new System.Windows.Forms.Padding(4);
            this.rdbArchivoTXT.Name = "rdbArchivoTXT";
            this.rdbArchivoTXT.Size = new System.Drawing.Size(85, 17);
            this.rdbArchivoTXT.TabIndex = 2;
            this.rdbArchivoTXT.Text = "Archivo TXT";
            this.rdbArchivoTXT.UseVisualStyleBackColor = true;
            // 
            // rdbArchivoXML
            // 
            this.rdbArchivoXML.AutoSize = true;
            this.rdbArchivoXML.Location = new System.Drawing.Point(16, 94);
            this.rdbArchivoXML.Margin = new System.Windows.Forms.Padding(4);
            this.rdbArchivoXML.Name = "rdbArchivoXML";
            this.rdbArchivoXML.Size = new System.Drawing.Size(86, 17);
            this.rdbArchivoXML.TabIndex = 3;
            this.rdbArchivoXML.Text = "Archivo XML";
            this.rdbArchivoXML.UseVisualStyleBackColor = true;
            // 
            // rdbArchivoCSV
            // 
            this.rdbArchivoCSV.AutoSize = true;
            this.rdbArchivoCSV.Location = new System.Drawing.Point(17, 129);
            this.rdbArchivoCSV.Margin = new System.Windows.Forms.Padding(4);
            this.rdbArchivoCSV.Name = "rdbArchivoCSV";
            this.rdbArchivoCSV.Size = new System.Drawing.Size(85, 17);
            this.rdbArchivoCSV.TabIndex = 4;
            this.rdbArchivoCSV.Text = "Archivo CSV";
            this.rdbArchivoCSV.UseVisualStyleBackColor = true;
            // 
            // rdbArchivoRTF
            // 
            this.rdbArchivoRTF.AutoSize = true;
            this.rdbArchivoRTF.Location = new System.Drawing.Point(17, 169);
            this.rdbArchivoRTF.Margin = new System.Windows.Forms.Padding(4);
            this.rdbArchivoRTF.Name = "rdbArchivoRTF";
            this.rdbArchivoRTF.Size = new System.Drawing.Size(85, 17);
            this.rdbArchivoRTF.TabIndex = 6;
            this.rdbArchivoRTF.TabStop = true;
            this.rdbArchivoRTF.Text = "Archivo RTF";
            this.rdbArchivoRTF.UseVisualStyleBackColor = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(30, 200);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(136, 51);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // frmentrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 271);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.rdbArchivoRTF);
            this.Controls.Add(this.rdbArchivoCSV);
            this.Controls.Add(this.rdbArchivoXML);
            this.Controls.Add(this.rdbArchivoTXT);
            this.Controls.Add(this.lbl1);
            this.Name = "frmentrada";
            this.Text = "frmentrada";
            this.Load += new System.EventHandler(this.frmentrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RadioButton rdbArchivoTXT;
        private System.Windows.Forms.RadioButton rdbArchivoXML;
        private System.Windows.Forms.RadioButton rdbArchivoCSV;
        private System.Windows.Forms.RadioButton rdbArchivoRTF;
        private System.Windows.Forms.Button btnEntrar;
    }
}