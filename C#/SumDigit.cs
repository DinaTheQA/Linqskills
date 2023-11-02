using System;
class SumDigits
{
	static int SumOfDigits(int n)
	{
		int sum=0;
		while(n!=0)
		{
			sum +=n%10;
			n=n/10;	
			
		}
		return sum;	
	}
	static bool CheckForPrime(int n)
	{
		for (int i=2;i<=n/2;i++)
		{
			if(n%i==0)
			{
				return false;
			}
			return true;
		}
	}
	static void PrintIfSumOfDigitIsPrime(int start , int end)
	{
			for (int num=start;num<=end;num++)
			{
				if(CheckForPrime(SumOfDigits(num)))
				{
					Console.WriteLine($"{num}\t {SumOfDigits(num)}");
				}
			}
	}
static void Main(string[] args)
		{
			int start,end;
			Console.WriteLine("Enter lower limit value:");
			start=Int32.Parse(Console.ReadLine());
			Console.WriteLine("Enter Upper Limit value");
			end=Int32.Parse(Console.ReadLine());
			
			Console.WriteLine("Number whose sum of digit is prime ::");
			
			PrintIfSumOfDigitIsPrime(start,end);
		
		}

}
