namespace Sameday.Models
{
    /// <summary>
    /// Defines an interface for objects that have an identifier
    /// </summary>
    public interface IHaveId
    {
        /// <summary>
        /// Gets or sets the identifier
        /// </summary>
        int Id { get; set; }
    }
}
