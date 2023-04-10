using System;
class Cdk
{
	 public static void Main(String[ ] args)
	{
	      //   PRIME  NO. PROGRAMS
	/*
			int i=1,count=0;	         
	        Console.WriteLine(" enter any number");
	        int  num=int.Parse(Console.ReadLine());			
	
	        while(i<=num)
	      {
			if(num%i==0)
			count++;
			i=i+1;
	      }
		if (count==2)
		Console.WriteLine(" prime no.");
		else
		Console.WriteLine(" not a prime no."); 
	
		*/
		
	/* 
	 int i=2;
      while(i<num)
	{
	if(num%i==0) 
	{
	  Console.WriteLine(" not prime no.");
		break;
	}
	i=i+1;
	}
	if(i==num)
	Console.WriteLine(" prime no.");
	*/
	
	/*
		 
	 Console.WriteLine(" enter any nunmber");
     int num=Convert.ToInt32(Console.ReadLine()); 
	 bool flag=true;
	  int i=2;
	while(i<=num/2)
	{
	  flag=false;
	{
                   Console.WriteLine(" prime is not ");
	break;
	}
  
	i=i+1;
	}
	if (flag==true)
	{
	Console.WriteLine(" no. is prime");
 	}  

	*/
	
		/* char ch;		
		Console.WriteLine(" enter any character");
		 ch =Convert.ToChar(Console.ReadLine());
		

		//if ((ch=='a' || ch=='e'  || ch=='i' ||ch=='o' || ch=='u')  ||(  ch=='A'  || ch=='E'  || ch=='I' || ch=='O' || ch=='U'))   
		{			  
		Console.WriteLine(" Vowels");
		}
		else
		{
		Console.WriteLine(" constant");
		}  */	
		

		/*  Count the digit of the number

		int num,count=0;
		Console.WriteLine(" enter any number");
		num=Convert.ToInt32(Console.ReadLine());
		while(num>0)
		{
		     num=num/10;
		     count=count+1;		
		}
		Console.WriteLine(" digit count "+count);
		*/
		

		/*
		Count the number  Even and odd :

	
		 int Count=0,Count1=0,rem;
		Console.WriteLine(" enter the number");
		int  num=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(" original number is : "+num);
		Console.Write(" reverse number ");
	
		while(num>0)
		{
			rem=num%10;
			Console.Write(rem);
			if(rem%2==0)
			{
				Count++;
			 }
			else
			{
		   	       Count1++;
			}
			num=num/10;		
		}
		
			
			Console.WriteLine();
		Console.WriteLine(" count  of even number"+Count);
		Console.WriteLine(" count  of even number"+Count1);

		*/
		/*		
			DOUBLE  NUMBER OF A REVERSE  NUMBER
		 int rev,n,doub=0;
		Console.WriteLine(" enter the number");
		int  num=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(" original number is : "+num);
		Console.Write(" reverse number ");		 
		while(num>0)
		{
			rev=num%10;
			Console.Write(rev);
			n=rev;
			doub= doub + n*n;
			num=num/10;	
		}
		Console.WriteLine();
		Console.WriteLine(" double of digit "+doub);   */

		/*
		WEEK NAME PRINT USING SWITCH CASE  
		
		Console.WriteLine(" enter any number");
		int num=Convert.ToInt32(Console.ReadLine());
 		switch(num)
		{
		case 1:
		Console.WriteLine("  Monday");		
		break;
		case 2:
		Console.WriteLine("  Tuesday");		
		break;
		case 3:
		Console.WriteLine("  wednesday");		
		break;
		case 4:
		Console.WriteLine("  thursday");		
		break;
		case  5:
		Console.WriteLine("  friday");		
		break;
		case 6:
		Console.WriteLine("  saturday");		
		break;
		case 7:
		Console.WriteLine("  sunday");		
		break
		default:
		Console.WriteLine(" invalid number");
		break;		
	}	
			
		*/

		/*
			CUBE OF THE DIGIT 
		int cube = 0, rem,sum=0,rev=0;
		Console.WriteLine(" enter any number");
		int num = Convert.ToInt32(Console.ReadLine());
		while(num>0)
     		      {
			rem = num % 10;
			rev=rev*10+rem;
			// Console.WriteLine(rem);
			cube = rem * rem * rem;
			//Console.WriteLine(" cube of the digit :" + cube);
			sum=sum+cube;
			num = num / 10;
			

		        }
			Console.WriteLine("reverse no:"+rev);
			Console.WriteLine(" sum of  cube digit"+sum);
			*/

		/*

		DOUBLE OF THE DIGIT
		int doub = 0, rem,sum=0,rev=0;
		Console.WriteLine(" enter any number");
		int num = Convert.ToInt32(Console.ReadLine());
		while(num>0)
     		      {
			rem = num % 10;
			rev=rev*10+rem;
			// Console.WriteLine(rem);
			doub = 2* rem ;
			Console.WriteLine("double of the  digit "+doub);
			sum=sum+doub;
			num = num / 10;
			
		        }
			Console.WriteLine("reverse no:"+rev);
			Console.WriteLine(" sum of  double digit"+sum);
			*/
			
			// reverse number			
			int rev;
			Console.WriteLine(" enter any number");
			int num=Convert.ToInt32(Console.ReadLine());
			while(num!=0)
			{
				rev=num%10;
				Console.Write(rev);
				num=num/10;
				}
					
}	
}