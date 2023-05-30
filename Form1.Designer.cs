namespace Login
{
    partial class Crud
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
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnearch = new System.Windows.Forms.Button();
            this.dtginfo = new System.Windows.Forms.DataGridView();
            this.lblrole = new System.Windows.Forms.Label();
            this.cborole = new System.Windows.Forms.ComboBox();
            this.lbldues = new System.Windows.Forms.Label();
            this.cbodues = new System.Windows.Forms.ComboBox();
            this.btnup = new System.Windows.Forms.Button();
            this.btninvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtginfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(36, 70);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(86, 25);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "Usuario";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(36, 131);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(123, 25);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "Contraseña";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(41, 108);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(318, 20);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(41, 159);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(318, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(41, 196);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Turquoise;
            this.btnupdate.Location = new System.Drawing.Point(122, 196);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Actualizar";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(41, 47);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(131, 20);
            this.txtid.TabIndex = 10;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(36, 19);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(80, 25);
            this.lblid.TabIndex = 11;
            this.lblid.Text = "Cédula";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Crimson;
            this.btndelete.Location = new System.Drawing.Point(203, 196);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Borrar";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnearch
            // 
            this.btnearch.BackColor = System.Drawing.Color.Orange;
            this.btnearch.Location = new System.Drawing.Point(284, 196);
            this.btnearch.Name = "btnearch";
            this.btnearch.Size = new System.Drawing.Size(75, 23);
            this.btnearch.TabIndex = 14;
            this.btnearch.Text = "Buscar";
            this.btnearch.UseVisualStyleBackColor = false;
            this.btnearch.Click += new System.EventHandler(this.btnearch_Click);
            // 
            // dtginfo
            // 
            this.dtginfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtginfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtginfo.Location = new System.Drawing.Point(41, 225);
            this.dtginfo.Name = "dtginfo";
            this.dtginfo.Size = new System.Drawing.Size(479, 138);
            this.dtginfo.TabIndex = 15;
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.Location = new System.Drawing.Point(223, 19);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(44, 25);
            this.lblrole.TabIndex = 17;
            this.lblrole.Text = "Rol";
            // 
            // cborole
            // 
            this.cborole.FormattingEnabled = true;
            this.cborole.Items.AddRange(new object[] {
            "Administrador\t",
            "Cliente",
            "Empleado"});
            this.cborole.Location = new System.Drawing.Point(228, 45);
            this.cborole.Name = "cborole";
            this.cborole.Size = new System.Drawing.Size(121, 21);
            this.cborole.TabIndex = 18;
            // 
            // lbldues
            // 
            this.lbldues.AutoSize = true;
            this.lbldues.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldues.Location = new System.Drawing.Point(417, 19);
            this.lbldues.Name = "lbldues";
            this.lbldues.Size = new System.Drawing.Size(80, 25);
            this.lbldues.TabIndex = 19;
            this.lbldues.Text = "Cuotas";
            // 
            // cbodues
            // 
            this.cbodues.FormattingEnabled = true;
            this.cbodues.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbodues.Location = new System.Drawing.Point(399, 45);
            this.cbodues.Name = "cbodues";
            this.cbodues.Size = new System.Drawing.Size(121, 21);
            this.cbodues.TabIndex = 20;
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(422, 108);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(75, 23);
            this.btnup.TabIndex = 21;
            this.btnup.Text = "Cargar";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btninvoice
            // 
            this.btninvoice.Location = new System.Drawing.Point(422, 156);
            this.btninvoice.Name = "btninvoice";
            this.btninvoice.Size = new System.Drawing.Size(75, 23);
            this.btninvoice.TabIndex = 22;
            this.btninvoice.Text = "Facturación";
            this.btninvoice.UseVisualStyleBackColor = true;
            this.btninvoice.Click += new System.EventHandler(this.btninvoice_Click);
            // 
            // Crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 377);
            this.ControlBox = false;
            this.Controls.Add(this.btninvoice);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.cbodues);
            this.Controls.Add(this.lbldues);
            this.Controls.Add(this.cborole);
            this.Controls.Add(this.lblrole);
            this.Controls.Add(this.dtginfo);
            this.Controls.Add(this.btnearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluser);
            this.Name = "Crud";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Crud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtginfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnearch;
        private System.Windows.Forms.DataGridView dtginfo;
        private System.Windows.Forms.Label lblrole;
        private System.Windows.Forms.ComboBox cborole;
        private System.Windows.Forms.Label lbldues;
        private System.Windows.Forms.ComboBox cbodues;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btninvoice;
    }
}

