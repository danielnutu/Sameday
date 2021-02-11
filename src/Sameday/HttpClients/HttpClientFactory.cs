using System;

namespace Sameday.HttpClients
{
    public class HttpClientFactory
    {
        private HttpClientFactory()
        {
        }

        public static ISamedayHttpClient CreateHttpClient()
        {
            throw new NotImplementedException();
        }
    }
}
