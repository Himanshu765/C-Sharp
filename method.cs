using System;
class Hello
{
	/*
	 static void sum (int [] a)      // no return type with parameters
	 {
		 int i=0;
		 int sum=0;
		 while(i<a.Length)
		 {
			 sum=sum+a[i];
			 i=i+1;
		 }
		 Console.WriteLine(" sum is "+sum);
	 }	 
	
			static void Main()
			{
					int [] arr={1,2,3,4,5};
					sum(arr);
			
			}
		*/

		
	/*
	static int  Add (int [] a)      // with  return type with parameters
	 {
		 int i=0;
		 int sum=0;
		 
		 while(i<a.Length)
		 {
			 sum=sum+a[i];
			 i=i+1;
		 }
		 
		  return sum ;
	 }	 
	
			static void Main()
			{
				
					int [] arr={1,2,3,4,5};
					int s=Add(arr);
					Console.WriteLine(" sum of array elements "+s);
			
			}
			
		*/
		
		//            without return type and with parameters
	/*	
	  static 	void even (int []a)
		{
	     int i=0;
		 
		while(i<a.Length)
			{
				if(a[i] %2==0)
				{
					Console.WriteLine(" even number"+a[i]);
				//Count=Count+1;
				}		                                   
				else
				{
					Console.WriteLine(" odd number"+a[i]);
				  //  Count1=Count1+1 ;         
	
				}
			i++;				
	
			}
				//Console.WriteLine(" count the even number"+Count);
				//Console.WriteLine(" count the odd number"+Count1);
			
		}

			static void Main()
			{
				int [] arr= {11,22,33,55,3,6,8};
				even(arr);
				
				
			}
*/
	
	//WITH RETURN TYPE AND WITH PARAMETER
	/*	static string  even(int []a)
	{
		string result=" ";
	     int i=0;
		 // int count=0,count1=0;
		while(i<a.Length)
			{
				if(a[i] %2==0)
				{
				result = " even number";
				Console.WriteLine(result);
				//count=count+1;
				}		                                   
				else
				{
					result = " odd number";
					Console.WriteLine(result);
				   //count1=count1+1 ;         
	
				}
				i++;		
			}
				//Console.WriteLine(" count the even number"+count);
				//Console.WriteLine(" count the odd number"+count1);

		return result ;    //  return count+count1;
		
	}

			static void Main()
			{
				int [] arr= {11,22,33,55,3,6,8};
				string  s =even(arr);
				 Console.WriteLine(" "+s);
		
				
			}
}			
		*/	
			/*
						SEARCHING THE ELEMENTS :  WITHOUT RETURN TYPE AND WITH PARAMETER 
				static void search(int [] a)
				{  
					bool flag= false;
					Console.WriteLine(" enter the element");
					int search=Convert.ToInt32(Console.ReadLine());
					for (int i=0;i<a.Length;i++)
					{
						if(a[i]==search)
						{
							flag=true;
							Console.WriteLine(" element id found ");
							break;
						}
					}
				
						if(flag==false)
						{
						Console.WriteLine(" element is not found ");
						}
				} 
				static void Main()
				{
					int [] arr={22,11,33,44,55,66};
					search(arr);
				}
		*/
		/*
		
			static string  search(int [] a)
				{
						string m=" ";
					bool flag= false;
					Console.WriteLine(" enter the element");
					int search=Convert.ToInt32(Console.ReadLine());
					for (int i=0;i<a.Length;i++)
					{
						if(a[i]==search)
						{
							flag=true;
						m=" element id found ";
							break;
						}
					}
				
						if(flag==false)
						{
						m=" element is not found ";
						}
						
						return m;
				} 
				static void Main()
				{
					int [] arr={22,11,33,44,55,66};
				string s	=search(arr);
				Console.WriteLine(s);
					
				}
}		
*/
		
		/*
		static int [] sortasc(int [] a)
		{
			int i=0;
			int j;
			int temp=0;
			while(i<a.Length)
			{
				j=i+1;
				while(j<a.Length)
				{
					if (a[i]>a[j])
					{
						temp=a[i];
						a[i]=a[j];
						a[j]=temp;
					}
					j++;
				}
					
					i++;
			}
				return a ;
	
		}
			
			static void Main()
		{
				int[] arr={1,22,4,2,6,5};
				int [] x=sortasc(arr);
			for(int i=0;i<arr.Length;i++)
			{
				Console.WriteLine(" "+x[i]);
			}				
		
	    }    */
		
		/*
		static void prime(int [] a)
			{
			int j=0;
			Console.Write("********************");
			Console.WriteLine();
			while(j<a.Length)			
			{
				Console.Write(a[j]+" ");
				int k=1;
				int count=0;
				while(k<=a[j])
				{
					if(a[j]%k==0)
					{
					count++;
					}
					k++;
				}
			if(count==2)
			  Console.WriteLine(" prime no");
			else
			Console.WriteLine(" not  a prime no.");
		         j++;
			}					
			}
			
			static void Main()
			{
				int [] arr={2,3,6,9,8};
				prime(arr);
				
			}
*/
		/*
		
		with return types  and with arguments 
		
			static string  prime(int [] a)
			{
			int i=0;
			string s=" ";
			
			Console.Write("********************");
			Console.WriteLine();
			while(i<a.Length)			
			{
				Console.Write(a[i]+" ");
				int k=1;
				int count=0;
				while(k<=a[i])
				{
					if(a[i]%k==0)
					{
					count++;
					}
					k++;
				}
			if(count==2)
			{
			  s=" prime no";
		  Console.WriteLine(s);
			}
			else
			{
				s =  " not  a prime no.";
			Console.WriteLine(s);
			}
		         i++;
			}	
					return s ;
			}
			
			static void Main()
			{
				int [] arr={2,3,6,9,8,7};
				string p =prime(arr);
				Console.WriteLine(p);
				}
	
*/
/*
	reverse elements (without  return type and  with parameters)
	
		static 	void  rev(int []a)
		{
			Console.WriteLine(" REVRSE ELEMENTS ");
			int j=0;
			while(j<a.Length)
		{
			
			Console.WriteLine(a[j]+" ");
			j++;
		}
		
			int k;
			k=a.Length-1;
			Console.WriteLine();
			Console.WriteLine(" array  reverse elements");
			while(k>=0)
		{
			Console.Write(a[k]+" ");
			k--;
		}
		}
			static void Main()
		 {
			 int [] arr={ 2,3,4,5,6,7};
			 rev(arr);
		 }

*/
/*
		with return type and with parameter (reverse  element)
		static int[ ]  rev(int []a)
		{
			
			Console.WriteLine(" ARRAY  ELEMENTS ");
			int j=0;
			while(j<a.Length)
		{
			
			Console.WriteLine(a[j]+" ");
			j++;
		}
		
			int k;
			k=a.Length-1;
			Console.WriteLine();
			Console.WriteLine(" array  reverse elements");
			while(k>=0)
		{
			Console.Write(a[k]+" ");
			k--;
		}
		return a ;
		}
			static void Main()
		 {
			 int [] arr={ 2,3,4,5,6,7};
			var   s =rev(arr);
	
		 }

*/

/*
		static void max(int []a)
		{
				int max=0; 
				int k=0;
			while( k< a.Length)
			{
				if(a[k]> max)
					max=a[k];
				k++;
			}
			Console.WriteLine("maximum value of array : "+max);
	
		}
		
		static void Main ()
		{
			int []arr={1,33,4,99,55,3,77,55};
			max(arr);
			
		}
		*/
		
}
