using System;

public class Program
{
	static void Main()
	{
        var calc4 = new Calculator4();
        calc4.GetNumber("First");
        calc4.GetNumber("Second");
        calc4.AddNumbers();
        PrintResult(calc4);
        Console.ReadKey();
    }
}
