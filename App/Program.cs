
using Figures;

void PrintArea(Figure figure)
{
    Console.WriteLine("The area is equal to " + figure.Area());
}

Circle circle = new Circle(3.5);
PrintArea(circle);

Triangle triangle = new Triangle(3, 10, 8);
PrintArea(triangle);