namespace Sameday.PersistentData
{
    public abstract class PersistentDataFactory
    {
        public static ISamedayPersistentData CreatePersistentDataHandler()
        {
            return new SamedayMemoryPersistentDataHandler();
        }
    }
}
