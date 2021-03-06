﻿namespace MapEditor.Components
{
	partial class RoomEditor
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._rPanel = new MapEditor.Components.RoomCanvas();
			this.horizontalScb = new MapEditor.Components.customHScrollBar();
			this.verticalScb = new MapEditor.Components.customVScrollBar();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(150, 150);
			this.panel1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
			this.tableLayoutPanel1.Controls.Add(this._rPanel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.horizontalScb, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.verticalScb, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 150);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// _rPanel
			// 
			this._rPanel.BackColor = System.Drawing.SystemColors.Control;
			this._rPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
			this._rPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._rPanel.Location = new System.Drawing.Point(0, 0);
			this._rPanel.Margin = new System.Windows.Forms.Padding(0);
			this._rPanel.Name = "_rPanel";
			this._rPanel.Offset = new System.Drawing.Point(0, 0);
			this._rPanel.Size = new System.Drawing.Size(133, 133);
			this._rPanel.TabIndex = 2;
			this._rPanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this._rPanel_PreviewKeyDown);
			// 
			// horizontalScb
			// 
			this.horizontalScb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.horizontalScb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.horizontalScb.LargeChange = 0;
			this.horizontalScb.Location = new System.Drawing.Point(0, 133);
			this.horizontalScb.Maximum = 200;
			this.horizontalScb.Name = "horizontalScb";
			this.horizontalScb.Size = new System.Drawing.Size(133, 17);
			this.horizontalScb.SmallChange = 0;
			this.horizontalScb.TabIndex = 0;
			this.horizontalScb.ValueChanged += new System.EventHandler(this.horizontalScroll_ValueChanged);
			this.horizontalScb.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.horizontalScb_PreviewKeyDown);
			// 
			// verticalScb
			// 
			this.verticalScb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.verticalScb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.verticalScb.LargeChange = 0;
			this.verticalScb.Location = new System.Drawing.Point(133, 0);
			this.verticalScb.Maximum = 200;
			this.verticalScb.Name = "verticalScb";
			this.verticalScb.Size = new System.Drawing.Size(17, 133);
			this.verticalScb.SmallChange = 0;
			this.verticalScb.TabIndex = 1;
			this.verticalScb.ValueChanged += new System.EventHandler(this.verticalScroll_ValueChanged);
			this.verticalScb.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.verticalScb_PreviewKeyDown);
			// 
			// RoomEditor
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.panel1);
			this.Name = "RoomEditor";
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private customHScrollBar horizontalScb;
		private customVScrollBar verticalScb;
		public RoomCanvas _rPanel;
	}
}
