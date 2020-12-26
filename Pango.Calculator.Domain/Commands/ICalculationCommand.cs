namespace Pango.Calculator.Domain.Commands
{
	internal interface ICalculationCommand
	{
		Operation Operation { get; }

		decimal Run(params decimal[] args);
	}
}
