

    class student
    {
        private int rollno;
        private string name;
       private string subject;
        public void insert(int r, string n, string sub)
        {
            this.rollno = r;
            this.name = n;
            this.subject = sub;

        }
        public void display()
        {
            Console.WriteLine(" Rollno={0} \n  name={1} \n  subject={2}", this.rollno, this.name, this.subject);
        }

    }

        class emp
        {
            private int account = 1000;
            private string name = "Himanshu chauhan";
            public static string company = " Chetu ";

            public int setAccount
            {
                set
                {
                     if (value < 0 || value>1000 || value<1000)
                    {
                        Console.WriteLine(" not  match value in your account");
                    }
                     else
                   {
                       account = value;
                    }
                }

                get
                {
                   return account;
                }
            }
        public string getname
            {
               set { name = value; }
                get { return name; }
            }
        }
    class Program
    {
        static void Main(string[] args)
       {
            student s = new student();
            s.insert(1, " himanshu", " Hindi");
            s.display();
    


        }


            {
                emp obj1 = new emp();
                obj1.setAccount = 500;
                Console.WriteLine(obj1.setAccount);
                Console.WriteLine(obj1.getname);
                Console.ReadLine();
            }
    }    
        }


        }
    }
