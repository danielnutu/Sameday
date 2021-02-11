namespace Sameday.Objects.PickupPoint
{
    /// <summary>
    /// Pickup point
    /// </summary>
    public class PickupPointObject : IObjectId
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public CountyObject County { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PickupPoint.CityObject City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Default { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ContactPersonObject[] ContactPersons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Alias { get; set; }
    }
}
