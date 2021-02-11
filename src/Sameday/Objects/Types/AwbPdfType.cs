namespace Sameday.Objects.Types
{
    public class AwbPdfType
    {
        public const string A4 = "A4";
        public const string A6 = "A6";

        public AwbPdfType(string type)
        {
            Type = type;
        }

        public string Type { get; }
    }
}
