namespace Carbon_API.Data.DataStore
{
    public interface DataStoreClass
    {
        string GetName();
        string[] GetParentClasses();
        string[] GetSubClasses();
    }
}