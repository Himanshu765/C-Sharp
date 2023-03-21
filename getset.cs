using System;
/*
class test{
	public int add(int a)
	{
		return a ;
	}
	public int add(int a, int b){
		return a+b;
		
	}
	public int add(int a, int b, int c){
		return a+b+c;
		
	}
	public int  add(int a, int b, int c, int d){
		return a+b+c+d;
		
	}
}
	class demo
	{
		static void Main(){
			test t= new test();
			int m=t.add(5);
			int n=t.add(5,6);
			int o=t.add(5,6,7);
			int p=t.add(5,6,7,8);
			Console.WriteLine(" Method over loading mehod is 1argu..."+m);
			Console.WriteLine(" Method over loading mehod is 2argu..."+n);
			Console.WriteLine(" Method over loading mehod is 3 argu..."+o);
			Console.WriteLine(" Method over loading mehod is 4 argu..."+p);
           			
		   }
	}
*/

// Access the private variable using Getter and Setter Method  

/*
class Employee
{
	private int empno;
	private string  empname;
	private double empsal;
	private string companyname;
	
	public void setEmpNo(int eno)  // set means write 
	{
		empno=eno;
	}
	public void setEmpName(string ename)
	{
		empname=ename;
	}
	public void setEmpSal(double esal)
	{
		empsal=esal;
	}
	public void setCompanyname(string ecompanyname)
	{
		companyname=ecompanyname;
	}
	
	public int getEmpNo()
	{
	return empno;
	}
	
	public string  getEmpName()
	{
	return empname;
	}
		public double getEmpSal()
	{
	return empsal;
	}
	public string   getEcompanyname()
	{
		return companyname;
	}

}

class Test 
{
	static void Main()
	{
		Employee emp=new Employee();
		emp.setEmpNo(101);
		emp.setEmpName(" Himanshu Chauhan ");
		emp.setEmpSal(100000d);
		emp.setCompanyname("Chetu.Inc.Pvt Ltd");
		
		Console.WriteLine(" Employee id number :  " + emp.getEmpNo());
		Console.WriteLine(" Employee name : " + emp.getEmpName());
		Console.WriteLine(" Employee salary : " + emp.getEmpSal());
		Console.WriteLine(" Employee comoany name : " + emp.getEcompanyname());
		
	}
}
*/

/*
// Access the private variable using Getter and Setter Method with THIS KEYWORD
class Employee
{
	private int empno;
	private string  empname;
	private double empsal;
	private string companyname;
	
	public void setEmpNo(int empno)  // set means write 
	{
		this .empno=empno;
	}
	public void setEmpName(string empname)
	{
	this.empname=empname;
	}
	public void setEmpSal(double empsal)
	{
		this.empsal=empsal;
	}
	public void setCompanyname(string companyname)
	{
		this.companyname=companyname;
	}
	
	public int getEmpNo()
	{
	return this . empno;
	}
	
	public string  getEmpName()
	{
	return this .empname;
	}
		public double getEmpSal()
	{
	return this.empsal;
	}
	public string   getEcompanyname()
	{
		return this.companyname;
	}

}

class Test 
{
	static void Main()
	{
		Employee emp=new Employee();
		emp.setEmpNo(101);
		emp.setEmpName(" Himanshu Chauhan ");
		emp.setEmpSal(100000d);
		emp.setCompanyname("Chetu.Inc.Pvt Ltd");
		
		Console.WriteLine(" Employee id number :  " + emp.getEmpNo());
		Console.WriteLine(" Employee name : " + emp.getEmpName());
		Console.WriteLine(" Employee salary : " + emp.getEmpSal());
		Console.WriteLine(" Employee comoany name : " + emp.getEcompanyname());
		
	}
}
*/

// Using get set property  Access the private variable

/*
class Employee
{
	private int  empno;
	private string  empname;
	private int  empsal;
	
	public int EmpNo
	{
		set {this.empno=value;
		}
		get{
			return this.empno;
		}
	}
	public string  EmpName
	{
		set {this.empname=value;
		}
		get{
			return this.empname;
		}
			
	}
	
	public int   EmpSal
	{
		set {this.empsal=value;
		}
		get{
			return this.empsal;
		}
	}
	
class Test 
{
	static void Main()
	{
	Employee  emp=new Employee();
	emp.EmpNo=100;
	emp.EmpName="Himanshu  Chauhan";
	emp.EmpSal=10000;
	Console.WriteLine(emp.EmpNo);
	Console.WriteLine(emp.EmpName);
	Console.WriteLine(emp.EmpSal);
	}
}
*/

class BankAccount
    {
        private string Owner;
        private int balance;

        public void BankAcc(string owner, int ball)
        {
            this.Owner = owner;
            this.balance = ball;
            Console.WriteLine("  Account  Money{0}",ball);
            Console.WriteLine("  Account  Owner name :{0}", owner);
        }

        public string owner
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Can't Enter The Null or Empty Name");
                }
                else
              {
                    this.Owner = value;
                }
            }
            get
            {
                return this.Owner;
            }
        }

        public void deposit(int amount)
        {
            balance += amount;
            Console.WriteLine(" deposit money={0}", amount);
        }

        public void withdraw(int amount)
        {
            balance -= amount;
            Console.WriteLine(" Withdrawl money {0}",amount);
        }
        public string toString()
        {
            return Owner + " Acc Hold money " + balance;

        }

        public int bal
        {
            set
            {
                if (value > balance)
                {
                    Console.WriteLine("Can't Withdraw ");
                }
                else
                {
                    withdraw(value);
                }
            }

        }
    }
	
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount obj = new BankAccount();
            obj.BankAcc("Himanshu", 5000);
            obj.deposit(1000);
            obj.owner = "Himanshu";
            obj.bal = 4000;
            var data = obj.toString();
            Console.WriteLine(data);
        }
    }

