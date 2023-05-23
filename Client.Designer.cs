namespace Login
{
    partial class ClientForms
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
            this.lblamountdues = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblamountdues
            // 
            this.lblamountdues.AutoSize = true;
            this.lblamountdues.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamountdues.Location = new System.Drawing.Point(12, 102);
            this.lblamountdues.Name = "lblamountdues";
            this.lblamountdues.Size = new System.Drawing.Size(386, 25);
            this.lblamountdues.TabIndex = 0;
            this.lblamountdues.Text = "Su número de cuotas restantes es: ";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Location = new System.Drawing.Point(404, 114);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(0, 13);
            this.lblamount.TabIndex = 1;
            // 
            // ClientForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(495, 232);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lblamountdues);
            this.Name = "ClientForms";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblamountdues;
        private System.Windows.Forms.Label lblamount;
    }
}