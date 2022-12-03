
#pragma warning disable CS8618
namespace ViewModelFun.Models;

public class Friend
{
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public string? Location {get;set;}
    public int Age {get; set;}

    public Friend(string fn, string ln, string? l, int a)
    {
        FirstName = fn;
        LastName = ln;
        Location = l;
        Age = a;
    }

}