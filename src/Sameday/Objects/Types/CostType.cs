namespace Sameday.Objects.Types
{
    public class CostType
    {
        public const string FIXED = "Fix";
        public const string PERCENT = "Procentual";

        public CostType(string type)
        {
            Type = type;
        }

        public string Type { get; }
    }
}
