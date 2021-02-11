namespace Sameday.Objects.Types
{
    public class PersonType
    {
        public const int INDIVIDUAL = 0;
        public const int COMPANY = 1;

        public PersonType(int type)
        {
            Type = type;
        }

        public int Type { get; set; }
    }
}
