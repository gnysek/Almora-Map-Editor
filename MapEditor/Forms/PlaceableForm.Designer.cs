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
			this.pfWind = new System.Windows.Forms.CheckBox();
			this.pfMultidraw = new System.Windows.Forms.CheckBox();
			this.pfShadow = new System.Windows.Forms.CheckBox();
			this.pfShadowSize = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.pfCancel = new System.Windows.Forms.Button();
			this.pfOK = new System.Windows.Forms.Button();
			this.pfCode = new System.Windows.Forms.TextBox();
			this.pfVisible = new System.Windows.Forms.CheckBox();
			this.pfParent = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.pfDefaultParent = new System.Windows.Forms.CheckBox();
			this.pfSpriteDefault = new System.Windows.Forms.CheckBox();
			this.pfDepthDefault = new System.Windows.Forms.CheckBox();
			this.pfMaskDefault = new System.Windows.Forms.CheckBox();
			this.pfSolidDefault = new System.Windows.Forms.CheckBox();
			this.pfVisibleDefault = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pfSprite
			// 
			this.pfSprite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.pfSprite.FormattingEnabled = true;
			this.pfSprite.Location = new System.Drawing.Point(12, 64);
			this.pfSprite.Name = "pfSprite";
			this.pfSprite.Size = new System.Drawing.Size(158, 21);
			this.pfSprite.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Sprite for that Placeable:\r\n";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Depth:";
			// 
			// pfName
			// 
			this.pfName.Location = new System.Drawing.Point(12, 25);
			this.pfName.Name = "pfName";
			this.pfName.Size = new System.Drawing.Size(158, 20);
			this.pfName.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Name [editor only]:";
			// 
			// pfSolid
			// 
			this.pfSolid.AutoSize = true;
			this.pfSolid.Location = new System.Drawing.Point(12, 170);
			this.pfSolid.Name = "pfSolid";
			this.pfSolid.Size = new System.Drawing.Size(49, 17);
			this.pfSolid.TabIndex = 6;
			this.pfSolid.Text = "Solid";
			this.pfSolid.UseVisualStyleBackColor = true;
			// 
			// pfDepth
			// 
			this.pfDepth.Location = new System.Drawing.Point(12, 104);
			this.pfDepth.Name = "pfDepth";
			this.pfDepth.Size = new System.Drawing.Size(70, 20);
			this.pfDepth.TabIndex = 7;
			// 
			// pfMask
			// 
			this.pfMask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.pfMask.FormattingEnabled = true;
			this.pfMask.Location = new System.Drawing.Point(12, 143);
			this.pfMask.Name = "pfMask";
			this.pfMask.Size = new System.Drawing.Size(158, 21);
			this.pfMask.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Mask:";
			// 
			// pfWind
			// 
			this.pfWind.AutoSize = true;
			this.pfWind.Location = new System.Drawing.Point(26, 65);
			this.pfWind.Name = "pfWind";
			this.pfWind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.pfWind.Size = new System.Drawing.Size(54, 17);
			this.pfWind.TabIndex = 11;
			this.pfWind.Text = ":Wind";
			this.pfWind.UseVisualStyleBackColor = true;
			// 
			// pfMultidraw
			// 
			this.pfMultidraw.AutoSize = true;
			this.pfMultidraw.Location = new System.Drawing.Point(6, 19);
			this.pfMultidraw.Name = "pfMultidraw";
			this.pfMultidraw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.pfMultidraw.Size = new System.Drawing.Size(74, 17);
			this.pfMultidraw.TabIndex = 13;
			this.pfMultidraw.Text = ":Multidraw";
			this.pfMultidraw.UseVisualStyleBackColor = true;
			// 
			// pfShadow
			// 
			this.pfShadow.AutoSize = true;
			this.pfShadow.Location = new System.Drawing.Point(12, 42);
			this.pfShadow.Name = "pfShadow";
			this.pfShadow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.pfShadow.Size = new System.Drawing.Size(68, 17);
			this.pfShadow.TabIndex = 15;
			this.pfShadow.Text = ":Shadow";
			this.pfShadow.UseVisualStyleBackColor = true;
			this.pfShadow.CheckedChanged += new System.EventHandler(this.pfShadow_CheckedChanged);
			// 
			// pfShadowSize
			// 
			this.pfShadowSize.Location = new System.Drawing.Point(95, 40);
			this.pfShadowSize.Name = "pfShadowSize";
			this.pfShadowSize.Size = new System.Drawing.Size(83, 20);
			this.pfShadowSize.TabIndex = 17;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(92, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(70, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "Shadow size:";
			// 
			// pfCancel
			// 
			this.pfCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.pfCancel.Image = global::MapEditor.Properties.Resources.cross;
			this.pfCancel.Location = new System.Drawing.Point(611, 333);
			this.pfCancel.Name = "pfCancel";
			this.pfCancel.Size = new System.Drawing.Size(23, 23);
			this.pfCancel.TabIndex = 19;
			this.pfCancel.UseVisualStyleBackColor = true;
			// 
			// pfOK
			// 
			this.pfOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.pfOK.Image = global::MapEditor.Properties.Resources.tick;
			this.pfOK.Location = new System.Drawing.Point(582, 333);
			this.pfOK.Name = "pfOK";
			this.pfOK.Size = new System.Drawing.Size(23, 23);
			this.pfOK.TabIndex = 20;
			this.pfOK.UseVisualStyleBackColor = true;
			this.pfOK.Click += new System.EventHandler(this.pfOK_Click);
			// 
			// pfCode
			// 
			this.pfCode.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.pfCode.Location = new System.Drawing.Point(6, 19);
			this.pfCode.Multiline = true;
			this.pfCode.Name = "pfCode";
			this.pfCode.Size = new System.Drawing.Size(328, 290);
			this.pfCode.TabIndex = 21;
			// 
			// pfVisible
			// 
			this.pfVisible.AutoSize = true;
			this.pfVisible.Location = new System.Drawing.Point(12, 193);
			this.pfVisible.Name = "pfVisible";
			this.pfVisible.Size = new System.Drawing.Size(56, 17);
			this.pfVisible.TabIndex = 24;
			this.pfVisible.Text = "Visible";
			this.pfVisible.UseVisualStyleBackColor = true;
			// 
			// pfParent
			// 
			this.pfParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.pfParent.FormattingEnabled = true;
			this.pfParent.Location = new System.Drawing.Point(12, 335);
			this.pfParent.Name = "pfParent";
			this.pfParent.Size = new System.Drawing.Size(158, 21);
			this.pfParent.TabIndex = 25;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(12, 319);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(41, 13);
			this.label12.TabIndex = 26;
			this.label12.Text = "Object:";
			// 
			// pfDefaultParent
			// 
			this.pfDefaultParent.AutoSize = true;
			this.pfDefaultParent.Location = new System.Drawing.Point(176, 337);
			this.pfDefaultParent.Name = "pfDefaultParent";
			this.pfDefaultParent.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.pfDefaultParent.Size = new System.Drawing.Size(109, 17);
			this.pfDefaultParent.TabIndex = 27;
			this.pfDefaultParent.Text = "Use editor default";
			this.pfDefaultParent.UseVisualStyleBackColor = true;
			this.pfDefaultParent.CheckedChanged += new System.EventHandler(this.pfDefaultParent_CheckedChanged);
			// 
			// pfSpriteDefault
			// 
			this.pfSpriteDefault.AutoSize = true;
			this.pfSpriteDefault.Location = new System.Drawing.Point(176, 66);
			this.pfSpriteDefault.Name = "pfSpriteDefault";
			this.pfSpriteDefault.Size = new System.Drawing.Size(112, 17);
			this.pfSpriteDefault.TabIndex = 28;
			this.pfSpriteDefault.Text = "Use object default";
			this.pfSpriteDefault.UseVisualStyleBackColor = true;
			this.pfSpriteDefault.CheckedChanged += new System.EventHandler(this.pfDefault_CheckedChanged);
			// 
			// pfDepthDefault
			// 
			this.pfDepthDefault.AutoSize = true;
			this.pfDepthDefault.Location = new System.Drawing.Point(88, 106);
			this.pfDepthDefault.Name = "pfDepthDefault";
			this.pfDepthDefault.Size = new System.Drawing.Size(112, 17);
			this.pfDepthDefault.TabIndex = 29;
			this.pfDepthDefault.Text = "Use object default";
			this.pfDepthDefault.UseVisualStyleBackColor = true;
			this.pfDepthDefault.CheckedChanged += new System.EventHandler(this.pfDepthDefault_CheckedChanged);
			// 
			// pfMaskDefault
			// 
			this.pfMaskDefault.AutoSize = true;
			this.pfMaskDefault.Location = new System.Drawing.Point(176, 145);
			this.pfMaskDefault.Name = "pfMaskDefault";
			this.pfMaskDefault.Size = new System.Drawing.Size(112, 17);
			this.pfMaskDefault.TabIndex = 30;
			this.pfMaskDefault.Text = "Use object default";
			this.pfMaskDefault.UseVisualStyleBackColor = true;
			this.pfMaskDefault.CheckedChanged += new System.EventHandler(this.pfMaskDefault_CheckedChanged);
			// 
			// pfSolidDefault
			// 
			this.pfSolidDefault.AutoSize = true;
			this.pfSolidDefault.Location = new System.Drawing.Point(74, 170);
			this.pfSolidDefault.Name = "pfSolidDefault";
			this.pfSolidDefault.Size = new System.Drawing.Size(112, 17);
			this.pfSolidDefault.TabIndex = 31;
			this.pfSolidDefault.Text = "Use object default";
			this.pfSolidDefault.UseVisualStyleBackColor = true;
			this.pfSolidDefault.CheckedChanged += new System.EventHandler(this.pfSolidDefault_CheckedChanged);
			// 
			// pfVisibleDefault
			// 
			this.pfVisibleDefault.AutoSize = true;
			this.pfVisibleDefault.Location = new System.Drawing.Point(74, 193);
			this.pfVisibleDefault.Name = "pfVisibleDefault";
			this.pfVisibleDefault.Size = new System.Drawing.Size(112, 17);
			this.pfVisibleDefault.TabIndex = 32;
			this.pfVisibleDefault.Text = "Use object default";
			this.pfVisibleDefault.UseVisualStyleBackColor = true;
			this.pfVisibleDefault.CheckedChanged += new System.EventHandler(this.pfVisibleDefault_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pfMultidraw);
			this.groupBox1.Controls.Add(this.pfShadow);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.pfShadowSize);
			this.groupBox1.Controls.Add(this.pfWind);
			this.groupBox1.Location = new System.Drawing.Point(12, 216);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(188, 100);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Special";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pfCode);
			this.groupBox2.Location = new System.Drawing.Point(294, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(340, 315);
			this.groupBox2.TabIndex = 34;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Custom code (if any)";
			// 
			// PlaceableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 370);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.pfVisibleDefault);
			this.Controls.Add(this.pfSolidDefault);
			this.Controls.Add(this.pfMaskDefault);
			this.Controls.Add(this.pfDepthDefault);
			this.Controls.Add(this.pfSpriteDefault);
			this.Controls.Add(this.pfDefaultParent);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.pfParent);
			this.Controls.Add(this.pfVisible);
			this.Controls.Add(this.pfOK);
			this.Controls.Add(this.pfCancel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pfMask);
			this.Controls.Add(this.pfDepth);
			this.Controls.Add(this.pfSolid);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pfName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pfSprite);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "PlaceableForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Placeable Element";
			this.Load += new System.EventHandler(this.PlaceableForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
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
		private System.Windows.Forms.CheckBox pfWind;
		private System.Windows.Forms.CheckBox pfMultidraw;
		private System.Windows.Forms.CheckBox pfShadow;
		private System.Windows.Forms.TextBox pfShadowSize;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button pfOK;
		private System.Windows.Forms.Button pfCancel;
		private System.Windows.Forms.TextBox pfCode;
		private System.Windows.Forms.CheckBox pfVisible;
		private System.Windows.Forms.ComboBox pfParent;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.CheckBox pfDefaultParent;
		private System.Windows.Forms.CheckBox pfSpriteDefault;
		private System.Windows.Forms.CheckBox pfDepthDefault;
		private System.Windows.Forms.CheckBox pfMaskDefault;
		private System.Windows.Forms.CheckBox pfSolidDefault;
		private System.Windows.Forms.CheckBox pfVisibleDefault;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}