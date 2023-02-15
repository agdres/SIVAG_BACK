namespace SIVAG_BACKEND.Interfaces.General
{
    public interface IEntityRep<T>
    {
        Task<List<T>> GetAll();
        Task<bool> Insert(T data);
        Task<bool> Update(T data);
        Task<bool> ChangeEstatus(int id);
    }
}
