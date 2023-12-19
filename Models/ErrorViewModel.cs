using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Ship_Review.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class XmlValidationError
    {
        [Display(Name = "XML Element")]
        public string Element { get; set; }
        [Display(Name = "Error Type")]
        public string ErrorType { get; set; }
        [Display(Name = "Line Number")]
        public int Line { get; set; }
        [Display(Name = "Column Number")]
        public int Column { get; set; }
        [Display(Name = "Error Message")]
        public string Message { get; set; }
    }
}