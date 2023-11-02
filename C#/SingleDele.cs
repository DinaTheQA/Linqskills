using System;
namespace DelegateExp{
//delegate decl
	public delegate int Mydelegate(int x,int y);
class Test1
{
	public int Add(int a, int b)
	{
		return a+b;
	}
	public static int Substract(int a, int b)
	{
		return a-b;
	}
}
class Test2
{
	public static int Multiply(int a, int b)
	{
		return a*b;
	}
	public static int Divide(int a, int b)
	{
		return a/b;
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

		int result =del(30,20);//delegate invocation
		Console.WriteLine($"Result is:{result}");
	}

}
}