using Asseco.Contracts.Abstractions;
using Asseco.Contracts.Common;
using Asseco.REST.Validations;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models
{
  /// <summary> </summary>
[Serializable]
[DataContract(Name = "spending-in-category", Namespace = "personal-finance-management")]
public partial class SpendingInCategory 
{
    
    [DataMember(Name = "catcode", EmitDefaultValue = false)]
    public string Catcode { get; set; }

    
    [DataMember(Name = "amount", EmitDefaultValue = false)]
    public double? Amount { get; set; }

    
    [DataMember(Name = "count", EmitDefaultValue = false)]
    public decimal? Count { get; set; }


}
}