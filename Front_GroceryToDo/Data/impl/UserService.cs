namespace Front_GroceryToDo.Data.impl
{
    public class UserService : IUserService
    {
        private int cachedId;

        public int GetCachedId()
        {
            return cachedId;
        }

        public void SetCachedId(int id)
        {
            cachedId = id;
        }
    }
}