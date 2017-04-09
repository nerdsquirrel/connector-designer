using System.Collections.Generic;

namespace ConnectorDesigner.App.Models
{
    public abstract class ConnectorEnd
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<File> Images { get; set; }
    }

    public class LeftEnd : ConnectorEnd
    {
        public ICollection<ConnectedRightEnd> ConnectedRightEnds { get; set; }
    }

    public class RightEnd : ConnectorEnd
    {
        public ICollection<ConnectedLeftEnd> ConnectedLeftEnds { get; set; }
    }

    public abstract class ConnectedEnd
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ConnectedRightEnd : ConnectedEnd
    {
       public virtual LeftEnd LeftEnd { get; set; }
    }

    public class ConnectedLeftEnd: ConnectedEnd
    {
        public virtual RightEnd RightEnd { get; set; }
    }
}