using System;

namespace Pango.Calculator.Domain.Commands
{
	class DivideCommand : ICalculationCommand
	{
		public Operation Operation => Operation.Divide;

		public decimal Run(params decimal[] args)
		{
			args.ValidateTwoOperands();

			var firstOperand = args[0];
			var secondOperand = args[1];

			if (firstOperand == 0)
				throw new InvalidOperationException("Divisions by zero are not allowed.");

			return firstOperand / secondOperand;
		}
	}
}
