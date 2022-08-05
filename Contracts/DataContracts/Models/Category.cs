using Asseco.Contracts.Abstractions;
using Asseco.Contracts.Common;
using Asseco.REST.Validations;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models
{
  /// <summary>category</summary>
[Serializable]
[DataContract(Name = "category", Namespace = "personal-finance-management")]
public partial class Category 
{
    
    [DataMember(Name = "code", EmitDefaultValue = false)]
    public string Code { get; set; }

    
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    
    [DataMember(Name = "parent-code", EmitDefaultValue = false)]
    public string ParentCode { get; set; }


}
}