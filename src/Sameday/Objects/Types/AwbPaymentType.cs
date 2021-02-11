namespace Sameday.Objects.Types
{
    public class AwbPaymentType
    {
        public const int CLIENT = 1;
        // public const int RECIPIENT = 2;
        // public const int THIRD_PARTY = 3;

        public AwbPaymentType(int type)
        {
            Type = type;
        }

        public int Type { get; set; }
    }
}
