using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MapEditor.Components;
using MapEditor.Common;

namespace MapEditor.Components
{
	public partial class RoomEditor : UserControl
	{
		private bool _dragging = false;

		public RoomEditor()
		{
			InitializeComponent();

			SetupScrollbars();

			// Set the backcolor for mock visual styled border.
			// BackColor = System.Windows.Forms.VisualStyles.VisualStyleInformation.TextControlBorder;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			SetupScrollbars();

			_rPanel.Invalidate();
		}

		private void SetupScrollbars()
		{
			horizontalScroll.Minimum = 0;
			verticalScroll.Minimum = 0;

			tableLayoutPanel1.RowStyles[1].Height = 0;
			tableLayoutPanel1.ColumnStyles[1].Width = 0;

			if (Manager.Room == null) return;

			if (Manager.Room.Width > _rPanel.ClientSize.Width)
			{
				tableLayoutPanel1.RowStyles[1].Height = 17;
			}
			if (Manager.Room.Height > _rPanel.ClientSize.Height)
			{
				tableLayoutPanel1.ColumnStyles[1].Width = 17;
			}

			if (Manager.Room.Width - _rPanel.ClientSize.Width > 0)
			{
				horizontalScroll.Maximum = Manager.Room.Width - _rPanel.ClientSize.Width - 1;
			}
		}

		private void horizontalScroll_ValueChanged(object sender, EventArgs e)
		{
			_rPanel.Offset = new Point(horizontalScroll.Value, _rPanel.Offset.Y);
		}

		private void verticalScroll_ValueChanged(object sender, EventArgs e)
		{
			_rPanel.Offset = new Point(_rPanel.Offset.X, verticalScroll.Value);
		}
	}
}
