namespace Sameday.PersistentData
{
    public interface ISamedayPersistentData
    {
        string Get(string key);
        void Set(string key, string value);
    }
}
