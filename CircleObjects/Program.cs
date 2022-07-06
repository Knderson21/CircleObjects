
using CircleObjects;

double radius = 0;

int i = 0;

bool tryAgain = true;

Console.WriteLine("Welcome to the Circle Tester!");

while (tryAgain)
{
    i++;
    Console.WriteLine("Enter radius: ");

    while (true)
    {
        while (!double.TryParse(Console.ReadLine(), out radius))
        {
            Console.WriteLine("That was not a number, try again:");
        }

        //Create the new circle
        Circle newCircle = new Circle(radius);

        double x = newCircle.CalculateCircumference();
        Console.WriteLine("Circumference: " + newCircle.CalculateFormattedCircumference(x));

        double y = newCircle.CalculateArea();
        Console.WriteLine("Radius:" + newCircle.CalculateFormattedArea(y));
        break;
    }

    Console.WriteLine("Continue? y/n: ");
    string restart = Console.ReadLine().ToLower();

    if (restart != "y")
    {
        tryAgain = false;
    }

    
}
Console.WriteLine($"\nGoodbye! You created {i} Cirle Objects.");

