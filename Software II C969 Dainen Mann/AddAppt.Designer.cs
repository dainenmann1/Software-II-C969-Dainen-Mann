
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
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addApptLabel = new System.Windows.Forms.Label();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.customerIDBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "yyyy/MM/dd hh:mm:ss tt";
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(147, 159);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(262, 21);
            this.startTimePicker.TabIndex = 0;
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "yyyy/MM/dd hh:mm:ss tt";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(147, 206);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(262, 21);
            this.endTimePicker.TabIndex = 1;
            this.endTimePicker.ValueChanged += new System.EventHandler(this.endTimePicker_ValueChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(73, 293);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(198, 293);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addApptLabel
            // 
            this.addApptLabel.AutoSize = true;
            this.addApptLabel.Location = new System.Drawing.Point(12, 9);
            this.addApptLabel.Name = "addApptLabel";
            this.addApptLabel.Size = new System.Drawing.Size(100, 15);
            this.addApptLabel.TabIndex = 4;
            this.addApptLabel.Text = "Add Appointment";
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Location = new System.Drawing.Point(71, 76);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(75, 15);
            this.customerIDLabel.TabIndex = 5;
            this.customerIDLabel.Text = "Customer ID";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(70, 120);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(33, 15);
            this.typeLabel.TabIndex = 6;
            this.typeLabel.Text = "Type";
            this.typeLabel.Click += new System.EventHandler(this.typeLabel_Click);
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(71, 164);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(63, 15);
            this.startTimeLabel.TabIndex = 7;
            this.startTimeLabel.Text = "Start Time";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(70, 211);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(60, 15);
            this.endTimeLabel.TabIndex = 8;
            this.endTimeLabel.Text = "End Time";
            // 
            // customerIDBox
            // 
            this.customerIDBox.Location = new System.Drawing.Point(173, 73);
            this.customerIDBox.Name = "customerIDBox";
            this.customerIDBox.Size = new System.Drawing.Size(100, 21);
            this.customerIDBox.TabIndex = 9;
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(173, 114);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(100, 21);
            this.typeBox.TabIndex = 10;
            // 
            // AddAppt
            // 
            this.ClientSize = new System.Drawing.Size(460, 389);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.customerIDBox);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.addApptLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddAppt";
            this.Load += new System.EventHandler(this.AddAppt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label addApptLabel;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.TextBox customerIDBox;
        private System.Windows.Forms.TextBox typeBox;
    }
}