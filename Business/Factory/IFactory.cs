using Business.Contracts;

namespace Business.Factory
{
    public interface IFactory : IDisposable
    {
        IPeopleService PeopleService { get; }
    }
}