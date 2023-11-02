using System;
class Singleton
{
	static Singleton obj;
	private Singleton(){}

	public static Singleton GetObject()
	{
		if(obj==null)
		obj=new Singleton();//object creation
			return obj;
		
	}
	
	public static Singleton GetObjectRef
		{
			get{
				if (obj==null)
					obj=new Singleton();//object creation
				return obj;
		
			}
	
		}
	public void Display()
	{
		Console.WriteLine("Display from singleton");
	}

}
class MainClass
{
	static void Main()
		{
	Singleton obj=Singleton.GetObject();
	obj.Display();
	//Singleton obj=Singleton.GetObjectRef();
		}

}