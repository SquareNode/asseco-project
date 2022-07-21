using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace projekat.Models
{
  /// <summary>category</summary>
public partial class Category
{
    
    public string Code { get; set; }

    
    public string Name { get; set; }

    
    public string ParentCode { get; set; }


}
}