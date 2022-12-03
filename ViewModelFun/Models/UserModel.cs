namespace ViewModelFun.Models;

public class UserModel
{
    public string[]? firstName;
    public string[]? lastName;

    public UserModel(string[] fn,string[] ln)
    {
        firstName = fn;
        lastName = ln;
    }
}