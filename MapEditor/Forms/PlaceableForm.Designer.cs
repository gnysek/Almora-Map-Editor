namespace MapEditor.Forms
{
	partial class PlaceableForm
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
			this.pfSprite = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pfName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pfSolid = new System.Windows.Forms.CheckBox();
			this.pfDepth = new System.Windows.Forms.TextBox();
			this.pfMask = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pfWind = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pfMultidraw = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pfShadow = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pfShadowSize = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.pfCancel = new System.Windows.Forms.Button();
			this.pfOK = new System.Windows.Forms.Button();
			this.pfCode = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.pfVisible = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// pfSprite
			// 
			this.pfSprite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.pfSprite.FormattingEnabled = true;
			this.pfSprite.Location = new System.Drawing.Point(140, 38);
			this.pfSprite.Name = "pfSprite";
			this.pfSprite.Size = new System.Drawing.Size(158, 21);
			this.pfSprite.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Sprite for that Placeable:\r\n";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Depth:";
			// 
			// pfName
			// 
			this.pfName.Location = new System.Drawing.Point(140, 12);
			this.pfName.Name = "pfName";
			this.pfName.Size = new System.Drawing.Size(158, 20);
			this.pfName.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Name:";
			// 
			// pfSolid
			// 
			this.pfSolid.AutoSize = true;
			this.pfSolid.Location = new System.Drawing.Point(185, 120);
			this.pfSolid.Name = "pfSolid";
			this.pfSolid.Size = new System.Drawing.Size(15, 14);
			this.pfSolid.TabIndex = 6;
			this.pfSolid.UseVisualStyleBackColor = true;
			// 
			// pfDepth
			// 
			this.pfDepth.Location = new System.Drawing.Point(140, 65);
			this.pfDepth.Name = "pfDepth";
			this.pfDepth.Size = new System.Drawing.Size(158, 20);
			this.pfDepth.TabIndex = 7;
			// 
			// pfMask
			// 
			this.pfMask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.pfMask.FormattingEnabled = true;
			this.pfMask.Location = new System.Drawing.Point(142, 91);
			this.pfMask.Name = "pfMask";
			this.pfMask.Size = new System.Drawing.Size(158, 21);
			this.pfMask.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Mask:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(139, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Solid:";
			// 
			// pfWind
			// 
			this.pfWind.AutoSize = true;
			this.pfWind.Location = new System.Drawing.Point(75, 119);
			this.pfWind.Name = "pfWind";
			this.pfWind.Size = new System.Drawing.Size(15, 14);
			this.pfWind.TabIndex = 11;
			this.pfWind.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(14, 119);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Wind:";
			// 
			// pfMultidraw
			// 
			this.pfMultidraw.AutoSize = true;
			this.pfMultidraw.Location = new System.Drawing.Point(75, 138);
			this.pfMultidraw.Name = "pfMultidraw";
			this.pfMultidraw.Size = new System.Drawing.Size(15, 14);
			this.pfMultidraw.TabIndex = 13;
			this.pfMultidraw.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(14, 138);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Multidraw:";
			// 
			// pfShadow
			// 
			this.pfShadow.AutoSize = true;
			this.pfShadow.Location = new System.Drawing.Point(75, 158);
			this.pfShadow.Name = "pfShadow";
			this.pfShadow.Size = new System.Drawing.Size(15, 14);
			this.pfShadow.TabIndex = 15;
			this.pfShadow.UseVisualStyleBackColor = true;
			this.pfShadow.CheckedChanged += new System.EventHandler(this.pfShadow_CheckedChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(14, 158);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Shadow:";
			// 
			// pfShadowSize
			// 
			this.pfShadowSize.Location = new System.Drawing.Point(215, 155);
			this.pfShadowSize.Name = "pfShadowSize";
			this.pfShadowSize.Size = new System.Drawing.Size(85, 20);
			this.pfShadowSize.TabIndex = 17;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(139, 158);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(70, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "Shadow size:";
			// 
			// pfCancel
			// 
			this.pfCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.pfCancel.Image = global::MapEditor.Properties.Resources.cross;
			this.pfCancel.Location = new System.Drawing.Point(277, 357);
			this.pfCancel.Name = "pfCancel";
			this.pfCancel.Size = new System.Drawing.Size(23, 23);
			this.pfCancel.TabIndex = 19;
			this.pfCancel.UseVisualStyleBackColor = true;
			// 
			// pfOK
			// 
			this.pfOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.pfOK.Image = global::MapEditor.Properties.Resources.tick;
			this.pfOK.Location = new System.Drawing.Point(248, 357);
			this.pfOK.Name = "pfOK";
			this.pfOK.Size = new System.Drawing.Size(23, 23);
			this.pfOK.TabIndex = 20;
			this.pfOK.UseVisualStyleBackColor = true;
			this.pfOK.Click += new System.EventHandler(this.button2_Click);
			// 
			// pfCode
			// 
			this.pfCode.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.pfCode.Location = new System.Drawing.Point(15, 194);
			this.pfCode.Multiline = true;
			this.pfCode.Name = "pfCode";
			this.pfCode.Size = new System.Drawing.Size(285, 157);
			this.pfCode.TabIndex = 21;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(14, 178);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(106, 13);
			this.label10.TabIndex = 22;
			this.label10.Text = "Custom code (if any):";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(139, 138);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 13);
			this.label11.TabIndex = 23;
			this.label11.Text = "Visible:";
			// 
			// pfVisible
			// 
			this.pfVisible.AutoSize = true;
			this.pfVisible.Location = new System.Drawing.Point(185, 138);
			this.pfVisible.Name = "pfVisible";
			this.pfVisible.Size = new System.Drawing.Size(15, 14);
			this.pfVisible.TabIndex = 24;
			this.pfVisible.UseVisualStyleBackColor = true;
			// 
			// PlaceableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 386);
			this.Controls.Add(this.pfVisible);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.pfCode);
			this.Controls.Add(this.pfOK);
			this.Controls.Add(this.pfCancel);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.pfShadowSize);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.pfShadow);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.pfMultidraw);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pfWind);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pfMask);
			this.Controls.Add(this.pfDepth);
			this.Controls.Add(this.pfSolid);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pfName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pfSprite);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "PlaceableForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PlaceableForm";
			this.Load += new System.EventHandler(this.PlaceableForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox pfSprite;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox pfName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox pfSolid;
		private System.Windows.Forms.TextBox pfDepth;
		private System.Windows.Forms.ComboBox pfMask;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox pfWind;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox pfMultidraw;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox pfShadow;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox pfShadowSize;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button pfOK;
		private System.Windows.Forms.Button pfCancel;
		private System.Windows.Forms.TextBox pfCode;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckBox pfVisible;
	}
}