using DesignPatterns.Prototype;

User admin = new User
{
    Type = "Admin",
    UserName = "admin"
};

var anotherAdmin = admin.Clone();
anotherAdmin.UserName = "anotherAdmin";

Console.WriteLine(admin.ToString());
Console.WriteLine(anotherAdmin.ToString());

