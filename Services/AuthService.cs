namespace Giwu.HRMS.Hybrid.Services;

public class AuthService
{
    public bool IsLoggedIn { get; private set; }
    public string UserEmail { get; private set; } = string.Empty;
    public string UserName { get; private set; } = "Jane Dela Cruz";

    public void Login(string email)
    {
        IsLoggedIn = true;
        UserEmail = email;
    }

    public void Logout()
    {
        IsLoggedIn = false;
        UserEmail = string.Empty;
    }
}
