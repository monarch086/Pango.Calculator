using System.Drawing;

namespace Pango.Calculator.Domain.Colors
{
	public class ColorProvider : IColorProvider
	{
		private Color[] colors = { Color.Green, Color.Red };
		
		public Color GetColor(decimal value)
		{
			return IsOdd(value) ? colors[1] : colors[0];
		}

		private bool IsOdd(decimal value) => value % 2 > 0;
	}
}
