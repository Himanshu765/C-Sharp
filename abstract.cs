using System;
/*
		ABSTRACT CLASS 
		*****************************
		
 abstract class RBI
{
	public  virtual void interest()
	{
		Console.WriteLine(" 10%");
	}
}

class HDFC:RBI
{
	
}

class ICICI:RBI
{
	public override void interest()
	{
		Console.WriteLine(" 5%");
	}
}

class Customer
{
	static void Main()
	{
		RBI obj= new HDFC();
		obj.interest();
		RBI obj1= new ICICI();
			obj1.interest();
	}
}
*/

/*
		abstract method 
********************************

abstract class RBI
{
	public abstract   void interest();
	
}

class HDFC:RBI
{
	public override  void interest()
	{
		Console.WriteLine(" 10%");
	}
}

class ICICI:RBI
{
	public override void interest()
	{
		Console.WriteLine(" 5%");
	}
}

class Customer
{
	static void Main()
	{
		RBI obj= new HDFC();
		obj.interest();
		RBI obj1= new ICICI();
		obj1.interest();
	}
}
*/

/*
		abstract class using constructor 
		************************************
		
abstract class RBI
{
	public abstract   void interest();
	public RBI()
	{
		Console.WriteLine("  Constructor hai  ");
	}
	
}

class HDFC:RBI
{
	public override  void interest()
	{
		Console.WriteLine(" 10%");
	}
}

class ICICI:RBI
{
	public override void interest()
	{
		Console.WriteLine(" 5%");
	}
}

class Customer
{
	static void Main()
	{
		RBI obj= new HDFC();
		obj.interest();
		RBI obj1= new ICICI();
		obj1.interest();
	}
}
*/

abstract class RBI
{
	public abstract   void interest();
	public RBI()
	{
		Console.WriteLine("  Constructor hai  ");
	}
	static void Main ()
	{
		Console.WriteLine("  I am a RBI Bank");
		
		RBI obj= new HDFC();
		RBI obj1= new ICICI();
		obj.interest();
		obj1.interest();
	
	}
}

class HDFC:RBI
{
	public override  void interest()
	{
		Console.WriteLine(" 10%");
	}
}

class ICICI:RBI
{
	public override void interest()
	{
		Console.WriteLine(" 5%");
	}
}

abstract class Test 
{
	public abstract void sum();	
}

class Demo:Test 
{
	public override void sum()
	{
		Console.WriteLine(" hi" );
	}	
}
class  D: Test 
{
	public   override void sum()
	{
		Console.WriteLine(" BYE");
		base .sum();   //Cannot call an abstract base member: 'Test.sum()'
	}
}

class M1
{
	static void Main()
	{
		Test t = new D();
		t.sum();
	}	
}
*/


