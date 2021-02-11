using Sameday.Http;
using System;

namespace Sameday.Requests
{
    public class SamedayPutParcelSizeRequest : ISamedayRequest
    {
        public SamedayPutParcelSizeRequest(string parcel, string weight, string width, string length, string height)
        {
            Parcel = parcel;
            Weight = weight;
            Width = width;
            Length = length;
            Height = height;
        }

        public string Parcel { get; set; }
        public string Weight { get; set; }
        public string Width { get; set; }
        public string Length { get; set; }
        public string Height { get; set; }

        public SamedayRequest BuildRequest()
        {
            throw new NotImplementedException();
        }
    }
}
