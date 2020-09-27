namespace UI
{
    partial class Forgot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot));
            this.ForgotLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ForgotLabel
            // 
            this.ForgotLabel.AutoSize = true;
            this.ForgotLabel.Font = new System.Drawing.Font("Gadugi", 16F);
            this.ForgotLabel.ForeColor = System.Drawing.Color.White;
            this.ForgotLabel.Location = new System.Drawing.Point(12, 9);
            this.ForgotLabel.Name = "ForgotLabel";
            this.ForgotLabel.Size = new System.Drawing.Size(77, 26);
            this.ForgotLabel.TabIndex = 4;
            this.ForgotLabel.Text = "Forgot";
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Gadugi", 10F);
            this.IDBox.Location = new System.Drawing.Point(12, 77);
            this.IDBox.Multiline = true;
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(137, 20);
            this.IDBox.TabIndex = 50;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.White;
            this.IDLabel.Location = new System.Drawing.Point(12, 55);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(24, 19);
            this.IDLabel.TabIndex = 49;
            this.IDLabel.Text = "ID";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.DarkGray;
            this.SubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.SubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Gadugi", 10F);
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(172, 73);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(68, 31);
            this.SubmitButton.TabIndex = 56;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Forgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(264, 121);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.ForgotLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Forgot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ForgotLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button SubmitButton;
    }
}