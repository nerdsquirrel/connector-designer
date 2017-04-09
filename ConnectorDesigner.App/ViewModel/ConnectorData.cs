using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConnectorDesigner.App.Models
{
    public class GroupViewModel
    {
        public List<LeftEnd> LeftEnds { get; set; }
        public List<RightEnd> RightEnds { get; set; }
        public List<Cable> Cables { get; set; }
        public List<LeftConnectorType> LeftTypes { get; set; }
        public List<RightConnectorType> RightTypes { get; set; }
    }
}