namespace ConsoleApp1
{
    internal class Program
    {
        /*
                struct Person
                {
                    public string FullName;
                    public int age;
                }
                enum status_marital
                {
                    single, married
                }

                static void proc1(int a, int b)
                {
                    int sum = a+ b; 
                    Console.WriteLine("the sum is : " + sum);
                }
                static void showMessage(String param)
                {
                    Console.WriteLine("Bonjour mr  " + param);
                }

                
        static int sum(int a, int b)
        {
            return a+ b;    
        }*/
        static void myProc(ref int number)
        {
            number = 10;
            Console.WriteLine("the value of this number is : " + number);   

        }

        static void myProc2(out int number)
        {
            number = 10;
            Console.WriteLine("the value of this number is : " + number);

        }

        static void Main(string[] args)
        {

            /*
            Console.Title = "my first project";
            Console.WriteLine("Enter your Name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your Age :");
            int age = Convert.ToInt32(Console.ReadLine());
            //int age2 = int.Parse(Console.ReadLine());
            Console.Write("Hello mr : " + name + "\t and your age is " + age + "\t " + age2);


            /* variable declaration

            int number;
            string text;
            bool test;
            DateTime myDate;
            double number2;


            number = 8;
            text = "Abdelouahed";
            test = false;
            myDate = DateTime.Now;
            number2 = 5.54;
            */
            /* Const

            const int myNumber = 3;
            const string name = "karim";
             */
            /*
                        //arithmetic opertators
                        int x, y, sum;
                        x = 7;
                        y = 9;
                        sum = x + y;

                        Console.WriteLine("the sum is " + sum);


                        //test operator

                        bool test = 5 < 6;
                        Console.WriteLine(test);


                        // logic operator

                        bool test2 = 5 < 6 && 7 > 9;
                        Console.WriteLine(test2);*/

            /*   // Conditions
               int number1, number2;
               double div;

               Console.WriteLine("Enter the First Number");
               number1 = int.Parse(Console.ReadLine());

               Console.WriteLine("Enter the Second Number");
               number2 = int.Parse(Console.ReadLine());

               if (number2 == 0)
               {
                   Console.WriteLine("Connot Divide By Zero");

               }
               else
               {
                   div = number1 / number2;
                   Console.WriteLine("the division is " + div);
               }
            //Switch Case

            int number1, number2;
            double div;

            Console.WriteLine("Enter the First Number");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            number2 = int.Parse(Console.ReadLine());

            switch (number2)
            {
                case 0:
                    Console.WriteLine("Cannot divide by zero");
                    break;
                default:
                    div = number1 / number2;
                    Console.WriteLine("the division is " + div);
                    break;

            }

            //COndition triplet
            string msg;
            int number1, number2;
            double div;

            Console.WriteLine("Enter the First Number");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            number2 = int.Parse(Console.ReadLine());
            msg = number1 == 0 ? "Cannot divide by zero" : "The results is : " + number1 / number2;
            Console.WriteLine(msg);



            ask:Console.Write("who is the first KHALIFA?");
                string name = Console.ReadLine();

                while (name != "abu bakr")
                {
                    Console.WriteLine(false);
                    goto ask;
                }
                Console.WriteLine("True");
           
            //Tableaux 

            int[] array = new int[5];
            array[0] = 3;
            array[1] = 55;
            array[2] = 13;
            array[3] = 21;
            array[4] = 36;

            string[] name = new string[4];

            name[0] = "Ahmed";
            name[1] = "Karim";
            name[2] = "Abdou";
            name[3] = "Hassan";

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Hello Mr. " + name[i]);
            }

            foreach (String n in name)
            {
                Console.WriteLine("Hello Mr. " +n);
            }
            
            // Matrices

            int[,] array = new int[2, 2];

            array[0,0] = 2;
            array[0,1] = 4;
            array[1, 0] = 3;
            array[1, 1] = 5;

            Console.WriteLine("The lenght is " + array.Length);

            foreach (int i in array)
            {
                    Console.WriteLine(i);
               
                
            }
            
            //Structures

            Person p = new Person();

            Console.WriteLine("Enter your FullName : ");
            p.FullName = Console.ReadLine();
            Console.WriteLine("Enter you age : ");
            p.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your fullName is \t:" + p.FullName + "and your age is :" + p.age);
            
            //Enumm
            Console.WriteLine("Are you married?");
            string response = Console.ReadLine();
            switch (response)
            {
                case "yes":
                    Console.WriteLine("You are :" + status_marital.married);
                    break;
                case "no":
                    Console.WriteLine("You are :" + status_marital.single);
                    break;
            }
       
            
            //Lists
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(6);    
            list.Add(7);
            list.Add(10);
            list.Remove(10);
            list.RemoveAt(2);
            foreach (int n in list)
            {
                Console.WriteLine(n);
            }
            

            Console.WriteLine(list.Count);
            
            //Procedures
            proc1(10, 11);
            Console.WriteLine("ENter your Name");
            string name = Console.ReadLine();
            showMessage(name);
            
            Console.WriteLine("Enter the first nummber");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second nummber");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum1 = sum(num1, num2);
            Console.WriteLine("the sum is :" + sum1);
            

            //passage par reference
            int number = 20;
            Console.WriteLine("the first value is : "+number);
            myProc(ref number);
            Console.WriteLine("the first value is : " + number);

           // Passage OUT
            int number =20;
            myProc2(out number);
             
            //Exceptions Handling
            int a = 15, b = 0;
            try
            {
                double div = a / b;
                Console.WriteLine("the result is :" + div);
            }
            catch(Exception ex)     
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Message");
            }
            
            //Console properties
            Console.Title = "c# Language";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Beep();
            Console.Clear();
            Console.Read();
            
            //Escape caracters
            Console.WriteLine("\n \t word\b \a \\ \" \'");
           
            //Break and Continue
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
                if (i < 10)
                {
                    continue;
                }
                else break;
                //or
                if (i < 10) continue;break;
            }
            //Concatination
            String name = "Abdou", country = "Oujda", age = "26";
            Console.WriteLine("my name is : " + name + " and my country is :" + country + " and my age is : " + age);
            Console.WriteLine("my name is {0} and my country is {1},  and my age is {2}", name, country, age);
            */


            Console.ReadKey();
        }
    }
}