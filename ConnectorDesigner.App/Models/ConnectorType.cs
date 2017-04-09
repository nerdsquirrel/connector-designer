namespace ConnectorDesigner.App.Models
{
    public class ConnectorType
    {
        public int Id { get; set; }
        public bool Select { get; set; }
        public string Type { get; set; }
        public string Impediment { get; set; }
        public string InterfaceFreq { get; set; }
        public string OCP { get; set; }
        public string CEOC { get; set; }
        public string FlangType { get; set; }
        public string ProductDetails { get; set; }      
        public File Image { get; set; } 

    }

    public class LeftConnectorType : ConnectorType
    {
        
    }

    public class RightConnectorType : ConnectorType
    {
       
    }
}