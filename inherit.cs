using System;
/*
				Multi level inheritance 
				
class grand 
{
	protected  void  property()
	{
		Console.WriteLine("  Grand property  ");
	}
	
}

class parent : grand 
{

protected   void display()
	{
		//parent  or 	this  .property();
		
		Console.WriteLine("  choice   father ");
	}
	
}
class child: parent
{
	static void Main()
	{
		child c = new child();
		c.display();
		c.property();
	}
}
*/

 /*
			SINGLE   INHERITANCE 
			
 class father
 {
	 protected  void show()
	  {
	 Console.WriteLine(" hello");
	  }
 }
 
  class child: father
 {
	  void show1()
	  {
	
	 Console.WriteLine(" hiii");
	  }
	  static void Main()
	  {
		 child c = new child();
		  c.show();
	  }
 }
 */
 /*
			HIERARICHAL INHERITANCE 
 
class father
{
	protected void show()
	{
		Console.WriteLine(" papa car ");
	}
} 
 
 class child1 : father
 {
	 public void display()
	 {
		 this.show();
		 Console.WriteLine(" child -1 car");
	 }
 }
 class child2 : father
 {
	 public void display1()
	 {
		 this.show();
		 Console.WriteLine(" child -2 car");
	 }
 }
 
 class test 
 {
	 static void Main()
	 {
		 child1 c=new child1();
		 child2 c1=new child2();
		 c.display();
		 c1.display1();
	 }
 }
 
 */