using Sameday.Http;
using Sameday.Requests;
using System;

namespace Sameday.Responses
{
    public class SamedayAuthenticateResponse : SamedayResponse
    {
        public SamedayAuthenticateResponse(SamedayAuthenticateRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }

        public string Token { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}
