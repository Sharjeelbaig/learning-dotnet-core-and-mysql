namespace Properties
{
    class Person
    {
        public Person(string name)
        {
            this.name = name;
        }
        private string name; 
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person("Liam First");
            Console.WriteLine(myObj.Name);
            myObj.Name = "Liam Second";
            Console.WriteLine(myObj.Name);
        }
    }
}