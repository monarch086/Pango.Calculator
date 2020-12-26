namespace Pango.Calculator.Domain
{
	public interface ICalculator
	{
		decimal Calculate(Operation operation, params decimal[] operands);
	}
}
