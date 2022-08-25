namespace DesignPatterns.Prototype;
internal class ExampleClass
{
    protected void Method()
    {
        var admin = new User
        {
            Type = "Admin",
            UserName = "admin"
        };

        var anotherAdmin = admin.Clone();
        anotherAdmin.UserName = "anotherAdmin";

        Console.WriteLine(admin.ToString());
        Console.WriteLine(anotherAdmin.ToString());
    }
}
