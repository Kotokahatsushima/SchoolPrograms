using System;
public class Shapes
{
    public int height, width;
    public string Formula;

    public Shapes()
    {
        this.height = 10;
        this.width = 10;
        this.Formula = "";
    }
}

public class Rectangle : Shapes
{

    public Rectangle()
    {
        Formula = "Rectangle Formula: \n2 * (Length + Width)\n";
        double perimeter = 2*(height + width);
        Console.WriteLine(Formula + "The Perimeter of the rectangle is: " + perimeter + "\n\n");
    }
}

public class Square : Shapes
{

    public Square()
    {
        Formula = "Square Formula: \n2 * (Height * Width)\n";
        double area = height * width;
        Console.WriteLine(Formula + "The Area of the square is: " + area + "\n\n");
    }
}

public class Circle : Shapes
{

    public Circle(int radius)
    {
        Formula = "Circle Formula: \n2 * (Pi * Radius)\n";
        double pi = 3.1415;
        double area = 2 * (pi * radius);
        Console.WriteLine(Formula + "The Area of the circle is: " + area + "\n\n");
    }
}

public class Triangle : Shapes
{

    public Triangle()
    {
        Formula = "Triangle Formula: \n2 / (Width * Height)\n";
        double area = (width * height) / 2;
        Console.WriteLine(Formula + "The Area of the triangle is: " + area + "\n\n");
    }
}

public class MainClass
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle();

        Square square = new Square();

        Circle circle= new Circle(3);

        Triangle triangle = new Triangle();
    }
}

