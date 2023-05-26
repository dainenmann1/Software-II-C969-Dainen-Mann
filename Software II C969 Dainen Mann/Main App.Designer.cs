
namespace Software_II_C969_Dainen_Mann
{
	partial class MainForm
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
            this.addApptButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.weekRadio = new System.Windows.Forms.RadioButton();
            this.monthRadio = new System.Windows.Forms.RadioButton();
            this.allRadio = new System.Windows.Forms.RadioButton();
            this.apptFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sortbyLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addApptButton
            // 
            this.addApptButton.Location = new System.Drawing.Point(22, 722);
            this.addApptButton.Name = "addApptButton";
            this.addApptButton.Size = new System.Drawing.Size(150, 27);
            this.addApptButton.TabIndex = 0;
            this.addApptButton.Text = "Appointments";
            this.addApptButton.UseVisualStyleBackColor = true;
            this.addApptButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerButton
            // 
            this.customerButton.Location = new System.Drawing.Point(22, 689);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(150, 27);
            this.customerButton.TabIndex = 1;
            this.customerButton.Text = "Customers";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(191, 722);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(127, 27);
            this.reportButton.TabIndex = 2;
            this.reportButton.Text = "Reports";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(957, 703);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(106, 30);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1090, 703);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(100, 30);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // weekRadio
            // 
            this.weekRadio.AutoSize = true;
            this.weekRadio.Checked = true;
            this.weekRadio.Location = new System.Drawing.Point(94, 39);
            this.weekRadio.Name = "weekRadio";
            this.weekRadio.Size = new System.Drawing.Size(56, 19);
            this.weekRadio.TabIndex = 7;
            this.weekRadio.TabStop = true;
            this.weekRadio.Text = "Week";
            this.weekRadio.UseVisualStyleBackColor = true;
            this.weekRadio.CheckedChanged += new System.EventHandler(this.weekRadio_CheckedChanged);
            // 
            // monthRadio
            // 
            this.monthRadio.AutoSize = true;
            this.monthRadio.Location = new System.Drawing.Point(175, 39);
            this.monthRadio.Name = "monthRadio";
            this.monthRadio.Size = new System.Drawing.Size(60, 19);
            this.monthRadio.TabIndex = 8;
            this.monthRadio.Text = "Month";
            this.monthRadio.UseVisualStyleBackColor = true;
            this.monthRadio.CheckedChanged += new System.EventHandler(this.monthRadio_CheckedChanged);
            // 
            // allRadio
            // 
            this.allRadio.AutoSize = true;
            this.allRadio.Location = new System.Drawing.Point(22, 39);
            this.allRadio.Name = "allRadio";
            this.allRadio.Size = new System.Drawing.Size(38, 19);
            this.allRadio.TabIndex = 9;
            this.allRadio.TabStop = true;
            this.allRadio.Text = "All";
            this.allRadio.UseVisualStyleBackColor = true;
            this.allRadio.CheckedChanged += new System.EventHandler(this.allRadio_CheckedChanged);
            // 
            // apptFlowPanel
            // 
            this.apptFlowPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.apptFlowPanel.Location = new System.Drawing.Point(22, 64);
            this.apptFlowPanel.Name = "apptFlowPanel";
            this.apptFlowPanel.Size = new System.Drawing.Size(1168, 586);
            this.apptFlowPanel.TabIndex = 10;
            // 
            // sortbyLabel
            // 
            this.sortbyLabel.AutoSize = true;
            this.sortbyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sortbyLabel.Location = new System.Drawing.Point(18, 16);
            this.sortbyLabel.Name = "sortbyLabel";
            this.sortbyLabel.Size = new System.Drawing.Size(61, 20);
            this.sortbyLabel.TabIndex = 11;
            this.sortbyLabel.Text = "Sort By";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(191, 689);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(127, 27);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1230, 761);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.sortbyLabel);
            this.Controls.Add(this.apptFlowPanel);
            this.Controls.Add(this.allRadio);
            this.Controls.Add(this.monthRadio);
            this.Controls.Add(this.weekRadio);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.addApptButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button addApptButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.RadioButton weekRadio;
        private System.Windows.Forms.RadioButton monthRadio;
        private System.Windows.Forms.RadioButton allRadio;
        private System.Windows.Forms.FlowLayoutPanel apptFlowPanel;
        private System.Windows.Forms.Label sortbyLabel;
        private System.Windows.Forms.Button searchButton;
    }
}

