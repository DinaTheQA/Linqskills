using System;

class CharCount
{
    static int StringLength(string str)
    {
        int count = 0;

        foreach (char c in str)
        {
            count++;
        }

        return count;
    }

    static int NoOfWords(string str)
    {
        int wc = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ' || (i + 1) == str.Length)
            {
                wc++;
            }
        }

        return wc;
    }

    static void PrintMaxLengthWord(string str)
    {
			int pos=0;
			int max=0;
			int c=0;
	for(int i=0; i<str.Length;i++)
	{
		if(str[i]==' '||(i+1)==str.Length)
		{
			if(c>max)	
			{
				max=c;
				pos=i-c;
			}
			c=0;
		}
		else
			c++; 
	}
		Console.WriteLine($"Max Length word max {max}\t pos: {pos}");
			for(int i=pos;i<=(max+pos); i++)
			{
				Console.WriteLine(str[i]);
			}
 }

    public static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        Console.WriteLine($"Total Chars: {StringLength(str)}");
        Console.WriteLine($"Total Words: {NoOfWords(str)}");
        //Console.WriteLine($"Maximum Length of Words: {PrintMaxLengthWord(str)}");
    }
}