using System;

namespace Pango.Calculator.Domain.Commands
{
	internal class SubstructCommand : ICalculationCommand
	{
		public Operation Operation => Operation.Subtract;

		public decimal Run(params decimal[] args)
		{
			args.ValidateTwoOperands();

			var firstOperand = args[0];
			var secondOperand = args[1];

			return firstOperand - secondOperand;
		}
	}
}
