namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        public static bool NotEmpty(this string @this) 
            => !string.IsNullOrEmpty(@this);
    }
}