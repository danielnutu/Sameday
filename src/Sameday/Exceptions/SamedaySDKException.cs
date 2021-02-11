using System;

namespace Sameday.Exceptions
{
    public class SamedaySDKException : Exception
    {
        public SamedaySDKException(string message) : base(message)
        {
        }
    }
}
