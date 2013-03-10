namespace MapEditor.Forms
{
	partial class InstanceProp
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
			this.instX = new System.Windows.Forms.TextBox();
			this.instLabel = new System.Windows.Forms.Label();
			this.instRotate = new System.Windows.Forms.TextBox();
			this.instY = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.instLayer = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.instElement = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.instOK = new System.Windows.Forms.Button();
			this.instCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// instX
			// 
			this.instX.Location = new System.Drawing.Point(15, 59);
			this.instX.Name = "instX";
			this.instX.Size = new System.Drawing.Size(100, 20);
			this.instX.TabIndex = 0;
			// 
			// instLabel
			// 
			this.instLabel.AutoSize = true;
			this.instLabel.Location = new System.Drawing.Point(12, 9);
			this.instLabel.Name = "instLabel";
			this.instLabel.Size = new System.Drawing.Size(43, 13);
			this.instLabel.TabIndex = 1;
			this.instLabel.Text = "AME_X";
			// 
			// instRotate
			// 
			this.instRotate.Location = new System.Drawing.Point(15, 98);
			this.instRotate.Name = "instRotate";
			this.instRotate.Size = new System.Drawing.Size(100, 20);
			this.instRotate.TabIndex = 2;
			// 
			// instY
			// 
			this.instY.Location = new System.Drawing.Point(124, 59);
			this.instY.Name = "instY";
			this.instY.Size = new System.Drawing.Size(100, 20);
			this.instY.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "X:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(121, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Y:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Rotation:";
			// 
			// instLayer
			// 
			this.instLayer.Enabled = false;
			this.instLayer.Location = new System.Drawing.Point(15, 137);
			this.instLayer.Name = "instLayer";
			this.instLayer.Size = new System.Drawing.Size(100, 20);
			this.instLayer.TabIndex = 7;
			this.instLayer.Text = "-";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Layer:";
			// 
			// instElement
			// 
			this.instElement.Enabled = false;
			this.instElement.Location = new System.Drawing.Point(124, 137);
			this.instElement.Name = "instElement";
			this.instElement.Size = new System.Drawing.Size(100, 20);
			this.instElement.TabIndex = 9;
			this.instElement.Text = "-";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(121, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Element:";
			// 
			// instOK
			// 
			this.instOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.instOK.Image = global::MapEditor.Properties.Resources.tick;
			this.instOK.Location = new System.Drawing.Point(169, 163);
			this.instOK.Name = "instOK";
			this.instOK.Size = new System.Drawing.Size(26, 23);
			this.instOK.TabIndex = 11;
			this.instOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.instOK.UseVisualStyleBackColor = true;
			this.instOK.Click += new System.EventHandler(this.instOK_Click);
			// 
			// instCancel
			// 
			this.instCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.instCancel.Image = global::MapEditor.Properties.Resources.cross;
			this.instCancel.Location = new System.Drawing.Point(201, 163);
			this.instCancel.Name = "instCancel";
			this.instCancel.Size = new System.Drawing.Size(23, 23);
			this.instCancel.TabIndex = 12;
			this.instCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.instCancel.UseVisualStyleBackColor = true;
			// 
			// InstanceProp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(243, 199);
			this.Controls.Add(this.instCancel);
			this.Controls.Add(this.instOK);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.instElement);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.instLayer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.instY);
			this.Controls.Add(this.instRotate);
			this.Controls.Add(this.instLabel);
			this.Controls.Add(this.instX);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "InstanceProp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "InstanceProp";
			this.Shown += new System.EventHandler(this.InstanceProp_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox instX;
		private System.Windows.Forms.Label instLabel;
		private System.Windows.Forms.TextBox instRotate;
		private System.Windows.Forms.TextBox instY;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox instLayer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox instElement;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button instOK;
		private System.Windows.Forms.Button instCancel;
	}
}