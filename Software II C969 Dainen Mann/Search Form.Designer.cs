
namespace Software_II_C969_Dainen_Mann
{
    partial class Search_Form
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.closeButton = new System.Windows.Forms.Button();
			this.searchButton = new System.Windows.Forms.Button();
			this.custLabel = new System.Windows.Forms.Label();
			this.titleLabel = new System.Windows.Forms.Label();
			this.descLabel = new System.Windows.Forms.Label();
			this.custCombo = new System.Windows.Forms.ComboBox();
			this.locationCombo = new System.Windows.Forms.ComboBox();
			this.typeCombo = new System.Windows.Forms.ComboBox();
			this.createdCombo = new System.Windows.Forms.ComboBox();
			this.clearButton = new System.Windows.Forms.Button();
			this.titleBox = new System.Windows.Forms.TextBox();
			this.descBox = new System.Windows.Forms.TextBox();
			this.locationLabel = new System.Windows.Forms.Label();
			this.typeLabel = new System.Windows.Forms.Label();
			this.createdLabel = new System.Windows.Forms.Label();
			this.gridSearchResults = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).BeginInit();
			this.SuspendLayout();
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.closeButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.closeButton.Location = new System.Drawing.Point(756, 479);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(87, 27);
			this.closeButton.TabIndex = 9;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = false;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// searchButton
			// 
			this.searchButton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.searchButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.searchButton.Location = new System.Drawing.Point(14, 479);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(87, 27);
			this.searchButton.TabIndex = 7;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = false;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// custLabel
			// 
			this.custLabel.AutoSize = true;
			this.custLabel.Location = new System.Drawing.Point(25, 58);
			this.custLabel.Name = "custLabel";
			this.custLabel.Size = new System.Drawing.Size(60, 15);
			this.custLabel.TabIndex = 2;
			this.custLabel.Text = "Customer";
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(25, 102);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(30, 15);
			this.titleLabel.TabIndex = 3;
			this.titleLabel.Text = "Title";
			// 
			// descLabel
			// 
			this.descLabel.AutoSize = true;
			this.descLabel.Location = new System.Drawing.Point(25, 143);
			this.descLabel.Name = "descLabel";
			this.descLabel.Size = new System.Drawing.Size(69, 15);
			this.descLabel.TabIndex = 4;
			this.descLabel.Text = "Description";
			// 
			// custCombo
			// 
			this.custCombo.FormattingEnabled = true;
			this.custCombo.Location = new System.Drawing.Point(124, 58);
			this.custCombo.Name = "custCombo";
			this.custCombo.Size = new System.Drawing.Size(197, 23);
			this.custCombo.TabIndex = 1;
			// 
			// locationCombo
			// 
			this.locationCombo.FormattingEnabled = true;
			this.locationCombo.ItemHeight = 15;
			this.locationCombo.Location = new System.Drawing.Point(124, 224);
			this.locationCombo.Name = "locationCombo";
			this.locationCombo.Size = new System.Drawing.Size(197, 23);
			this.locationCombo.TabIndex = 4;
			// 
			// typeCombo
			// 
			this.typeCombo.FormattingEnabled = true;
			this.typeCombo.Location = new System.Drawing.Point(124, 272);
			this.typeCombo.Name = "typeCombo";
			this.typeCombo.Size = new System.Drawing.Size(197, 23);
			this.typeCombo.TabIndex = 5;
			// 
			// createdCombo
			// 
			this.createdCombo.FormattingEnabled = true;
			this.createdCombo.Location = new System.Drawing.Point(124, 324);
			this.createdCombo.Name = "createdCombo";
			this.createdCombo.Size = new System.Drawing.Size(197, 23);
			this.createdCombo.TabIndex = 6;
			// 
			// clearButton
			// 
			this.clearButton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.clearButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.clearButton.Location = new System.Drawing.Point(124, 479);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(84, 27);
			this.clearButton.TabIndex = 8;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = false;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// titleBox
			// 
			this.titleBox.Location = new System.Drawing.Point(124, 102);
			this.titleBox.Name = "titleBox";
			this.titleBox.Size = new System.Drawing.Size(197, 21);
			this.titleBox.TabIndex = 2;
			// 
			// descBox
			// 
			this.descBox.Location = new System.Drawing.Point(124, 143);
			this.descBox.Name = "descBox";
			this.descBox.Size = new System.Drawing.Size(197, 21);
			this.descBox.TabIndex = 3;
			// 
			// locationLabel
			// 
			this.locationLabel.AutoSize = true;
			this.locationLabel.Location = new System.Drawing.Point(25, 224);
			this.locationLabel.Name = "locationLabel";
			this.locationLabel.Size = new System.Drawing.Size(54, 15);
			this.locationLabel.TabIndex = 12;
			this.locationLabel.Text = "Location";
			// 
			// typeLabel
			// 
			this.typeLabel.AutoSize = true;
			this.typeLabel.Location = new System.Drawing.Point(25, 272);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(33, 15);
			this.typeLabel.TabIndex = 13;
			this.typeLabel.Text = "Type";
			// 
			// createdLabel
			// 
			this.createdLabel.AutoSize = true;
			this.createdLabel.Location = new System.Drawing.Point(25, 324);
			this.createdLabel.Name = "createdLabel";
			this.createdLabel.Size = new System.Drawing.Size(66, 15);
			this.createdLabel.TabIndex = 14;
			this.createdLabel.Text = "Created By";
			// 
			// gridSearchResults
			// 
			this.gridSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridSearchResults.DefaultCellStyle = dataGridViewCellStyle1;
			this.gridSearchResults.Location = new System.Drawing.Point(373, 58);
			this.gridSearchResults.Name = "gridSearchResults";
			this.gridSearchResults.Size = new System.Drawing.Size(470, 390);
			this.gridSearchResults.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 20);
			this.label1.TabIndex = 15;
			this.label1.Text = "Search";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// Search_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(855, 519);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gridSearchResults);
			this.Controls.Add(this.createdLabel);
			this.Controls.Add(this.typeLabel);
			this.Controls.Add(this.locationLabel);
			this.Controls.Add(this.descBox);
			this.Controls.Add(this.titleBox);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.createdCombo);
			this.Controls.Add(this.typeCombo);
			this.Controls.Add(this.locationCombo);
			this.Controls.Add(this.custCombo);
			this.Controls.Add(this.descLabel);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.custLabel);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.closeButton);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Name = "Search_Form";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search";
			this.Load += new System.EventHandler(this.Search_Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label custLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.ComboBox custCombo;
        private System.Windows.Forms.ComboBox locationCombo;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.ComboBox createdCombo;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.DataGridView gridSearchResults;
        private System.Windows.Forms.Label label1;
    }
}