using System;
namespace Practice
{
    class variables
    {
        //public static void Main()
        //{
        /*
        //int x = 10;
        //int y = 20;
        //int z;

        //z = x + y;
        //Console.WriteLine(z);
        //Console.ReadLine();


        //Console.WriteLine("HEY! Please Enter Your Name, We Need it");
        //Console.Write("Your First Name: ");
        //string FirstName = Console.ReadLine();

        //Console.Write("Now Please Enter Your Second Name: ");
        //string LastName = Console.ReadLine();

        //Console.WriteLine("Hello! " + FirstName + " " + LastName);
        //Console.ReadLine();


        //string name = "Honey";
        //Console.WriteLine(name.Substring(0, 3));
        //Console.ReadLine();


        //Console.WriteLine("Jay's Giveaway");
        //Console.WriteLine("Win Grand Prizes, Please choose a no. Between 1 to 10");
        //Console.Write("Enter a no: ");
        //string Val = Console.ReadLine();

        //if (Val == "1")
        //{
        //    Console.WriteLine("Please Select a Valid Number!");
        //}

        //else if (Val == "6") 
        //{
        //    Console.WriteLine("Yeheee, You have won a Car!");
        //}

        //else
        //{
        //    Console.WriteLine("Badluck, Better Luck next Time");
        //}

        //Console.WriteLine("Hey! Welcome to Casino");
        //Console.WriteLine("Enter a number Now");
        //Console.Write("Enter a number between 1 to 99:");
        //string Value = Console.ReadLine();
        //string Msg = (Value == "1") ? "Boat" : "Nothing";
        //Console.WriteLine("As u entered {0}, You won a {1}", Value, Msg); 
        //Console.ReadLine();

        //Random random = new Random();
        //var b = random.Next();
        //Console.WriteLine(random.Next());   
        //Console.ReadLine();

        //Console.WriteLine("Now Please enter a no. for validation");
        //var a = Console.ReadLine();

        //for (int i = 20; i > 10; i--)
        //{
        //    Console.WriteLine(i);

        //}
        //Console.ReadLine();

        //int[] id = new int[] { 1, 2, 3, 4 };
        //foreach (int id2 in id)
        //{ 
        //    Console.WriteLine(id2);      
        //}

        //Console.WriteLine("Please enter a no.");
        //string a = Console.ReadLine();
        //Console.Write("You have entered: {0}", a);


        //string msg = (a == "3490") ? "You won Watch" : "You won nothing";
        //Console.WriteLine("As u have entered {0}, you have won {1}", a, msg);

        //string Value = "Jay loves dance";
        //char[] Value1 = Value.ToCharArray();
        //Array.Reverse(Value1);
        //Console.WriteLine(Value1);

        //foreach (char item in Value1)
        //{
        //    Console.WriteLine(ite);
        //}


        //int[] arr = new int[] { 3, 9, 3, 7, 1 };
        //Array.Sort(arr);    
        //foreach (int i in arr)
        //{
        //    Console.WriteLine(i + " ");
        //}

        //    Console.WriteLine("Welcome to name game");
        //    Console.WriteLine("----------------------");
        //    Console.Write("Please enter your first name: ");
        //    string FirstName = Console.ReadLine();

        //    Console.WriteLine("----------------------");
        //    Console.Write("Please enter your last name: ");
        //    string LastName = Console.ReadLine();

        //    Console.WriteLine("----------------------");
        //    Console.Write("Please enter your city: ");
        //    string City = Console.ReadLine();
        //    Console.WriteLine("----------------------");

        //    ReverseString(FirstName);
        //    ReverseString(LastName);
        //    ReverseString(City);
        //}
        //private static void ReverseString(string message)
        //{
        //    char[] messageArray = message.ToCharArray();
        //    Array.Reverse(messageArray);
        //    foreach (char item in messageArray)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.WriteLine("----------------------");
        //    Console.WriteLine(messageArray);
        //    Console.WriteLine("----------------------");
        //}
        */
        //Console.WriteLine("Welcome to calculator!");
        //Console.WriteLine("Yes It is simple but, I am Trying.");
        //Console.WriteLine("---------------------------------");

        //Console.Write("Please enter two numbers to add: ");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.Write("{0} is value u have entered: ", a);
        //int b = Convert.ToInt32(Console.ReadLine());
        //Console.Write("{0} is value u have entered: ", b);
        //add(a, b);

        //static void add(int a, int b)
        //{
        //    int c = a + b;
        //    Console.WriteLine(c);
        //    Console.WriteLine("{0} your ans is: ", c);
        //}

        //string Value = "Jay loves dance";
        //char[] Value1 = Value.ToCharArray();
        //Console.WriteLine(Value1 + " ");

        //foreach (char item in Value1)
        //{
        //    Console.Write(" "+ item);
        //}

        //string char_arr = "abcdefg";
        //var split = char_arr.Select(x => x).ToList();   
        //foreach (char arr in split)

        //    Console.Write(arr);    


        // Simple C# program to count occurrences
        // of pat in txt.

        //public class GFG
        //        {

        //            static int countFreq(String pat, String txt)
        //            {
        //                int M = pat.Length;
        //                int N = txt.Length;
        //                int res = 0;

        //                /* A loop to slide pat[] one by one */
        //                for (int i = 0; i <= N - M; i++)
        //                {
        //                    /* For current index i, check for
        //                pattern match */
        //                    int j;
        //                    for (j = 0; j < M; j++)
        //                    {
        //                        if (txt[i + j] != pat[j])
        //                        {
        //                            break;
        //                        }
        //                    }

        //                    // if pat[0...M-1] = txt[i, i+1, ...i+M-1]
        //                    if (j == M)
        //                    {
        //                        res++;
        //                        j = 0;
        //                    }
        //                }
        //                return res;
        //            }

        //            /* Driver program to test above function */
        //            static public void Main()
        //            {
        //                String txt = "BlUeBe1Bl*fjal9jkl";
        //                String pat = "Bl";
        //                Console.Write(countFreq(pat, txt));
        //            }
        //        }

        //        // This code is contributed by 29AjayKumar

        //class A
        //{
        //    public string a;
        //}

        //class B : A
        //{
        //    public string b;

        //}

        //public class Program 
        //{
        //    static void Main(string[] args)
        //    {
        //        A a = new B();
        //        Console.WriteLine(a);
        //    }
        //}
        class maths
        {
            public maths()
            {
                Console.WriteLine("constructor 1 :");
            }
            public maths(int x)
            {
                int p = 2;
                int u;
                u = p + x;
                Console.WriteLine("constructor 2 : " + u);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                maths k = new maths(4);
                maths t = new maths();
                Console.ReadLine();
            }
        }
    }

}
