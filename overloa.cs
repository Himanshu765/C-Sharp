 using System;
class maths
 {
     public int x;
     public double y;
     
     public int add(int a, int b)
     {
         x = a + b;
         return x;
     }
     
     public int add(double c, double d)
     {
         y = c + d;
         return (int)y;
     }
     
     public maths()
     {
         this.x = 0;
         this.y = 0;
     }
 } 
 
class Program
{
    static void Main(string[] args)
    {
        maths obj = new maths();
        
        int a = 4;
        double b = 3.5;
        
        obj.add(a, a);
        obj.add(b, b);
        
        Console.WriteLine(obj.x + " " + obj.y);
        
    }
}