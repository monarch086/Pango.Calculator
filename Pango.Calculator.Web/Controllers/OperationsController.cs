using Microsoft.AspNetCore.Mvc;
using Pango.Calculator.Domain;
using Pango.Calculator.Domain.Colors;
using Pango.Calculator.Web.Model;

namespace Pango.Calculator.Controllers
{
	[Route("api/operations")]
	[ApiController]
	public class OperationsController : ControllerBase
	{
		private readonly ICalculator calculator;
		private readonly IColorProvider colorProvider;

		public OperationsController(ICalculator calculator, IColorProvider colorProvider)
		{
			this.calculator = calculator;
			this.colorProvider = colorProvider;
		}

		[HttpPost("calculate")]
		public CalculationResponse Calculate([FromBody] CalculationRequest request, [FromQuery] bool colored = false)
		{
			var result = calculator.Calculate((Operation)request.Operation, request.Operands);

			if (colored)
			{
				var color = colorProvider.GetColor(result);
				return new CalculationColorResponse(result, color);
			}

			return new CalculationResponse(result);
		}
	}
}
