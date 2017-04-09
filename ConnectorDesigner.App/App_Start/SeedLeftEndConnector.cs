using ConnectorDesigner.App.Dbcontext;
using ConnectorDesigner.App.Models;
using System.Collections.Generic;
using System.Linq;

namespace ConnectorDesigner.App.App_Start
{
    public partial class SeedData
    {
        static void SeedLeftEndData(ApplicationDbContext dbContext)
        {
            var leftEnds = new List<LeftEnd>();
            var rightEndNameList = new List<ConnectedRightEnd>
                {
                    new ConnectedRightEnd
                    {
                        Name="BNC"
                    }, new ConnectedRightEnd
                    {
                        Name="C"
                    }, new ConnectedRightEnd
                    {
                        Name="MCX"
                    },new ConnectedRightEnd
                    {
                        Name="MMBX"
                    }, new ConnectedRightEnd
                    {
                        Name="MMCX"
                    },new ConnectedRightEnd
                    {
                        Name="N"
                    }, new ConnectedRightEnd
                    {
                        Name="PC 3.5"
                    },new ConnectedRightEnd
                    {
                        Name="QLA"
                    }, new ConnectedRightEnd
                    {
                        Name="QMA"
                    },new ConnectedRightEnd
                    {
                        Name="QN"
                    }, new ConnectedRightEnd
                    {
                        Name="SMA"
                    },new ConnectedRightEnd
                    {
                        Name="SMB"
                    }, new ConnectedRightEnd
                    {
                        Name="SMC"
                    },new ConnectedRightEnd
                    {
                        Name="TNC"
                    }, new ConnectedRightEnd
                    {
                        Name="10/23"
                    },new ConnectedRightEnd
                    {
                        Name="7/16"
                    }
                };           


            leftEnds.Add(new LeftEnd
            {
                Name = "BNC",
                ConnectedRightEnds= new List<ConnectedRightEnd>(rightEndNameList),
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Left/BNC/1.gif",
                            MimeType="image/gif"
                }, new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Left/BNC/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Left/BNC/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Left/BNC/4.gif",
                            MimeType="image/gif"
                },new File{
                            Name="flange",
                            RelativePath="/content/connectorEndImg/Left/BNC/5.gif",
                            MimeType="image/gif"
                }

        }
            });


            leftEnds.Add(new LeftEnd
            {
                Name = "C",
                ConnectedRightEnds = new List<ConnectedRightEnd> {
                     new ConnectedRightEnd
                    {
                        Name="BNC"
                    }, new ConnectedRightEnd
                    {
                        Name="C"
                    }, new ConnectedRightEnd
                    {
                        Name="N"
                    }, new ConnectedRightEnd
                    {
                        Name="QN"
                    }, new ConnectedRightEnd
                    {
                        Name="TNC"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Left/C/1.gif",
                            MimeType="image/gif"
                }
           }
            });

            leftEnds.Add(new LeftEnd
            {
                Name = "MCX",
                ConnectedRightEnds= new List<ConnectedRightEnd> {
                     new ConnectedRightEnd
                    {
                        Name="BNC"
                    }, new ConnectedRightEnd
                    {
                        Name="MCX"
                    },new ConnectedRightEnd
                    {
                        Name="MMBX"
                    }, new ConnectedRightEnd
                    {
                        Name="MMCX"
                    },new ConnectedRightEnd
                    {
                        Name="N"
                    }, new ConnectedRightEnd
                    {
                        Name="PC 3.5"
                    },new ConnectedRightEnd
                    {
                        Name="QLA"
                    }, new ConnectedRightEnd
                    {
                        Name="QMA"
                    },new ConnectedRightEnd
                    {
                        Name="QN"
                    }, new ConnectedRightEnd
                    {
                        Name="SMA"
                    },new ConnectedRightEnd
                    {
                        Name="SMB"
                    }, new ConnectedRightEnd
                    {
                        Name="SMC"
                    },new ConnectedRightEnd
                    {
                        Name="TNC"
                    }, new ConnectedRightEnd
                    {
                        Name="10/23"
                    },new ConnectedRightEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Left/MCX/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Left/MCX/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Left/MCX/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Left/MCX/4.gif",
                            MimeType="image/gif"
                }

}
            });

            leftEnds.Add(new LeftEnd
            {
                Name = "MMBX",
                ConnectedRightEnds= new List<ConnectedRightEnd> {
                 new ConnectedRightEnd
                    {
                        Name="BNC"
                    }, new ConnectedRightEnd
                    {
                        Name="MCX"
                    },new ConnectedRightEnd
                    {
                        Name="MMBX"
                    }, new ConnectedRightEnd
                    {
                        Name="MMCX"
                    },new ConnectedRightEnd
                    {
                        Name="N"
                    }, new ConnectedRightEnd
                    {
                        Name="QLA"
                    }, new ConnectedRightEnd
                    {
                        Name="QMA"
                    },new ConnectedRightEnd
                    {
                        Name="QN"
                    }, new ConnectedRightEnd
                    {
                        Name="SMA"
                    },new ConnectedRightEnd
                    {
                        Name="SMB"
                    }, new ConnectedRightEnd
                    {
                        Name="SMC"
                    },new ConnectedRightEnd
                    {
                        Name="TNC"
                    }, new ConnectedRightEnd
                    {
                        Name="10/23"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Left/MMBX/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Left/MMBX/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Left/MMBX/4.gif",
                            MimeType="image/gif"
                }

}
            });

            leftEnds.Add(new LeftEnd
            {
                Name = "MMCX",
                ConnectedRightEnds= new List<ConnectedRightEnd> {
                     new ConnectedRightEnd
                    {
                        Name="BNC"
                    }, new ConnectedRightEnd
                    {
                        Name="MCX"
                    },new ConnectedRightEnd
                    {
                        Name="MMBX"
                    }, new ConnectedRightEnd
                    {
                        Name="MMCX"
                    },new ConnectedRightEnd
                    {
                        Name="N"
                    }, new ConnectedRightEnd
                    {
                        Name="QLA"
                    }, new ConnectedRightEnd
                    {
                        Name="QMA"
                    },new ConnectedRightEnd
                    {
                        Name="QN"
                    }, new ConnectedRightEnd
                    {
                        Name="SMA"
                    },new ConnectedRightEnd
                    {
                        Name="SMB"
                    }, new ConnectedRightEnd
                    {
                        Name="SMC"
                    },new ConnectedRightEnd
                    {
                        Name="TNC"
                    }, new ConnectedRightEnd
                    {
                        Name="10/23"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Left/MMCX/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Left/MMCX/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Left/MMCX/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Left/MMCX/4.gif",
                            MimeType="image/gif"
                }

}
            });

            leftEnds.Add(new LeftEnd
            {
                Name = "N",
                ConnectedRightEnds= new List<ConnectedRightEnd> {
                     new ConnectedRightEnd
                    {
                        Name="BNC"
                    }, new ConnectedRightEnd
                    {
                        Name="C"
                    }, new ConnectedRightEnd
                    {
                        Name="MCX"
                    },new ConnectedRightEnd
                    {
                        Name="MMBX"
                    }, new ConnectedRightEnd
                    {
                        Name="MMCX"
                    },new ConnectedRightEnd
                    {
                        Name="N"
                    }, new ConnectedRightEnd
                    {
                        Name="PC 3.5"
                    },new ConnectedRightEnd
                    {
                        Name="QLA"
                    }, new ConnectedRightEnd
                    {
                        Name="QMA"
                    },new ConnectedRightEnd
                    {
                        Name="QN"
                    }, new ConnectedRightEnd
                    {
                        Name="SMA"
                    },new ConnectedRightEnd
                    {
                        Name="SMB"
                    }, new ConnectedRightEnd
                    {
                        Name="SMC"
                    },new ConnectedRightEnd
                    {
                        Name="TNC"
                    }, new ConnectedRightEnd
                    {
                        Name="10/23"
                    },new ConnectedRightEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Left/N/1.gif",
                            MimeType="image/gif"
                }, new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Left/N/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Left/N/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Left/N/4.gif",
                            MimeType="image/gif"
                },new File{
                            Name="flange",
                            RelativePath="/content/connectorEndImg/Left/N/5.gif",
                            MimeType="image/gif"
                }

        }
            });


            leftEnds.Add(new LeftEnd
            {
                Name = "PC 3.5",
                ConnectedRightEnds= new List<ConnectedRightEnd> {
                     new ConnectedRightEnd
                    {
                        Name="BNC"
                    }, new ConnectedRightEnd
                    {
                        Name="MCX"
                    }, new ConnectedRightEnd
                    {
                        Name="N"
                    }, new ConnectedRightEnd
                    {
                        Name="PC 3.5"
                    }, new ConnectedRightEnd
                    {
                        Name="QMA"
                    },new ConnectedRightEnd
                    {
                        Name="QN"
                    }, new ConnectedRightEnd
                    {
                        Name="SMA"
                    }, new ConnectedRightEnd
                    {
                        Name="TNC"
                    }, new ConnectedRightEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Left/PC3.5/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Left/PC3.5/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Left/PC3.5/4.gif",
                            MimeType="image/gif"
                }

}
            });

            leftEnds.Add(new LeftEnd
            {
                Name = "QLA",
                ConnectedRightEnds= new List<ConnectedRightEnd> {
                     new ConnectedRightEnd
                    {
                        Name="BNC"
                    }, new ConnectedRightEnd
                    {
                        Name="MCX"
                    },new ConnectedRightEnd
                    {
                        Name="MMBX"
                    }, new ConnectedRightEnd
                    {
                        Name="MMCX"
                    }, new ConnectedRightEnd
                    {
                        Name="N"
                    }, new ConnectedRightEnd
                    {
                        Name="QLA"
                    }, new ConnectedRightEnd
                    {
                        Name="QMA"
                    },new ConnectedRightEnd
                    {
                        Name="QN"
                    }, new ConnectedRightEnd
                    {
                        Name="SMA"
                    },new ConnectedRightEnd
                    {
                        Name="SMB"
                    }, new ConnectedRightEnd
                    {
                        Name="SMC"
                    },new ConnectedRightEnd
                    {
                        Name="TNC"
                    }, new ConnectedRightEnd
                    {
                        Name="10/23"
                    },new ConnectedRightEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Left/QLA/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Left/QLA/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Left/QLA/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Left/QLA/4.gif",
                            MimeType="image/gif"
                }

}
            });

            leftEnds.Add(new LeftEnd
            {
                Name = "QMA",
                ConnectedRightEnds= new List<ConnectedRightEnd> {
                     new ConnectedRightEnd
                    {
                        Name="BNC"
                    }, new ConnectedRightEnd
                    {
                        Name="MCX"
                    },new ConnectedRightEnd
                    {
                        Name="MMBX"
                    }, new ConnectedRightEnd
                    {
                        Name="MMCX"
                    },new ConnectedRightEnd
                    {
                        Name="N"
                    }, new ConnectedRightEnd
                    {
                        Name="PC 3.5"
                    },new ConnectedRightEnd
                    {
                        Name="QLA"
                    }, new ConnectedRightEnd
                    {
                        Name="QMA"
                    },new ConnectedRightEnd
                    {
                        Name="QN"
                    }, new ConnectedRightEnd
                    {
                        Name="SMA"
                    },new ConnectedRightEnd
                    {
                        Name="SMB"
                    }, new ConnectedRightEnd
                    {
                        Name="SMC"
                    },new ConnectedRightEnd
                    {
                        Name="TNC"
                    }, new ConnectedRightEnd
                    {
                        Name="10/23"
                    },new ConnectedRightEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Left/QMA/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Left/QMA/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Left/QMA/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Left/QMA/4.gif",
                            MimeType="image/gif"
                }

}
            });

            leftEnds.Add(new LeftEnd
            {
                Name = "QN",
                ConnectedRightEnds= new List<ConnectedRightEnd> {
                     new ConnectedRightEnd
                    {
                        Name="BNC"
                    }, new ConnectedRightEnd
                    {
                        Name="C"
                    }, new ConnectedRightEnd
                    {
                        Name="MCX"
                    },new ConnectedRightEnd
                    {
                        Name="MMBX"
                    }, new ConnectedRightEnd
                    {
                        Name="MMCX"
                    },new ConnectedRightEnd
                    {
                        Name="N"
                    }, new ConnectedRightEnd
                    {
                        Name="PC 3.5"
                    },new ConnectedRightEnd
                    {
                        Name="QLA"
                    }, new ConnectedRightEnd
                    {
                        Name="QMA"
                    },new ConnectedRightEnd
                    {
                        Name="QN"
                    }, new ConnectedRightEnd
                    {
                        Name="SMA"
                    },new ConnectedRightEnd
                    {
                        Name="SMB"
                    }, new ConnectedRightEnd
                    {
                        Name="SMC"
                    },new ConnectedRightEnd
                    {
                        Name="TNC"
                    }, new ConnectedRightEnd
                    {
                        Name="10/23"
                    },new ConnectedRightEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Left/QN/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Left/QN/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Left/QN/4.gif",
                            MimeType="image/gif"
                }

}
            });


            leftEnds.Add(new LeftEnd
            {
                Name = "SMA",
                ConnectedRightEnds= new List<ConnectedRightEnd> {
                     new ConnectedRightEnd
                    {
                        Name="BNC"
                    }, new ConnectedRightEnd
                    {
                        Name="MCX"
                    },new ConnectedRightEnd
                    {
                        Name="MMBX"
                    }, new ConnectedRightEnd
                    {
                        Name="MMCX"
                    },new ConnectedRightEnd
                    {
                        Name="N"
                    }, new ConnectedRightEnd
                    {
                        Name="PC 3.5"
                    },new ConnectedRightEnd
                    {
                        Name="QLA"
                    }, new ConnectedRightEnd
                    {
                        Name="QMA"
                    },new ConnectedRightEnd
                    {
                        Name="QN"
                    }, new ConnectedRightEnd
                    {
                        Name="SMA"
                    },new ConnectedRightEnd
                    {
                        Name="SMB"
                    }, new ConnectedRightEnd
                    {
                        Name="SMC"
                    },new ConnectedRightEnd
                    {
                        Name="TNC"
                    }, new ConnectedRightEnd
                    {
                        Name="10/23"
                    },new ConnectedRightEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Left/SMA/1.gif",
                            MimeType="image/gif"
                }, new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Left/SMA/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Left/SMA/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Left/SMA/4.gif",
                            MimeType="image/gif"
                },new File{
                            Name="flange",
                            RelativePath="/content/connectorEndImg/Left/SMA/5.gif",
                            MimeType="image/gif"
                }

        }
            });

            leftEnds.Add(new LeftEnd
            {
                Name = "SMB",
                ConnectedRightEnds= new List<ConnectedRightEnd>{
                     new ConnectedRightEnd
                    {
                        Name="BNC"
                    }, new ConnectedRightEnd
                    {
                        Name="MCX"
                    },new ConnectedRightEnd
                    {
                        Name="MMBX"
                    }, new ConnectedRightEnd
                    {
                        Name="MMCX"
                    },new ConnectedRightEnd
                    {
                        Name="N"
                    }, new ConnectedRightEnd
                    {
                        Name="QLA"
                    }, new ConnectedRightEnd
                    {
                        Name="QMA"
                    },new ConnectedRightEnd
                    {
                        Name="QN"
                    }, new ConnectedRightEnd
                    {
                        Name="SMA"
                    },new ConnectedRightEnd
                    {
                        Name="SMB"
                    }, new ConnectedRightEnd
                    {
                        Name="SMC"
                    },new ConnectedRightEnd
                    {
                        Name="TNC"
                    }, new ConnectedRightEnd
                    {
                        Name="10/23"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Left/SMB/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Left/SMB/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Left/SMB/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Left/SMB/4.gif",
                            MimeType="image/gif"
                }

}
            });

            leftEnds.Add(new LeftEnd
            {
                Name = "SMC",
                ConnectedRightEnds= new List<ConnectedRightEnd>{
                     new ConnectedRightEnd
                    {
                        Name="BNC"
                    }, new ConnectedRightEnd
                    {
                        Name="MCX"
                    },new ConnectedRightEnd
                    {
                        Name="MMBX"
                    }, new ConnectedRightEnd
                    {
                        Name="MMCX"
                    },new ConnectedRightEnd
                    {
                        Name="N"
                    }, new ConnectedRightEnd
                    {
                        Name="QLA"
                    }, new ConnectedRightEnd
                    {
                        Name="QMA"
                    },new ConnectedRightEnd
                    {
                        Name="QN"
                    }, new ConnectedRightEnd
                    {
                        Name="SMA"
                    },new ConnectedRightEnd
                    {
                        Name="SMB"
                    }, new ConnectedRightEnd
                    {
                        Name="SMC"
                    },new ConnectedRightEnd
                    {
                        Name="TNC"
                    }, new ConnectedRightEnd
                    {
                        Name="10/23"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Left/SMC/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Left/SMC/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Left/SMC/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Left/SMC/4.gif",
                            MimeType="image/gif"
                }

}
            });


            leftEnds.Add(new LeftEnd
            {
                Name = "TNC",
                ConnectedRightEnds= new List<ConnectedRightEnd> {
                     new ConnectedRightEnd
                    {
                        Name="BNC"
                    }, new ConnectedRightEnd
                    {
                        Name="C"
                    }, new ConnectedRightEnd
                    {
                        Name="MCX"
                    },new ConnectedRightEnd
                    {
                        Name="MMBX"
                    }, new ConnectedRightEnd
                    {
                        Name="MMCX"
                    },new ConnectedRightEnd
                    {
                        Name="N"
                    }, new ConnectedRightEnd
                    {
                        Name="PC 3.5"
                    },new ConnectedRightEnd
                    {
                        Name="QLA"
                    }, new ConnectedRightEnd
                    {
                        Name="QMA"
                    },new ConnectedRightEnd
                    {
                        Name="QN"
                    }, new ConnectedRightEnd
                    {
                        Name="SMA"
                    },new ConnectedRightEnd
                    {
                        Name="SMB"
                    }, new ConnectedRightEnd
                    {
                        Name="SMC"
                    },new ConnectedRightEnd
                    {
                        Name="TNC"
                    }, new ConnectedRightEnd
                    {
                        Name="10/23"
                    },new ConnectedRightEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Left/TNC/1.gif",
                            MimeType="image/gif"
                }, new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Left/TNC/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Left/TNC/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Left/TNC/4.gif",
                            MimeType="image/gif"
                },new File{
                            Name="flange",
                            RelativePath="/content/connectorEndImg/Left/TNC/5.gif",
                            MimeType="image/gif"
                }

        }
            });


            leftEnds.Add(new LeftEnd
            {
                Name = "10/23",
                ConnectedRightEnds= new List<ConnectedRightEnd>{
                     new ConnectedRightEnd
                    {
                        Name="BNC"
                    }, new ConnectedRightEnd
                    {
                        Name="MCX"
                    },new ConnectedRightEnd
                    {
                        Name="MMBX"
                    }, new ConnectedRightEnd
                    {
                        Name="MMCX"
                    },new ConnectedRightEnd
                    {
                        Name="N"
                    }, new ConnectedRightEnd
                    {
                        Name="QLA"
                    }, new ConnectedRightEnd
                    {
                        Name="QMA"
                    },new ConnectedRightEnd
                    {
                        Name="QN"
                    }, new ConnectedRightEnd
                    {
                        Name="SMA"
                    },new ConnectedRightEnd
                    {
                        Name="SMB"
                    }, new ConnectedRightEnd
                    {
                        Name="SMC"
                    },new ConnectedRightEnd
                    {
                        Name="TNC"
                    }, new ConnectedRightEnd
                    {
                        Name="10/23"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Left/1023/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Left/1023/3.gif",
                            MimeType="image/gif"
                }
}
            });

            leftEnds.Add(new LeftEnd
            {
                Name = "7/16",
                ConnectedRightEnds = new List<ConnectedRightEnd> {
                     new ConnectedRightEnd
                    {
                        Name="BNC"
                    }, new ConnectedRightEnd
                    {
                        Name="MCX"
                    }, new ConnectedRightEnd
                    {
                        Name="N"
                    }, new ConnectedRightEnd
                    {
                        Name="PC 3.5"
                    },new ConnectedRightEnd
                    {
                        Name="QLA"
                    }, new ConnectedRightEnd
                    {
                        Name="QMA"
                    },new ConnectedRightEnd
                    {
                        Name="QN"
                    }, new ConnectedRightEnd
                    {
                        Name="SMA"
                    }, new ConnectedRightEnd
                    {
                        Name="TNC"
                    }, new ConnectedRightEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Left/716/1.gif",
                            MimeType="image/gif"
                }, new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Left/716/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Left/716/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Left/716/4.gif",
                            MimeType="image/gif"
                },new File{
                            Name="flange",
                            RelativePath="/content/connectorEndImg/Left/716/5.gif",
                            MimeType="image/gif"
                }

        }
            });

            dbContext.LeftEnds.AddRange(leftEnds);
            dbContext.SaveChanges();
        }
    }
}