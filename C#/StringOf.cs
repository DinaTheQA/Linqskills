using System;
class StringOp
{
		static int StringLength(string str)
		{
				int i=0;
				try
				{
					for(i=0; ;i++)
					{
					char ch =str[i];
					}
				}
				catch(Exception ex)
				{
					return i;	
				}
				return 0;
		}
		static int NoOfWords(string str)
			{
				int wc=0;
				for(int i=0;i<str.length;i++)	
				{
					if(str[i]==' ' || (i+1)==str.length )
						wc++;
					
				}
				return wc;
			
			
			}
				static void Main()
				{
					Console.WriteLine("Enter any String");
					string str=Console.ReadLine();
					Console.WriteLine($"total char:{StringLength(str)}");
					Console.WriteLine($"total word:{NoOfWords(str)}");
				}
}