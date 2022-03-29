namespace TWinActivator
{
    partial class TWinForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.keysComboBox = new System.Windows.Forms.ComboBox();
            this.activate_button = new System.Windows.Forms.Button();
            this.txtBx_kms = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // keysComboBox
            // 
            this.keysComboBox.DisplayMember = "Key";
            this.keysComboBox.FormattingEnabled = true;
            this.keysComboBox.Location = new System.Drawing.Point(4, 4);
            this.keysComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.keysComboBox.Name = "keysComboBox";
            this.keysComboBox.Size = new System.Drawing.Size(378, 33);
            this.keysComboBox.TabIndex = 0;
            this.keysComboBox.ValueMember = "Value";
            // 
            // activate_button
            // 
            this.activate_button.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.activate_button.Location = new System.Drawing.Point(4, 81);
            this.activate_button.Name = "activate_button";
            this.activate_button.Size = new System.Drawing.Size(378, 86);
            this.activate_button.TabIndex = 1;
            this.activate_button.Text = "Activate";
            this.activate_button.UseVisualStyleBackColor = true;
            this.activate_button.Click += new System.EventHandler(this.PromptActivate);
            // 
            // txtBx_kms
            // 
            this.txtBx_kms.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBx_kms.Location = new System.Drawing.Point(4, 44);
            this.txtBx_kms.Name = "txtBx_kms";
            this.txtBx_kms.Size = new System.Drawing.Size(378, 31);
            this.txtBx_kms.TabIndex = 2;
            this.txtBx_kms.Text = "KMS server";
            this.txtBx_kms.Enter += new System.EventHandler(this.KMSTextBoxFocusEntered);
            this.txtBx_kms.Leave += new System.EventHandler(this.KMSTextBoxFocusLeft);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.keysComboBox);
            this.panel1.Controls.Add(this.txtBx_kms);
            this.panel1.Controls.Add(this.activate_button);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 177);
            this.panel1.TabIndex = 3;
            // 
            // TWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 194);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TWinForm";
            this.RightToLeftLayout = true;
            this.Text = "TWin Activator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox keysComboBox;
        private Button activate_button;
        private TextBox txtBx_kms;
        private Panel panel1;
    }
}