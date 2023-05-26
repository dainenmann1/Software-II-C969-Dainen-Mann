
namespace Software_II_C969_Dainen_Mann
{
	partial class Login
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
            this.userLabel = new System.Windows.Forms.Label();
            this.pwLabel = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.pwBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newUserLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(12, 115);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(65, 15);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Username";
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Location = new System.Drawing.Point(16, 178);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(61, 15);
            this.pwLabel.TabIndex = 1;
            this.pwLabel.Text = "Password";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(99, 112);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(138, 21);
            this.userBox.TabIndex = 1;
            // 
            // pwBox
            // 
            this.pwBox.Location = new System.Drawing.Point(99, 175);
            this.pwBox.Name = "pwBox";
            this.pwBox.PasswordChar = '*';
            this.pwBox.Size = new System.Drawing.Size(138, 21);
            this.pwBox.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(15, 266);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(116, 266);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Exit";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "ApptScheduler";
            // 
            // newUserLink
            // 
            this.newUserLink.AutoSize = true;
            this.newUserLink.Location = new System.Drawing.Point(271, 274);
            this.newUserLink.Name = "newUserLink";
            this.newUserLink.Size = new System.Drawing.Size(68, 15);
            this.newUserLink.TabIndex = 6;
            this.newUserLink.TabStop = true;
            this.newUserLink.Text = "New User?";
            this.newUserLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newUserLink_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(347, 307);
            this.Controls.Add(this.newUserLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pwBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.userLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label userLabel;
		private System.Windows.Forms.Label pwLabel;
		private System.Windows.Forms.TextBox userBox;
		private System.Windows.Forms.TextBox pwBox;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel newUserLink;
    }
}