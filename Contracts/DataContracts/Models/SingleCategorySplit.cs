using Asseco.Contracts.Abstractions;
using Asseco.Contracts.Common;
using Asseco.REST.Validations;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models
{
  /// <summary>single-category-split</summary>
[Serializable]
[DataContract(Name = "single-category-split", Namespace = "personal-finance-management")]
public partial class SingleCategorySplit 
{
    
    [DataMember(Name = "catcode", EmitDefaultValue = false)]
    public string Catcode { get; set; }

    
    [DataMember(Name = "amount", EmitDefaultValue = false)]
    public double? Amount { get; set; }


}
}