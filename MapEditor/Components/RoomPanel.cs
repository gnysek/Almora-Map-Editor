using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using MapEditor.Graphics;
using System.Drawing;
using MapEditor.Common;
using System.Reflection;
using MapEditor.Forms;

namespace MapEditor.Components
{
	public enum BrushMode
	{
		Select = 1,
		Paint,
		Move,
		Rotate
	}

	public partial class RoomPanel : Panel
	{
		private int _layerNumber = -1;
		private int _gridX = 32;
		private int _gridY = 32;
		private int _zoom = 1;
		private bool _enabled = true;
		private int _mouseX = 0;
		private int _mouseY = 0;
		private int _mx = 0;
		private int _my = 0;
		private bool _drawMousePosition = false;
		private Cursor _bucketCursor;
		private bool _drag = false;
		private int _rotateStart = 0;
		private int _rotateCurrent = 0;

		public BrushMode CurrentBrush = BrushMode.Select;

		public RoomPanel()
		{
			InitializeComponent();

			// For mouse wheel scrolling support.
			this.SetStyle(ControlStyles.Selectable, true);

			// For resizing flicker issues.
			this.SetStyle(ControlStyles.UserPaint, true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.Opaque, true);

			_bucketCursor = new Cursor(GetType().Assembly.GetManifestResourceStream("MapEditor.Resources.cur_bucket.cur"));
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

			// draw selected instance
			if (Manager.Project.SelectedInstance != null)
			{
				PlaceableInstance instance = Manager.Project.SelectedInstance;
				//GraphicsManager.DrawRectangle(new Rectangle(instance.XStart - 1, instance.YStart - 1, instance.Width + 2, instance.Height + 2), Color.Black, true);
				GraphicsManager.DrawStippledRectangle(new Rectangle(instance.XStart - 1, instance.YStart - 1, instance.Width + 2, instance.Height + 2), Color.Black, instance.Rotation, 2);
				//GraphicsManager.DrawRectangle(new Rectangle(instance.XStart, instance.YStart, instance.Width, instance.Height), Color.Red, true);
				GraphicsManager.DrawStippledRectangle(new Rectangle(instance.XStart, instance.YStart, instance.Width, instance.Height), Color.Red, instance.Rotation, 2);
				//GraphicsManager.DrawRectangle(new Rectangle(instance.XStart + 1, instance.YStart + 1, instance.Width - 2, instance.Height - 2), Color.Black, true);
				GraphicsManager.DrawStippledRectangle(new Rectangle(instance.XStart + 1, instance.YStart + 1, instance.Width - 2, instance.Height - 2), Color.Black, instance.Rotation, 2);
			}

			// ???
			if (_drawMousePosition)
			{
				if (Manager.Project.HighlightedInstance != null && Manager.Project.HighlightedInstance != Manager.Project.SelectedInstance)
				{
					PlaceableInstance instance = Manager.Project.HighlightedInstance;
					//GraphicsManager.DrawRectangle(new Rectangle(instance.XStart, instance.YStart, instance.Width, instance.Height), Color.FromArgb(30, Color.Yellow), false);
					//GraphicsManager.DrawRectangle(new Rectangle(instance.XStart - 1, instance.YStart - 1, instance.Width + 2, instance.Height + 2), Color.Black, true);
					//GraphicsManager.DrawRectangle(new Rectangle(instance.XStart, instance.YStart, instance.Width, instance.Height), Color.Yellow, true);
					//GraphicsManager.DrawRectangle(new Rectangle(instance.XStart + 1, instance.YStart + 1, instance.Width - 2, instance.Height - 2), Color.Black, true);
					GraphicsManager.DrawRectangleRotated(new Rectangle(instance.XStart, instance.YStart, instance.Width, instance.Height), instance.Rotation, Color.FromArgb(30, Color.Yellow), false);
					GraphicsManager.DrawRectangleRotated(new Rectangle(instance.XStart - 1, instance.YStart - 1, instance.Width + 2, instance.Height + 2), instance.Rotation, Color.Black, true);
					GraphicsManager.DrawRectangleRotated(new Rectangle(instance.XStart, instance.YStart, instance.Width, instance.Height), instance.Rotation, Color.Yellow, true);
					GraphicsManager.DrawRectangleRotated(new Rectangle(instance.XStart + 1, instance.YStart + 1, instance.Width - 2, instance.Height - 2), instance.Rotation, Color.Black, true);
				}
			}
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
				int selectedLayerDepth = Manager.Room.Layers[Manager.MainWindow.tbLayerDropDown.SelectedIndex].LayerDepth;

				int layerCounter = 0;
				foreach (MapLayers layer in Manager.Room.Layers)
				{
					Color defaultLayerColor = Color.Gray;
					if (layer.LayerDepth == selectedLayerDepth) defaultLayerColor = Color.White;

					foreach (PlaceableInstance instance in Manager.Room.Instances)
					{
						if (instance.Layer != layer.LayerDepth) continue;

						Color color = defaultLayerColor;
						if (Manager.Project.HighlightedInstance == instance) color = Color.Yellow;
						if (Manager.Project.SelectedInstance == instance) color = Color.Red;

						if (instance.Element != null)
						{
							GraphicsManager.DrawSprite(instance.Element.textureId, instance.XStart, instance.YStart, instance.Rotation, color);

							if (instance.Element.MultiDraw)
							{
								GraphicsManager.DrawSprite(instance.Element.textureId, instance.XStart, instance.YStart, instance.Rotation + 90, color);
							}
							//GraphicsManager.draw
						}
					}
					layerCounter++;
				}

				if (CurrentBrush == BrushMode.Paint && Manager.Project.Instance != null)
				{
					try
					{
						GraphicsManager.DrawSprite(
							Manager.Project.Instance.textureId,
							_mx - Manager.Project.Instance.offsetX,
							_my - Manager.Project.Instance.offsetY,
							0, Color.Yellow);
					}
					catch { }
				}

				GraphicsManager.DrawSpriteBatch(false);

				if (_drag)
				{
					if (Manager.Project.SelectedInstance != null)
					{
						PlaceableInstance p = Manager.Project.SelectedInstance;
						// drawing when moving
						if (CurrentBrush == BrushMode.Move)
						{
							GraphicsManager.DrawSprite(
								Manager.Project.SelectedInstance.Element.textureId,
								/*Manager.Project.SelectedInstance.X +*/ (_mouseX - Manager.Project.SelectedInstance.Element.offsetX),
								/*Manager.Project.SelectedInstance.Y +*/ (_mouseY - Manager.Project.SelectedInstance.Element.offsetY),
								Manager.Project.SelectedInstance.Rotation, Color.Red);
						}

						// drawing when rotating
						if (CurrentBrush == BrushMode.Rotate)
						{
							Color green = Color.FromArgb(100, Color.Green);

							//GraphicsManager.DrawRectangle(
							//    new Rectangle(p.XStart - 50, p.YStart - 50, p.Width + 100, p.Height + 100),
							//    Color.FromArgb(100, Color.White),
							//    false
							//);

							//GraphicsManager.DrawLineCache(
							//    p.X - (int)lengthdir_x(p.Width, p.Rotation),
							//    p.Y - (int)lengthdir_y(p.Height, p.Rotation),
							//    p.X + (int)lengthdir_x(p.Width, p.Rotation),
							//    p.Y + (int)lengthdir_y(p.Height, p.Rotation),
							//    green
							//);
							//GraphicsManager.DrawLineCache(
							//    p.X - (int)lengthdir_x(p.Width, p.Rotation + 90),
							//    p.Y - (int)lengthdir_y(p.Height, p.Rotation + 90),
							//    p.X + (int)lengthdir_x(p.Width, p.Rotation + 90),
							//    p.Y + (int)lengthdir_y(p.Height, p.Rotation + 90),
							//    green
							//);
							//GraphicsManager.DrawLineBatch();

							//GraphicsManager.DrawSprite(
							//    p.Element.textureId,
							//    p.XStart, p.YStart,
							//    p.Rotation, green
							//);


							// draw rotated one
							//double newRotation = (Manager.Project.SelectedInstance.Rotation + pointDistance(Manager.Project.SelectedInstance.XCenter, Manager.Project.SelectedInstance.YCenter, _mx, _my)) % 360;

							int newRotation = MathMethods.AngleDifference(MathMethods.PointDirection(p.X, p.Y, _mx, _my), _rotateStart);
							_rotateCurrent = (p.Rotation + newRotation) % 360;

							//Manager.MainWindow.statusLabelMousePos.Text = newRotation.ToString();

							GraphicsManager.DrawSprite(
								p.Element.textureId,
								p.XStart,
								p.YStart,
								(float)_rotateCurrent,
								Color.Red
							);

							//GraphicsManager.DrawLineCache(
							//    p.XCenter - (int)lengthdir_x(p.Width, newRotation),
							//    p.YCenter - (int)lengthdir_y(p.Height, newRotation),
							//    p.XCenter + (int)lengthdir_x(p.Width, newRotation),
							//    p.YCenter + (int)lengthdir_y(p.Height, newRotation),
							//    Color.Red
							//);
							//GraphicsManager.DrawLineCache(
							//    p.XCenter - (int)lengthdir_x(p.Width, newRotation + 90),
							//    p.YCenter - (int)lengthdir_y(p.Height, newRotation + 90),
							//    p.XCenter + (int)lengthdir_x(p.Width, newRotation + 90),
							//    p.YCenter + (int)lengthdir_y(p.Height, newRotation + 90),
							//    Color.Red
							//);

							GraphicsManager.DrawRectangleRotated(
								new Rectangle(p.XStart, p.YStart, p.Width, p.Height),
								_rotateCurrent, Color.FromArgb(150, Color.White), false
							);

							//GraphicsManager.DrawLineBatch();
						}
					}
					GraphicsManager.DrawSpriteBatch(false);
				}


			}
		}
		#endregion

