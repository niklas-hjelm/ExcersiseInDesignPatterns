namespace ExcersiseInDesignPatterns.DAL
{
    public interface IUserStorage
    {
        Task<ICollection<User>> GetAllUsers();
    }
}
