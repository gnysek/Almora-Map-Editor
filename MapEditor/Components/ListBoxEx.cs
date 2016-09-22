using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using MapEditor.Common;

namespace MapEditor.Components
{
	public partial class ListBoxEx : ListBox
	{
		public enum SortType
		{
			Asc,
			Desc,
			Default
		}

		public enum ListType
		{
			Placeables,
			PlaceableInstances,
			Events,
			EventInstances,
			Rooms,
			Layers
		}

		private ListType _listBoxType = ListType.Placeables;
		private SortType _sort = SortType.Default;

		[DefaultValue(SortType.Default)]
		public SortType SortMode
		{
			set { _sort = value; /*SortItems()*/}
			get { return _sort; }
		}

		[DefaultValue(ListType.Placeables)]
		public ListType Type
		{
			set { _listBoxType = value; }
			get { return _listBoxType; }
		}

		public ListBoxEx()
		{
			InitializeComponent();
			// Set up defaults for ease of use
			DrawMode = DrawMode.OwnerDrawFixed;

			// Set drawing style to reduce flicker
			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			SetStyle(ControlStyles.Opaque, true);
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			//base.OnMouseDown(e);
			int index = this.IndexFromPoint(e.Location);

			// Left mouse button clicked.
			if (e.Button == MouseButtons.Left)
			{
				// If there was an item under the cursor, and there are items to select.
				if (index != -1 && Items.Count > 0)
					this.SelectedIndex = index;
			}
		}

		protected override void OnDrawItem(DrawItemEventArgs e)
		{
			// Disable anti-aliasing
			e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
			e.Graphics.SmoothingMode = SmoothingMode.None;

			// If there are items to draw
			if (e.Index != -1)
			{
				//base.OnDrawItem(e);
				string text = this.Items[e.Index].ToString();

				_paintItem(e.Index, e, e.Bounds.Y / this.ItemHeight);
			}
		}

		/// <summary>
		/// Override measure item.
		/// </summary>
		protected override void OnMeasureItem(MeasureItemEventArgs e)
		{
			// Do nothing.
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			// Disable anti-aliasing.
			e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
			e.Graphics.SmoothingMode = SmoothingMode.None;

			// Clear the control
			e.Graphics.FillRectangle(Brushes.White, this.ClientRectangle);

			if (Items.Count > 0)
			{
				int index = this.IndexFromPoint(0, 0);
				int item = 0;

				for (int i = index; i < this.Items.Count; i++)
				{
					// Draw item arguments.
					DrawItemEventArgs args;

					// Rendering bounds.
					//Rectangle bounds = new Rectangle(0 - _offsetX, item * this.ItemHeight, _maxWidth, this.ItemHeight);
					Rectangle bounds = new Rectangle(0, item * this.ItemHeight, this.Width, this.ItemHeight);

					// Set draw item argument, based on item selected index.
					if (i == this.SelectedIndex)
						args = new DrawItemEventArgs(e.Graphics, Font, bounds, i, DrawItemState.Selected);
					else
						args = new DrawItemEventArgs(e.Graphics, Font, bounds, i, DrawItemState.None);

					// Draw item.
					//OnDrawItem(args);
					// If the current item is selected.
					//if ((args.State & DrawItemState.Selected) == DrawItemState.Selected)
					//{
					//    if (_lastSelectedIndex > -1)
					//    {
					//        DrawItemEventArgs diea = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, _lastSelectedIndex, DrawItemState.NoFocusRect);
					//        base.OnDrawItem(diea);
					//    }

					//    // Draw the area in the selected state.
					//    e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
					//    textColor = Color.White;
					//    _lastSelectedIndex = e.Index;
					//}

					// Do some fancy background painting
					_paintItem(i, args, item);

					// Increment item draw index.
					item++;
				}
			}
			else
			{
				// Empty items text to be drawn.
				string text = string.Empty;

				// Get text based on the type of listbox.
				switch (_listBoxType)
				{
					case ListType.PlaceableInstances:
					case ListType.EventInstances: text = "- No Instances -"; break;
					case ListType.Events: text = "- No Event Definitions -"; break;
					case ListType.Placeables: text = "- No Placeable Definitions -"; break;
					case ListType.Rooms: text = "- No Room Definitions -"; break;
					case ListType.Layers: text = "- No Layer Definitions -"; break;
					default: text = "- No Definitions -"; break;
				}

				// Calculate the position of the text, which is the center of the control.
				SizeF size = e.Graphics.MeasureString(text, Font);
				int x = (int)((ClientSize.Width / 2) - (size.Width / 2));
				int y = (int)((ClientSize.Height / 2) - (size.Height / 2));

				// Draw the text.
				e.Graphics.DrawString(text, Font, Brushes.Gray, x, y);
			}
		}

		private void _paintItem(int itemNumber, DrawItemEventArgs args, int item)
		{
			string text = this.Items[itemNumber].ToString();
			string addText = "";

			if (_listBoxType == ListType.PlaceableInstances && Manager.Room != null)
			{
				addText += "X: " + Manager.Room.instances[itemNumber].x.ToString();
				addText += ", Y: " + Manager.Room.instances[itemNumber].x.ToString();
				addText += ", ID: " + Manager.Room.instances[itemNumber].gms_id.ToString();
			}
			else if (_listBoxType == ListType.Layers)
			{
				//addText += "Depth: " + Manager.Room.Layers[itemNumber].LayerDepth.ToString();
			}
			else if (_listBoxType == ListType.Rooms)
			{
				addText += "Instances: " + Manager.Project.GMRooms[itemNumber].instances.Count.ToString();
			}
			else if (_listBoxType == ListType.Placeables)
			{
                //addText += Manager.Project.PlaceableList[itemNumber].Sprite;
				//if (Manager.Project.PlaceableList[itemNumber].useDefaultObjectMask)
				//{
				//    addText += "/skip mask/";
				//}
				//else
				//{
				//    addText += (Manager.Project.PlaceableList[itemNumber].Mask == "") ? "-" : ("Mask: " + Manager.Project.PlaceableList[itemNumber].Mask);
				//}
			}

			_paintItem(text, args, item);

			if (addText != "")
			{
				int after = (int)args.Graphics.MeasureString(text, this.Font).Width + 5;
				args.Graphics.DrawString(addText, this.Font, Brushes.Gray, after, item * this.ItemHeight);
			}

		}

		private void _paintItem(string text, DrawItemEventArgs args, int item)
		{
			if ((args.State & DrawItemState.Selected) == DrawItemState.Selected)
			{
				args.Graphics.FillRectangle(new SolidBrush((this.Focused) ? SystemColors.Highlight : SystemColors.InactiveCaption), args.Bounds);
			}
			else if (args.Index % 2 == 0)
			{
				args.Graphics.FillRectangle(SystemBrushes.Control, args.Bounds);
			}
			else
			{
				args.Graphics.FillRectangle(new SolidBrush(this.BackColor), args.Bounds);
			}

			args.Graphics.DrawString(text, this.Font, Brushes.Black, 0, item * this.ItemHeight);
		}
	}
}
