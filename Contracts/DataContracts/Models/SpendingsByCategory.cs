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
[DataContract(Name = "spendings-by-category", Namespace = "personal-finance-management")]
public partial class SpendingsByCategory 
{
    
    [DataMember(Name = "groups", EmitDefaultValue = false)]
    public List<SpendingInCategory> Groups { get; set; }


}
}