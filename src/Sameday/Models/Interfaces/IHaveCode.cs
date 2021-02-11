namespace Sameday.Models
{
    /// <summary>
    /// Defines an interface for objects that have a code
    /// </summary>
    public interface IHaveCode
    {
        /// <summary>
        /// Gets or sets the code
        /// </summary>
        string Code { get; set; }
    }
}
