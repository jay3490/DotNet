namespace JAY
{
    public class Perimeter
    {
        int Height;
        int Width;
        int pmeter;
        int area;

        public Perimeter() { }

        public void Pmeter()
        {
            //Perimeter of Rectangle = 2(Height + Width)
            Console.Write("Enter Height of Rectangle in cms : ");
            Height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Width of Rectangle in cms : ");
            Width = Convert.ToInt32(Console.ReadLine());
            pmeter = 2 * (Height + Width);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nPerimeter of Rectangle of Height : {Height} cm and Width : {Width} cm is {pmeter} cm.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Area()
        {
            area = (Height * Width);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"\nArea of Rectangle of Height: {Height} cm and width: {Width} cm is {area} cm\u00b2.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}