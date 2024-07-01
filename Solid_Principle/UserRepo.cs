namespace Single_Responsibility_Principle;

public class UserRepo
{
    public void saveUser(string email, string password)
    {
        // save user
        Console.WriteLine("Saved user: " + email);
    }
}
