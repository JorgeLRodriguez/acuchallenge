namespace Business.Contracts
{
    public interface IGetAllService <T>
    {
        List<T> GetAll();
    }
}
