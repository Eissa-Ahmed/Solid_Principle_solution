namespace Liskov_Substitution_Principle;

public interface Animal
{
    public void MakeSound();
}
public interface IHaha
{
    public void haha();
}

public class Cat : Animal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

public class Dog : Animal, IHaha
{
    public void haha()
    {
        Console.WriteLine("Haha");
    }

    public void MakeSound()
    {
        Console.WriteLine("Woof");
    }

}
