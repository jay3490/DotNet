using System;

//namespace Car
//{
//    class Elantra
//    {
//        string Looks = "LUXURY";
//        int NoPlate = 5599;

//        static void Main()
//        {
//            Elantra elantra = new Elantra();
//            Console.WriteLine(elantra.Looks);
//            Console.WriteLine(elantra.NoPlate);
//            fullThrottle();
//        }

//        public static void fullThrottle()
//        {
//            Console.WriteLine("The car is going as fast as it can!");
//        }

//        public static void DriveCar()
//        {
//            Console.WriteLine("Car is driving");

//        }

//        public static void ApplyBrake()
//        {
//            Console.WriteLine("Car is applying brakes");

//        }
//    }
//}

//namespace Rectangle

//namespace Jay
//{
//    class area
//    {
//        int width;
//        int height;

//        int area;
//        int perimeter;

//        public static void Main()
//        {
//            height = Convert.ToInt32(Console.ReadLine());
//            width = Convert.ToInt32(Console.ReadLine());

//            perimeter = 2 * (height + width);
//            Console.WriteLine("perimeter of the rectangle = %d inches\n", perimeter);

//            area = height * width;
//            Console.WriteLine("area of the rectangle = %d square inches\n", area);

//        }
//    }
//}

//public class Perimeter
//{
//    int Height;
//    int Width;
//    int pmeter;
//    int area;

//    public Perimeter() { }

//    public void Pmeter()
//    {
//        //Perimeter of Rectangle = 2(Height + Width)
//        Console.Write("Enter Height of Rectangle in cms : ");
//        Height = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter Width of Rectangle in cms : ");
//        Width = Convert.ToInt32(Console.ReadLine());
//        pmeter = 2 * (Height + Width);
//        Console.ForegroundColor = ConsoleColor.Blue;
//        Console.WriteLine($"\nPerimeter of Rectangle of Height : {Height} cm and Width : {Width} cm is {pmeter} cm.");
//        Console.ForegroundColor = ConsoleColor.White;
//    }
//    public void Area()
//    {
//        area = (Height * Width);
//        Console.ForegroundColor = ConsoleColor.Blue;
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        Console.WriteLine($"\nArea of Rectangle of Height: {Height} cm and width: {Width} cm is {area} cm\u00b2.");
//        Console.ForegroundColor = ConsoleColor.White;
//    }
//}

//    namespace jay
//{
//    using System.Diagnostics;
//    public class program
//    {

//        public static void Main(string[] args)
//        {
//            Stopwatch stopWatch = new Stopwatch();
//            stopWatch.Start();
//            int n, t;
//            double s = 0;
//            Console.WriteLine("Please Enter a number between 1 -50");
//            n = Convert.ToInt32(Console.ReadLine());
//            int a = n;
//            if (n <= 50)
//            {
//                t = n + 10;
//                while (n <= t)
//                {

//                    s = s + Math.Pow(n, 4); ;
//                    n++;

//                }

//                Console.WriteLine("the sum of next 10 natural numbers starting from " + a + " each raised to power 4 is " + s);
//            }

//            stopWatch.Stop();
//            Console.WriteLine("Time of Execution: {0:hh\\:mm\\:ss}", stopWatch.Elapsed);
//        }
//    }
//}

//namespace Practice
//{
//    class Jay
//    {
//        string name;
//        public static void hey()
//        {
//            Jay str = new Jay();    
//            Jay str1 = new Jay();    

//        }
//    }

//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Jay str = new Jay();
//            Jay str1 = new Jay();

//            if(str1 == str1) {
//                Console.WriteLine("String Matches");

//            }

//        }

//    }
//}
//namespace Hey
//{
//    class student
//    {
//        public string name;
//        public int age, clas;
//        public string id;
//        public student(string name, int age, int clas)
//        {
//            this.name = name;
//            this.age = age;
//            this.clas = clas;
//            Console.WriteLine("New student has been admitted to the school");
//            System.Guid guid = System.Guid.NewGuid();
//            this.id = guid.ToString();
//            Console.WriteLine("His I.D has been created");


//        }

//    }
//    class program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Student name");
//            string na = Console.ReadLine();
//            Console.WriteLine("Enter his age");
//            int age = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter his class");
//            int clas = Convert.ToInt32(Console.ReadLine());


//            student s1 = new student(na, age, clas);

//            Console.WriteLine(" wanna see details? press y for yes, n for exit. ");
//            string see = Console.ReadLine();
//            if (see == "y")
//            {
//                Console.WriteLine(" HIS UNIQUE I.D ->" + s1.id);
//                Console.WriteLine(" NAME ->" + s1.name);
//                Console.WriteLine(" AGE ->" + s1.age);
//                Console.WriteLine(" CLASS ->" + s1.clas);
//            }

//        }
//    }
//}

//class Program
//{ 
//    private string Name;
//    public string name
//    { 
//        get { return Name; }
//        set { Name = value; }   
//    }

//    class Method
//    {
//        static void Main(string[] args)
//        { 
//            Program program1 = new Program();
//            program1.name = "C sharp";
//            Console.WriteLine(program1.name);

//            int myInt = 9;
//            float myDouble = myInt;
//        }
//    }
//}

class method
{
    public static void Main()
    {
        int myInt = 9;
        float a = myInt;
        Console.WriteLine(Convert.ToDecimal(a));   
    }
}