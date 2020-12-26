using Pango.Calculator.Domain.Commands;
using System;

namespace Pango.Calculator.Domain
{
	internal class SumCommand : ICalculationCommand
	{
		public Operation Operation => Operation.Sum;

		public decimal Run(params decimal[] args)
		{
			args.ValidateTwoOperands();

			var firstOperand = args[0];
			var secondOperand = args[1];

			return firstOperand + secondOperand;
		}
	}
}
