using System;
class SumNum
{
 static int Factor(int num)
	{
        int fact = 1;
        for (int i = 1; i <= num; i++) 
		{
            fact*=i;
        }
        return fact;
	}
	static void printSeriesSum(int term	)
	{
		float sum=0.0f;
		for (int i=1;i<=term;i++)
		{
			sum=sum+(float)i/Factor(i);
			Console.Write($"{i}/{i}! ");
			if (i<term)
				
			Console.Write("+");	
		}
		Console.WriteLine($"={sum}");   // ($"\b={sum}")
	}
	static void Main()
	{
		int term;
		Console.WriteLine("Enter the Number");
		term	=Int32.Parse(Console.ReadLine());
		printSeriesSum(term);
	}
}

