using Sameday.Objects.Types;

namespace Sameday.Objects.Service
{
    /// <summary>
    /// Optional tax for service
    /// </summary>
    public class OptionalTaxObject : IObjectId, IObjectName, IObjectCode
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
        public CostType CostType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float Tax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PackageType PackageType { get; set; }
    }
}
