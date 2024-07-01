namespace Dependency_Inversion_Principle;
public interface IMessage
{
    public void Send(string message);
}

public class EmailService : IMessage
{
    public void Send(string message)
    {
        Console.WriteLine($"Email {message}");
    }
}
public class SmsService : IMessage
{
    public void Send(string message)
    {
        Console.WriteLine($"Sms {message}");
    }
}

public class Noti
{
    private readonly IMessage _message;
    public Noti(IMessage message)
    {
        _message = message;
    }

    public void Notify(string message)
    {
        _message.Send(message);
    }
}