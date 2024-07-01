namespace Liskov_Substitution_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            cat.MakeSound();
            Animal dog = new Dog();
            dog.MakeSound();
        }
    }
}
