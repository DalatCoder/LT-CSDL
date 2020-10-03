using System.Globalization;
using System.Linq;
using System.Text;

namespace Lab02_GiaoVien
{
    public static class Utils
    {
        public static string NormalizeVietnameseString(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            text = text.Normalize(NormalizationForm.FormD);
            var chars = text.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray();
            return new string(chars).Normalize(NormalizationForm.FormC);
        }
    }
}
