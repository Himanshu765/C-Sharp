using System;
public class Himanshu
{
    static void Sum(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine(" Sum is " + sum);
    }
    static void Cube(int[] arr)
    {
        int[] arr1 = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr1[i] = arr[i] * arr[i] * arr[i];
        }
        foreach (int x in arr1)
        {
            Console.Write(" " + x);
        }
        Console.WriteLine();
    }
    static void Square(int[] arr)
    {
        int[] arr1 = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr1[i] = arr[i] * arr[i];
        }
        foreach (int x in arr1)
        {
            Console.Write(" " + x);
        }
        Console.WriteLine();
    }
    static void Double(int[] arr)
    {
        int[] arr1 = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr1[i] = arr[i] * 2;
        }
        foreach (int x in arr1)
        {
            Console.Write(" " + x);
        }
        Console.WriteLine();
    }
    static void Even_Odd(int[] arr)
    {
        int even = 0, odd = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
                even++;
            else
                odd++;
        }
        Console.WriteLine(" No of Even is :{0}\n No of Odd is :{1}", even, odd);
    }
    static void Prime_NotPrime(int[] arr)
    {
        int p = 0, np = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int j = 0, count = 0;
            for (j = 1; j <= arr[i]; j++)
            {
                if (arr[i] % j == 0)
                    count++;
            }
            if (count == 2)
                p++;
            else
                np++;
        }
        Console.WriteLine(" No of Prime: {0}\n No of NonPrime: {1}", p, np);
    }
    static void Greatest_Number(int[] arr)
    {
        int big = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (big < arr[i])
                big = arr[i];
        }
        Console.WriteLine("Greatset No is: {0}", big);
    }
    static void Positive_Negative(int[] arr)
    {
        int pos = 0, neg = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
                pos++;
            else if (arr[i] < 0)
                neg++;
        }
        Console.WriteLine("Positive No is: {0}\n Negative No is: {1}", pos, neg);
    }
    static void Ascending_Order(int[] arr)
    {
        
        for (int i = 0; i < arr.Length; i++)
        {
            int temp = 0;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        foreach (int x in arr)
        {
            Console.Write(" " + x);
        }
        Console.WriteLine();
    }
    static void Descending_Order(int [] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int temp = 0;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] < arr[j])
                { 
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        foreach (int x in arr)
        {
            Console.Write(" " + x);
        }
        Console.WriteLine();
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("* * * * * * * * * * * * * * * *  Welcome To My Code  * * * * * * * * * *  * *  * * * *");

      /**********************************Input Array*********************/

        Console.WriteLine("Enter The Base Size:");
        int BaseSize = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter The Sub Size:");
        int SubSize = int.Parse(Console.ReadLine());
        int[,] Array = new int[BaseSize, SubSize];
        int i = 0, j;
        int r = 0, c = 0;
        int [] operation = new int[BaseSize];
        int [] operation2 = new int[BaseSize * SubSize];   
            while (i < Array.GetLength(0))
        {
            j = 0;
            while (j < Array.GetLength(1))
            {
                Console.Write("Enter The [{0}][{1}]:", i, j);
                Array[i, j] = int.Parse(Console.ReadLine());
                j++;
            }
            i++;
        }

        /*********************************Matrix Print**************************************/

        Console.WriteLine("    Your Matrix is Ready :");
        i = 0;
        while (i < Array.GetLength(0))
        {
            for(int s=0;s<10;s++)
            {
                Console.Write("   ");
            }
            j = 0;
            while (j < Array.GetLength(1))
            {
                Console.Write(" "+Array[i,j]);
                j++;
            }
            Console.WriteLine();
            i++;
        }
        /*********************** Option Print***********************************************/
        Console.Write("Choose The Option:\n");
        Console.WriteLine("     1. Row-Matrix\n     2. Column-Matrix\n     3. Primary-Diagonal\n     4. Secondary-Diagonal\n     5. Complete-Matrix");
        int Option2 = int.Parse(Console.ReadLine());

        if (Option2 == 1)
        {
            Console.WriteLine("Enter The Row Number:");
            r = int.Parse(Console.ReadLine());
        }
        if (Option2 == 2)
        {
            Console.WriteLine("Enter The Column Number:");
            c = int.Parse(Console.ReadLine());
        }
        /******************************** Array Print through the Option****************************/
        int k = 0;
        i = 0;
        while (i < Array.GetLength(0))
        {
            j = 0;
            while (j < Array.GetLength(1))
            {
                switch (Option2)
                {
                    case 1:
                        if (i == r - 1)
                        {
                            Console.Write(" " + Array[i, j]);
                            operation[k] = Array[i, j];
                            k++;
                        }

                        break;
                    case 2:
                        if (c - 1 == j)
                        {
                            Console.Write(" " + Array[i, j]);
                            operation[k] = Array[i, j];
                            k++;
                        }
                        break;
                    case 3:
                        if (i == j)
                        {
                            Console.Write(" " + Array[i, j]);
                            operation[k] = Array[i, j];
                            k++;
                        }
                        break;
                    case 4:
                        if ((i + j) == (Array.GetLength(0) - 1))
                        {
                            Console.Write(" " + Array[i, j]);
                            operation[k] = Array[i, j];
                            k++;
                        }
                        break;
                    case 5:
                        Console.Write(" " + Array[i, j]);
                        operation2[k] = Array[i, j];
                        k++;
                        break;
                    default:
                        Console.Write("Invalid Option");
                        break;
                }
                j++;
            }
            Console.WriteLine();
            i++;
        }
        /***************************Operation Perform*********************************/
        Console.WriteLine();
        int z = 1;
        while (z != 0)
        {

            Console.Write("Choose The Option:\n");
            Console.WriteLine("   1. Sum\n   2. Cube\n   3. Square\n   4. Double\n   5. Even_Odd\n   6. Prime_NotPrime\n   7. Greatest_Number\n   8. Positive_Negative\n   9. Ascending_order\n   10.Descending_Order");
            int Choose = int.Parse(Console.ReadLine());
        
            switch (Choose)
            {
                case 1:
                    if (Option2 == 5)
                        Sum(operation2);
                    else
                         Sum(operation);
                    break;

                case 2:
                    if(Option2 == 5)    
                        Cube(operation2);
                    else
                        Cube(operation);   
                    break;

                case 3:
                    if(Option2 == 5)
                        Square(operation2);
                    else
                        Square(operation);
                    break;

                case 4:
                    if(Option2 == 5)
                        Double(operation2);
                    else
                        Double(operation);
                    break;

                case 5:
                    if(Option2 == 5)
                        Even_Odd(operation2);
                    else
                        Even_Odd(operation);
                    break;

                case 6:
                    if(Option2 == 5)
                        Prime_NotPrime(operation2);
                    else
                        Prime_NotPrime(operation);
                    break;

                case 7:
                    if(Option2 == 5)
                        Greatest_Number(operation2);
                    else
                        Greatest_Number(operation);
                    break;

                case 8:
                    if(Option2 == 5)
                        Positive_Negative(operation2);
                    else
                        Positive_Negative(operation);
                    break;

                case 9:
                    if(Option2 == 5)
                        Ascending_Order(operation2);
                    else
                        Ascending_Order(operation);
                    break;

                case 10:
                    if(Option2==5)
                    Descending_Order(operation2);
                    else
                        Descending_Order(operation);
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;

            }
            z++;
        }

    }
}
