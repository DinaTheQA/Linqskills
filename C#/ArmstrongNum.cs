using System;
class Armstrong
{
	static int DigitCount(int number)
	{
			int count=0;
		while (number!=0) 
		{
           count++;
            number /= 10;
        }

        return count;
	
	}
	static int Power (int base,int exp)
	{
		int pow=1;
		for (int i=1;i<=exp;i++)
		{
			pow*=base;
		}
		return pow;
	}
	static int PowerSum(int number)
	{
			int count =DigitCount(Number);
			int powSum=0;
			
			while(number!=0)
			{
				powSum=powSum+Power(number%10,count);
				number/=10;
			}
			return powerSum;
	}
	static int PrintArmstrong(int start)
	{
		Console.WriteLine("First 5 Armstrong number starting from {start} are:");
		int count=5;
		while(count >0)
		{
				if(PowerSum(start)==start)
				{
					Console.WriteLine($"{start}");
					count--;
				
				}
				start++;
		}
		return false;
		
	}
		static int PrintArmstrong(int start,int count)
	{
		Console.WriteLine("First 5 Armstrong number starting from {start} are:");
		int count=5;
		while(count >0)
		{
				if(PowerSum(start)==start)
				{
					Console.WriteLine($"{start}");
					count--;
				
				}
				start++;
		}
		return false;
		
	}
	static void Main(string[] args)
	{	
		int start;
		Console.WriteLine("Enter start value:");
		start=Int32.Parse(Console.ReadLine());
		PrintArmstrong(start);
	}
}





