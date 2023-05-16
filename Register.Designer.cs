namespace Login
{
    partial class Register
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
            this.btnregis = new System.Windows.Forms.Button();
            this.txtidRegi = new System.Windows.Forms.TextBox();
            this.txtuserRegi = new System.Windows.Forms.TextBox();
            this.txtpasswordRegi = new System.Windows.Forms.TextBox();
            this.lblidRegi = new System.Windows.Forms.Label();
            this.lbluserRegi = new System.Windows.Forms.Label();
            this.lblpassRegi = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnregis
            // 
            this.btnregis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregis.Location = new System.Drawing.Point(26, 255);
            this.btnregis.Name = "btnregis";
            this.btnregis.Size = new System.Drawing.Size(110, 40);
            this.btnregis.TabIndex = 19;
            this.btnregis.Text = "Registrarse";
            this.btnregis.UseVisualStyleBackColor = true;
            this.btnregis.Click += new System.EventHandler(this.btnregis_Click);
            // 
            // txtidRegi
            // 
            this.txtidRegi.Location = new System.Drawing.Point(26, 89);
            this.txtidRegi.Name = "txtidRegi";
            this.txtidRegi.Size = new System.Drawing.Size(245, 20);
            this.txtidRegi.TabIndex = 20;
            // 
            // txtuserRegi
            // 
            this.txtuserRegi.Location = new System.Drawing.Point(26, 149);
            this.txtuserRegi.Name = "txtuserRegi";
            this.txtuserRegi.Size = new System.Drawing.Size(245, 20);
            this.txtuserRegi.TabIndex = 21;
            // 
            // txtpasswordRegi
            // 
            this.txtpasswordRegi.Location = new System.Drawing.Point(26, 209);
            this.txtpasswordRegi.Name = "txtpasswordRegi";
            this.txtpasswordRegi.Size = new System.Drawing.Size(245, 20);
            this.txtpasswordRegi.TabIndex = 22;
            // 
            // lblidRegi
            // 
            this.lblidRegi.AutoSize = true;
            this.lblidRegi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidRegi.Location = new System.Drawing.Point(21, 51);
            this.lblidRegi.Name = "lblidRegi";
            this.lblidRegi.Size = new System.Drawing.Size(80, 25);
            this.lblidRegi.TabIndex = 23;
            this.lblidRegi.Text = "Cédula";
            // 
            // lbluserRegi
            // 
            this.lbluserRegi.AutoSize = true;
            this.lbluserRegi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserRegi.Location = new System.Drawing.Point(21, 112);
            this.lbluserRegi.Name = "lbluserRegi";
            this.lbluserRegi.Size = new System.Drawing.Size(86, 25);
            this.lbluserRegi.TabIndex = 24;
            this.lbluserRegi.Text = "Usuario";
            // 
            // lblpassRegi
            // 
            this.lblpassRegi.AutoSize = true;
            this.lblpassRegi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassRegi.Location = new System.Drawing.Point(21, 172);
            this.lblpassRegi.Name = "lblpassRegi";
            this.lblpassRegi.Size = new System.Drawing.Size(123, 25);
            this.lblpassRegi.TabIndex = 25;
            this.lblpassRegi.Text = "Contraseña";
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(152, 255);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(110, 40);
            this.btnexit.TabIndex = 26;
            this.btnexit.Text = "Salir";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(297, 319);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lblpassRegi);
            this.Controls.Add(this.lbluserRegi);
            this.Controls.Add(this.lblidRegi);
            this.Controls.Add(this.txtpasswordRegi);
            this.Controls.Add(this.txtuserRegi);
            this.Controls.Add(this.txtidRegi);
            this.Controls.Add(this.btnregis);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregis;
        private System.Windows.Forms.TextBox txtidRegi;
        private System.Windows.Forms.TextBox txtuserRegi;
        private System.Windows.Forms.TextBox txtpasswordRegi;
        private System.Windows.Forms.Label lblidRegi;
        private System.Windows.Forms.Label lbluserRegi;
        private System.Windows.Forms.Label lblpassRegi;
        private System.Windows.Forms.Button btnexit;
    }
}