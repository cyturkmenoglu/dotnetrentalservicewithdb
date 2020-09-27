using System.Windows.Forms;

namespace UI
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.AgeLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.LastnameBox = new System.Windows.Forms.TextBox();
            this.LastnameLabel = new System.Windows.Forms.Label();
            this.AccountTypeLabel = new System.Windows.Forms.Label();
            this.AccountTypeBox = new System.Windows.Forms.ComboBox();
            this.AgeBox = new System.Windows.Forms.NumericUpDown();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AgeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.ForeColor = System.Drawing.Color.White;
            this.AgeLabel.Location = new System.Drawing.Point(194, 160);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(36, 19);
            this.AgeLabel.TabIndex = 37;
            this.AgeLabel.Text = "Age";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Gadugi", 10F);
            this.NameBox.Location = new System.Drawing.Point(13, 125);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(108, 20);
            this.NameBox.TabIndex = 40;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(13, 103);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 19);
            this.NameLabel.TabIndex = 39;
            this.NameLabel.Text = "Name";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Gadugi", 10F);
            this.PasswordBox.Location = new System.Drawing.Point(13, 237);
            this.PasswordBox.Multiline = true;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(154, 20);
            this.PasswordBox.TabIndex = 42;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(13, 215);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(76, 19);
            this.Password.TabIndex = 41;
            this.Password.Text = "Password";
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Font = new System.Drawing.Font("Gadugi", 10F);
            this.PhoneNumberBox.Location = new System.Drawing.Point(145, 69);
            this.PhoneNumberBox.Multiline = true;
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(108, 20);
            this.PhoneNumberBox.TabIndex = 44;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.White;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(145, 47);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(115, 19);
            this.PhoneNumberLabel.TabIndex = 43;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Gadugi", 10F);
            this.EmailBox.Location = new System.Drawing.Point(13, 183);
            this.EmailBox.Multiline = true;
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(154, 20);
            this.EmailBox.TabIndex = 46;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.White;
            this.EmailLabel.Location = new System.Drawing.Point(13, 161);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(47, 19);
            this.EmailLabel.TabIndex = 45;
            this.EmailLabel.Text = "Email";
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Gadugi", 10F);
            this.IDBox.Location = new System.Drawing.Point(13, 69);
            this.IDBox.Multiline = true;
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(108, 20);
            this.IDBox.TabIndex = 48;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.White;
            this.IDLabel.Location = new System.Drawing.Point(13, 47);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(24, 19);
            this.IDLabel.TabIndex = 47;
            this.IDLabel.Text = "ID";
            // 
            // LastnameBox
            // 
            this.LastnameBox.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LastnameBox.Location = new System.Drawing.Point(145, 125);
            this.LastnameBox.Multiline = true;
            this.LastnameBox.Name = "LastnameBox";
            this.LastnameBox.Size = new System.Drawing.Size(108, 20);
            this.LastnameBox.TabIndex = 50;
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.AutoSize = true;
            this.LastnameLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastnameLabel.ForeColor = System.Drawing.Color.White;
            this.LastnameLabel.Location = new System.Drawing.Point(145, 103);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(76, 19);
            this.LastnameLabel.TabIndex = 49;
            this.LastnameLabel.Text = "Lastname";
            // 
            // AccountTypeLabel
            // 
            this.AccountTypeLabel.AutoSize = true;
            this.AccountTypeLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypeLabel.ForeColor = System.Drawing.Color.White;
            this.AccountTypeLabel.Location = new System.Drawing.Point(12, 276);
            this.AccountTypeLabel.Name = "AccountTypeLabel";
            this.AccountTypeLabel.Size = new System.Drawing.Size(102, 19);
            this.AccountTypeLabel.TabIndex = 52;
            this.AccountTypeLabel.Text = "Account Type";
            // 
            // AccountTypeBox
            // 
            this.AccountTypeBox.FormattingEnabled = true;
            this.AccountTypeBox.Items.AddRange(new object[] {
            "Personel",
            "Manager",
            "Client"});
            this.AccountTypeBox.Location = new System.Drawing.Point(12, 298);
            this.AccountTypeBox.Name = "AccountTypeBox";
            this.AccountTypeBox.Size = new System.Drawing.Size(108, 21);
            this.AccountTypeBox.SelectedIndex = 0;
            this.AccountTypeBox.TabIndex = 51;
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(194, 183);
            this.AgeBox.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(59, 20);
            this.AgeBox.TabIndex = 54;
            this.AgeBox.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Font = new System.Drawing.Font("Gadugi", 16F);
            this.SignUpLabel.ForeColor = System.Drawing.Color.White;
            this.SignUpLabel.Location = new System.Drawing.Point(12, 9);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(88, 26);
            this.SignUpLabel.TabIndex = 53;
            this.SignUpLabel.Text = "Sign Up";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.DarkGray;
            this.SubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.SubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Gadugi", 10F);
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(184, 288);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(68, 31);
            this.SubmitButton.TabIndex = 55;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(264, 331);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.AccountTypeLabel);
            this.Controls.Add(this.AccountTypeBox);
            this.Controls.Add(this.LastnameBox);
            this.Controls.Add(this.LastnameLabel);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AgeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.AgeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox LastnameBox;
        private System.Windows.Forms.Label LastnameLabel;
        private System.Windows.Forms.Label AccountTypeLabel;
        private System.Windows.Forms.ComboBox AccountTypeBox;
        private System.Windows.Forms.NumericUpDown AgeBox;
        private System.Windows.Forms.Label SignUpLabel;
        private Button SubmitButton;
    }
}