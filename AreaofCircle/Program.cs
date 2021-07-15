using System;

namespace AreaofCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = -1;

            while (radius <= 0)
            {
                Console.WriteLine("Enter a radius");
                string radiusInput = Console.ReadLine();
                var text = double.TryParse(radiusInput, out radius);
                if (!text || text && radius < 0)
                {
                    Console.WriteLine("Not a valid radius!");
                }
            }

            double area = Circle.areaMethod(radius);
            double circumference = Circle.circumferenceMethod(radius);


            Console.WriteLine("Area of radius" + radius + "is:" + area);
            Console.WriteLine("Circumference of radius" + radius + "is:" + circumference);


            Console.WriteLine("Enter the miles per gallon of gas you used:");
            double mpg = double.Parse(Console.ReadLine());
            double galPerCir = (circumference / mpg);

            Console.WriteLine("It takes" + galPerCir + "gallons to drive around a circle with a circumference of" + circumference + "miles.");
        }
        
    }
}
