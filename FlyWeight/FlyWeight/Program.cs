using System;
using System.Collections.Generic;

// Flyweight interface
interface IShape
{
    public int Radius { get; set; }
    void Draw(int x, int y);
}

// Concrete Flyweight class
public class Circle : IShape
{
    public int Radius { get; set; }
    private string _color;

    public Circle(string color)
    {
        _color = color;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Drawing a {_color} circle with radius {Radius} at ({x},{y})");
    }
}


// Flyweight Factory class
class ShapeFactory
{
    // Словарь для хранения фигур
    private Dictionary<string, IShape> _shapes = new Dictionary<string, IShape>();

    public IShape GetCircle(string color)
    {
        if (_shapes.ContainsKey(color))
        {
            return _shapes[color];
        }
        else
        {
            Circle circle = new Circle(color);
            _shapes.Add(color, circle);
            return circle;
        }
    }
}

// Client code
class Program
{
    static void Main(string[] args)
    {
        // Завод - который производит фигуры
        ShapeFactory factory = new ShapeFactory();

        // Настройки для моей будущей фигуры
        int x = 10;
        int y = 20;
        int radius = 5;
        string color = "red";

        
        // Создаю круг и записыва его в абстрактный IShape
        IShape circle = factory.GetCircle(color);
        circle.Radius = radius;
        circle.Draw(x, y);

        // Reuse the circle object
        x = 30;
        y = 40;
        radius = 3;
        color = "blue";

        circle = factory.GetCircle(color);
        circle.Radius = radius;
        circle.Draw(x, y);
        
        x = 10;
        y = 20;
        radius = 5;
        color = "blue";

        circle = factory.GetCircle(color);
        circle.Radius = radius;
        circle.Draw(x, y);
    }
}