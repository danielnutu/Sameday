namespace Sameday.Objects.PostAwb
{
    public class ParcelObject
    {
        public ParcelObject(int position, string awbNumber)
        {
            Position = position;
            AwbNumber = awbNumber;
        }

        public int Position { get; set; }
        public string AwbNumber { get; set; }
    }
}
