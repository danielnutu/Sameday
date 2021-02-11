namespace Sameday.Objects.Service
{
    /// <summary>
    /// Service
    /// </summary>
    public class ServiceObject : IObjectId, IObjectName, IObjectCode
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
        public DeliveryTypeObject DeliveryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public OptionalTaxObject[] OptionalTaxes { get; set; }
    }
}
