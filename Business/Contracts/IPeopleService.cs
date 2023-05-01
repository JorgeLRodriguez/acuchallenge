using Domain;

namespace Business.Contracts
{
    public interface IPeopleService : IGetAllService<People>, IGetByIDService<People>, IDeleteService<People>
    {

    }
}
