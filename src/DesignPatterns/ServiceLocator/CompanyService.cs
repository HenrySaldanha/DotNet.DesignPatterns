namespace DotNet.DesignPatterns.ServiceLocator;

internal interface ICompanyService
{
    string GetCompanyName(Guid id);
}

internal class CompanyService : ICompanyService
{
    public string GetCompanyName(Guid id) => "CompanyName";
}
