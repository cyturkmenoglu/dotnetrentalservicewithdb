namespace UI
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.AdminPanelLabel = new System.Windows.Forms.Label();
            this.VehiclesButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminPanelLabel
            // 
            this.AdminPanelLabel.AutoSize = true;
            this.AdminPanelLabel.Font = new System.Drawing.Font("Gadugi", 16F);
            this.AdminPanelLabel.ForeColor = System.Drawing.Color.White;
            this.AdminPanelLabel.Location = new System.Drawing.Point(12, 10);
            this.AdminPanelLabel.Name = "AdminPanelLabel";
            this.AdminPanelLabel.Size = new System.Drawing.Size(133, 26);
            this.AdminPanelLabel.TabIndex = 54;
            this.AdminPanelLabel.Text = "Admin Panel";
            // 
            // VehiclesButton
            // 
            this.VehiclesButton.BackColor = System.Drawing.Color.DarkGray;
            this.VehiclesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.VehiclesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.VehiclesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehiclesButton.Font = new System.Drawing.Font("Gadugi", 10F);
            this.VehiclesButton.ForeColor = System.Drawing.Color.White;
            this.VehiclesButton.Location = new System.Drawing.Point(44, 94);
            this.VehiclesButton.Name = "VehiclesButton";
            this.VehiclesButton.Size = new System.Drawing.Size(127, 31);
            this.VehiclesButton.TabIndex = 57;
            this.VehiclesButton.Text = "Vehicles";
            this.VehiclesButton.UseVisualStyleBackColor = false;
            this.VehiclesButton.Click += new System.EventHandler(this.VehiclesButton_Click);
            // 
            // UsersButton
            // 
            this.UsersButton.BackColor = System.Drawing.Color.DarkGray;
            this.UsersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.UsersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersButton.Font = new System.Drawing.Font("Gadugi", 10F);
            this.UsersButton.ForeColor = System.Drawing.Color.White;
            this.UsersButton.Location = new System.Drawing.Point(44, 48);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(127, 31);
            this.UsersButton.TabIndex = 62;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = false;
            this.UsersButton.Click += new System.EventHandler(this.ViewUsersButton_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(209, 141);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.VehiclesButton);
            this.Controls.Add(this.AdminPanelLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminPanelLabel;
        private System.Windows.Forms.Button VehiclesButton;
        private System.Windows.Forms.Button UsersButton;
    }
}