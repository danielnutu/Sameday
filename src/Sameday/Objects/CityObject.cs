namespace Sameday.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public class CityObject : IObjectId, IObjectName, IObjectCode
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public CountyObject Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ExtraKM { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Village { get; set; }
    }
}
