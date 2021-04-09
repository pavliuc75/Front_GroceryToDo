namespace Front_GroceryToDo.Data
{
    public interface IUserService
    {
        int GetCachedId();
        void SetCachedId(int id);
    }
}