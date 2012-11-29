using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using MapEditor.Graphics;
using System.Drawing;
using MapEditor.Common;

namespace MapEditor.Components
{
	public partial class RoomPanel : Panel
	{
		private int _layerNumber = -1;
		private int _gridX = 32;
		private int _gridY = 32;
		private int _zoom = 1;
		private bool _enabled = true;
		private int _mouseX = 0;
		private int _mouseY = 0;
		private bool _drawMousePosition = false;

		public RoomPanel()
		{
			InitializeComponent();

			// For mouse wheel scrolling support.
			this.SetStyle(ControlStyles.Selectable, true);

			// For resizing flicker issues.
			this.SetStyle(ControlStyles.UserPaint, true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.Opaque, true);
		}

		#region drawGrid
		private void DrawGrid()
		{
			int x1 = 0;
			int y1 = 0;
			int x2 = 0;
			int y2 = 0;
			Size canvas = getCurrentCanvas();//new Size(this.Width, this.Height);
			// Calculate line amounts.
			int cols = (int)(canvas.Width / _gridX / _zoom) + 2;
			int rows = (int)(canvas.Height / _gridY / _zoom) + 2;

			// Grid color.
			Color color = Color.FromArgb(128, Color.Black);

			// Calculate offsets.
			int offsetX = Offset.X % Manager.Room.Width;
			int offsetY = Offset.Y % Manager.Room.Height;

			Point snap = GetSnappedPoint(new Point(Offset.X - offsetX, Offset.Y - offsetY), new Size(_gridX, _gridY));

			// Draw vertical lines.
			for (int col = 0; col < cols; col++)
			{
				// Calculate coordinates.
				x1 = col * _gridX + snap.X;
				y1 = snap.Y;
				x2 = col * _gridX + snap.X;
				y2 = (int)(canvas.Height / _zoom) + snap.Y + _gridY;

				// Draw line.
				GraphicsManager.DrawLineCache(x1, y1, x2, y2, color);
			}

			// Draw horizontal lines.
			for (int row = 0; row < rows; row++)
			{
				// Calculate coordinates.
				x1 = snap.X;
				y1 = row * _gridY + snap.Y;
				x2 = (int)(canvas.Width / _zoom) + snap.X + _gridX;
				y2 = row * _gridY + snap.Y;

				// Draw line.
				GraphicsManager.DrawLineCache(x1, y1, x2, y2, color);
			}

			GraphicsManager.DrawLineBatch();
		}

		private Size getCurrentCanvas()
		{
			Size size = ClientSize;

			if (Manager.Room == null) return size;

			if (ClientSize.Width > Manager.Room.Width)
			{
				size.Width = Manager.Room.Width;
			}
			if (ClientSize.Height > Manager.Room.Height)
			{
				size.Height = Manager.Room.Height;
			}

			return size;
		}

		private void DrawInstances()
		{
			if (Manager.Room != null)
			{
				foreach (PlaceableInstance instance in Manager.Project.PlaceableInstances)
				{
					//GraphicsManager.DrawSprite(0, instance.X + 5, instance.Y + 5, 70, Color.Black);
					GraphicsManager.DrawSprite(0, instance.X, instance.Y, 0, Color.White);
				}

				GraphicsManager.DrawSpriteBatch(false);
			}
		}
		#endregion

		/// <summary>
		/// Override CreateControl event.
		/// </summary>
		protected override void OnCreateControl()
		{
			// Allow hooking of this event.
			base.OnCreateControl();

			// If not in design mode, initialize OpenGL.
			if (DesignMode == false)
				GraphicsManager.Initialize(this);

			// Set blend mode for alpha data.
			GraphicsManager.BlendMode = GraphicsManager.BlendType.Alpha;
		}

