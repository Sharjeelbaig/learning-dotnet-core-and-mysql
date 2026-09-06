namespace Abstraction
{
    abstract class Animal
    {
        public abstract void animalSound();
    }

    class Cat:Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Meow Meow");
        }
    }

    class Dog:Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Bhau Bhau");
        }
    }

    class Program
    {
        static void Main()
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.animalSound();
            dog.animalSound();
        }
    }
}