namespace Business.Contracts
{
    public interface IGetByIDService <T>
    {
        T GetByID(int ID);
    }
}
