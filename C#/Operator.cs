using System;
class Point{
	int x;
	int y;
	public Point(int x=0,int y=0)
	{
		this.x=x;
		this.y=y;

	}
	public override string ToString()
	{
		return $"Point({x},{y})";
	}
	public static Point operator +(Point obj1,Point obj2)
	{
		return new Point((obj1.x+obj2.x),(obj1.y+obj2.y));
	}
	public static Point operator -(Point obj1,Point obj2)
	{
		return new Point((obj1.x-obj2.x),(obj1.y-obj2.y));
	}
	public static Point operator ++(Point obj1)
	{
		obj1.x++;
		obj1.y++;
		return obj1;
	}
	public static bool operator >(Point obj1,Point obj2)
	{
		if (obj1.x>obj2.x && obj1.y>obj2.y)
			return true;
		else
			return false;
	}
	public static bool operator <(Point obj1,Point obj2)
	{
		if (obj1.x<obj2.x && obj1.y<obj2.y)
			return true;
		else
			return false;
	}
}
class MainClass{
		static void Main(string[]args)
		{
			Point p1=new Point();
			Console.WriteLine(p1);//10,10

			Point p2=new Point(30);
			Console.WriteLine(p2);//30,10

			Point p3=new Point(y:40,x:60);//named args
			Console.WriteLine(p3);

			Point p4=p1+p2;
			Console.WriteLine(p4);//Point(20,10)

			Point p5=p3-p1;
			Console.WriteLine(p5);//Point(50,30)

			Point p6=new Point(20,20);
			Point p7=new Point(5,5);
				if(p6>p7)
					Console.WriteLine(p6+"Its Greater");
				else
					Console.WriteLine(p7+"Its Greater");
			
			p5++;
			Console.WriteLine(p5);//Point(51,31)

		}
}