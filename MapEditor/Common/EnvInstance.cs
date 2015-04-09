using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapEditor.Graphics;

namespace MapEditor.Common
{
	public class PlaceableInstance
	{
		public int X = 0;
		public int Y = 0;
		public int Layer = -1;
		public PlaceableElement Element = null;
		public int ID = -1;
		public int Rotation = 0;

		public int Width
		{
			get { return (Element == null) ? 0 : GraphicsManager.Sprites[Element.textureId].Width; }
		}

		public int WidthZoomed
		{
			get { return this.Width / Manager.MainWindow.roomEditor1._rPanel.Zoom; }
		}

		public int Height
		{
			get { return (Element == null) ? 0 : GraphicsManager.Sprites[Element.textureId].Height; }
		}

		public int HeightZoomed
		{
			get { return this.Height / Manager.MainWindow.roomEditor1._rPanel.Zoom; }
		}

		public int XStart
		{
			get { return (X) - (Element.offsetX); }
		}

		public int XStartZoomed
		{
			get { return this.XStart / Manager.MainWindow.roomEditor1._rPanel.Zoom; }
		}

		public int YStart
		{
			get { return (Y) - (Element.offsetY); }
		}

		public int YStartZoomed
		{
			get { return this.YStart / Manager.MainWindow.roomEditor1._rPanel.Zoom; }
		}

		public int XCenter
		{
			get { return (X); }
		}

		public int XCenterZoomed
		{
			get { return this.XCenter / Manager.MainWindow.roomEditor1._rPanel.Zoom; }
		}

		public int YCenter
		{
			get { return (Y); }
		}

		public int YCenterZoomed
		{
			get { return this.YCenter / Manager.MainWindow.roomEditor1._rPanel.Zoom; }
		}

		public int XEnd
		{
			get { return XStart + Width; }
		}

		public int XEndZoomed
		{
			get { return this.XEnd / Manager.MainWindow.roomEditor1._rPanel.Zoom; }
		}

		public int YEnd
		{
			get { return YStart + Height; }
		}

		public int YEndZoomed
		{
			get { return this.YEnd / Manager.MainWindow.roomEditor1._rPanel.Zoom; }
		}
	}
}
