using System;

class maths
 {
    public int x;
    public double y;
   
     public double fu  //  properties
    {
         get
         {
           return this.y;
         }
    }
     
    public int add(int a, int b)
    {
         x = a + b;  //  4+3
         return x;//   x=7
    }
   
    public maths(int a, int b)
    {
         this.x = a;    // x=1
         this.y = b;   // y=5
    }
   
    public int add(int c, double d)
    {
         y = c + d;   // 3+5.0
         return (int)y;  // 8 
    }
     
   
     
    public int fa
    {
         get
         {
           return this.x;
         }
    }
     
   
}
 
class Program
{
    static void Main(string[] args)
    {
        maths obj = new maths(1,5);
       
        int a = 4;
        int b = 3;
        double c=5.0;
        obj.add(a,b);
        obj.add(b,c);
       
        Console.WriteLine(obj.x + " " + obj.y + " " + obj.fa + " " + obj.fu);    // 7   8   7  8  OUTPUT   
       
    }
}
