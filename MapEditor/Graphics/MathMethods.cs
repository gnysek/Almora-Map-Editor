/* 
 * Most of this code copied from:
 * 
 * Copyright (c) Timothy Leonard, Binary Phoenix. All rights reserved.
 * 
 */

using System;

namespace MapEditor.Graphics
{
	/// <summary>
	/// Generic math methods.
	/// </summary>
	public static class MathMethods
	{
		#region Methods

		/// <summary>
		/// Converts an angle in degrees to an angle in radians.
		/// </summary>
		/// <param name="degrees">Angle to convert</param>
		/// <returns>Converted degree.</returns>
		public static double DegreesToRadians(double degree)
		{
			// Return the converted degree.
			return degree * (Math.PI / 180.0f);
		}

		/// <summary>
		///	Converts an angle in radians to an angle in degrees.
		/// </summary>
		/// <param name="radians">Angle to convert</param>
		/// <returns>Converted radian.</returns>
		public static double RadiansToDegree(double radian)
		{
			// Return converted radian.
			return radian * (180.0f / Math.PI);
		}

		/// <summary>
		/// Calculates the closest power from the given number, and desired power.
		/// </summary>
		/// <param name="integer">Number to find closest power of.</param>
		/// <param name="power">The desired power range to check.</param>
		/// <returns>Closest power of the given number.</returns>
		public static int Pow(int number, int power)
		{
			// Increment variable.
			int i = 1;

			// Keep incrementing powers until the incremented number is greater than the given number.
			while (i < number)
				i *= power;

			// Return closest power of given number.
			return i;
		}

		/// <summary>
		/// Division that divides towards negative.
		/// </summary>
		/// <param name="a">The dividend.</param>
		/// <param name="b">The divisor.</param>
		/// <returns></returns>
		public static int DivideTowardsNegative(int a, int b)
		{
			// Return result.
			return a >= 0 ? a / b : (a / b);
		}

		public static int PointDirection(int x1, int y1, int x2, int y2)
		{
			//return (int) ((180 / Math.PI) * Math.Atan((x2 - x1) / (y2 - y1)));
			//dir = radtodeg(arctan2(y1-y2,x2-x1));
			int dir = (int)(RadiansToDegree(Math.Atan2(y1 - y2, x2 - x1)) % 360);
			return (dir >= 0) ? dir : 360 + dir;
		}

		public static int AngleDifference(int dir1, int dir2)
		{
			//return ((((argument0 - argument1) mod 360) + 540) mod 360) - 180;
			return ((((dir1 - dir2) % 360) + 540) % 360) - 180;
		}

		#endregion
	}
}
