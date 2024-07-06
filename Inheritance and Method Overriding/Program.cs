
using System;
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main()
    {
        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        Console.WriteLine("Animal makes:");
        animal.MakeSound();

        Console.WriteLine("\nDog makes:");
        dog.MakeSound();

        Console.WriteLine("\nCat makes:");
        cat.MakeSound();
    }
}