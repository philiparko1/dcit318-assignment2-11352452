using System;

interface IMoveable {
    void Move();
}

class Car : IMoveable {
    public void Move() => Console.WriteLine("Car is moving");
}

class Bicycle : IMoveable {
    public void Move() => Console.WriteLine("Bicycle is moving");
}

class Program {
    static void Main() {
        IMoveable car = new Car();
        IMoveable bike = new Bicycle();

        car.Move();   // Car is moving
        bike.Move();  // Bicycle is moving
    }
}