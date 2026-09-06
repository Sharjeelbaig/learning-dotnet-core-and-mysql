namespace Interface {
    interface IAnimal
    {
        void animalSound();
    }

    class Cat : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("Meow Meow");
        }
    }

    class Dog : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("Bhau Bhau!");
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