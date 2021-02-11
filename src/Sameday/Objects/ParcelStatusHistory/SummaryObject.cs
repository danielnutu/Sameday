using System;

namespace Sameday.Objects.ParcelStatusHistory
{
    /// <summary>
    /// Summary for parcel status
    /// </summary>
    public class SummaryObject
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime? DeliveredAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? LastDeliveryAttempt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Delivered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Canceled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int DeliveryAttempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ParcelAwbNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float ParcelWeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool PickedUp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? PickedUpAt { get; set; }
    }
}
