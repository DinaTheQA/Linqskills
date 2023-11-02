using System;
class MyBase{
	public virtual void Display(){
	Console.WriteLine("Disply form mybase");
	}
}
class Driver1 : Mybase{
	public override void Disply(){
	Console.WriteLine("Disply form Driver1");
	}
}
class Driver2 : MyBase{
	public override void Disply(){
	Console.WriteLine("Disply from");
	}
}
class MainClass{
	static void Main(string [] args){
		Driver d1;
		d1= new Driver1();
		d1.Disply();
		Driver2 d2=new Driver2();
		d2.Disply();

		Mybase baseObj;
		baseObj=d1; //upcasting
		baseObj.Disply();//Driver1
		
		baseObj=d2;
		baseObj.Disply();//Driver2
	
		Driver2 d3=(Driver2)baseObj;//downcasting
		d3.Disply();

		Mybase base2=new Driver1();//correct
		Driver2 d4=(Driver2)new Mybase();//syntactically correct but logically incorrect`

		d4.Display();
	}
}