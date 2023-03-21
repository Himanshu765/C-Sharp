    class student
    {

        private student()    // private Constructor
        {
            //    int rollno = 111;
            //    string subject = "hindi";
            //    string name = " Himanshu";
            //    Console.WriteLine(rollno );
            //    Console.WriteLine(subject);
            //    Console.WriteLine(name);
            //
            Console.WriteLine(" private construtor");
        }
        public static void details()
            {
            int rollno;
            string name, subject;
            Console.WriteLine(" enter any roll no");
            rollno = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter the name ");
            name = Console.ReadLine();
            Console.WriteLine(" enter the subject");
            subject = Console.ReadLine();
			}

            }
         
    //class university
    //{
    //    private static string UniversityName;
    //    private static string UniversityDepart;
    //    public static string Uname
    //    {

    //        set
    //        {
    //            if (string.IsNullOrEmpty(value))
    //            {
    //                Console.WriteLine(" You enter null or empty value in University name");
    //            }
    //            else
    //            {
    //                UniversityName = value;
    //            }
    //        }
    //        get
    //        { return UniversityName; }



    //    }
     class Program
        {
            static void Main( )
            {
            //university.Uname  = " IFTM University";
            //Console.WriteLine("University name is {0}",university.Uname );
            //student s=new student();
            student.details();   
			}
		}