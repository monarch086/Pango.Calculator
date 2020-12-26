namespace Pango.Calculator.Web.Model
{
	public class CalculationRequest
	{
		public int Operation { get; set; }
		public decimal[] Operands { get; set; }
	}
}
