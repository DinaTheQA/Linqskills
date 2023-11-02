using System;
namespace DelegateExp{
//delegate decl
	public delegate void Mydelegate(int x,int y);
class Test1
{
	public void Add(int a, int b)
	{
		Console.WriteLine($"Add is:{a+b}");
	}
	public static void Substract(int a, int b)
	{
		Console.WriteLine($"Subtract is:{a-b}");
	}
}
class Test2
{
	public static void Multiply(int a, int b)
	{
		Console.WriteLine($"Multiplication is:{a*b}");
	}
	public static void Divide(int a, int b)
	{
		Console.WriteLine($"Divide is:{a/b}");
	}
}
class MainClass
{
	static void Main(string[] args)
	{
		Test1 t1= new Test1();
		Mydelegate del=new Mydelegate(Test1.Substract);//delegate intantion

		del +=new Mydelegate(t1.Add);
		del +=Test2.Multiply;
		del +=Test2.Divide;

		del(30,20);//delegate invocation
		del -=Test2.Multiply;
		del(100,20);
	}

}
}