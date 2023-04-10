using System;
class hello
{
	public static void Main(String[ ] args )
	{
		//  TABLE PROGRAM
	 int i=1,multi=0;
	Console.WriteLine(" enter the number");
	int num=int.Parse(Console.ReadLine());
	while(i<=10)
		{
	   	multi=num*i;   
		Console.WriteLine(" \n "+num +  " * "  + i  + " = "  + "  " + multi);
		//Console.WriteLine("  \n  {0} * {1} = {2} ",num,i,multi);
		i=i+1;
		}
		

	 /*    TEMPERATURE CELCIUS TO FARNEHEHIT 
	float  temp_f,temp_c;
	Console.WriteLine(" enter the temperature in celcius ");
	temp_c= float.Parse(Console.ReadLine());
	temp_f=(temp_c * 9/5 +32);
	Console.WriteLine(" temperature is  farnheit : "+temp_f);	
	*/

	/*	(IF LADDER)   CHARACTER FIND THE ALPHABET OR SPECIAL CHARACTER
	char ch;
	Console.WriteLine(" enter the character ");
	ch=char.Parse(Console.ReadLine());	
	if((ch>= 65 && ch <=90) || (ch>=97 && ch<=120 ))
 	{
 	Console.WriteLine(" alphabet ");

	 }
 	else if ( (ch>=48  && ch<=57))
	 {
 	Console.WriteLine(" digit ");
 	}
 	else if ((ch>=32 && ch<=47) || ( ch>=58 && ch<=64)|| (ch>=91 && ch<=96 ))
 	{
 	Console.WriteLine(" special character ");
 	}
 	else
 	{
 	Console.WriteLine(" invalid char ");
   	}
	*/
	
	/*   PALINDROME NO.
	
	int n,rem,sum=0,temp;
	Console.WriteLine(" enter any number");
	n=int.Parse(Console.ReadLine());
	temp=n;
	while(n>0)
	{
		rem=n%10;
		sum= (sum*10) + rem;
		n=n/10;
	}
	if(temp==sum)
	{
	Console.WriteLine(" Palindrome no.");	
	}
	else
	{
	Console.WriteLine(" not a palindrome no.");
	}    */
 
	

	} 

}