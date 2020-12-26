using System;

namespace Pango.Calculator.Domain.Commands
{
	class MultiplyCommand : ICalculationCommand
	{
		public Operation Operation => Operation.Multiply;

		public decimal Run(params decimal[] args)
		{
			args.ValidateTwoOperands();

			var firstOperand = args[0];
			var secondOperand = args[1];

			return firstOperand * secondOperand;
		}
	}
}
