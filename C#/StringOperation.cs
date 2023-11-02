using System;
class PrintChar
{
	static void Main()
	{
		Console.WriteLine("Enter a value");
		string str=Console.ReadLine();
		int c=0;
		foreach(var ch in str)
		{
			c++;
		}
		Console.WriteLine($"Totol chars:{c}");	
	
	}


}