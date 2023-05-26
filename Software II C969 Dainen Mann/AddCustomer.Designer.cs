
namespace Software_II_C969_Dainen_Mann
{
    partial class AddCustomer
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
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.customerListLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.address1Box = new System.Windows.Forms.TextBox();
            this.address2Box = new System.Windows.Forms.TextBox();
            this.address1Label = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.zipCodeBox = new System.Windows.Forms.TextBox();
            this.phoneNumBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerComboBox
            // 
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(124, 44);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(140, 23);
            this.customerComboBox.TabIndex = 1;
            this.customerComboBox.SelectedIndexChanged += new System.EventHandler(this.customerComboBox_SelectedIndexChanged);
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(124, 244);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(140, 23);
            this.cityComboBox.TabIndex = 6;
            // 
            // customerListLabel
            // 
            this.customerListLabel.AutoSize = true;
            this.customerListLabel.Location = new System.Drawing.Point(25, 52);
            this.customerListLabel.Name = "customerListLabel";
            this.customerListLabel.Size = new System.Drawing.Size(82, 15);
            this.customerListLabel.TabIndex = 2;
            this.customerListLabel.Text = "Customer List";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(37, 208);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(48, 15);
            this.countryLabel.TabIndex = 3;
            this.countryLabel.Text = "Country";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(137, 404);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(87, 27);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(239, 404);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(87, 27);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(366, 404);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 27);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(469, 404);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(87, 27);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(568, 404);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(87, 27);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(32, 404);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(87, 27);
            this.newButton.TabIndex = 10;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Location = new System.Drawing.Point(124, 369);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(57, 19);
            this.activeCheckBox.TabIndex = 9;
            this.activeCheckBox.Text = "Active";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(124, 200);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(140, 23);
            this.countryComboBox.TabIndex = 5;
            this.countryComboBox.Leave += new System.EventHandler(this.countryComboBox_Leave);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(59, 252);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(26, 15);
            this.cityLabel.TabIndex = 12;
            this.cityLabel.Text = "City";
            // 
            // address1Box
            // 
            this.address1Box.Location = new System.Drawing.Point(124, 132);
            this.address1Box.Name = "address1Box";
            this.address1Box.Size = new System.Drawing.Size(271, 21);
            this.address1Box.TabIndex = 3;
            // 
            // address2Box
            // 
            this.address2Box.Location = new System.Drawing.Point(124, 159);
            this.address2Box.Name = "address2Box";
            this.address2Box.Size = new System.Drawing.Size(271, 21);
            this.address2Box.TabIndex = 4;
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Location = new System.Drawing.Point(24, 138);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(61, 15);
            this.address1Label.TabIndex = 15;
            this.address1Label.Text = "Address 1";
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Location = new System.Drawing.Point(24, 165);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(61, 15);
            this.address2Label.TabIndex = 16;
            this.address2Label.Text = "Address 2";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(29, 296);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(56, 15);
            this.zipCodeLabel.TabIndex = 17;
            this.zipCodeLabel.Text = "Zip Code";
            // 
            // zipCodeBox
            // 
            this.zipCodeBox.Location = new System.Drawing.Point(124, 290);
            this.zipCodeBox.Name = "zipCodeBox";
            this.zipCodeBox.Size = new System.Drawing.Size(100, 21);
            this.zipCodeBox.TabIndex = 7;
            // 
            // phoneNumBox
            // 
            this.phoneNumBox.Location = new System.Drawing.Point(124, 331);
            this.phoneNumBox.Name = "phoneNumBox";
            this.phoneNumBox.Size = new System.Drawing.Size(140, 21);
            this.phoneNumBox.TabIndex = 8;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(12, 337);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(91, 15);
            this.phoneLabel.TabIndex = 20;
            this.phoneLabel.Text = "Phone Number";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(124, 90);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(140, 21);
            this.nameBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(44, 96);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 15);
            this.nameLabel.TabIndex = 22;
            this.nameLabel.Text = "Name";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(667, 448);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneNumBox);
            this.Controls.Add(this.zipCodeBox);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.address2Label);
            this.Controls.Add(this.address1Label);
            this.Controls.Add(this.address2Box);
            this.Controls.Add(this.address1Box);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.customerListLabel);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.customerComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddCustomer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label customerListLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox address1Box;
        private System.Windows.Forms.TextBox address2Box;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox zipCodeBox;
        private System.Windows.Forms.TextBox phoneNumBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
    }
}