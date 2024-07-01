namespace Single_Responsibility_Principle;

public class NotiManager
{
    public void sendEmail(string email)
    {
        // send Email
        Console.WriteLine("Email sent to: " + email);
    }
}
