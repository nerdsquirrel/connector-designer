using ConnectorDesigner.App.Dbcontext;
using ConnectorDesigner.App.Models;
using System.Collections.Generic;
using System.Linq;

namespace ConnectorDesigner.App.App_Start
{
    public partial class SeedData
    {
        public static void Execute()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                if (!dbContext.Cables.Any())
                {
                    SeedCableData(dbContext);                   
                }

                if (!dbContext.LeftConnectorTypes.Any())
                {
                    SeedLeftConnectorTypes(dbContext);                   
                }

                if (!dbContext.RightConnectorTypes.Any())
                {
                    SeedRightConnectorTypes(dbContext);
                }

                if (!dbContext.LeftEnds.Any())
                {
                    SeedLeftEndData(dbContext);                   
                }

                if (!dbContext.RightEnds.Any())
                {
                    SeedRightEndData(dbContext);                   
                }
            }
        }

        static void SeedCableData(ApplicationDbContext dbContext)
        {
            var cables = new List<Cable> 
            {
                new Cable {
                    Select= false,Description = "PE Foam cross-linked - 50 Ohm - double screen (UL AWM Style 3651) ",
                    Type="ENVIROFLEX_142", Impediments="50",OperationFreq="60", JackerDiameter="5",JacketMaterial="RADOX ",
                    CCM="Copper, Silver plated",CCD="wire", Attenuation="1.70 dB/m at 6 GHz ",ProductDetails="http://www.hubersuhner.com/ProdDet/4503107",
                    Images= new List<File>{
                        new File{
                         Name="black",
                        RelativePath="/content/cable/black_1.gif",
                        MimeType="image/gif"}
                       
                    }
                }, new Cable {
                    Select= false,Description = "PE Foam cross-linked - 50 Ohm - double screen (UL AWM Style 3651) ",
                    Type="ENVIROFLEX_142", Impediments="50",OperationFreq="60", JackerDiameter="5",JacketMaterial="RADOX ",
                    CCM="Copper, Silver plated",CCD="wire", Attenuation="1.70 dB/m at 6 GHz ",ProductDetails="http://www.hubersuhner.com/ProdDet/4503107",
                    Images= new List<File>{
                        new File{
                         Name="black",
                        RelativePath="/content/cable/blue_1.gif",
                        MimeType="image/gif"}
                       
                    }
                }, new Cable {
                 Select= false,Description = "PE Foam cross-linked - 50 Ohm - double screen (UL AWM Style 3651) ",
                    Type="ENVIROFLEX_142", Impediments="50",OperationFreq="60", JackerDiameter="5",JacketMaterial="RADOX ",
                    CCM="Copper, Silver plated",CCD="wire", Attenuation="1.70 dB/m at 6 GHz ",ProductDetails="http://www.hubersuhner.com/ProdDet/4503107",
                    Images= new List<File>{
                        new File{
                         Name="black",
                        RelativePath="/content/cable/brown_1.gif",
                        MimeType="image/gif"}
                       
                    }
                }, new Cable {
                 Select= false,Description = "PE Foam cross-linked - 50 Ohm - double screen (UL AWM Style 3651) ",
                    Type="ENVIROFLEX_142", Impediments="50",OperationFreq="60", JackerDiameter="5",JacketMaterial="RADOX ",
                    CCM="Copper, Silver plated",CCD="wire", Attenuation="1.70 dB/m at 6 GHz ",ProductDetails="http://www.hubersuhner.com/ProdDet/4503107",
                    Images= new List<File>{
                        new File{
                         Name="black",
                        RelativePath="/content/cable/blackblue_1.gif",
                        MimeType="image/gif"}
                       
                    }
                }, new Cable {
                Select= false,Description = "PE Foam cross-linked - 50 Ohm - double screen (UL AWM Style 3651) ",
                    Type="ENVIROFLEX_142", Impediments="50",OperationFreq="60", JackerDiameter="5",JacketMaterial="RADOX ",
                    CCM="Copper, Silver plated",CCD="wire", Attenuation="1.70 dB/m at 6 GHz ",ProductDetails="http://www.hubersuhner.com/ProdDet/4503107",
                    Images= new List<File>{
                        new File{
                         Name="black",
                        RelativePath="/content/cable/gray_1.gif",
                        MimeType="image/gif"}
                       
                    }
                }
            };

            dbContext.Cables.AddRange(cables);
            dbContext.SaveChanges();
        }

        static void SeedLeftConnectorTypes(ApplicationDbContext dbContext)
        {
            var connectorTypes = new List<LeftConnectorType>
            {
                new LeftConnectorType{
                    Select= false,Type="11_BNC-50-3-54/103_N",Impediment="50",
                    InterfaceFreq="4", OCP="Silver Plating", CEOC="soldered ", FlangType="no",
                    ProductDetails="http://www.hubersuhner.com/ProdDet/1596716",
                     Image=  new File{
                        Name="black",
                        RelativePath="/content/connectorTypeImg/Left/1.jpg",
                        MimeType="image/jpg"}
                },new LeftConnectorType{
                    Select= false,Type="11_BNC-50-3-54/103_N",Impediment="50",
                    InterfaceFreq="4", OCP="Silver Plating", CEOC="soldered ", FlangType="no",
                    ProductDetails="http://www.hubersuhner.com/ProdDet/1596716",
                    Image= new File{
                         Name="black",
                        RelativePath="/content/connectorTypeImg/Left/2.jpg",
                        MimeType="image/jpg"}
                    },
                new LeftConnectorType{
                    Select= false,Type="11_BNC-50-3-54/103_N",Impediment="50",
                    InterfaceFreq="4", OCP="Silver Plating", CEOC="soldered ", FlangType="no",
                    ProductDetails="http://www.hubersuhner.com/ProdDet/1596716",
                     Image= new File{
                         Name="black",
                        RelativePath="/content/connectorTypeImg/Left/3.jpg",
                        MimeType="image/jpg"}

                },
                new LeftConnectorType{
                    Select= false,Type="11_BNC-50-3-54/103_N",Impediment="50",
                    InterfaceFreq="4", OCP="Silver Plating", CEOC="soldered ", FlangType="no",
                    ProductDetails="http://www.hubersuhner.com/ProdDet/1596716",
                    Image= new File{
                         Name="black",
                        RelativePath="/content/connectorTypeImg/Left/4.jpg",
                        MimeType="image/jpg"}
                    },
                new LeftConnectorType{
                    Select= false,Type="11_BNC-50-3-54/103_N",Impediment="50",
                    InterfaceFreq="4", OCP="Silver Plating", CEOC="soldered ", FlangType="no",
                    ProductDetails="http://www.hubersuhner.com/ProdDet/1596716",
                    Image= new File{
                         Name="black",
                        RelativePath="/content/connectorTypeImg/Left/5.jpg",
                        MimeType="image/jpg"}
                    }
            };
            dbContext.LeftConnectorTypes.AddRange(connectorTypes);
            dbContext.SaveChanges();
        }

        static void SeedRightConnectorTypes(ApplicationDbContext dbContext)
        {
            var connectorTypes = new List<RightConnectorType>
            {
                new RightConnectorType{
                    Select= false,Type="11_BNC-50-3-54/103_N",Impediment="50",
                    InterfaceFreq="4", OCP="Silver Plating", CEOC="soldered ", FlangType="no",
                    ProductDetails="http://www.hubersuhner.com/ProdDet/1596716",
                     Image=  new File{
                        Name="black",
                        RelativePath="/content/connectorTypeImg/Right/1.jpg",
                        MimeType="image/jpg"}
                },new RightConnectorType{
                    Select= false,Type="11_BNC-50-3-54/103_N",Impediment="50",
                    InterfaceFreq="4", OCP="Silver Plating", CEOC="soldered ", FlangType="no",
                    ProductDetails="http://www.hubersuhner.com/ProdDet/1596716",
                    Image= new File{
                         Name="black",
                        RelativePath="/content/connectorTypeImg/Right/2.jpg",
                        MimeType="image/jpg"}
                    },
                new RightConnectorType{
                    Select= false,Type="11_BNC-50-3-54/103_N",Impediment="50",
                    InterfaceFreq="4", OCP="Silver Plating", CEOC="soldered ", FlangType="no",
                    ProductDetails="http://www.hubersuhner.com/ProdDet/1596716",
                     Image= new File{
                         Name="black",
                        RelativePath="/content/connectorTypeImg/Right/3.jpg",
                        MimeType="image/jpg"}

                },
                new RightConnectorType{
                    Select= false,Type="11_BNC-50-3-54/103_N",Impediment="50",
                    InterfaceFreq="4", OCP="Silver Plating", CEOC="soldered ", FlangType="no",
                    ProductDetails="http://www.hubersuhner.com/ProdDet/1596716",
                    Image= new File{
                         Name="black",
                        RelativePath="/content/connectorTypeImg/Right/4.jpg",
                        MimeType="image/jpg"}
                    },
                new RightConnectorType{
                    Select= false,Type="11_BNC-50-3-54/103_N",Impediment="50",
                    InterfaceFreq="4", OCP="Silver Plating", CEOC="soldered ", FlangType="no",
                    ProductDetails="http://www.hubersuhner.com/ProdDet/1596716",
                    Image= new File{
                         Name="black",
                        RelativePath="/content/connectorTypeImg/Right/5.jpg",
                        MimeType="image/jpg"}
                    }
            };
            dbContext.RightConnectorTypes.AddRange(connectorTypes);
            dbContext.SaveChanges();
        }

    }
}