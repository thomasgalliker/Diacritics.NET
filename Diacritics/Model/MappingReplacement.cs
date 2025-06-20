using System;

namespace Diacritics
{
    public struct MappingReplacement : IEquatable<MappingReplacement>
    {
        public MappingReplacement(string @base, string decompose, string decomposeTitle) : this()
        {
            this.Base = @base;
            this.Decompose = decompose;
            this.DecomposeTitle = decomposeTitle;
        }

        public string Base { get; set; }

        public string Decompose { get; set; }

        public string DecomposeTitle { get; set; }

        public static implicit operator MappingReplacement(string value) => new MappingReplacement(value, null, null);

        public bool Equals(MappingReplacement other)
        {
            return string.Equals(this.Base, other.Base, StringComparison.Ordinal) &&
                   string.Equals(this.Decompose, other.Decompose, StringComparison.Ordinal) &&
                   string.Equals(this.DecomposeTitle, other.DecomposeTitle, StringComparison.Ordinal);
        }

        public override bool Equals(object obj)
        {
            return obj is MappingReplacement other && this.Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (this.Base != null ? StringComparer.Ordinal.GetHashCode(this.Base) : 0);
                hashCode = (hashCode * 397) ^ (this.Decompose != null ? StringComparer.Ordinal.GetHashCode(this.Decompose) : 0);
                hashCode = (hashCode * 397) ^ (this.DecomposeTitle != null ? StringComparer.Ordinal.GetHashCode(this.DecomposeTitle) : 0);
                return hashCode;
            }
        }

        public static bool operator ==(MappingReplacement left, MappingReplacement right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(MappingReplacement left, MappingReplacement right)
        {
            return !left.Equals(right);
        }
    }
}
