using System;

namespace Sameday.Objects.AwbStatusHistory
{
    /// <summary>
    /// 
    /// </summary>
    public class SummaryObject
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime DeliveredAt { get; set; }

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
        public float ServicePayment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string AwbNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float AwbWeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float CashOnDelivery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int RedirectionAttempts { get; set; }
    }
}
