namespace Sameday.Objects.PickupPoint
{
    /// <summary>
    /// City for pickup point
    /// </summary>
    public class CityObject : IObjectId, IObjectName
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
        public string DeliveryAgency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PickupAgency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ExtraKm { get; set; }
    }
}
