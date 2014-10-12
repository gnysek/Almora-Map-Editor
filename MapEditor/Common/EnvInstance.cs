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
			//get { return (Element == null) ? 0 : GraphicsManager.Sprites[Element.textureId].Width / Manager.MainWindow.roomEditor1._rPanel.Zoom; }
			get { return (Element == null) ? 0 : GraphicsManager.Sprites[Element.textureId].Width; }
		}

		public int Height
		{
			//get { return (Element == null) ? 0 : GraphicsManager.Sprites[Element.textureId].Height / Manager.MainWindow.roomEditor1._rPanel.Zoom; }
			get { return (Element == null) ? 0 : GraphicsManager.Sprites[Element.textureId].Height; }
		}

		public int XStart
		{
			//get { return (X / Manager.MainWindow.roomEditor1._rPanel.Zoom) - (Element.offsetX / Manager.MainWindow.roomEditor1._rPanel.Zoom); }
			get { return (X) - (Element.offsetX); }
		}

		public int YStart
		{
			//get { return (Y / Manager.MainWindow.roomEditor1._rPanel.Zoom) - (Element.offsetY / Manager.MainWindow.roomEditor1._rPanel.Zoom); }
			get { return (Y) - (Element.offsetY); }
		}

		public int XCenter
		{
			get { return (X); }
		}
		public int YCenter
		{
			get { return (Y); }
		}

		public int XEnd
		{
			get { return XStart + Width; }
		}

		public int YEnd
		{
			get { return YStart + Height; }
		}

		//public int offsetX
		//{
		//    get { return X - Element.offsetX; }
		//}

		//public int offsetY
		//{
		//    get { return Y - Element.offsetY; }
		//}
	}
}
