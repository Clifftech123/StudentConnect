using System.Text.RegularExpressions;

namespace StudentConnect.Domain.Helper
{
    public static class SlugTitleHelper
    {

        public static string GenerateSlug(this string phrase)
        {
            var shortGuid = CreateShortGuid();
            var slug = CreateSlug(phrase);
            return slug + "-" + shortGuid;
        }

        // Create a slug from the title

        private static string CreateSlug(string input)
        {
            var str = input.ToLowerInvariant();

            // invalid chars
            str = Regex.Replace(str, @"[^a-z0-9\s-]", string.Empty);

            // convert multiple spaces into one space
            str = Regex.Replace(str, @"\s+", " ").Trim();

            // cut and trim
            str = str[..(str.Length <= 45 ? str.Length : 45)].Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens
            return str;
        }


        // Create a short guid for the slug

        public static string CreateShortGuid()
        {
            var guid = Guid.NewGuid();
            var enc = Convert.ToBase64String(guid.ToByteArray());
            enc = enc.Replace("/", "_");
            enc = enc.Replace("+", "-");
            return enc.Substring(0, 22);
        }
    }
}
