using System;

namespace Sameday.Models.Types
{
    public class CostType : IEquatable<CostType>
    {
        private readonly string _type;
        private int _hashcode;

        private static readonly CostType _fixed = new CostType("Fix");
        private static readonly CostType _percent = new CostType("Procentual");

        public static CostType Fixed
        {
            get { return _fixed; }
        }

        public static CostType Percent
        {
            get { return _percent; }
        }

        public CostType(string type)
        {
            if (string.IsNullOrWhiteSpace(type)) throw new ArgumentException("Cost type is empty.");

            _type = type;
        }

        public bool Equals(CostType other)
        {
            if ((object)other == null)
            {
                return false;
            }

            if (object.ReferenceEquals(_type, other._type))
            {
                return true;
            }

            return string.Equals(_type, other._type, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as CostType);
        }

        public override int GetHashCode()
        {
            if (_hashcode == 0)
            {
                _hashcode = StringComparer.OrdinalIgnoreCase.GetHashCode(_type);
            }

            return _hashcode;
        }

        public override string ToString()
        {
            return _type;
        }

        public static bool operator ==(CostType left, CostType right)
        {
            return (object)left == null || (object)right == null ?
                ReferenceEquals(left, right) :
                left.Equals(right);
        }

        public static bool operator !=(CostType left, CostType right)
        {
            return !(left == right);
        }
    }
}
