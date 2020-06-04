namespace Sameday
{
    public class Sameday
    {
        public Sameday(ISamedayClient client)
        {
            Client = client;
        }

        public ISamedayClient Client { get; }
    }
}