		#region Paint
		protected override void OnPaint(PaintEventArgs e)
		{
			if (Manager.Room != null)
			{
				// Clear the screen.
				GraphicsManager.DrawClear(this.BackColor);

				// Begin drawing the scene.
				GraphicsManager.BeginScene();
				GraphicsManager.DrawRectangle(new Rectangle(0, 0, Math.Min(Manager.Room.Width, this.Width) + 1, Math.Min(Manager.Room.Height, this.Height) + 1), Color.Orange, false);
				GraphicsManager.Scissor = new Rectangle(0, 0, this.Width, this.Height);

				DrawInstances();
				DrawGrid();

				OpenGL.glTexParameteri(OpenGL.GL_TEXTURE_2D, OpenGL.GL_TEXTURE_MAG_FILTER, OpenGL.GL_LINEAR);

				if (_drawMousePosition)
				{
					drawMouseGrid(new Rectangle(_mouseX, _mouseY, _gridX, _gridY));
				}

				// Disable scissor testing.
				OpenGL.glDisable(GLOption.ScissorTest);

				// End drawing the scene.
				GraphicsManager.EndScene();
			}
			else
			{
				e.Graphics.Clear(this.BackColor);
			}
		}

		private void drawSelectionTool(Rectangle rec, Color c, int offset)
		{
			GraphicsManager.DrawStippledRectangle(rec, c, offset);
		}

		private void drawMouseGrid(Rectangle rec)
		{
			rec.Width++;
			rec.Height++;
			GraphicsManager.DrawRectangle(rec, Color.Black, true);
			rec.X += 1;
			rec.Y += 1;
			rec.Width -= 2;
			rec.Height -= 2;
			GraphicsManager.DrawRectangle(rec, Color.White, true);
			rec.X += 1;
			rec.Y += 1;
			rec.Width -= 2;
			rec.Height -= 2;
			GraphicsManager.DrawRectangle(rec, Color.Black, true);
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			//base.OnPaintBackground(e);
		}
		#endregion

		/// <summary>
		/// Gets or sets the viewport offset.
		/// </summary>
		public Point Offset
		{
			get { return new Point(GraphicsManager.OffsetX, GraphicsManager.OffsetY); }
			set { GraphicsManager.OffsetX = value.X; GraphicsManager.OffsetY = value.Y; Invalidate(); }
		}

		/// <summary>
		/// Calculates a snapped version of a point.
		/// </summary>
		/// <param name="position">Point to use as snapping origin.</param>
		/// <param name="snap">Snapping value.</param>
		/// <returns>A snapped point.</returns>
		private Point GetSnappedPoint(Point position, Size snap)
		{
			// Calculate snapped position.
			int width = (int)(snap.Width * _zoom);
			int height = (int)(snap.Height * _zoom);
			int offsetX = (int)(Offset.X * _zoom);
			int offsetY = (int)(Offset.Y * _zoom);
			int x = (int)((((position.X + offsetX) / width) * width) / _zoom);
			int y = (int)((((position.Y + offsetY) / height) * height) / _zoom);

			return new Point(x, y);
		}

		public void enable()
		{
			_enabled = true;
		}

		/////

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);

			if (Manager.Room == null) return;

			Point snap = GetSnappedPoint(e.Location, new Size(_gridX, _gridY));

			// If mouse left button clicked.
			if (e.Button == MouseButtons.Left)
			{
				//Invalidate();
				_mouseX = snap.X;
				_mouseY = snap.Y;
			}
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);

			if (Manager.Room == null) return;

			PlaceableInstance instance = new PlaceableInstance();
			instance.X = _mouseX;
			instance.Y = _mouseY;

			Manager.Project.PlaceableInstances.Add(instance);

			// Force redraw
			Invalidate();

		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);

			if (Manager.Room == null) return;

			Point snap = GetSnappedPoint(e.Location, new Size(_gridX, _gridY));
			_drawMousePosition = true;

			if (snap.X != _mouseX || snap.Y != _mouseY)
			{
				_mouseX = snap.X;
				_mouseY = snap.Y;
				Manager.MainWindow.statusLabelMousePos.Text = "X: " + _mouseX.ToString() + ", Y: " + _mouseY.ToString();
				Invalidate();
			}

		}

		protected override void OnMouseLeave(EventArgs e)
		{
			//base.OnMouseLeave(e);
			_drawMousePosition = false;
			Invalidate();
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			_drawMousePosition = true;
			Invalidate();
		}
	}
}
