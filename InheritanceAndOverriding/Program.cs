﻿using System;

class Animal {
    public virtual void MakeSound() => Console.WriteLine("Some generic sound");
}

class Dog : Animal {
    public override void MakeSound() => Console.WriteLine("Bark");
}

class Cat : Animal {
    public override void MakeSound() => Console.WriteLine("Meow");
}

class Program {
    static void Main() {
        Animal generic = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        generic.MakeSound(); // Some generic sound
        dog.MakeSound();     // Bark
        cat.MakeSound();     // Meow
    }
}