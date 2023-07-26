
Console.WriteLine("Hello, World!");
string fName = "ahir";
string lName = "jay";
var fullName = string.Format("{0} {1}", fName, lName);
Console.WriteLine(fullName);

namespace enums
{
    public enum ShippingMethods
    { 
        a = 1,
        b = 2,
        c = 3
    }

    class Program
    {

        static void Main()
        { 
         var method = ShippingMethods.a;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethods)methodId);
        }
    }
}