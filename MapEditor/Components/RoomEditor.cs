using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MapEditor.Components;

namespace MapEditor.Components
{
	public partial class RoomEditor : UserControl
	{
		private bool _dragging = false;

		public RoomEditor()
		{
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			_rPanel.Invalidate();
		}
	}
}
