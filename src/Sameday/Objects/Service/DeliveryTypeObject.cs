namespace Sameday.Objects.Service
{
    /// <summary>
    /// Delivery type for service
    /// </summary>
    public class DeliveryTypeObject : IObjectId, IObjectName
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
    }
}
