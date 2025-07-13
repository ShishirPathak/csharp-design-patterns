namespace BuilderDesignPattern;
using System;

// Step 1 Define the Product (Car)

public class Car
{
    public string Engine {get;set; }
    public string Wheels {get;set;}
    public string Body {get;set; }

    public void ShowSpecification()
    {
        Console.WriteLine($"Engine: {Engine}");
        Console.WriteLine($"Wheels: {Wheels}");
        Console.WriteLine($"Body: {Body}");
    }

}

// Step 2 Define the builder interface

public interface ICarBuilder
{
    void BuildEngine();
    void BuildWheels();
    void BuildBody();

    Car GetCar();
}

// Step 3 Implement Concrete Builder

public class SportsCarBuilder : ICarBuilder
{
    private Car _car = new Car();

    public void  BuildEngine(){
        _car.Engine = "V8 Engine";
    }

    public void BuildWheels(){
        _car.Wheels = "18\" Alloy Wheels";

    }

    public void BuildBody(){
        _car.Body = "Sleek Carbon Fiber Body";
    }

    public Car GetCar(){
        return _car;
    }
}

// Step 4 Define the director

public class CarDirector
{
private ICarBuilder _builder;

public CarDirector(ICarBuilder builder){
    _builder = builder;
}

public void BuildCar(){
    _builder.BuildEngine();
    _builder.BuildWheels();
    _builder.BuildBody();
}

public Car GetCar(){
    return _builder.GetCar();
}



}