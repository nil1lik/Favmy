using Core.Entities;

namespace Domain;

public class User : BaseEntity
{
    public string UserName { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    protected User()
    {
        
    }
    public User(string userName, string email, string password, string firstName, string lastName)
    {
        SetUserName(userName);
        SetEmail(email);
        SetPassword(password);
        SetFirstName(firstName);
        SetLastName(lastName);
    }

    private void SetUserName(string userName)
    {
        UserName = userName;
    }

    private void SetEmail(string email)
    {
        Email = email;
    }

    private void SetPassword(string password)
    {
        Password = password;
    }

    private void SetFirstName(string firstName)
    {
        FirstName = firstName;
    }

    private void SetLastName(string lastName)
    {
        LastName = lastName;
    }
}
