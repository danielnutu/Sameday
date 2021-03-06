﻿using Sameday.Http;
using System;

namespace Sameday.Requests
{
    public class SamedayGetCitiesRequest : ISamedayPaginatedRequest
    {
        public SamedayGetCitiesRequest(int countyId = 0, string name = null, string postalCode = null)
        {
            CountyId = countyId;
            Name = name;
            PostalCode = postalCode;
        }

        public int CountyId { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public int Page { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CountPerPage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public SamedayRequest BuildRequest()
        {
            throw new NotImplementedException();
        }
    }
}
