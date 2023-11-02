using System;
class MyBase
	{
		public MyBase()
			{
				Console.WriteLine("constr from my base");
			}
		static MyBase()
			{
				Console.WriteLine("static from my base");
			}
		~MyBase()
			{
				Console.WriteLine("static from my base");
			}
	}	

class Derive1 : MyBase
		{
		public Derive1()
			{
				Console.WriteLine("constr from my derive1");
			}
		static Derive1()
			{
				Console.WriteLine("static from my derive1");
			}
		~Derive1()
			{
				Console.WriteLine("static from my derive1");
			}
		}
class Derive2 : Derive1
		{
		public Derive2()
			{
				Console.WriteLine("constr from my derive2");
			}
		static Derive2()
			{
				Console.WriteLine("static from my derive2");
			}
		~Derive2()
			{
				Console.WriteLine("static from my derive2");
			}
		}

class MainClass{

	static void Main(string []args)
		{
		Derive2 d=new Derive2();	
		}
}
