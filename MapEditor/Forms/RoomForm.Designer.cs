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
			this.rfWidth = new System.Windows.Forms.TextBox();
			this.rfHeight = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rfMapped = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// rfWidth
			// 
			this.rfWidth.Location = new System.Drawing.Point(114, 32);
			this.rfWidth.Name = "rfWidth";
			this.rfWidth.Size = new System.Drawing.Size(71, 20);
			this.rfWidth.TabIndex = 1;
			this.rfWidth.Text = "0";
			// 
			// rfHeight
			// 
			this.rfHeight.Location = new System.Drawing.Point(114, 58);
			this.rfHeight.Name = "rfHeight";
			this.rfHeight.Size = new System.Drawing.Size(71, 20);
			this.rfHeight.TabIndex = 2;
			this.rfHeight.Text = "0";
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Image = global::MapEditor.Properties.Resources.tick;
			this.button1.Location = new System.Drawing.Point(222, 84);
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
			this.button2.Location = new System.Drawing.Point(251, 84);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(23, 23);
			this.button2.TabIndex = 4;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Width:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Height:";
			// 
			// rfMapped
			// 
			this.rfMapped.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.rfMapped.FormattingEnabled = true;
			this.rfMapped.Location = new System.Drawing.Point(114, 6);
			this.rfMapped.Name = "rfMapped";
			this.rfMapped.Size = new System.Drawing.Size(160, 21);
			this.rfMapped.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Room mapping:";
			// 
			// RoomForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(291, 122);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.rfMapped);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.rfHeight);
			this.Controls.Add(this.rfWidth);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "RoomForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "RoomForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RoomForm_FormClosing);
			this.Load += new System.EventHandler(this.RoomForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox rfWidth;
		private System.Windows.Forms.TextBox rfHeight;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox rfMapped;
		private System.Windows.Forms.Label label4;
	}
}