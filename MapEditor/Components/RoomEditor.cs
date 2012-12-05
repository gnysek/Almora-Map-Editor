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
			_rPanel.Invalidate();
			SetupScrollbars();
		}

		private void SetupScrollbars()
		{
			horizontalScroll.Minimum = 0;
			verticalScroll.Minimum = 0;

			tableLayoutPanel1.RowStyles[1].Height = 0;
			tableLayoutPanel1.ColumnStyles[1].Width = 0;

			if (Manager.Room == null) return;

			if (Manager.Room.Width - _rPanel/*.ClientSize*/.Width > 0)
			{
				tableLayoutPanel1.RowStyles[1].Height = 17;
				horizontalScroll.Maximum = Manager.Room.Width - _rPanel.ClientSize.Width - 1;
			}
			if (Manager.Room.Height - _rPanel.ClientSize.Height > 0)
			{
				tableLayoutPanel1.ColumnStyles[1].Width = 17;
				verticalScroll.Maximum = Manager.Room.Height - _rPanel.ClientSize.Height - 1;
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
