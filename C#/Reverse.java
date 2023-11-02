class ReverseNum
{
 	public static void main(String[] args)
	{
	Scanner sc = new Scanner(System.in);
	System.out.println("Enter a Number")
	int a=sc.nextInt();
	int temp=0;
	int copy=a;
	int rev=0;
	while(num !=0){
		temp=a%10;
		rev=rev*10+temp;
		a=a/10;
	}
	System.out.println(" :" +rev);
	
}