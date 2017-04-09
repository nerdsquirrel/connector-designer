using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConnectorDesigner.App.Models
{
    public class PdfInformation
    {
        public string ConfigName { get; set; }
        public int LeftConnectorTypeId { get; set; }
        public int RightConnectorTypeId { get; set; }
        public int CableId { get; set; }
        public string Length { get; set; }
        public string Unit { get; set; }
        public string StandardTolerance { get; set; }
        public string ChoosenTolarance { get; set; }
    }
}