namespace Single_Responsibility_Principle;

public class UserValidation
{
    public bool ValidateUser(string email, string password)
    {
        // validation
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            return false;
        return true;
    }

}
