namespace UI
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.RemoveSelectedLabel = new System.Windows.Forms.Label();
            this.RemoveLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.FulNamesLabel = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.UsersLabel = new System.Windows.Forms.Label();
            this.RentedVehicleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RemoveSelectedLabel
            // 
            this.RemoveSelectedLabel.AutoSize = true;
            this.RemoveSelectedLabel.Font = new System.Drawing.Font("Gadugi", 8F);
            this.RemoveSelectedLabel.ForeColor = System.Drawing.Color.White;
            this.RemoveSelectedLabel.Location = new System.Drawing.Point(14, 224);
            this.RemoveSelectedLabel.Name = "RemoveSelectedLabel";
            this.RemoveSelectedLabel.Size = new System.Drawing.Size(93, 14);
            this.RemoveSelectedLabel.TabIndex = 98;
            this.RemoveSelectedLabel.Text = "Remove Selected";
            // 
            // RemoveLabel
            // 
            this.RemoveLabel.AutoSize = true;
            this.RemoveLabel.Font = new System.Drawing.Font("Gadugi", 14F);
            this.RemoveLabel.ForeColor = System.Drawing.Color.White;
            this.RemoveLabel.Location = new System.Drawing.Point(13, 202);
            this.RemoveLabel.Name = "RemoveLabel";
            this.RemoveLabel.Size = new System.Drawing.Size(77, 22);
            this.RemoveLabel.TabIndex = 97;
            this.RemoveLabel.Text = "Remove";
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.DarkGray;
            this.RemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Gadugi", 10F);
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.Location = new System.Drawing.Point(41, 243);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(68, 31);
            this.RemoveButton.TabIndex = 96;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click_1);
            // 
            // FulNamesLabel
            // 
            this.FulNamesLabel.AutoSize = true;
            this.FulNamesLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FulNamesLabel.ForeColor = System.Drawing.Color.White;
            this.FulNamesLabel.Location = new System.Drawing.Point(13, 51);
            this.FulNamesLabel.Name = "FulNamesLabel";
            this.FulNamesLabel.Size = new System.Drawing.Size(87, 19);
            this.FulNamesLabel.TabIndex = 94;
            this.FulNamesLabel.Text = "Full Names";
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(12, 75);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(202, 21);
            this.TypeBox.TabIndex = 93;
            this.TypeBox.Text = "--Choose--";
            this.TypeBox.IntegralHeight = false;
            this.TypeBox.MaxDropDownItems = 10;
            this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Gadugi", 10F);
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.White;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(13, 152);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(101, 17);
            this.PhoneNumberLabel.TabIndex = 91;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Gadugi", 10F);
            this.EmailLabel.ForeColor = System.Drawing.Color.White;
            this.EmailLabel.Location = new System.Drawing.Point(13, 135);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(40, 17);
            this.EmailLabel.TabIndex = 90;
            this.EmailLabel.Text = "Email";
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.AutoSize = true;
            this.LastnameLabel.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LastnameLabel.ForeColor = System.Drawing.Color.White;
            this.LastnameLabel.Location = new System.Drawing.Point(13, 118);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(67, 17);
            this.LastnameLabel.TabIndex = 89;
            this.LastnameLabel.Text = "Lastname";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Gadugi", 10F);
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(13, 101);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 17);
            this.NameLabel.TabIndex = 88;
            this.NameLabel.Text = "Name";
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Font = new System.Drawing.Font("Gadugi", 16F);
            this.UsersLabel.ForeColor = System.Drawing.Color.White;
            this.UsersLabel.Location = new System.Drawing.Point(12, 9);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(65, 26);
            this.UsersLabel.TabIndex = 73;
            this.UsersLabel.Text = "Users";
            // 
            // RentedVehicleLabel
            // 
            this.RentedVehicleLabel.AutoSize = true;
            this.RentedVehicleLabel.Font = new System.Drawing.Font("Gadugi", 10F);
            this.RentedVehicleLabel.ForeColor = System.Drawing.Color.White;
            this.RentedVehicleLabel.Location = new System.Drawing.Point(13, 169);
            this.RentedVehicleLabel.Name = "RentedVehicleLabel";
            this.RentedVehicleLabel.Size = new System.Drawing.Size(98, 17);
            this.RentedVehicleLabel.TabIndex = 99;
            this.RentedVehicleLabel.Text = "Rented Vehicle";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(259, 286);
            this.Controls.Add(this.RentedVehicleLabel);
            this.Controls.Add(this.RemoveSelectedLabel);
            this.Controls.Add(this.RemoveLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.FulNamesLabel);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LastnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.UsersLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RemoveSelectedLabel;
        private System.Windows.Forms.Label RemoveLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label FulNamesLabel;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label LastnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.Label RentedVehicleLabel;
    }
}