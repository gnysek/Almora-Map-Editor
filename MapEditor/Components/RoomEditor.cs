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
			BackColor = System.Windows.Forms.VisualStyles.VisualStyleInformation.TextControlBorder;

			this.MouseWheel += new MouseEventHandler(MouseWheelEvent);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			_rPanel.Invalidate();
			SetupScrollbars();
		}

		private void SetupScrollbars()
		{
			horizontalScb.Minimum = 0;
			verticalScb.Minimum = 0;

			tableLayoutPanel1.RowStyles[1].Height = 0;
			tableLayoutPanel1.ColumnStyles[1].Width = 0;

			if (Manager.Room == null) return;

			if (Manager.Room.width - _rPanel/*.ClientSize*/.Width > 0)
			{
				tableLayoutPanel1.RowStyles[1].Height = 17;
				horizontalScb.Maximum = Manager.Room.width - _rPanel.ClientSize.Width - 1;
			}
			if (Manager.Room.height - _rPanel.ClientSize.Height > 0)
			{
				tableLayoutPanel1.ColumnStyles[1].Width = 17;
				verticalScb.Maximum = Manager.Room.height - _rPanel.ClientSize.Height - 1;
			}
		}

		private void horizontalScroll_ValueChanged(object sender, EventArgs e)
		{
			_rPanel.Offset = new Point(horizontalScb.Value, _rPanel.Offset.Y);
		}

		private void verticalScroll_ValueChanged(object sender, EventArgs e)
		{
			_rPanel.Offset = new Point(_rPanel.Offset.X, verticalScb.Value);
		}

		private void MouseWheelEvent(object sender, MouseEventArgs e)
		{
			MouseHorizontalWheelEvent(e, ModifierKeys == Keys.Shift);
		}

		private void MouseHorizontalWheelEvent(MouseEventArgs e, bool horizontal)
		{
			if (Manager.Room != null)
			{
				//MessageBox.Show(e.Delta.ToString() + ((horizontal) ? "H" : "V"));
				if (horizontal)
				{
					horizontalScb.Value = Math.Max(0, Math.Min(horizontalScb.Maximum,
						horizontalScb.Value + ((int)(_rPanel.Width * 0.1) * Math.Sign(e.Delta))
					));
				}
				else
				{
					verticalScb.Value = Math.Max(0, Math.Min(verticalScb.Maximum,
						verticalScb.Value + ((int)(_rPanel.Height * 0.1) * Math.Sign(-e.Delta))
					));
				}
			}
		}

		protected override void WndProc(ref Message m)
		{
			if (m.HWnd == this.Handle)
			{
				switch (m.Msg)
				{
					case 0x020e:
						int delta = (Int16)HIWORD(m.WParam);
						MouseHorizontalWheelEvent(new MouseEventArgs(MouseButtons.None, 0, MousePosition.X, MousePosition.Y, delta), true);
						m.Result = (IntPtr)0;
						return;
					default:
						break;
				}
			}
			base.WndProc(ref m);
		}

		private static Int32 HIWORD(IntPtr ptr)
		{
			Int32 val32 = ptr.ToInt32();
			return ((val32 >> 16) & 0xFFFF);
		}

		private void verticalScb_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			e.IsInputKey = true;
			//_rPanel.Focus();
		}

		private void horizontalScb_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			e.IsInputKey = true;
			//_rPanel.Focus();
		}

		private void _rPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Right)
			{
				horizontalScb.Value = Math.Min(horizontalScb.Maximum, horizontalScb.Value + 200);
			}
			else if (e.KeyCode == Keys.Left)
			{
				horizontalScb.Value = Math.Max(0, horizontalScb.Value - 200);
			}
			else if (e.KeyCode == Keys.Down)
			{
				verticalScb.Value = Math.Min(verticalScb.Maximum, verticalScb.Value + 200);
			}
			else if (e.KeyCode == Keys.Up)
			{
				verticalScb.Value = Math.Max(0, verticalScb.Value - 200);
			}

			e.IsInputKey = true;
		}
	}

	public class customHScrollBar : HScrollBar
	{
		protected override bool ProcessDialogKey(Keys keyData)
		{
			return false;
		}
	}

	public class customVScrollBar : VScrollBar
	{
		protected override bool ProcessDialogKey(Keys keyData)
		{
			return false;
		}
	}
}
