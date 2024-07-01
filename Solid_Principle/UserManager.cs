namespace Single_Responsibility_Principle;

public class UserManager
{
    private readonly UserValidation _userValidation;
    private readonly NotiManager _notiManager;
    private readonly UserRepo _userRepo;
    public UserManager(UserValidation userValidation, NotiManager notiManager, UserRepo userRepo)
    {
        _userValidation = userValidation;
        _notiManager = notiManager;
        _userRepo = userRepo;
    }

    public void AddUser(string email, string password)
    {
        // validation
        if (_userValidation.ValidateUser(email, password))
            throw new ArgumentNullException("email or password cannot be null");

        // add user
        _userRepo.saveUser(email, password);

        // send Email
        _notiManager.sendEmail(email);
    }
    public void UpdateUser(string email, string password)
    {

    }
    public void DeleteUser(string email, string password)
    {

    }

}
