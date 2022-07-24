
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
			this.MainLoginB = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// MainLoginB
			// 
			this.MainLoginB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainLoginB.Location = new System.Drawing.Point(1002, 12);
			this.MainLoginB.Name = "MainLoginB";
			this.MainLoginB.Size = new System.Drawing.Size(75, 23);
			this.MainLoginB.TabIndex = 0;
			this.MainLoginB.Text = "Login";
			this.MainLoginB.UseVisualStyleBackColor = true;
			this.MainLoginB.Click += new System.EventHandler(this.MainLoginB_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1089, 512);
			this.Controls.Add(this.MainLoginB);
			this.Name = "MainForm";
			this.Text = "Main Form";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button MainLoginB;
	}
}

