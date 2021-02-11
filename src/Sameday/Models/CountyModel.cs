namespace Sameday.Models
{
    /// <summary>
    /// Defines a county model
    /// </summary>
    public class CountyModel : IHaveId, IHaveName, IHaveCode
    {
        /// <inheritdoc />
        public int Id { get; set; }

        /// <inheritdoc />
        public string Name { get; set; }

        /// <inheritdoc />
        public string Code { get; set; }
    }
}
