namespace PresentationLayer
{
    partial class FormCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateAccount));
            this.lblCreateText = new System.Windows.Forms.Label();
            this.lblCreateFirstName = new System.Windows.Forms.Label();
            this.lblCreateLastName = new System.Windows.Forms.Label();
            this.lblCreateUsername = new System.Windows.Forms.Label();
            this.lblCreatePassword = new System.Windows.Forms.Label();
            this.lblCreateEmail = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.btnCreateCancel = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateText
            // 
            this.lblCreateText.AutoSize = true;
            this.lblCreateText.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.lblCreateText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCreateText.Location = new System.Drawing.Point(725, 89);
            this.lblCreateText.Name = "lblCreateText";
            this.lblCreateText.Size = new System.Drawing.Size(612, 41);
            this.lblCreateText.TabIndex = 0;
            this.lblCreateText.Text = "Unesite podatke za novi račun:";
            // 
            // lblCreateFirstName
            // 
            this.lblCreateFirstName.AutoSize = true;
            this.lblCreateFirstName.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblCreateFirstName.Location = new System.Drawing.Point(757, 213);
            this.lblCreateFirstName.Name = "lblCreateFirstName";
            this.lblCreateFirstName.Size = new System.Drawing.Size(44, 20);
            this.lblCreateFirstName.TabIndex = 1;
            this.lblCreateFirstName.Text = "Ime";
            // 
            // lblCreateLastName
            // 
            this.lblCreateLastName.AutoSize = true;
            this.lblCreateLastName.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblCreateLastName.Location = new System.Drawing.Point(720, 281);
            this.lblCreateLastName.Name = "lblCreateLastName";
            this.lblCreateLastName.Size = new System.Drawing.Size(77, 20);
            this.lblCreateLastName.TabIndex = 2;
            this.lblCreateLastName.Text = "Prezime";
            // 
            // lblCreateUsername
            // 
            this.lblCreateUsername.AutoSize = true;
            this.lblCreateUsername.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblCreateUsername.Location = new System.Drawing.Point(657, 346);
            this.lblCreateUsername.Name = "lblCreateUsername";
            this.lblCreateUsername.Size = new System.Drawing.Size(134, 20);
            this.lblCreateUsername.TabIndex = 3;
            this.lblCreateUsername.Text = "Korisničko ime";
            this.lblCreateUsername.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCreatePassword
            // 
            this.lblCreatePassword.AutoSize = true;
            this.lblCreatePassword.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblCreatePassword.Location = new System.Drawing.Point(1027, 214);
            this.lblCreatePassword.Name = "lblCreatePassword";
            this.lblCreatePassword.Size = new System.Drawing.Size(73, 20);
            this.lblCreatePassword.TabIndex = 4;
            this.lblCreatePassword.Text = "Lozinka";
            // 
            // lblCreateEmail
            // 
            this.lblCreateEmail.AutoSize = true;
            this.lblCreateEmail.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblCreateEmail.Location = new System.Drawing.Point(1043, 284);
            this.lblCreateEmail.Name = "lblCreateEmail";
            this.lblCreateEmail.Size = new System.Drawing.Size(62, 20);
            this.lblCreateEmail.TabIndex = 5;
            this.lblCreateEmail.Text = "E-Mail";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(821, 213);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(163, 22);
            this.textBoxFirstName.TabIndex = 6;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(821, 281);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(163, 22);
            this.textBoxLastName.TabIndex = 7;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(821, 346);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(163, 22);
            this.textBoxUsername.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(1151, 214);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(163, 22);
            this.textBoxPassword.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(1151, 284);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(163, 22);
            this.textBoxEmail.TabIndex = 10;
            // 
            // btnCreateCancel
            // 
            this.btnCreateCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCancel.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.btnCreateCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCreateCancel.Location = new System.Drawing.Point(751, 498);
            this.btnCreateCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateCancel.Name = "btnCreateCancel";
            this.btnCreateCancel.Size = new System.Drawing.Size(235, 86);
            this.btnCreateCancel.TabIndex = 11;
            this.btnCreateCancel.Text = "Odustani";
            this.btnCreateCancel.UseVisualStyleBackColor = false;
            this.btnCreateCancel.Click += new System.EventHandler(this.btnCreateCancel_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.btnCreateAccount.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCreateAccount.Location = new System.Drawing.Point(1119, 498);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(235, 86);
            this.btnCreateAccount.TabIndex = 12;
            this.btnCreateAccount.Text = "Potvrdi";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 681);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 522);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1481, 677);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.btnCreateCancel);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.lblCreateEmail);
            this.Controls.Add(this.lblCreatePassword);
            this.Controls.Add(this.lblCreateUsername);
            this.Controls.Add(this.lblCreateLastName);
            this.Controls.Add(this.lblCreateFirstName);
            this.Controls.Add(this.lblCreateText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormCreateAccount";
            this.Text = "Novi račun";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateText;
        private System.Windows.Forms.Label lblCreateFirstName;
        private System.Windows.Forms.Label lblCreateLastName;
        private System.Windows.Forms.Label lblCreateUsername;
        private System.Windows.Forms.Label lblCreatePassword;
        private System.Windows.Forms.Label lblCreateEmail;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button btnCreateCancel;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}