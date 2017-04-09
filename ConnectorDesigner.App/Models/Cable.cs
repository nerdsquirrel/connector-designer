using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConnectorDesigner.App.Models
{
    public class Cable
    {
        public int Id { get; set; }
        public bool Select { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Impediments { get; set; }
        public string OperationFreq { get; set; }
        public string JackerDiameter { get; set; }
        public string JacketMaterial { get; set; }
        public string CCM { get; set; }
        public string CCD { get; set; }
        public string Attenuation { get; set; }
        public string ProductDetails { get; set; }
        public ICollection<File> Images { get; set; }
             
    }
}