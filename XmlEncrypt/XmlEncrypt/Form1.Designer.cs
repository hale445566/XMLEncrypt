namespace XmlEncrypt
{
    partial class Form1
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
            this.LoadXMl = new System.Windows.Forms.Button();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.XmlTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoadXMl
            // 
            this.LoadXMl.Location = new System.Drawing.Point(533, 582);
            this.LoadXMl.Name = "LoadXMl";
            this.LoadXMl.Size = new System.Drawing.Size(75, 23);
            this.LoadXMl.TabIndex = 0;
            this.LoadXMl.Text = "Load";
            this.LoadXMl.UseVisualStyleBackColor = true;
            this.LoadXMl.Click += new System.EventHandler(this.button1_Click);
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(112, 582);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(367, 21);
            this.KeyBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "密钥";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(631, 582);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // XmlTextBox
            // 
            this.XmlTextBox.Location = new System.Drawing.Point(12, 12);
            this.XmlTextBox.Multiline = true;
            this.XmlTextBox.Name = "XmlTextBox";
            this.XmlTextBox.Size = new System.Drawing.Size(694, 564);
            this.XmlTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 617);
            this.Controls.Add(this.XmlTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.LoadXMl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadXMl;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox XmlTextBox;
    }
}

