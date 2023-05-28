
namespace Software_II_C969_Dainen_Mann
{
    partial class NewUserForm
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
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.maskedPWBox = new System.Windows.Forms.MaskedTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pwLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmPWBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.createButton.Location = new System.Drawing.Point(12, 272);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.Location = new System.Drawing.Point(260, 272);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // maskedPWBox
            // 
            this.maskedPWBox.Location = new System.Drawing.Point(151, 118);
            this.maskedPWBox.Name = "maskedPWBox";
            this.maskedPWBox.PasswordChar = '*';
            this.maskedPWBox.Size = new System.Drawing.Size(124, 21);
            this.maskedPWBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(30, 63);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(65, 15);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Username";
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Location = new System.Drawing.Point(34, 121);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(61, 15);
            this.pwLabel.TabIndex = 4;
            this.pwLabel.Text = "Password";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(151, 60);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(124, 21);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Confirm Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // confirmPWBox
            // 
            this.confirmPWBox.Location = new System.Drawing.Point(151, 179);
            this.confirmPWBox.Name = "confirmPWBox";
            this.confirmPWBox.PasswordChar = '*';
            this.confirmPWBox.Size = new System.Drawing.Size(124, 21);
            this.confirmPWBox.TabIndex = 3;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(347, 307);
            this.Controls.Add(this.confirmPWBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.maskedPWBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "NewUserForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.MaskedTextBox maskedPWBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox confirmPWBox;
    }
}