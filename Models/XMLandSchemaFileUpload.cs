using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Ship_Review.Models
{
    public class XMLandSchemaFileUpload
    {
        [Display(Name = "XML File")]
        public IFormFile XMLFile { get; set; }
        [Display(Name = "Schema File")]
        public IFormFile SchemaFile { get; set; }
    }
}
