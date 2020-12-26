using Pango.Calculator.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pango.Calculator.Domain
{
	public class Calculator : ICalculator
	{
		private Dictionary<Operation, ICalculationCommand> commands;

		public Calculator()
		{
			commands = CreateCommands();
		}

		private Dictionary<Operation, ICalculationCommand> CreateCommands()
		{
			commands = new Dictionary<Operation, ICalculationCommand>();

			var commandType = typeof(ICalculationCommand);
			var types = AppDomain.CurrentDomain.GetAssemblies()
				.SelectMany(s => s.GetTypes())
				.Where(p => commandType.IsAssignableFrom(p) && p.IsClass);

			foreach (var item in types)
			{
				AddCommand(commands, Activator.CreateInstance(item) as ICalculationCommand);
			}

			return commands;
		}

		private void AddCommand(IDictionary<Operation, ICalculationCommand> commands, ICalculationCommand command)
		{
			if (commands.ContainsKey(command.Operation))
				throw new InvalidOperationException($"The requested command {command.Operation} can not be added more than once.");

			commands.Add(command.Operation, command);
		}

		public decimal Calculate(Operation operation, params decimal[] operands)
		{
			var commandExist = commands.TryGetValue(operation, out ICalculationCommand command);
			if (!commandExist)
				throw new InvalidOperationException("The requested operation is not supported yet");

			return command.Run(operands);
		}
	}
}
