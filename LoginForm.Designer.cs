namespace Login
{
    partial class LoginForm
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
            this.btnaccess = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.lblattemptsremaining = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnreg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnaccess
            // 
            this.btnaccess.Location = new System.Drawing.Point(12, 222);
            this.btnaccess.Name = "btnaccess";
            this.btnaccess.Size = new System.Drawing.Size(75, 23);
            this.btnaccess.TabIndex = 7;
            this.btnaccess.Text = "Ingresar";
            this.btnaccess.UseVisualStyleBackColor = true;
            this.btnaccess.Click += new System.EventHandler(this.btnaccess_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(150, 222);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // lblattemptsremaining
            // 
            this.lblattemptsremaining.AutoSize = true;
            this.lblattemptsremaining.Location = new System.Drawing.Point(14, 276);
            this.lblattemptsremaining.Name = "lblattemptsremaining";
            this.lblattemptsremaining.Size = new System.Drawing.Size(0, 13);
            this.lblattemptsremaining.TabIndex = 13;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 76);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(213, 20);
            this.txtUsername.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 161);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(213, 20);
            this.txtPassword.TabIndex = 15;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(12, 38);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(92, 25);
            this.lbluser.TabIndex = 16;
            this.lbluser.Text = "Usuario ";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(12, 120);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(123, 25);
            this.lblpassword.TabIndex = 17;
            this.lblpassword.Text = "Contraseña";
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(80, 251);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(75, 23);
            this.btnreg.TabIndex = 18;
            this.btnreg.Text = "Registrarse";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(250, 298);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblattemptsremaining);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnaccess);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaccess;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label lblattemptsremaining;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnreg;
    }
}