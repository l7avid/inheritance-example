namespace AnimalsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Burbuja", 1);
            Console.WriteLine($"{myDog.Name} is {myDog.Age} years old");
            if (myDog.IsHappy)
            {
                Console.WriteLine($"{myDog.Name} is happy"); 
            }
            else
            {
                Console.WriteLine($"{myDog.Name} is not happy :c");
            }
            myDog.MakeSound();
            myDog.Play();
            myDog.Eat();
        }
    }
}