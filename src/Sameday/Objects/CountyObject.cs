namespace Sameday.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public class CountyObject : IObjectId, IObjectName, IObjectCode
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
    }
}
