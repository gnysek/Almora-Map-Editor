namespace MapEditor.Forms
{
	partial class Prompt
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
			this.description = new System.Windows.Forms.Label();
			this.value = new System.Windows.Forms.TextBox();
			this.OkButton = new System.Windows.Forms.Button();
			this.CancelActionButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// description
			// 
			this.description.AutoSize = true;
			this.description.Location = new System.Drawing.Point(12, 9);
			this.description.Name = "description";
			this.description.Size = new System.Drawing.Size(35, 13);
			this.description.TabIndex = 0;
			this.description.Text = "label1";
			// 
			// value
			// 
			this.value.Location = new System.Drawing.Point(12, 25);
			this.value.Name = "value";
			this.value.Size = new System.Drawing.Size(260, 20);
			this.value.TabIndex = 1;
			// 
			// OkButton
			// 
			this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OkButton.Location = new System.Drawing.Point(197, 51);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 2;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// CancelActionButton
			// 
			this.CancelActionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelActionButton.Location = new System.Drawing.Point(116, 51);
			this.CancelActionButton.Name = "CancelActionButton";
			this.CancelActionButton.Size = new System.Drawing.Size(75, 23);
			this.CancelActionButton.TabIndex = 3;
			this.CancelActionButton.Text = "Cancel";
			this.CancelActionButton.UseVisualStyleBackColor = true;
			this.CancelActionButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// Prompt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 88);
			this.Controls.Add(this.CancelActionButton);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.value);
			this.Controls.Add(this.description);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Prompt";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Prompt";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label description;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button CancelActionButton;
		public System.Windows.Forms.TextBox value;
	}
}