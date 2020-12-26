using System.Drawing;

namespace Pango.Calculator.Domain.Colors
{
	public interface IColorProvider
	{
		Color GetColor(decimal value);
	}
}
