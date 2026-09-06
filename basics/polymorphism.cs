namespace polymorphism
{
    class Animal
    {
      public virtual void animalSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Cat:Animal
    {
     public override void animalSound()
        {
            Console.WriteLine("Meow");
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
            Animal animal = new Animal();
            Cat cat = new Cat();
            Dog dog = new Dog();
            animal.animalSound();
            cat.animalSound();
            dog.animalSound();
        }
    }
}