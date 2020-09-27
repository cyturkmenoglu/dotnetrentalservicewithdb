namespace UI
{
    partial class RentAVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentAVehicle));
            this.ControlPanelLabel = new System.Windows.Forms.Label();
            this.VehicleAvailabilityLabel = new System.Windows.Forms.Label();
            this.VehicleColorLabel = new System.Windows.Forms.Label();
            this.VehicleMileageLabel = new System.Windows.Forms.Label();
            this.VehicleYearLabel = new System.Windows.Forms.Label();
            this.VehicleNameBox = new System.Windows.Forms.ListBox();
            this.VehicleNameLabel = new System.Windows.Forms.Label();
            this.VehicleTypeLabel = new System.Windows.Forms.Label();
            this.VehicleRatingLabel = new System.Windows.Forms.Label();
            this.AdminButton = new System.Windows.Forms.Button();
            this.DismissVehicleButton = new System.Windows.Forms.Button();
            this.RentVehicleButton = new System.Windows.Forms.Button();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.LogoutLabel = new System.Windows.Forms.Button();
            this.AvailableCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ControlPanelLabel
            // 
            this.ControlPanelLabel.AutoSize = true;
            this.ControlPanelLabel.Font = new System.Drawing.Font("Gadugi", 16F);
            this.ControlPanelLabel.ForeColor = System.Drawing.Color.White;
            this.ControlPanelLabel.Location = new System.Drawing.Point(12, 9);
            this.ControlPanelLabel.Name = "ControlPanelLabel";
            this.ControlPanelLabel.Size = new System.Drawing.Size(142, 26);
            this.ControlPanelLabel.TabIndex = 3;
            this.ControlPanelLabel.Text = "Control Panel";
            // 
            // VehicleAvailabilityLabel
            // 
            this.VehicleAvailabilityLabel.AutoSize = true;
            this.VehicleAvailabilityLabel.Font = new System.Drawing.Font("Gadugi", 10F);
            this.VehicleAvailabilityLabel.ForeColor = System.Drawing.Color.White;
            this.VehicleAvailabilityLabel.Location = new System.Drawing.Point(231, 222);
            this.VehicleAvailabilityLabel.Name = "VehicleAvailabilityLabel";
            this.VehicleAvailabilityLabel.Size = new System.Drawing.Size(120, 17);
            this.VehicleAvailabilityLabel.TabIndex = 30;
            this.VehicleAvailabilityLabel.Text = "Vehicle Availability";
            // 
            // VehicleColorLabel
            // 
            this.VehicleColorLabel.AutoSize = true;
            this.VehicleColorLabel.Font = new System.Drawing.Font("Gadugi", 10F);
            this.VehicleColorLabel.ForeColor = System.Drawing.Color.White;
            this.VehicleColorLabel.Location = new System.Drawing.Point(231, 180);
            this.VehicleColorLabel.Name = "VehicleColorLabel";
            this.VehicleColorLabel.Size = new System.Drawing.Size(88, 17);
            this.VehicleColorLabel.TabIndex = 29;
            this.VehicleColorLabel.Text = "Vehicle Color";
            // 
            // VehicleMileageLabel
            // 
            this.VehicleMileageLabel.AutoSize = true;
            this.VehicleMileageLabel.Font = new System.Drawing.Font("Gadugi", 10F);
            this.VehicleMileageLabel.ForeColor = System.Drawing.Color.White;
            this.VehicleMileageLabel.Location = new System.Drawing.Point(231, 159);
            this.VehicleMileageLabel.Name = "VehicleMileageLabel";
            this.VehicleMileageLabel.Size = new System.Drawing.Size(103, 17);
            this.VehicleMileageLabel.TabIndex = 28;
            this.VehicleMileageLabel.Text = "Vehicle Mileage";
            // 
            // VehicleYearLabel
            // 
            this.VehicleYearLabel.AutoSize = true;
            this.VehicleYearLabel.Font = new System.Drawing.Font("Gadugi", 10F);
            this.VehicleYearLabel.ForeColor = System.Drawing.Color.White;
            this.VehicleYearLabel.Location = new System.Drawing.Point(231, 138);
            this.VehicleYearLabel.Name = "VehicleYearLabel";
            this.VehicleYearLabel.Size = new System.Drawing.Size(82, 17);
            this.VehicleYearLabel.TabIndex = 27;
            this.VehicleYearLabel.Text = "Vehicle Year";
            // 
            // VehicleNameBox
            // 
            this.VehicleNameBox.Font = new System.Drawing.Font("Gadugi", 12F);
            this.VehicleNameBox.FormattingEnabled = true;
            this.VehicleNameBox.ItemHeight = 19;
            this.VehicleNameBox.Location = new System.Drawing.Point(17, 113);
            this.VehicleNameBox.Name = "VehicleNameBox";
            this.VehicleNameBox.Size = new System.Drawing.Size(192, 175);
            this.VehicleNameBox.TabIndex = 26;
            this.VehicleNameBox.SelectedIndexChanged += new System.EventHandler(this.VehicleNameBox_SelectedIndexChanged);
            // 
            // VehicleNameLabel
            // 
            this.VehicleNameLabel.AutoSize = true;
            this.VehicleNameLabel.Font = new System.Drawing.Font("Gadugi", 10F);
            this.VehicleNameLabel.ForeColor = System.Drawing.Color.White;
            this.VehicleNameLabel.Location = new System.Drawing.Point(231, 117);
            this.VehicleNameLabel.Name = "VehicleNameLabel";
            this.VehicleNameLabel.Size = new System.Drawing.Size(91, 17);
            this.VehicleNameLabel.TabIndex = 25;
            this.VehicleNameLabel.Text = "Vehicle Name";
            // 
            // VehicleTypeLabel
            // 
            this.VehicleTypeLabel.AutoSize = true;
            this.VehicleTypeLabel.Font = new System.Drawing.Font("Gadugi", 10F);
            this.VehicleTypeLabel.ForeColor = System.Drawing.Color.White;
            this.VehicleTypeLabel.Location = new System.Drawing.Point(231, 201);
            this.VehicleTypeLabel.Name = "VehicleTypeLabel";
            this.VehicleTypeLabel.Size = new System.Drawing.Size(84, 17);
            this.VehicleTypeLabel.TabIndex = 24;
            this.VehicleTypeLabel.Text = "Vehicle Type";
            // 
            // VehicleRatingLabel
            // 
            this.VehicleRatingLabel.AutoSize = true;
            this.VehicleRatingLabel.Font = new System.Drawing.Font("Gadugi", 10F);
            this.VehicleRatingLabel.ForeColor = System.Drawing.Color.White;
            this.VehicleRatingLabel.Location = new System.Drawing.Point(231, 243);
            this.VehicleRatingLabel.Name = "VehicleRatingLabel";
            this.VehicleRatingLabel.Size = new System.Drawing.Size(94, 17);
            this.VehicleRatingLabel.TabIndex = 23;
            this.VehicleRatingLabel.Text = "Vehicle Rating";
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.DarkGray;
            this.AdminButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.AdminButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminButton.Font = new System.Drawing.Font("Gadugi", 10F);
            this.AdminButton.ForeColor = System.Drawing.Color.White;
            this.AdminButton.Location = new System.Drawing.Point(387, 293);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(60, 30);
            this.AdminButton.TabIndex = 31;
            this.AdminButton.Text = "Admin";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // DismissVehicleButton
            // 
            this.DismissVehicleButton.BackColor = System.Drawing.Color.DarkGray;
            this.DismissVehicleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.DismissVehicleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.DismissVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DismissVehicleButton.Font = new System.Drawing.Font("Gadugi", 10F);
            this.DismissVehicleButton.ForeColor = System.Drawing.Color.White;
            this.DismissVehicleButton.Location = new System.Drawing.Point(143, 293);
            this.DismissVehicleButton.Name = "DismissVehicleButton";
            this.DismissVehicleButton.Size = new System.Drawing.Size(68, 31);
            this.DismissVehicleButton.TabIndex = 32;
            this.DismissVehicleButton.Text = "Dismiss";
            this.DismissVehicleButton.UseVisualStyleBackColor = false;
            this.DismissVehicleButton.Click += new System.EventHandler(this.DismissVehicleButton_Click);
            // 
            // RentVehicleButton
            // 
            this.RentVehicleButton.BackColor = System.Drawing.Color.DarkGray;
            this.RentVehicleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.RentVehicleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.RentVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentVehicleButton.Font = new System.Drawing.Font("Gadugi", 10F);
            this.RentVehicleButton.ForeColor = System.Drawing.Color.White;
            this.RentVehicleButton.Location = new System.Drawing.Point(17, 293);
            this.RentVehicleButton.Name = "RentVehicleButton";
            this.RentVehicleButton.Size = new System.Drawing.Size(68, 31);
            this.RentVehicleButton.TabIndex = 33;
            this.RentVehicleButton.Text = "Rent";
            this.RentVehicleButton.UseVisualStyleBackColor = false;
            this.RentVehicleButton.Click += new System.EventHandler(this.RentVehicleButton_Click);
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.IntegralHeight = false;
            this.TypeBox.Location = new System.Drawing.Point(326, 75);
            this.TypeBox.MaxDropDownItems = 10;
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(121, 21);
            this.TypeBox.TabIndex = 34;
            this.TypeBox.Text = "--Choose--";
            this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Gadugi", 10F);
            this.SearchBox.Location = new System.Drawing.Point(17, 73);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(189, 20);
            this.SearchBox.TabIndex = 36;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.ForeColor = System.Drawing.Color.White;
            this.SearchLabel.Location = new System.Drawing.Point(13, 51);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(56, 19);
            this.SearchLabel.TabIndex = 35;
            this.SearchLabel.Text = "Search";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.ForeColor = System.Drawing.Color.White;
            this.TypeLabel.Location = new System.Drawing.Point(327, 51);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(42, 19);
            this.TypeLabel.TabIndex = 37;
            this.TypeLabel.Text = "Type";
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.BackColor = System.Drawing.Color.DarkGray;
            this.DeleteAccountButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.DeleteAccountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.DeleteAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAccountButton.Font = new System.Drawing.Font("Gadugi", 10F);
            this.DeleteAccountButton.ForeColor = System.Drawing.Color.White;
            this.DeleteAccountButton.Location = new System.Drawing.Point(326, 9);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(121, 30);
            this.DeleteAccountButton.TabIndex = 38;
            this.DeleteAccountButton.Text = "Delete Account";
            this.DeleteAccountButton.UseVisualStyleBackColor = false;
            this.DeleteAccountButton.Click += new System.EventHandler(this.DeleteAccountButton_Click);
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.BackColor = System.Drawing.Color.DarkGray;
            this.LogoutLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.LogoutLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.LogoutLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutLabel.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LogoutLabel.ForeColor = System.Drawing.Color.White;
            this.LogoutLabel.Location = new System.Drawing.Point(269, 293);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(69, 30);
            this.LogoutLabel.TabIndex = 39;
            this.LogoutLabel.Text = "Logout";
            this.LogoutLabel.UseVisualStyleBackColor = false;
            this.LogoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // AvailableCheckBox
            // 
            this.AvailableCheckBox.AutoSize = true;
            this.AvailableCheckBox.Font = new System.Drawing.Font("Gadugi", 8F);
            this.AvailableCheckBox.ForeColor = System.Drawing.Color.White;
            this.AvailableCheckBox.Location = new System.Drawing.Point(17, 94);
            this.AvailableCheckBox.Name = "AvailableCheckBox";
            this.AvailableCheckBox.Size = new System.Drawing.Size(104, 18);
            this.AvailableCheckBox.TabIndex = 40;
            this.AvailableCheckBox.Text = "Show Available";
            this.AvailableCheckBox.UseVisualStyleBackColor = true;
            this.AvailableCheckBox.CheckedChanged += new System.EventHandler(this.AvailableCheckBox_CheckedChanged);
            // 
            // RentAVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(459, 331);
            this.Controls.Add(this.AvailableCheckBox);
            this.Controls.Add(this.LogoutLabel);
            this.Controls.Add(this.DeleteAccountButton);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.RentVehicleButton);
            this.Controls.Add(this.DismissVehicleButton);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.VehicleAvailabilityLabel);
            this.Controls.Add(this.VehicleColorLabel);
            this.Controls.Add(this.VehicleMileageLabel);
            this.Controls.Add(this.VehicleYearLabel);
            this.Controls.Add(this.VehicleNameBox);
            this.Controls.Add(this.VehicleNameLabel);
            this.Controls.Add(this.VehicleTypeLabel);
            this.Controls.Add(this.VehicleRatingLabel);
            this.Controls.Add(this.ControlPanelLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RentAVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horse Rental";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentAVehicle_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ControlPanelLabel;
        private System.Windows.Forms.Label VehicleAvailabilityLabel;
        private System.Windows.Forms.Label VehicleColorLabel;
        private System.Windows.Forms.Label VehicleMileageLabel;
        private System.Windows.Forms.Label VehicleYearLabel;
        private System.Windows.Forms.ListBox VehicleNameBox;
        private System.Windows.Forms.Label VehicleNameLabel;
        private System.Windows.Forms.Label VehicleTypeLabel;
        private System.Windows.Forms.Label VehicleRatingLabel;
        public System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button DismissVehicleButton;
        private System.Windows.Forms.Button RentVehicleButton;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Button DeleteAccountButton;
        private System.Windows.Forms.Button LogoutLabel;
        private System.Windows.Forms.CheckBox AvailableCheckBox;
    }
}