		public double lengthdir_x(int len, int dir)
		{
			return Math.Cos(dir * Math.PI / 180) * len;
		}

		public double lengthdir_x(int len, double dir)
		{
			return lengthdir_x(len, (int)dir);
		}

		public double lengthdir_y(int len, int dir)
		{
			return -Math.Sin(dir * Math.PI / 180) * len;
		}

		public double lengthdir_y(int len, double dir)
		{
			return lengthdir_y(len, (int)dir);
		}

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
			//e.Graphics.Clear(this.BackColor);
			if (Manager.Room != null)
			{
				// Clear the screen.
				GraphicsManager.DrawClear(this.BackColor);

				// Begin drawing the scene.
				GraphicsManager.BeginScene();
				int sq = 0;
				int lastStartedFrom = 1;
				for (int i = 0; i < Math.Min(Manager.Room.Width, this.Width); i += _gridX / 2)
				{
					if (lastStartedFrom == sq % 2)
					{
						sq++;
					}

					lastStartedFrom = sq % 2;

					for (int j = 0; j < Math.Min(Manager.Room.Height, this.Height); j += _gridY / 2)
					{
						GraphicsManager.DrawRectangle(
							new Rectangle(Offset.X + i, Offset.Y + j, 30, 30),
							(sq % 2 == 1) ? Color.Silver : Color.White,
							false
							);
						sq++;
					}
				}

				//GraphicsManager.DrawRectangle(new Rectangle(Offset.X, Offset.Y, Math.Min(Manager.Room.Width, this.Width) + 1, Math.Min(Manager.Room.Height, this.Height) + 1), Color.Orange, false);
				GraphicsManager.Scissor = new Rectangle(0, 0, this.Width, this.Height);

				// draw instances
				DrawInstances();

				// draw grid and higlights
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

				//e.Graphics.Clear(this.BackColor);
				//foreach (PlaceableInstance instance in Manager.Room.Instances)
				//{
				//    e.Graphics.DrawString( pointDistance(instance.XCenter, instance.YCenter, _mx, _my).ToString(), Manager.MainWindow.Font, Brushes.Black, instance.X, instance.Y);
				//}
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

		private void drawSelectionToolRotated(Rectangle rec, Color c, float angle, int offset)
		{
			GraphicsManager.DrawStippledRectangle(rec, c, angle, offset);
		}

		private void drawMouseGrid(Rectangle rec)
		{
			rec.Width++;
			rec.Height++;
			GraphicsManager.DrawRectangle(rec, Color.Black, true);
			//GraphicsManager.DrawStippledRectangle(rec, Color.Black, 4);
			rec.X += 1;
			rec.Y += 1;
			rec.Width -= 2;
			rec.Height -= 2;
			GraphicsManager.DrawRectangle(rec, Color.White, true);
			//GraphicsManager.DrawStippledRectangle(rec, Color.White, 4);
			rec.X += 1;
			rec.Y += 1;
			rec.Width -= 2;
			rec.Height -= 2;
			GraphicsManager.DrawRectangle(rec, Color.Black, true);
			//GraphicsManager.DrawStippledRectangle(rec, Color.Black, 4);
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

		protected override void OnDoubleClick(EventArgs e)
		{
			base.OnDoubleClick(e);

			if (Manager.Project.SelectedInstance != null)
			{
				using (InstanceProp form = new InstanceProp())
				{
					form.Element = Manager.Project.SelectedInstance;
					form.ShowDialog();
				}
			}
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

				if (CurrentBrush == BrushMode.Move || CurrentBrush == BrushMode.Rotate)
				{
					_drag = true;
					if (CurrentBrush == BrushMode.Rotate)
					{
						Invalidate();

						if (Manager.Project.SelectedInstance != null)
						{
							PlaceableInstance p = Manager.Project.SelectedInstance;
							this._rotateStart = MathMethods.PointDirection(p.X, p.Y, _mx, _my);
							Manager.MainWindow.statusLabelMousePos.Text = _rotateStart.ToString();
						}
					}
				}
			}
		}

		private double pointDistance(int x1, int y1, int x2, int y2)
		{
			return Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);

			if (Manager.Room == null) return;
			if (Manager.Project.Instance == null) return;

			switch (e.Button)
			{
				case System.Windows.Forms.MouseButtons.Left:
					switch (CurrentBrush)
					{
						case BrushMode.Select:

							if (Manager.Project.HighlightedInstance != null)
							{
								Manager.Project.SelectedInstance = Manager.Project.HighlightedInstance;
								//MessageBox.Show(Manager.Project.HighlightedInstance.Element.Name + Manager.Room.Instances.IndexOf(Manager.Project.HighlightedInstance).ToString());
							}

							/*int counter = 0;
							int foundId = 0;
							double distance = 1000000;
							PlaceableInstance found = null;
							foreach (PlaceableInstance pinstance in Manager.Room.Instances)
							{
								double dist = pointDistance(pinstance.X, pinstance.Y, _mx, _my);
								if (dist < distance)
								{
									distance = dist;
									found = pinstance;
									foundId = counter;
								}
								counter++;
							}
							MessageBox.Show(found.Element.Name + "[" + foundId.ToString() + "]");*/

							break;
						case BrushMode.Paint:
							PlaceableInstance instance = new PlaceableInstance()
							{
								X = _mouseX /*- Manager.Project.Instance.offsetX*/,
								Y = _mouseY /*- Manager.Project.Instance.offsetY*/,
								Element = Manager.Project.Instance,
								Layer = Manager.Room.Layers[Manager.Room.LastUsedLayer].LayerDepth
							};

							Manager.Room.addInstance(instance);
							Manager.Project.regenerateInstanceList();
							break;
						case BrushMode.Move:
							if (_drag)
							{
								if (Manager.Project.SelectedInstance != null)
								{
									Manager.Project.SelectedInstance.X = _mouseX;
									Manager.Project.SelectedInstance.Y = _mouseY;
								}
							}
							_drag = false;
							break;
						case BrushMode.Rotate:
							if (_drag)
							{
								if (Manager.Project.SelectedInstance != null)
								{
									Manager.Project.SelectedInstance.Rotation = _rotateCurrent;
									//(int)(Manager.Project.SelectedInstance.Rotation + pointDistance(Manager.Project.SelectedInstance.XCenter, Manager.Project.SelectedInstance.YCenter, _mx, _my)) % 360;
								}
							}
							_drag = false;
							break;

					}
					break;
			}

			// Force redraw
			Invalidate();
		}

