namespace App_D
{
    public class Dog
    {
        public int Size { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"App_D - Hund: {Size}, {Age} Jahre alt ()";
        }

    }
}
