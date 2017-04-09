using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConnectorDesigner.App.Models
{
    public class File
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "The {0} must be at most {1} characters long.")]
        public string Name { get; set; }
        [Required]
        public string RelativePath { get; set; }
        public string MimeType { get; set; }
        public int Size { get; set; }    
        public virtual LeftConnectorType LeftConnectorType { get; set; }   
        public virtual RightConnectorType RightConnectorType { get; set; }
        public virtual LeftEnd LeftEnd { get; set; }
        public virtual RightEnd RightEnd { get; set; }
       
    }
}