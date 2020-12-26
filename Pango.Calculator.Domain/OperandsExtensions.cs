using System;

namespace Pango.Calculator.Domain
{
	internal static class OperandsExtensions
	{
		public static void ValidateTwoOperands(this decimal[] operands)
		{
			if (operands.Length > 2 || operands.Length < 2)
				throw new ArgumentException("The operation requires 2 operands.");
		}
	}
}
