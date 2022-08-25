namespace DesignPatterns.Prototype;
internal class User : Prototype<User>
{
    public User() : base() { }
    public string UserName;
    public string Type;

    public override User Clone() =>
        (User)MemberwiseClone();

    public override string ToString() =>
        $"{Id} {Type} {UserName}";
}
