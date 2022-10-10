
namespace Software_II_C969_Dainen_Mann
{
    partial class AddAppt
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
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.apptFormLabel = new System.Windows.Forms.Label();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.comboCustList = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.contactBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.apptCombo = new System.Windows.Forms.ComboBox();
            this.apptLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(126, 440);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(597, 440);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 16;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // apptFormLabel
            // 
            this.apptFormLabel.AutoSize = true;
            this.apptFormLabel.Location = new System.Drawing.Point(12, 9);
            this.apptFormLabel.Name = "apptFormLabel";
            this.apptFormLabel.Size = new System.Drawing.Size(139, 15);
            this.apptFormLabel.TabIndex = 4;
            this.apptFormLabel.Text = "Edit/Modify Appointment";
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Location = new System.Drawing.Point(71, 98);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(60, 15);
            this.customerIDLabel.TabIndex = 5;
            this.customerIDLabel.Text = "Customer";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(40, 309);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(33, 15);
            this.typeLabel.TabIndex = 6;
            this.typeLabel.Text = "Type";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(68, 352);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(63, 15);
            this.startTimeLabel.TabIndex = 7;
            this.startTimeLabel.Text = "Start Time";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(71, 399);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(60, 15);
            this.endTimeLabel.TabIndex = 8;
            this.endTimeLabel.Text = "End Time";
            this.endTimeLabel.Click += new System.EventHandler(this.endTimeLabel_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(173, 172);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(100, 21);
            this.descriptionBox.TabIndex = 4;
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(101, 303);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(100, 21);
            this.typeBox.TabIndex = 7;
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "yyyy/MM/dd HH:mm";
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(173, 346);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(234, 21);
            this.startTimePicker.TabIndex = 9;
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "yyyy/MM/dd HH:mm";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(173, 393);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(234, 21);
            this.endTimePicker.TabIndex = 10;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(173, 132);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(100, 21);
            this.titleBox.TabIndex = 3;
            // 
            // comboCustList
            // 
            this.comboCustList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCustList.FormattingEnabled = true;
            this.comboCustList.Location = new System.Drawing.Point(173, 90);
            this.comboCustList.Name = "comboCustList";
            this.comboCustList.Size = new System.Drawing.Size(121, 23);
            this.comboCustList.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(71, 138);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 15);
            this.titleLabel.TabIndex = 16;
            this.titleLabel.Text = "Title";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(397, 440);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(497, 440);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(71, 178);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(69, 15);
            this.descriptionLabel.TabIndex = 19;
            this.descriptionLabel.Text = "Description";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(71, 220);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(54, 15);
            this.locationLabel.TabIndex = 20;
            this.locationLabel.Text = "Location";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(68, 264);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(48, 15);
            this.contactLabel.TabIndex = 21;
            this.contactLabel.Text = "Contact";
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(173, 214);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(100, 21);
            this.locationBox.TabIndex = 5;
            // 
            // contactBox
            // 
            this.contactBox.Location = new System.Drawing.Point(173, 258);
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(100, 21);
            this.contactBox.TabIndex = 6;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(223, 309);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(32, 15);
            this.urlLabel.TabIndex = 24;
            this.urlLabel.Text = "URL";
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(276, 303);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(154, 21);
            this.urlBox.TabIndex = 8;
            // 
            // apptCombo
            // 
            this.apptCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.apptCombo.FormattingEnabled = true;
            this.apptCombo.Location = new System.Drawing.Point(173, 46);
            this.apptCombo.MaxDropDownItems = 15;
            this.apptCombo.Name = "apptCombo";
            this.apptCombo.Size = new System.Drawing.Size(121, 23);
            this.apptCombo.TabIndex = 1;
            this.apptCombo.SelectedIndexChanged += new System.EventHandler(this.apptCombo_SelectedIndexChanged);
            // 
            // apptLabel
            // 
            this.apptLabel.AutoSize = true;
            this.apptLabel.Location = new System.Drawing.Point(71, 54);
            this.apptLabel.Name = "apptLabel";
            this.apptLabel.Size = new System.Drawing.Size(76, 15);
            this.apptLabel.TabIndex = 27;
            this.apptLabel.Text = "Appointment";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(226, 440);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(26, 440);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 11;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // AddAppt
            // 
            this.ClientSize = new System.Drawing.Size(690, 490);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.apptLabel);
            this.Controls.Add(this.apptCombo);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.comboCustList);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.apptFormLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddAppt";
            this.Load += new System.EventHandler(this.AddAppt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label apptFormLabel;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox typeBox;
		private System.Windows.Forms.DateTimePicker startTimePicker;
		private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.ComboBox comboCustList;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.ComboBox apptCombo;
        private System.Windows.Forms.Label apptLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button newButton;
    }
}