namespace DesignPatterns.ServiceLocator;

internal interface IUserService
{
    string GetUserName(Guid id);
}

internal class UserService : IUserService
{
    public string GetUserName(Guid id) => "UserName";
}
