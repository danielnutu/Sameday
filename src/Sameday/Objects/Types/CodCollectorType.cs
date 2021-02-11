namespace Sameday.Objects.Types
{
    public class CodCollectorType
    {
        // public const int THIRD_PARTY = 0;
        public const int CLIENT = 1;

        public CodCollectorType(int type)
        {
            Type = type;
        }

        public int Type { get; set; }
    }
}
