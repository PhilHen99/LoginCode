namespace Login.Charging
{
    partial class Products
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
            this.dtginvoice = new System.Windows.Forms.DataGridView();
            this.lblproducts = new System.Windows.Forms.Label();
            this.cbocategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtginvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dtginvoice
            // 
            this.dtginvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtginvoice.Location = new System.Drawing.Point(12, 114);
            this.dtginvoice.Name = "dtginvoice";
            this.dtginvoice.Size = new System.Drawing.Size(645, 224);
            this.dtginvoice.TabIndex = 0;
            this.dtginvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtginvoice_CellContentClick);
            // 
            // lblproducts
            // 
            this.lblproducts.AutoSize = true;
            this.lblproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproducts.Location = new System.Drawing.Point(12, 9);
            this.lblproducts.Name = "lblproducts";
            this.lblproducts.Size = new System.Drawing.Size(188, 33);
            this.lblproducts.TabIndex = 1;
            this.lblproducts.Text = "Facturación:";
            // 
            // cbocategory
            // 
            this.cbocategory.FormattingEnabled = true;
            this.cbocategory.Items.AddRange(new object[] {
            "Cocina",
            "Dormitorio",
            "Electrodoméstico",
            "Sonido"});
            this.cbocategory.Location = new System.Drawing.Point(12, 66);
            this.cbocategory.Name = "cbocategory";
            this.cbocategory.Size = new System.Drawing.Size(645, 21);
            this.cbocategory.TabIndex = 2;
            this.cbocategory.SelectedIndexChanged += new System.EventHandler(this.cbocategory_SelectedIndexChanged);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 372);
            this.Controls.Add(this.cbocategory);
            this.Controls.Add(this.lblproducts);
            this.Controls.Add(this.dtginvoice);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtginvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtginvoice;
        private System.Windows.Forms.Label lblproducts;
        private System.Windows.Forms.ComboBox cbocategory;
    }
}