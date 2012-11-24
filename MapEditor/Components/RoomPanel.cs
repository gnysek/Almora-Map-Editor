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
			Size canvas = new Size(this.Width, this.Height);
			// Calculate line amounts.
			int cols = (int)(canvas.Width / _gridX / _zoom) + 2;
			int rows = (int)(canvas.Height / _gridY / _zoom) + 2;

			// Grid color.
			Color color = Color.FromArgb(128, Color.Black);

			// Calculate offsets.
			int offsetX = Offset.X % 500;
			int offsetY = Offset.Y % 500;

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

		private void DrawInstances()
		{
			if (Manager.Project != null)
			{
				foreach (PlaceableInstance instance in Manager.Project.EnvInstancesList)
				{
					GraphicsManager.DrawSprite(0, instance.X, instance.Y, Color.White);
					//GraphicsManager.DrawRectangle(new Rectangle(instance.X, instance.Y, 16, 16), Color.White, true);
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
			if (_enabled)
			{
				//base.OnPaint(e);
				// Clear the screen.
				GraphicsManager.DrawClear(this.BackColor);

				// Begin drawing the scene.
				GraphicsManager.BeginScene();

				GraphicsManager.DrawRectangle(new Rectangle(0, 0, 301, 301), Color.Orange, false);

				GraphicsManager.Scissor = new Rectangle(0, this.Height - 300, 300, 300);

				DrawGrid();
				DrawInstances();

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

			if (Manager.Project == null) return;			

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

			PlaceableInstance instance = new PlaceableInstance();
			instance.X = _mouseX;
			instance.Y = _mouseY;

			Manager.Project.EnvInstancesList.Add(instance);

			// Force redraw
			Invalidate();
		}
	}
}
