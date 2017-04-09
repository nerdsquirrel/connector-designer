using ConnectorDesigner.App.Dbcontext;
using ConnectorDesigner.App.Models;
using System.Collections.Generic;

namespace ConnectorDesigner.App.App_Start
{
    public partial class SeedData
    {
        static void SeedRightEndData(ApplicationDbContext dbContext)
        {
            var rightEnds = new List<RightEnd>();
            var leftEndNameList = new List<ConnectedLeftEnd>
                {
                    new ConnectedLeftEnd
                    {
                        Name="BNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="C"
                    }, new ConnectedLeftEnd
                    {
                        Name="MCX"
                    },new ConnectedLeftEnd
                    {
                        Name="MMBX"
                    }, new ConnectedLeftEnd
                    {
                        Name="MMCX"
                    },new ConnectedLeftEnd
                    {
                        Name="N"
                    }, new ConnectedLeftEnd
                    {
                        Name="PC 3.5"
                    },new ConnectedLeftEnd
                    {
                        Name="QLA"
                    }, new ConnectedLeftEnd
                    {
                        Name="QMA"
                    },new ConnectedLeftEnd
                    {
                        Name="QN"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMA"
                    },new ConnectedLeftEnd
                    {
                        Name="SMB"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMC"
                    },new ConnectedLeftEnd
                    {
                        Name="TNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="10/23"
                    },new ConnectedLeftEnd
                    {
                        Name="7/16"
                    }
                };

            
            rightEnds.Add(new RightEnd
            {
                Name = "BNC",
                ConnectedLeftEnds= new List<ConnectedLeftEnd>(leftEndNameList),
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Right/BNC/1.gif",
                            MimeType="image/gif"
                }, new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Right/BNC/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Right/BNC/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Right/BNC/4.gif",
                            MimeType="image/gif"
                },new File{
                            Name="flange",
                            RelativePath="/content/connectorEndImg/Right/BNC/5.gif",
                            MimeType="image/gif"
                }

        }
            });


            rightEnds.Add(new RightEnd
            {
                Name = "C",
                ConnectedLeftEnds= new List<ConnectedLeftEnd>{
                     new ConnectedLeftEnd
                    {
                        Name="BNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="C"
                    }, new ConnectedLeftEnd
                    {
                        Name="N"
                    }, new ConnectedLeftEnd
                    {
                        Name="QN"
                    }, new ConnectedLeftEnd
                    {
                        Name="TNC"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Right/C/1.gif",
                            MimeType="image/gif"
                }
           }
            });

            rightEnds.Add(new RightEnd
            {
                Name = "MCX",
                ConnectedLeftEnds= new List<ConnectedLeftEnd> {
                    new ConnectedLeftEnd
                    {
                        Name="BNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="MCX"
                    },new ConnectedLeftEnd
                    {
                        Name="MMBX"
                    }, new ConnectedLeftEnd
                    {
                        Name="MMCX"
                    },new ConnectedLeftEnd
                    {
                        Name="N"
                    }, new ConnectedLeftEnd
                    {
                        Name="PC 3.5"
                    },new ConnectedLeftEnd
                    {
                        Name="QLA"
                    }, new ConnectedLeftEnd
                    {
                        Name="QMA"
                    },new ConnectedLeftEnd
                    {
                        Name="QN"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMA"
                    },new ConnectedLeftEnd
                    {
                        Name="SMB"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMC"
                    },new ConnectedLeftEnd
                    {
                        Name="TNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="10/23"
                    },new ConnectedLeftEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Right/MCX/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Right/MCX/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Right/MCX/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Right/MCX/4.gif",
                            MimeType="image/gif"
                }

}
            });

            rightEnds.Add(new RightEnd
            {
                Name = "MMBX",
                ConnectedLeftEnds= new List<ConnectedLeftEnd>{
                    new ConnectedLeftEnd
                    {
                        Name="BNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="MCX"
                    },new ConnectedLeftEnd
                    {
                        Name="MMBX"
                    }, new ConnectedLeftEnd
                    {
                        Name="MMCX"
                    },new ConnectedLeftEnd
                    {
                        Name="N"
                    }, new ConnectedLeftEnd
                    {
                        Name="QLA"
                    }, new ConnectedLeftEnd
                    {
                        Name="QMA"
                    },new ConnectedLeftEnd
                    {
                        Name="QN"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMA"
                    },new ConnectedLeftEnd
                    {
                        Name="SMB"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMC"
                    },new ConnectedLeftEnd
                    {
                        Name="TNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="10/23"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Right/MMBX/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Right/MMBX/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Right/MMBX/4.gif",
                            MimeType="image/gif"
                }

}
            });

            rightEnds.Add(new RightEnd
            {
                Name = "MMCX",
                ConnectedLeftEnds= new List<ConnectedLeftEnd>{
                    new ConnectedLeftEnd
                    {
                        Name="BNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="MCX"
                    },new ConnectedLeftEnd
                    {
                        Name="MMBX"
                    }, new ConnectedLeftEnd
                    {
                        Name="MMCX"
                    },new ConnectedLeftEnd
                    {
                        Name="N"
                    }, new ConnectedLeftEnd
                    {
                        Name="QLA"
                    }, new ConnectedLeftEnd
                    {
                        Name="QMA"
                    },new ConnectedLeftEnd
                    {
                        Name="QN"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMA"
                    },new ConnectedLeftEnd
                    {
                        Name="SMB"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMC"
                    },new ConnectedLeftEnd
                    {
                        Name="TNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="10/23"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Right/MMCX/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Right/MMCX/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Right/MMCX/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Right/MMCX/4.gif",
                            MimeType="image/gif"
                }

}
            });

            rightEnds.Add(new RightEnd
            {
                Name = "N",
                ConnectedLeftEnds= new List<ConnectedLeftEnd>{
                    new ConnectedLeftEnd
                    {
                        Name="BNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="C"
                    }, new ConnectedLeftEnd
                    {
                        Name="MCX"
                    },new ConnectedLeftEnd
                    {
                        Name="MMBX"
                    }, new ConnectedLeftEnd
                    {
                        Name="MMCX"
                    },new ConnectedLeftEnd
                    {
                        Name="N"
                    }, new ConnectedLeftEnd
                    {
                        Name="PC 3.5"
                    },new ConnectedLeftEnd
                    {
                        Name="QLA"
                    }, new ConnectedLeftEnd
                    {
                        Name="QMA"
                    },new ConnectedLeftEnd
                    {
                        Name="QN"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMA"
                    },new ConnectedLeftEnd
                    {
                        Name="SMB"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMC"
                    },new ConnectedLeftEnd
                    {
                        Name="TNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="10/23"
                    },new ConnectedLeftEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Right/N/1.gif",
                            MimeType="image/gif"
                }, new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Right/N/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Right/N/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Right/N/4.gif",
                            MimeType="image/gif"
                },new File{
                            Name="flange",
                            RelativePath="/content/connectorEndImg/Right/N/5.gif",
                            MimeType="image/gif"
                }

        }
            });


            rightEnds.Add(new RightEnd
            {
                Name = "PC 3.5",
                ConnectedLeftEnds= new List<ConnectedLeftEnd>{
                    new ConnectedLeftEnd
                    {
                        Name="BNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="MCX"
                    }, new ConnectedLeftEnd
                    {
                        Name="N"
                    }, new ConnectedLeftEnd
                    {
                        Name="PC 3.5"
                    }, new ConnectedLeftEnd
                    {
                        Name="QMA"
                    }, new ConnectedLeftEnd
                    {
                        Name="QN"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMA"
                    }, new ConnectedLeftEnd
                    {
                        Name="TNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Right/PC3.5/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Right/PC3.5/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Right/PC3.5/4.gif",
                            MimeType="image/gif"
                }

}
            });

            rightEnds.Add(new RightEnd
            {
                Name = "QLA",
                ConnectedLeftEnds= new List<ConnectedLeftEnd>{
                    new ConnectedLeftEnd
                    {
                        Name="BNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="MCX"
                    },new ConnectedLeftEnd
                    {
                        Name="MMBX"
                    }, new ConnectedLeftEnd
                    {
                        Name="MMCX"
                    },new ConnectedLeftEnd
                    {
                        Name="N"
                    }, new ConnectedLeftEnd
                    {
                        Name="QLA"
                    }, new ConnectedLeftEnd
                    {
                        Name="QMA"
                    },new ConnectedLeftEnd
                    {
                        Name="QN"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMA"
                    },new ConnectedLeftEnd
                    {
                        Name="SMB"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMC"
                    },new ConnectedLeftEnd
                    {
                        Name="TNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="10/23"
                    },new ConnectedLeftEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Right/QLA/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Right/QLA/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Right/QLA/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Right/QLA/4.gif",
                            MimeType="image/gif"
                }

}
            });

            rightEnds.Add(new RightEnd
            {
                Name = "QMA",
                ConnectedLeftEnds= new List<ConnectedLeftEnd>{
                    new ConnectedLeftEnd
                    {
                        Name="BNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="MCX"
                    },new ConnectedLeftEnd
                    {
                        Name="MMBX"
                    }, new ConnectedLeftEnd
                    {
                        Name="MMCX"
                    },new ConnectedLeftEnd
                    {
                        Name="N"
                    }, new ConnectedLeftEnd
                    {
                        Name="PC 3.5"
                    },new ConnectedLeftEnd
                    {
                        Name="QLA"
                    }, new ConnectedLeftEnd
                    {
                        Name="QMA"
                    },new ConnectedLeftEnd
                    {
                        Name="QN"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMA"
                    },new ConnectedLeftEnd
                    {
                        Name="SMB"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMC"
                    },new ConnectedLeftEnd
                    {
                        Name="TNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="10/23"
                    },new ConnectedLeftEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Right/QMA/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Right/QMA/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Right/QMA/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Right/QMA/4.gif",
                            MimeType="image/gif"
                }

}
            });

            rightEnds.Add(new RightEnd
            {
                Name = "QN",
                ConnectedLeftEnds= new List<ConnectedLeftEnd>{
                    new ConnectedLeftEnd
                    {
                        Name="BNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="C"
                    }, new ConnectedLeftEnd
                    {
                        Name="MCX"
                    },new ConnectedLeftEnd
                    {
                        Name="MMBX"
                    }, new ConnectedLeftEnd
                    {
                        Name="MMCX"
                    },new ConnectedLeftEnd
                    {
                        Name="N"
                    }, new ConnectedLeftEnd
                    {
                        Name="PC 3.5"
                    },new ConnectedLeftEnd
                    {
                        Name="QLA"
                    }, new ConnectedLeftEnd
                    {
                        Name="QMA"
                    },new ConnectedLeftEnd
                    {
                        Name="QN"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMA"
                    },new ConnectedLeftEnd
                    {
                        Name="SMB"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMC"
                    },new ConnectedLeftEnd
                    {
                        Name="TNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="10/23"
                    },new ConnectedLeftEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Right/QN/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Right/QN/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Right/QN/4.gif",
                            MimeType="image/gif"
                }

}
            });


            rightEnds.Add(new RightEnd
            {
                Name = "SMA",
                ConnectedLeftEnds= new List<ConnectedLeftEnd>{
                    new ConnectedLeftEnd
                    {
                        Name="BNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="MCX"
                    },new ConnectedLeftEnd
                    {
                        Name="MMBX"
                    }, new ConnectedLeftEnd
                    {
                        Name="MMCX"
                    },new ConnectedLeftEnd
                    {
                        Name="N"
                    }, new ConnectedLeftEnd
                    {
                        Name="PC 3.5"
                    },new ConnectedLeftEnd
                    {
                        Name="QLA"
                    }, new ConnectedLeftEnd
                    {
                        Name="QMA"
                    },new ConnectedLeftEnd
                    {
                        Name="QN"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMA"
                    },new ConnectedLeftEnd
                    {
                        Name="SMB"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMC"
                    },new ConnectedLeftEnd
                    {
                        Name="TNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="10/23"
                    },new ConnectedLeftEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Right/SMA/1.gif",
                            MimeType="image/gif"
                }, new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Right/SMA/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Right/SMA/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Right/SMA/4.gif",
                            MimeType="image/gif"
                },new File{
                            Name="flange",
                            RelativePath="/content/connectorEndImg/Right/SMA/5.gif",
                            MimeType="image/gif"
                }

        }
            });

            rightEnds.Add(new RightEnd
            {
                Name = "SMB",
                ConnectedLeftEnds= new List<ConnectedLeftEnd>{
                    new ConnectedLeftEnd
                    {
                        Name="BNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="MCX"
                    },new ConnectedLeftEnd
                    {
                        Name="MMBX"
                    }, new ConnectedLeftEnd
                    {
                        Name="MMCX"
                    },new ConnectedLeftEnd
                    {
                        Name="N"
                    }, new ConnectedLeftEnd
                    {
                        Name="QLA"
                    }, new ConnectedLeftEnd
                    {
                        Name="QMA"
                    },new ConnectedLeftEnd
                    {
                        Name="QN"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMA"
                    },new ConnectedLeftEnd
                    {
                        Name="SMB"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMC"
                    },new ConnectedLeftEnd
                    {
                        Name="TNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="10/23"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Right/SMB/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Right/SMB/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Right/SMB/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Right/SMB/4.gif",
                            MimeType="image/gif"
                }

}
            });

            rightEnds.Add(new RightEnd
            {
                Name = "SMC",
                ConnectedLeftEnds= new List<ConnectedLeftEnd>{
                    new ConnectedLeftEnd
                    {
                        Name="BNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="MCX"
                    },new ConnectedLeftEnd
                    {
                        Name="MMBX"
                    }, new ConnectedLeftEnd
                    {
                        Name="MMCX"
                    },new ConnectedLeftEnd
                    {
                        Name="N"
                    }, new ConnectedLeftEnd
                    {
                        Name="QLA"
                    }, new ConnectedLeftEnd
                    {
                        Name="QMA"
                    },new ConnectedLeftEnd
                    {
                        Name="QN"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMA"
                    },new ConnectedLeftEnd
                    {
                        Name="SMB"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMC"
                    },new ConnectedLeftEnd
                    {
                        Name="TNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="10/23"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Right/SMC/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Right/SMC/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Right/SMC/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Right/SMC/4.gif",
                            MimeType="image/gif"
                }

}
            });


            rightEnds.Add(new RightEnd
            {
                Name = "TNC",
                ConnectedLeftEnds= new List<ConnectedLeftEnd>{
                    new ConnectedLeftEnd
                    {
                        Name="BNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="C"
                    }, new ConnectedLeftEnd
                    {
                        Name="MCX"
                    },new ConnectedLeftEnd
                    {
                        Name="MMBX"
                    }, new ConnectedLeftEnd
                    {
                        Name="MMCX"
                    },new ConnectedLeftEnd
                    {
                        Name="N"
                    }, new ConnectedLeftEnd
                    {
                        Name="PC 3.5"
                    },new ConnectedLeftEnd
                    {
                        Name="QLA"
                    }, new ConnectedLeftEnd
                    {
                        Name="QMA"
                    },new ConnectedLeftEnd
                    {
                        Name="QN"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMA"
                    },new ConnectedLeftEnd
                    {
                        Name="SMB"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMC"
                    },new ConnectedLeftEnd
                    {
                        Name="TNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="10/23"
                    },new ConnectedLeftEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Right/TNC/1.gif",
                            MimeType="image/gif"
                }, new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Right/TNC/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Right/TNC/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Right/TNC/4.gif",
                            MimeType="image/gif"
                },new File{
                            Name="flange",
                            RelativePath="/content/connectorEndImg/Right/TNC/5.gif",
                            MimeType="image/gif"
                }

        }
            });


            rightEnds.Add(new RightEnd
            {
                Name = "10/23",
                ConnectedLeftEnds= new List<ConnectedLeftEnd>{
                    new ConnectedLeftEnd
                    {
                        Name="BNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="MCX"
                    },new ConnectedLeftEnd
                    {
                        Name="MMBX"
                    }, new ConnectedLeftEnd
                    {
                        Name="MMCX"
                    },new ConnectedLeftEnd
                    {
                        Name="N"
                    }, new ConnectedLeftEnd
                    {
                        Name="QLA"
                    }, new ConnectedLeftEnd
                    {
                        Name="QMA"
                    },new ConnectedLeftEnd
                    {
                        Name="QN"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMA"
                    },new ConnectedLeftEnd
                    {
                        Name="SMB"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMC"
                    },new ConnectedLeftEnd
                    {
                        Name="TNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="10/23"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Right/1023/1.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Right/1023/3.gif",
                            MimeType="image/gif"
                }
}
            });

            rightEnds.Add(new RightEnd
            {
                Name = "7/16",
                ConnectedLeftEnds= new List<ConnectedLeftEnd>{
                    new ConnectedLeftEnd
                    {
                        Name="BNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="MCX"
                    }, new ConnectedLeftEnd
                    {
                        Name="N"
                    }, new ConnectedLeftEnd
                    {
                        Name="PC 3.5"
                    },new ConnectedLeftEnd
                    {
                        Name="QLA"
                    }, new ConnectedLeftEnd
                    {
                        Name="QMA"
                    },new ConnectedLeftEnd
                    {
                        Name="QN"
                    }, new ConnectedLeftEnd
                    {
                        Name="SMA"
                    }, new ConnectedLeftEnd
                    {
                        Name="TNC"
                    }, new ConnectedLeftEnd
                    {
                        Name="7/16"
                    }
                },
                Images = new List<File>{
                        new File{
                            Name="straight plug",
                            RelativePath="/content/connectorEndImg/Right/716/1.gif",
                            MimeType="image/gif"
                }, new File{
                            Name="right angle plug",
                            RelativePath="/content/connectorEndImg/Right/716/2.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight jack",
                            RelativePath="/content/connectorEndImg/Right/716/3.gif",
                            MimeType="image/gif"
                },new File{
                            Name="straight bulkhead jack",
                            RelativePath="/content/connectorEndImg/Right/716/4.gif",
                            MimeType="image/gif"
                },new File{
                            Name="flange",
                            RelativePath="/content/connectorEndImg/Right/716/5.gif",
                            MimeType="image/gif"
                }

        }
            });
            dbContext.RightEnds.AddRange(rightEnds);
            dbContext.SaveChanges();
        }
    }
}