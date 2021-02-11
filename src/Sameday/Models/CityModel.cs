namespace Sameday.Models
{
    /// <summary>
    /// Defines a city model
    /// </summary>
    public class CityModel : IHaveId, IHaveName, IHaveCode
    {
        /// <inheritdoc />
        public int Id { get; set; }

        /// <inheritdoc />
        public string Name { get; set; }

        /// <inheritdoc />
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the county
        /// </summary>
        public CountyModel County { get; set; }

        /// <summary>
        /// Gets or sets the postal code
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the extra kilometers
        /// </summary>
        public int ExtraKM { get; set; }

        /// <summary>
        /// Gets or sets the village name
        /// </summary>
        public string Village { get; set; }
    }
}
