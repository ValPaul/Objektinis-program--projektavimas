using System;

// Abstraction
abstract class Shape
{
    protected Color color;

    public Shape(Color color)
    {
        this.color = color;
    }

    public abstract string Draw();
}

// Implementor
interface Color
{
    string FillColor();
}

// Concrete Implementors
class RedColor : Color
{
    public string FillColor()
    {
        return "Red";
    }
}

class GreenColor : Color
{
    public string FillColor()
    {
        return "Green";
    }
}

// Refined Abstraction
class Circle : Shape
{
    public Circle(Color color) : base(color) { }

    public override string Draw()
    {
        return $"Drawing a {color.FillColor()} Circle";
    }
}

class Square : Shape
{
    public Square(Color color) : base(color) { }

    public override string Draw()
    {
        return $"Drawing a {color.FillColor()} Square";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Color red = new RedColor();
        Color green = new GreenColor();

        Shape redCircle = new Circle(red);
        Shape greenSquare = new Square(green);

        Console.WriteLine(redCircle.Draw());     // Output: Drawing a Red Circle
        Console.WriteLine(greenSquare.Draw());   // Output: Drawing a Green Square
    }
}
