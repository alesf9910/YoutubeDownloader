using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace YoutubeDownloader
{
    public class PortValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int port;
            if (int.TryParse(value.ToString(), out port)) 
            {
                return new ValidationResult(true, null);
            }
            else
            {
                return new ValidationResult(false, "No es un puerto");
            }
        }
    }
}