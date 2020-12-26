using System.Drawing;

namespace Pango.Calculator.Web.Model
{
	public class CalculationResponse
	{
		public CalculationResponse(decimal result) => Result = result;

		public decimal Result { get; set; }
	}

	public class CalculationColorResponse : CalculationResponse
	{
		public CalculationColorResponse(decimal result, Color color) : base(result) => Color = color;

		public Color Color { get; set; }
	}
}
