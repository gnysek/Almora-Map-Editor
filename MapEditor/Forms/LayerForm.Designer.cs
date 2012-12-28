namespace MapEditor.Forms
{
	partial class LayerForm
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
			this.lfName = new System.Windows.Forms.TextBox();
			this.lfDepth = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lfName
			// 
			this.lfName.Location = new System.Drawing.Point(98, 12);
			this.lfName.Name = "lfName";
			this.lfName.Size = new System.Drawing.Size(100, 20);
			this.lfName.TabIndex = 0;
			this.lfName.Text = "New Layer";
			// 
			// lfDepth
			// 
			this.lfDepth.Location = new System.Drawing.Point(98, 38);
			this.lfDepth.Name = "lfDepth";
			this.lfDepth.Size = new System.Drawing.Size(100, 20);
			this.lfDepth.TabIndex = 1;
			this.lfDepth.Text = "0";
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Image = global::MapEditor.Properties.Resources.tick;
			this.button1.Location = new System.Drawing.Point(98, 64);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(41, 31);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(157, 64);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(41, 31);
			this.button2.TabIndex = 3;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// LayerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lfDepth);
			this.Controls.Add(this.lfName);
			this.Name = "LayerForm";
			this.Text = "te";
			this.Shown += new System.EventHandler(this.LayerForm_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox lfName;
		private System.Windows.Forms.TextBox lfDepth;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}