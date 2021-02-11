namespace Sameday.Objects.Types
{
    public class PackageType
    {
        public const int PARCEL = 0;
        public const int ENVELOPE = 1;
        public const int LARGE = 2;

        public PackageType(int type)
        {
            Type = type;
        }

        public int Type { get; set; }
    }
}
