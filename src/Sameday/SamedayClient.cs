using Sameday.Exceptions;
using Sameday.Http;
using Sameday.PersistentData;
using Sameday.Requests;
using Sameday.Responses;
using System;

namespace Sameday
{
    public class SamedayClient : ISamedayClient
    {
        private const string VERSION = "1.8.2";
        private const string API_HOST = "https://api.sameday.ro";
        private const string KEY_TOKEN = "token";
        private const string KEY_TOKEN_EXPIRES = "expires_at";

        private ISamedayPersistentData _persistentDataHandler;

        public SamedayClient()
        {
            _persistentDataHandler = PersistentDataFactory.CreatePersistentDataHandler();
        }

        public string UserName { get; set; }
        public string Password { get; set; }

        public bool Login()
        {
            try
            {
                GetToken(false);
            }
            catch (SamedayAuthenticationException ex)
            {
                return false;
            }

            return true;
        }

        public void Logoff()
        {
            _persistentDataHandler.Set(KEY_TOKEN, null);
            _persistentDataHandler.Set(KEY_TOKEN_EXPIRES, null);
        }

        public SamedayRawResponse SendRequest(SamedayRequest request)
        {
            throw new NotImplementedException();
        }

        private string GetToken(bool usePersistentData = true)
        {
            if (usePersistentData)
            {
                string token = _persistentDataHandler.Get(KEY_TOKEN);
                string expiresAt = _persistentDataHandler.Get(KEY_TOKEN_EXPIRES);

                if (!string.IsNullOrWhiteSpace(token) &&
                    !string.IsNullOrWhiteSpace(expiresAt))
                {
                    var expiresAtDate = DateTime.Parse(expiresAt);
                    if (expiresAtDate > DateTime.Now)
                    {
                        return token;
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(UserName) ||
                string.IsNullOrWhiteSpace(Password))
            {
                throw new SamedaySDKException("UserName or Password not set.");
            }

            var authenticateRequest = new SamedayAuthenticateRequest(UserName, Password);
            var rawResponse = SendRequest(authenticateRequest.BuildRequest());
            var response = new SamedayAuthenticateResponse(authenticateRequest, rawResponse);

            if (usePersistentData)
            {
                _persistentDataHandler.Set(KEY_TOKEN, response.Token);
                _persistentDataHandler.Set(KEY_TOKEN_EXPIRES, response.ExpiresAt.ToString("Y-m-d H:i:s"));
            }

            return response.Token;
        }
    }
}
