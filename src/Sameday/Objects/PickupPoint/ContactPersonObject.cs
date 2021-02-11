namespace Sameday.Objects.PickupPoint
{
    /// <summary>
    /// Contact person for pickup point
    /// </summary>
    public class ContactPersonObject : IObjectId, IObjectName
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
        public string Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Default { get; set; }
    }
}
