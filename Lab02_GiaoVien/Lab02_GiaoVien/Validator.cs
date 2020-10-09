using System.Text;
using System.Text.RegularExpressions;

namespace Lab02_GiaoVien
{
    public class Validator
    {
        private string value;
        private string name;

        public Validator(string value, string name)
        {
            this.value = value.Trim();
            this.name = name.Trim();
        }

        public bool isRequire()
        {
            return value.Length > 0;
        }

        public bool isEmail()
        {
            Regex reg = new Regex(@"\S+@\S+\.\S+");
            return reg.IsMatch(value);
        }

        public string GetErrorMessage()
        {
            StringBuilder builder = new StringBuilder();

            if (!isRequire()) builder.AppendLine(name + " không được để trống");
            if (!isEmail()) builder.AppendLine(value + " không phải là email hợp lệ");

            return builder.ToString();
        }
    }
}
