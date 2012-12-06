namespace MapEditor.Components
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
			this.horizontalScroll = new System.Windows.Forms.HScrollBar();
			this.verticalScroll = new System.Windows.Forms.VScrollBar();
			this._rPanel = new MapEditor.Components.RoomPanel();
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
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
			this.tableLayoutPanel1.Controls.Add(this.horizontalScroll, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.verticalScroll, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this._rPanel, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 150);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// horizontalScroll
			// 
			this.horizontalScroll.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.horizontalScroll.Location = new System.Drawing.Point(1, 132);
			this.horizontalScroll.Maximum = 10;
			this.horizontalScroll.Name = "horizontalScroll";
			this.horizontalScroll.Size = new System.Drawing.Size(130, 17);
			this.horizontalScroll.SmallChange = 5;
			this.horizontalScroll.TabIndex = 0;
			this.horizontalScroll.ValueChanged += new System.EventHandler(this.horizontalScroll_ValueChanged);
			// 
			// verticalScroll
			// 
			this.verticalScroll.Dock = System.Windows.Forms.DockStyle.Right;
			this.verticalScroll.Location = new System.Drawing.Point(132, 1);
			this.verticalScroll.Maximum = 10;
			this.verticalScroll.Name = "verticalScroll";
			this.verticalScroll.Size = new System.Drawing.Size(17, 130);
			this.verticalScroll.TabIndex = 1;
			this.verticalScroll.ValueChanged += new System.EventHandler(this.verticalScroll_ValueChanged);
			// 
			// _rPanel
			// 
			this._rPanel.BackColor = System.Drawing.Color.White;
			this._rPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
			this._rPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._rPanel.Location = new System.Drawing.Point(4, 4);
			this._rPanel.Name = "_rPanel";
			this._rPanel.Offset = new System.Drawing.Point(0, 0);
			this._rPanel.Size = new System.Drawing.Size(124, 124);
			this._rPanel.TabIndex = 2;
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
		private RoomPanel _rPanel;
		private System.Windows.Forms.HScrollBar horizontalScroll;
		private System.Windows.Forms.VScrollBar verticalScroll;
	}
}
