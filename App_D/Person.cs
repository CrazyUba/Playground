namespace App_D
{
    public class Person
    {
        public string Name { get; private set; }

        public string City { get; private set; }

        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            City = "Köln";
        }

        public override string ToString()
        {
            return $"App_D: {Name}, {Age} Jahre alt (Test)";
        }
    }
}
