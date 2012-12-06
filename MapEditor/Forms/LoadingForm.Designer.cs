namespace MapEditor.Forms
{
	partial class LoadingForm
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
			this.loadingBar = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// loadingBar
			// 
			this.loadingBar.Location = new System.Drawing.Point(12, 12);
			this.loadingBar.Name = "loadingBar";
			this.loadingBar.Size = new System.Drawing.Size(270, 16);
			this.loadingBar.TabIndex = 0;
			// 
			// LoadingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 42);
			this.Controls.Add(this.loadingBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "LoadingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Please wait...";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ProgressBar loadingBar;
	}
}