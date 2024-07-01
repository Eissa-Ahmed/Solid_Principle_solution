namespace Interface_Segregation_Principle;

public interface IVehicle
{
    public void StartEngine();
    public void StopEngine();
    public void Drive();

}
public interface IFly
{
    public void Fly();
}

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }

    public void StartEngine()
    {
        Console.WriteLine("Car is starting");
    }

    public void StopEngine()
    {
        Console.WriteLine("Car is stopping");
    }
}

public class AirPlane : IVehicle, IFly
{
    public void Drive()
    {
        Console.WriteLine("Airplane is driving");
    }

    public void Fly()
    {
        Console.WriteLine("Airplane is flying");
    }

    public void StartEngine()
    {
        Console.WriteLine("Airplane is starting");
    }

    public void StopEngine()
    {
        Console.WriteLine("Airplane is Stopping");
    }
}

