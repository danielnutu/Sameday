namespace Sameday.Objects.Locker
{
    /// <summary>
    /// Locker
    /// </summary>
    public class LockerObject : IObjectId, IObjectName
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
        public string County { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Lat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Long { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public BoxObject[] Boxes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ScheduleObject[] Schedule { get; set; }
    }
}
