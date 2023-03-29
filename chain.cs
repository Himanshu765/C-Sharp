using System;
/*
		CONSTRUCTOR CHAINING USING SINGLE INHERITANCE

class Grand 
{
	public Grand()
	{
		Console.WriteLine(" Grand");
	}
}

class father :   Grand
{
	public father()
	{
		Console.WriteLine(" father");
	}
}

class child :  father
{
	public child ()
	{
		Console.WriteLine(" child");
	}
	
	static void Main()
	{
		child c = new child();
	}
}
*/

//	CHAINING USING   PARAMETERIZED 		CONSTRUCTOR 
 
/*
class Grand 
{
	public Grand(int x ): base ()
	{
		Console.WriteLine(" Grand"+x);
	}
}

class father :  Grand
{
	public father(int x ): base(100)
	{
		Console.WriteLine(" father"+x);
	}
}

class child :  father
{
	public child (int x): base (200)
	{
		Console.WriteLine(" child"+x);
	}
	
	static void Main()
	{
		child c = new child(300);
	}
}
*/

//     CONSTRUCTOR CHAINING USING SINGLE CLASS
/* 
class test 
{
	test (double z)  : this ("z")
	{
		Console.WriteLine(" phir milenge ");
	}
	
	test ( )
	{
		Console.WriteLine(" Hello");
	}
	
	test (string y):this(10)
	{
		Console.WriteLine(" BYE ");
	}
	test (int x):this()
	{
		Console.WriteLine(" HI");
	}
	
	static void Main()
	{
		test t = new test(100.100d);
	}
}

*/

/*

class Address 
{
	// using constructor
	
	private int  _houseno;
	private  string  _housename;
	private int  _pincode;
	
	public Address (int houseno,string housename,int pincode)
	{
		_houseno=houseno;
		_housename=housename;
		_pincode=pincode;	
	}
	
	public override string ToString()
	{
		return _houseno +" "  +_housename +" " +_pincode;
	}
	
}

class Employee
{
		private int _empno;
		private string  _empname;
		private Address _empaddress;
		
	public int Empno
	{
		get;set;
	}
	
	public string  Empname
	{
		get;set;
	}
	
	public Address  Empaddress
 	{
		get;set;
	}
		
}

class chetu
{
	static void Main()
	{
		Address  address = new Address(101," SEOHARA" , 246746);
	Employee emp = new Employee();
	emp.Empno=100;
	emp.Empname=" Himanshu";
	emp.Empaddress=address;
	Console.WriteLine(" No is  "+emp.Empno);
	Console.WriteLine(" Name is  "+emp.Empname);
	Console.WriteLine(" Address  is  "+emp.Empaddress);
	}
}

*/


/*

class Address 
{
	// using property 
	
	private int  _houseno;
	private  string  _housename;
	private int  _pincode;
	
	public int Houseno
	{
		get; set;
	} 
			public string Housename
	{
		get; set;
	} 	 
		public int Pincode
	{
		get; set;
	} 	

}

class Employee
{
	// using Constructor
	
		private int _empno;
		private string  _empname;
		private Address _empaddress;
		
	public Employee ( int empno, string empname,  Address empaddress)
	{
		empno=_empno;
		empname=_empname;
		empaddress = _empaddress;
	}
	
	public override string ToString()
	{
		return  _empno +"   " +_empname + "   "+_empaddress;
		
	}

		
}

class chetu
{
	static void Main()
	{
	
			
			Address address = new Address();
			
			Employee emp = new Employee(101," Himanshu", address);
			
		    address.Houseno=101;
		    address.Housename= "chauhanniwas";
		    address.Pincode= 246746;
			
			Console.WriteLine("emp no is:"+emp.EmpNo);
			Console.WriteLine("emp name is:"+emp.EmpName);
			Console.WriteLine("emp address is:"+emp.EmpAddress);
		
	}
}
*/

//*********************************************************************

/*

class Address 
		// Third  METHOD USING Constructor   USER DEFINED DATA TYPE 
{
	// using Constructor 
	
	private int  _houseno;
	private  string  _housename;
	private int  _pincode;
	
	public Address(int houseno, string housename , int pincode)
	{
		_houseno = houseno;
		_housename = housename;
		_pincode = pincode;
	}
	
	public int HouseNo
	{
		get{return _houseno;}
		
	}
	public string  HouseName
	{
		get{return _housename;}
	}
		
	public int Pincode
	{
		get{return _pincode;}
		
	}
	
	
	public override string ToString()
	{
		{
		 return  HouseNo +"  " + HouseName +"  "+Pincode;
		}
	}
}
	
class Employee
{
	// using Constructor
	
		private int _empno;
		private string  _empname;
		private Address _empaddress;
		
	public Employee ( int empno, string empname,  Address empaddress)
	{
		_empno=empno;
		_empname=empname;
		_empaddress = empaddress;
	
	}
	
	public int EmpNo
	{
		get{return _empno;}
		
	}
	public string  EmpName
	{
		get{return _empname;}
	}
		
	public Address EmpAddress
	{
		get{return _empaddress;}
		
	}
	
		
}
class chetu
{
	static void Main()
	{
	
			
			Address address = new Address(101," rajvilla",246746);
			
			Employee emp = new Employee(101," Himanshu", address);
			
		    			
			Console.WriteLine("emp no is:"+emp.EmpNo);
			Console.WriteLine("emp name is:"+emp.EmpName);
			Console.WriteLine("emp address is:"+emp.EmpAddress);
		
	}
}
*/

//*****************************************************************************************

class Address 

		// fourth  METHOD USING  GET & SET PROPERTY USER DEFINED DATA TYPE 
{
	// using property 
	
	private int  _houseno;
	private  string  _housename;
	private int  _pincode;
	
	public int Houseno
	{
		get; set;
	} 
	public string Housename
		{
		get; set;
		} 	 
		public int Pincode
	{
		get; set;
	}

	public override string ToString()
	{
		{
		 return  Houseno +"  " + Housename +"  "+Pincode;
		}
	}
}	
class Employee
{
		private int _empno;
		private string  _empname;
		private Address _empaddress;
		
	public int Empno
	{
		get;set;
	}
	
	public string  Empname
	{
		get;set;
	}
	
	public Address  Empaddress
 	{
		get;set;
	}
		
}

class Test
{
	static void Main()
	{
		Address address = new Address();
		Employee emp = new Employee();
		
		emp.Empno=101;
		emp.Empname=" Himanshu";
		emp.Empaddress=address;
		
		address.Houseno=100;
		address.Housename=" Raj Villa";
		address.Pincode=246746;
		
		Console.WriteLine("emp no is:"+emp.Empno);
		Console.WriteLine("emp name is:"+emp.Empname);
		Console.WriteLine("emp address is:"+emp.Empaddress);
		
	}
}

/*
class student 
{
	private  int  _studentId;
	private  string _studentname;
	private  string _collagename;
	
	 public  student(int studentId ,  string studentname, string collagename)
	 {
		 _studentId=studentId;
		 _studentname=studentname;
		 _collagename=collagename;
	 }	 
	 
	 public override string ToString()
	 {
		 return  _studentId +"  " + _studentname +"  "+_collagename;
	 }
}
class Test
{
	static void Main()
	{
		student st = new student(101," Himanshu", " IFTM UNIVERSITY");
		Console.WriteLine(" student data   \n "+st);
		
		
	}
}
*/