		/// <summary>
		/// When there's a mouse move over map canvas
		/// </summary>
		/// <param name="e"></param>
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);

			if (Manager.Room == null) return;

			Focus();

			bool redraw = false;

			Point snap = GetSnappedPoint(e.Location, new Size(_gridX, _gridY));
			_drawMousePosition = true;

			int __mx, __my;

			__mx = Offset.X + e.Location.X;
			__my = Offset.Y + e.Location.Y;

			if (__mx != _mx || __my != _my)
			{
				_mx = __mx;
				_my = __my;
				redraw = true;
			}

			if (CurrentBrush == BrushMode.Select)
			{
				//int counter = 0;
				//int foundId = 0;
				double distance = 100000;
				PlaceableInstance found = null;
				foreach (PlaceableInstance pinstance in Manager.Room.Instances)
				{
					if (Manager.Room.Layers[Manager.MainWindow.tbLayerDropDown.SelectedIndex].LayerDepth != pinstance.Layer)
						continue;

					double dist = pointDistance(pinstance.X, pinstance.Y, _mx, _my);

					if (dist < distance)
					{
						if (pinstance.XStart <= _mx)
							if (pinstance.YStart <= _my)
								if (pinstance.XEnd >= _mx)
									if (pinstance.YEnd >= _my)
									{
										distance = dist;
										found = pinstance;
									}
						//foundId = counter;
					}
					//counter++;
				}
				//if (found != null)
				//{
				if (Manager.Project.HighlightedInstance != found)
				{
					redraw = true;
					Manager.Project.HighlightedInstance = found;
				}
				//}
			}

			if (_drag)
			{
				redraw = true;
			}

			//if (redraw)
			//{
			//    Invalidate();
			//}

			if (snap.X != _mouseX || snap.Y != _mouseY || redraw)
			{
				_mouseX = snap.X;
				_mouseY = snap.Y;
				Manager.MainWindow.statusLabelMousePos.Text = "X: " + _mouseX.ToString() + ", Y: " + _mouseY.ToString();
				Manager.MainWindow.statusLabelMousePos.Text += " / RX:  " + _mx.ToString() + ", RY: " + _my.ToString();
				Invalidate();
			}

		}

		protected override void OnMouseLeave(EventArgs e)
		{
			//base.OnMouseLeave(e);
			if (Manager.Project != null)
			{
				Manager.Project.HighlightedInstance = null;
			}
			_drawMousePosition = false;
			_drag = false;
			Invalidate();
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			_drawMousePosition = true;
			this.Focus();

			RefreshCursor();

			Invalidate();
		}

		public void RefreshCursor()
		{
			if (Manager.Room == null)
			{
				Cursor = Cursors.Default;
			}
			else
			{
				switch (CurrentBrush)
				{
					case BrushMode.Paint: Cursor = _bucketCursor; break;
					case BrushMode.Move: Cursor = Cursors.SizeAll; break;
					case BrushMode.Rotate: Cursor = Cursors.AppStarting; break;
					default: Cursor = Cursors.Default; break;
				}
			}
		}
	}
}
