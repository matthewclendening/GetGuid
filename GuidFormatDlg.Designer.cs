namespace GetGuid
{
    partial class GuidFormatDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuidFormatDlg));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pFormatRadioButton = new System.Windows.Forms.RadioButton();
            this.bFormatRadioButton = new System.Windows.Forms.RadioButton();
            this.dFormatRadioButton = new System.Windows.Forms.RadioButton();
            this.nFormatRadioButton = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pFormatRadioButton);
            this.groupBox1.Controls.Add(this.bFormatRadioButton);
            this.groupBox1.Controls.Add(this.dFormatRadioButton);
            this.groupBox1.Controls.Add(this.nFormatRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GUID Format";
            // 
            // pFormatRadioButton
            // 
            this.pFormatRadioButton.AutoSize = true;
            this.pFormatRadioButton.Location = new System.Drawing.Point(20, 100);
            this.pFormatRadioButton.Name = "pFormatRadioButton";
            this.pFormatRadioButton.Size = new System.Drawing.Size(203, 17);
            this.pFormatRadioButton.TabIndex = 0;
            this.pFormatRadioButton.TabStop = true;
            this.pFormatRadioButton.Text = "(xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx)";
            this.pFormatRadioButton.UseVisualStyleBackColor = true;
            // 
            // bFormatRadioButton
            // 
            this.bFormatRadioButton.AutoSize = true;
            this.bFormatRadioButton.Location = new System.Drawing.Point(20, 77);
            this.bFormatRadioButton.Name = "bFormatRadioButton";
            this.bFormatRadioButton.Size = new System.Drawing.Size(205, 17);
            this.bFormatRadioButton.TabIndex = 0;
            this.bFormatRadioButton.TabStop = true;
            this.bFormatRadioButton.Text = "{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}";
            this.bFormatRadioButton.UseVisualStyleBackColor = true;
            // 
            // dFormatRadioButton
            // 
            this.dFormatRadioButton.AutoSize = true;
            this.dFormatRadioButton.Location = new System.Drawing.Point(20, 54);
            this.dFormatRadioButton.Name = "dFormatRadioButton";
            this.dFormatRadioButton.Size = new System.Drawing.Size(197, 17);
            this.dFormatRadioButton.TabIndex = 0;
            this.dFormatRadioButton.TabStop = true;
            this.dFormatRadioButton.Text = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            this.dFormatRadioButton.UseVisualStyleBackColor = true;
            // 
            // nFormatRadioButton
            // 
            this.nFormatRadioButton.AutoSize = true;
            this.nFormatRadioButton.Location = new System.Drawing.Point(20, 31);
            this.nFormatRadioButton.Name = "nFormatRadioButton";
            this.nFormatRadioButton.Size = new System.Drawing.Size(185, 17);
            this.nFormatRadioButton.TabIndex = 0;
            this.nFormatRadioButton.TabStop = true;
            this.nFormatRadioButton.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            this.nFormatRadioButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(180, 164);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // GuidFormatDlg
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 199);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuidFormatDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get GUID";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton nFormatRadioButton;
        private System.Windows.Forms.RadioButton pFormatRadioButton;
        private System.Windows.Forms.RadioButton bFormatRadioButton;
        private System.Windows.Forms.RadioButton dFormatRadioButton;
        private System.Windows.Forms.Button okButton;

    }
}

