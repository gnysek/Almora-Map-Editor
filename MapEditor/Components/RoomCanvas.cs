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
        Rotate,
        Delete
    }

    public partial class RoomCanvas : Panel
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
        private Cursor _bucketCursor, _rotateCursor;
        private bool _drag = false;
        private int _rotateStart = 0;
        private int _rotateCurrent = 0;

        public BrushMode CurrentBrush = BrushMode.Select;

        public RoomCanvas()
        {
            InitializeComponent();

            // For mouse wheel scrolling support.
            this.SetStyle(ControlStyles.Selectable, true);

            // For resizing flicker issues.
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.Opaque, true);

            _bucketCursor = new Cursor(GetType().Assembly.GetManifestResourceStream("MapEditor.Resources.cur_bucket.cur"));
            _rotateCursor = new Cursor(GetType().Assembly.GetManifestResourceStream("MapEditor.Resources.cur_rotate.cur"));
        }

        public int Zoom
        {
            set
            {
                switch (value)
                {
                    case 0: this._zoom = 1; break;
                    case 1: if (this._zoom < 4) this._zoom *= 2; break;
                    case -1: if (this._zoom > 1) this._zoom /= 2; break;
                }
            }
            get { return this._zoom; }
        }

        public void addToolbarLog(string txt)
        {
            Manager.MainWindow.statusLabelMousePos.Text += " " + txt;
        }

        public bool GridEnabled = true;

        public bool BackgroundDraw = true;

        #region drawGrid
        private void DrawGrid()
        {
            if (GridEnabled)
            {
                int x1 = 0;
                int y1 = 0;
                int x2 = 0;
                int y2 = 0;
                Size canvas = getCurrentCanvas();//new Size(this.Width, this.Height);
                // Calculate line amounts.
                int cols = (int)(canvas.Width / (_gridX / _zoom)) + 1;
                int rows = (int)(canvas.Height / (_gridY / _zoom)) + 1;

                // Grid color.
                Color color = Color.FromArgb(128, Color.Black);

                // Calculate offsets.
                int offsetX = (Offset.X % Manager.Room.width);// *_zoom;
                int offsetY = (Offset.Y % Manager.Room.height);// *_zoom;

                Point snap = GetSnappedPoint(new Point(Offset.X - offsetX, Offset.Y - offsetY), new Size(_gridX, _gridY));

                // Draw vertical lines.
                for (int col = 0; col < cols; col++)
                {
                    // Calculate coordinates.
                    x1 = (col * (_gridX / _zoom) + snap.X);
                    y1 = snap.Y;
                    x2 = x1;//col * _gridX + snap.X;
                    y2 = (int)(canvas.Height /*/ _zoom*/) + snap.Y;

                    // Draw line.
                    GraphicsManager.DrawLineCache(x1, y1, x2, y2, color);
                }

                // Draw horizontal lines.
                for (int row = 0; row < rows; row++)
                {
                    // Calculate coordinates.
                    x1 = snap.X;
                    y1 = (row * (_gridY / _zoom) + snap.Y);
                    x2 = (int)(canvas.Width /*/ _zoom*/) + snap.X;
                    y2 = y1;//row * _gridY + snap.Y;

                    // Draw line.
                    GraphicsManager.DrawLineCache(x1, y1, x2, y2, color);
                }

                GraphicsManager.DrawLineBatch();
            }

            // draw selected instance
            if (Manager.Project.SelectedInstance != null)
            {
                this.drawSelectedInstance(Manager.Project.SelectedInstance);
            }

            // ???
            if (_drawMousePosition)
            {
                if (Manager.Project.HighlightedInstance != null && Manager.Project.HighlightedInstance != Manager.Project.SelectedInstance)
                {
                    this.drawHighlightedInstance(Manager.Project.HighlightedInstance);
                }
            }
        }

        private void drawHighlightedInstance(GmsRoomInstance instance)
        {
            GraphicsManager.DrawRectangleRotated(new Rectangle(instance.editor_data.XStartZoomed, instance.editor_data.YStartZoomed, instance.editor_data.WidthZoomed, instance.editor_data.HeightZoomed), instance.rotation, Color.FromArgb(30, Color.Yellow), false);
            GraphicsManager.DrawRectangleRotated(new Rectangle(instance.editor_data.XStartZoomed - 1, instance.editor_data.YStartZoomed - 1, instance.editor_data.WidthZoomed + 2, instance.editor_data.HeightZoomed + 2), instance.rotation, Color.Black, true);
            GraphicsManager.DrawRectangleRotated(new Rectangle(instance.editor_data.XStartZoomed, instance.editor_data.YStartZoomed, instance.editor_data.WidthZoomed, instance.editor_data.HeightZoomed), instance.rotation, Color.Yellow, true);
            GraphicsManager.DrawRectangleRotated(new Rectangle(instance.editor_data.XStartZoomed + 1, instance.editor_data.YStartZoomed + 1, instance.editor_data.WidthZoomed - 2, instance.editor_data.HeightZoomed - 2), instance.rotation, Color.Black, true);

            /*if (instance.Rotation != 0)
            {
                int rot = instance.Rotation;

                Point rotated = RotatePoint(new Point(_mx, _my), new Point(instance.XCenterZoomed, instance.YCenterZoomed), (double)rot);

                GraphicsManager.DrawRectangle(new Rectangle(rotated.X - 5, rotated.Y - 5, 10, 10), Color.Aqua, false);

                GraphicsManager.DrawRectangleRotated(new Rectangle(instance.XStartZoomed, instance.YStartZoomed, instance.WidthZoomed, instance.HeightZoomed), rot, Color.FromArgb(30, Color.Orange), false);
                GraphicsManager.DrawRectangleRotated(new Rectangle(instance.XStartZoomed - 1, instance.YStartZoomed - 1, instance.WidthZoomed + 2, instance.HeightZoomed + 2), rot, Color.Black, true);
                GraphicsManager.DrawRectangleRotated(new Rectangle(instance.XStartZoomed, instance.YStartZoomed, instance.WidthZoomed, instance.HeightZoomed), rot, Color.Orange, true);
                GraphicsManager.DrawRectangleRotated(new Rectangle(instance.XStartZoomed + 1, instance.YStartZoomed + 1, instance.WidthZoomed - 2, instance.HeightZoomed - 2), rot, Color.Black, true);
            }*/
        }

        static Point RotatePoint(Point pointToRotate, Point centerPoint, double angleInDegrees)
        {
            double angleInRadians = (angleInDegrees) * (Math.PI / 180);
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);
            return new Point
            {
                X =
                    (int)
                    (cosTheta * (pointToRotate.X - centerPoint.X) -
                    sinTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.X),
                Y =
                    (int)
                    (sinTheta * (pointToRotate.X - centerPoint.X) +
                    cosTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.Y)
            };
        }

        private void drawSelectedInstance(GmsRoomInstance instance)
        {
            GraphicsManager.DrawStippledRectangle(new Rectangle(instance.editor_data.XStartZoomed - 1, instance.editor_data.YStartZoomed - 1, instance.editor_data.WidthZoomed + 2, instance.editor_data.HeightZoomed + 2), Color.Black, instance.rotation, 2);
            GraphicsManager.DrawStippledRectangle(new Rectangle(instance.editor_data.XStartZoomed, instance.editor_data.YStartZoomed, instance.editor_data.WidthZoomed, instance.editor_data.HeightZoomed), Color.Red, instance.rotation, 2);
            GraphicsManager.DrawStippledRectangle(new Rectangle(instance.editor_data.XStartZoomed + 1, instance.editor_data.YStartZoomed + 1, instance.editor_data.WidthZoomed - 2, instance.editor_data.HeightZoomed - 2), Color.Black, instance.rotation, 2);
        }

        private Size getCurrentCanvas()
        {
            Size size = ClientSize;

            if (Manager.Room == null) return size;

            if (ClientSize.Width > Manager.Room.width / Zoom)
            {
                size.Width = Manager.Room.width / Zoom;
            }
            if (ClientSize.Height > Manager.Room.height / Zoom)
            {
                size.Height = Manager.Room.height / Zoom;
            }

            return size;
        }

        private void DrawBackground()
        {
            if (Manager.Room.width / Zoom < this.Width)
            {
                GraphicsManager.DrawLineCache(Manager.Room.width / Zoom, 0, Manager.Room.width / Zoom, Math.Min(Manager.Room.height / Zoom, this.Height) + 1, Color.Red);
            }

            if (Manager.Room.height / Zoom < this.Height)
            {
                GraphicsManager.DrawLineCache(0, Manager.Room.height / Zoom, Math.Min(Manager.Room.width / Zoom, this.Width) + 1, Manager.Room.height / Zoom, Color.Red);
            }

            //TODO: pre-cache it
            if (this.BackgroundDraw && Manager.Room.background != null && Manager.Room.background.image != null)
            {
                int width = GraphicsManager.Sprites["@bg:" + Manager.Room.background.name].Width;
                int height = GraphicsManager.Sprites["@bg:" + Manager.Room.background.name].Height;

                GraphicsManager.DrawRectangle(
                    new Rectangle(0, 0, this.Width, this.Height), Color.White, false
                );

                for (int i = (Offset.X - Offset.X % width); i < Offset.X + this.Width * Zoom; i += width)
                {
                    for (int j = (Offset.Y - Offset.Y % height); j < Offset.Y + this.Height * Zoom; j += height)
                    {
                        GraphicsManager.DrawSprite("@bg:" + Manager.Room.background.name, i, j, 0, Color.White);
                    }
                }
            }
            else
            {
                // Draw background pattern
                int sq = 0;
                int lastStartedFrom = 1;

                int x_size = _gridX / 2, y_size = _gridY / 2;
                int xstart = Offset.X - (Offset.X % x_size);
                int ystart = Offset.Y - (Offset.Y % y_size);

                for (int i = 0; i < Math.Min(Manager.Room.width / Zoom, this.Width); i += x_size)
                {
                    if (lastStartedFrom == sq % 2)
                    {
                        sq++;
                    }

                    lastStartedFrom = sq % 2;

                    for (int j = 0; j < Math.Min(Manager.Room.height / Zoom, this.Height); j += y_size)
                    {
                        GraphicsManager.DrawRectangle(
                            new Rectangle(xstart + i, ystart + j, x_size + 1, y_size + 1),
                            (sq % 2 == 1) ? Color.Silver : Color.White,
                            false
                            );
                        sq++;
                    }
                }
            }
        }

        private void DrawInstances()
        {
            if (Manager.Room != null)
            {
                int selectedLayerDepth = Manager.Room.Layers[Manager.MainWindow.tbLayerDropDown.SelectedIndex].LayerDepth;

                //int layerCounter = 0;
                //foreach (MapLayers layer in Manager.Room.Layers)
                //{
                //    if (layer.LayerDepth != selectedLayerDepth)
                //    {
                //        if (!layer.Active) continue;
                //    }

                Color defaultLayerColor = Color.Gray;
                defaultLayerColor = Color.White;//todo - if proper layer
                //if (layer.LayerDepth == selectedLayerDepth) defaultLayerColor = Color.White;

                foreach (GmsRoomInstance instance in Manager.Room.instances)
                {
                    //if (instance.editor_data.Layer != layer.LayerDepth) continue;

                    Color color = defaultLayerColor;
                    if (Manager.Project.HighlightedInstance == instance) color = Color.Yellow;
                    if (Manager.Project.SelectedInstance == instance) color = Color.Red;

                    if (instance.instance_of.sprite_index != null)
                    {
                        //GraphicsManager.DrawSprite(instance.Element.textureId, instance.XCenter / _zoom, instance.YCenter / _zoom, instance.Rotation, color);

                        //try
                        //{
                        GraphicsManager.DrawSprite(instance.instance_of.sprite_index.name, instance.editor_data.XStart, instance.editor_data.YStart, instance.rotation, color); //instance.linkedObj.sprite_index.name
                        //}
                        //catch (Exception e)
                        //{
                        //    MessageBox.Show(e.StackTrace.ToString());
                        //}

                        /*if (instance.Element.MultiDraw)
                        {
                            GraphicsManager.DrawSprite(instance.Element.textureId, instance.XStart, instance.YStart, instance.Rotation + 90, color);
                        }*/
                        //GraphicsManager.draw
                    }
                }
                //    layerCounter++;
                //}

                if (CurrentBrush == BrushMode.Paint && Manager.Project.Instance != null)
                {
                    try
                    {
                        int x, y;
                        x = ((GridEnabled) ? _mouseX : _mx) - Manager.Project.Instance.sprite_index.origin_x;
                        y = ((GridEnabled) ? _mouseY : _my) - Manager.Project.Instance.sprite_index.origin_y;

                        GraphicsManager.DrawSprite(
                            Manager.Project.Instance.sprite_index.name,
                            x,
                            y,
                            0, Color.Yellow);
                    }
                    catch { }
                }

                GraphicsManager.DrawSpriteBatch(false);

                if (_drag)
                {
                    if (Manager.Project.SelectedInstance != null)
                    {
                        GmsRoomInstance p = Manager.Project.SelectedInstance;
                        // drawing when moving
                        if (CurrentBrush == BrushMode.Move)
                        {
                            GraphicsManager.DrawSprite(
                                Manager.Project.SelectedInstance.editor_data.parent.instance_of.sprite_index.name,
                                /*Manager.Project.SelectedInstance.X +*/ (_mouseX - Manager.Project.SelectedInstance.instance_of.sprite_index.origin_x),
                                /*Manager.Project.SelectedInstance.Y +*/ (_mouseY - Manager.Project.SelectedInstance.instance_of.sprite_index.origin_y),
                                Manager.Project.SelectedInstance.rotation, Color.Red);
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

                            int newRotation = MathMethods.AngleDifference(MathMethods.PointDirection(p.x, p.y, _mx, _my), _rotateStart);
                            _rotateCurrent = ((int)p.rotation + newRotation + 360) % 360;

                            //Manager.MainWindow.statusLabelMousePos.Text = newRotation.ToString();

                            GraphicsManager.DrawSprite(
                                p.instance_of.sprite_index.name,
                                p.editor_data.XStart,
                                p.editor_data.YStart,
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
                                new Rectangle(p.editor_data.XStart, p.editor_data.YStart, p.editor_data.Width, p.editor_data.Height),
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

                DrawBackground();

                //GraphicsManager.DrawRectangle(new Rectangle(Offset.X, Offset.Y, Math.Min(Manager.Room.Width, this.Width) + 1, Math.Min(Manager.Room.Height, this.Height) + 1), Color.Orange, false);
                GraphicsManager.Scissor = new Rectangle(0, 0, this.Width, this.Height);



                // draw instances
                DrawInstances();

                // draw grid and higlights
                DrawGrid();

                OpenGL.glTexParameteri(OpenGL.GL_TEXTURE_2D, OpenGL.GL_TEXTURE_MAG_FILTER, OpenGL.GL_LINEAR);

                if (_drawMousePosition)
                {
                    drawRectangleAroundMouseOnGrid(new Rectangle(_mouseX, _mouseY, _gridX / _zoom, _gridY / _zoom));
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

        private void drawRectangleAroundMouseOnGrid(Rectangle rec)
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
            int width = (int)(snap.Width / _zoom);
            int height = (int)(snap.Height / _zoom);
            int offsetX = (int)(Offset.X);// / _zoom);
            int offsetY = (int)(Offset.Y);// / _zoom);
            int x = (int)((((position.X + offsetX) / width) * width) /** _zoom*/);
            int y = (int)((((position.Y + offsetY) / height) * height) /** _zoom*/);

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
                    form.Instance = Manager.Project.SelectedInstance;
                    form.ShowDialog();
                }
            }
        }

        /////

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (Manager.Room == null) return;

            Point snap = GetSnappedPoint(e.Location, new Size(_gridX / _zoom, _gridY / _zoom));

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
                            GmsRoomInstance p = Manager.Project.SelectedInstance;
                            this._rotateStart = MathMethods.PointDirection(p.x, p.y, _mx, _my);
                            Manager.MainWindow.statusLabelMousePos.Text = _rotateStart.ToString();
                        }
                    }

                    Manager.MainWindow.brushPlaceableUpdatePositionAndRotation();
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
                            this._onInstancePaint();
                            break;
                        case BrushMode.Move:
                            if (_drag)
                            {
                                if (Manager.Project.SelectedInstance != null)
                                {
                                    Manager.Project.SelectedInstance.x = _mouseX;
                                    Manager.Project.SelectedInstance.y = _mouseY;
                                }
                            }
                            _drag = false;
                            break;
                        case BrushMode.Rotate:
                            if (_drag)
                            {
                                if (Manager.Project.SelectedInstance != null)
                                {
                                    Manager.Project.SelectedInstance.rotation = _rotateCurrent;
                                    //(int)(Manager.Project.SelectedInstance.Rotation + pointDistance(Manager.Project.SelectedInstance.XCenter, Manager.Project.SelectedInstance.YCenter, _mx, _my)) % 360;
                                }
                            }
                            _drag = false;
                            break;

                    }
                    break;
            }

            Manager.MainWindow.brushPlaceableUpdatePositionAndRotation();

            // Force redraw
            Invalidate();
        }

        protected void _onInstancePaint()
        {
            if (Manager.Project.Instance == null) return;

            float rotation = 0.0f;

            if (Manager.MainWindow.brushOptionRandomizeCheckbox.Enabled)
            {
                float start = Helper.getDirFromInput(Manager.MainWindow.brushOptionRandomizeFrom);
                float _end = Helper.getDirFromInput(Manager.MainWindow.brushOptionRandomizeTo);

                float end = (start > _end) ? start : _end;
                start = (start > _end) ? _end : start;

                Random rnd = new Random();

                rotation = start + ((float)rnd.NextDouble() * (end - start));
            }

            GmsRoomInstance instance = new GmsRoomInstance()
            {
                x = _mouseX /*- Manager.Project.Instance.offsetX*/,
                y = _mouseY /*- Manager.Project.Instance.offsetY*/,
                instance_of = Manager.Project.Instance,
                rotation = rotation,
            };
            //instance.editor_data.Element = Manager.Project.Instance;
            instance.editor_data.Layer = Manager.Room.Layers[Manager.Room.LastUsedLayer].LayerDepth;

            Manager.Project.HighlightedInstance = instance;

            Manager.Room.instances.Add(instance);
            Manager.Project.regenerateInstanceList();
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

            __mx = (Offset.X + e.Location.X);
            __my = (Offset.Y + e.Location.Y);

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
                GmsRoomInstance found = null;
                foreach (GmsRoomInstance pinstance in Manager.Room.instances)
                {
                    //if (Manager.Room.Layers[Manager.MainWindow.tbLayerDropDown.SelectedIndex].LayerDepth != pinstance.editor_data.Layer)
                    //    continue;

                    double dist = pointDistance(pinstance.editor_data.XCenterZoomed, pinstance.editor_data.YCenterZoomed, _mx, _my);

                    if (dist > 300) continue;

                    if (dist < distance)
                    {

                        int _mxr = _mx;
                        int _myr = _my;
                        if (pinstance.rotation != 0)
                        {
                            Point rotated = RotatePoint(new Point(_mx, _my), new Point(pinstance.editor_data.XCenterZoomed, pinstance.editor_data.YCenterZoomed), (double)pinstance.rotation);
                            _mxr = rotated.X;
                            _myr = rotated.Y;
                        }


                        if (pinstance.editor_data.XStartZoomed <= _mxr)
                            if (pinstance.editor_data.YStartZoomed <= _myr)
                                if (pinstance.editor_data.XEndZoomed >= _mxr)
                                    if (pinstance.editor_data.YEndZoomed >= _myr)
                                    {
                                        distance = dist;
                                        found = pinstance;
                                    }
                    }
                }

                if (Manager.Project.HighlightedInstance != found)
                {
                    redraw = true;
                    Manager.Project.HighlightedInstance = found;
                }
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
                _mouseX = (GridEnabled) ? snap.X : _mx;
                _mouseY = (GridEnabled) ? snap.Y : _my;
                Manager.MainWindow.statusLabelMousePos.Text = "X: " + (_mouseX).ToString() + ", Y: " + (_mouseY).ToString();
                Manager.MainWindow.statusLabelMousePos.Text += " / RX:  " + _mx.ToString() + ", RY: " + _my.ToString()
                 + " / ZOOM" + this._zoom.ToString();
                Manager.MainWindow.statusStrip1.Refresh();
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
                    case BrushMode.Rotate: Cursor = _rotateCursor; break;
                    default: Cursor = Cursors.Default; break;
                }
            }
        }
    }
}
