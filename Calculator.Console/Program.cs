using System;
using Calculator;

class Program
{
	static void Main()
	{
		float? previousResult = null;

		while (true)
		{
			Prompts.PrintWelcomeMenu();
			Prompts.PrintOptions();
			Console.WriteLine("Enter a number or '5' to exit: ");
			string? OptionChoice = Console.ReadLine();

			if (OptionChoice == "5")
			{
				Console.WriteLine("Exiting succesfully");
				break;
			}

			float Number1Converted, Number2Converted;

			if (previousResult.HasValue)
			{
				Console.WriteLine("Using previous result: " + previousResult.Value);
				Number1Converted = previousResult.Value;
			}
			else
			{
				Console.WriteLine("Enter number 1: ");
				string? Number1 = Console.ReadLine();
				if (string.IsNullOrEmpty(Number1)) throw new ArgumentNullException(nameof(Number1));
				Number1Converted = float.Parse(Number1);
			}

			Console.WriteLine("Enter number 2: ");
			string? Number2 = Console.ReadLine();
			if (string.IsNullOrEmpty(Number2)) throw new ArgumentNullException(nameof(Number2));
			Number2Converted = float.Parse(Number2);

			switch (OptionChoice)
			{
				case "1":
					previousResult = Evaluator.Eval("+", Number1Converted, Number2Converted);
					Console.WriteLine($"{Number1Converted} + {Number2Converted} = {previousResult}");
					break;
				case "2":
					previousResult = Evaluator.Eval("-", Number1Converted, Number2Converted);
					Console.WriteLine($"{Number1Converted} - {Number2Converted} = {previousResult}");
					break;
				case "3":
					previousResult = Evaluator.Eval("*", Number1Converted, Number2Converted);
					Console.WriteLine($"{Number1Converted} * {Number2Converted} = {previousResult}");
					break;
				case "4":
					if (Number2Converted == 0)
					{
						Console.WriteLine("Cannot divide by zero.");
					}
					else
					{
						previousResult = Evaluator.Eval("/", Number1Converted, Number2Converted);
						Console.WriteLine($"{Number1Converted} / {Number2Converted} = {previousResult}");
					}
					break;
				default:
					Console.WriteLine("Invalid option, please try again.");
					break;
			}
		}
	}
}