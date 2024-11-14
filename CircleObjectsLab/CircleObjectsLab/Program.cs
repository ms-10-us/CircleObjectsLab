using CircleObjectsLab;

Console.WriteLine("Circle Objects Lab!");

Console.WriteLine();

double radius = 0;
Console.WriteLine("Entrer circle's radius");
while (true)
{
    try
    {
        string userAnswer = "";

        radius = Convert.ToDouble(Console.ReadLine());
        Circle circleObject = new Circle(radius);
        double diameter = circleObject.CalculateDiameter();
        double circumference = circleObject.CalculateCircumference();
        double area = circleObject.CalculateArea();
        Console.WriteLine($"Diameter: {diameter}");
        Console.WriteLine($"Circumference: {circumference}");
        Console.WriteLine($"Area: {area}");

        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("Should the circle grow (y/n)?");
            userAnswer = Console.ReadLine();

            if (userAnswer.ToLower().Trim() == "y")
            {
                Console.WriteLine("The circle is magically growing");
                circleObject.Grow();
            }
            else if (userAnswer.ToLower().Trim() == "n")
            {
                Console.WriteLine($"Goodbye! The circle's final radius is {circleObject.GetRadius()}");
                Environment.Exit(0);
            }
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Please enter a valid radius");
        continue;
    }
}




