namespace MapEditor.Forms
{
	partial class RoomForm
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
			this.rfName = new System.Windows.Forms.TextBox();
			this.rfWidth = new System.Windows.Forms.TextBox();
			this.rfHeight = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// rfName
			// 
			this.rfName.Location = new System.Drawing.Point(85, 12);
			this.rfName.Name = "rfName";
			this.rfName.Size = new System.Drawing.Size(100, 20);
			this.rfName.TabIndex = 0;
			this.rfName.Text = "Name";
			// 
			// rfWidth
			// 
			this.rfWidth.Location = new System.Drawing.Point(85, 38);
			this.rfWidth.Name = "rfWidth";
			this.rfWidth.Size = new System.Drawing.Size(100, 20);
			this.rfWidth.TabIndex = 1;
			this.rfWidth.Text = "0";
			// 
			// rfHeight
			// 
			this.rfHeight.Location = new System.Drawing.Point(85, 64);
			this.rfHeight.Name = "rfHeight";
			this.rfHeight.Size = new System.Drawing.Size(100, 20);
			this.rfHeight.TabIndex = 2;
			this.rfHeight.Text = "0";
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Image = global::MapEditor.Properties.Resources.tick;
			this.button1.Location = new System.Drawing.Point(133, 90);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(23, 23);
			this.button1.TabIndex = 3;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Image = global::MapEditor.Properties.Resources.cross;
			this.button2.Location = new System.Drawing.Point(162, 90);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(23, 23);
			this.button2.TabIndex = 4;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Room Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Width:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Height:";
			// 
			// RoomForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(199, 125);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.rfHeight);
			this.Controls.Add(this.rfWidth);
			this.Controls.Add(this.rfName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "RoomForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "RoomForm";
			this.Load += new System.EventHandler(this.RoomForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox rfName;
		private System.Windows.Forms.TextBox rfWidth;
		private System.Windows.Forms.TextBox rfHeight;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}