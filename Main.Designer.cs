namespace howto_address_integrated_map
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cboGoogle = new System.Windows.Forms.ComboBox();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.wbrMap = new System.Windows.Forms.WebBrowser();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboGoogle
            // 
            this.cboGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGoogle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGoogle.FormattingEnabled = true;
            this.cboGoogle.Items.AddRange(new object[] {
            "Map",
            "Satellite",
            "Hybrid",
            "Terrain",
            "Google Earth"});
            this.cboGoogle.Location = new System.Drawing.Point(805, 11);
            this.cboGoogle.Name = "cboGoogle";
            this.cboGoogle.Size = new System.Drawing.Size(115, 21);
            this.cboGoogle.TabIndex = 1;
            // 
            // btnGoogle
            // 
            this.btnGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoogle.Location = new System.Drawing.Point(926, 11);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(65, 30);
            this.btnGoogle.TabIndex = 2;
            this.btnGoogle.Text = "Get Map";
            this.btnGoogle.UseVisualStyleBackColor = true;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(66, 12);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(733, 20);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Text = "1600 Pennsylvania Avenue; NW Washington, D.C. 20500";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 13);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "Address:";
            // 
            // wbrMap
            // 
            this.wbrMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbrMap.Location = new System.Drawing.Point(12, 48);
            this.wbrMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrMap.Name = "wbrMap";
            this.wbrMap.Size = new System.Drawing.Size(1042, 555);
            this.wbrMap.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(997, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 30);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.btnGoogle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 615);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cboGoogle);
            this.Controls.Add(this.btnGoogle);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.wbrMap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "GoogleMap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboGoogle;
        internal System.Windows.Forms.Button btnGoogle;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.WebBrowser wbrMap;
        internal System.Windows.Forms.Button btnExit;
    }
}

