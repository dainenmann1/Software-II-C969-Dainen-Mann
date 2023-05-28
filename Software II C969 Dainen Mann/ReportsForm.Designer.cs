
namespace Software_II_C969_Dainen_Mann
{
    partial class ReportsForm
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
			this.reportDataGrid = new System.Windows.Forms.DataGridView();
			this.reportListCombo = new System.Windows.Forms.ComboBox();
			this.reportLabel = new System.Windows.Forms.Label();
			this.closeButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.reportDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// reportDataGrid
			// 
			this.reportDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.reportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.reportDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
			this.reportDataGrid.Location = new System.Drawing.Point(34, 74);
			this.reportDataGrid.Name = "reportDataGrid";
			this.reportDataGrid.Size = new System.Drawing.Size(760, 352);
			this.reportDataGrid.TabIndex = 3;
			// 
			// reportListCombo
			// 
			this.reportListCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.reportListCombo.FormattingEnabled = true;
			this.reportListCombo.Items.AddRange(new object[] {
            "Appointment Type by Month",
            "Schedule for each consultant",
            "Inactive Users"});
			this.reportListCombo.Location = new System.Drawing.Point(126, 32);
			this.reportListCombo.Name = "reportListCombo";
			this.reportListCombo.Size = new System.Drawing.Size(188, 23);
			this.reportListCombo.TabIndex = 1;
			this.reportListCombo.SelectedIndexChanged += new System.EventHandler(this.reportListCombo_SelectedIndexChanged);
			// 
			// reportLabel
			// 
			this.reportLabel.AutoSize = true;
			this.reportLabel.Location = new System.Drawing.Point(31, 35);
			this.reportLabel.Name = "reportLabel";
			this.reportLabel.Size = new System.Drawing.Size(66, 15);
			this.reportLabel.TabIndex = 2;
			this.reportLabel.Text = "Report List";
			// 
			// closeButton
			// 
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.closeButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.closeButton.Location = new System.Drawing.Point(835, 466);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 5;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.clearButton.Location = new System.Drawing.Point(736, 466);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(75, 23);
			this.clearButton.TabIndex = 6;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// ReportsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(933, 519);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.reportLabel);
			this.Controls.Add(this.reportListCombo);
			this.Controls.Add(this.reportDataGrid);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Name = "ReportsForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ReportsForm";
			this.Load += new System.EventHandler(this.ReportsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.reportDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reportDataGrid;
        private System.Windows.Forms.ComboBox reportListCombo;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button clearButton;
    }
}