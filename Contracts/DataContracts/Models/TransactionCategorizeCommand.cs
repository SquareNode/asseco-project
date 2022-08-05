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
[DataContract(Name = "transaction-categorize-command", Namespace = "personal-finance-management")]
public partial class TransactionCategorizeCommand 
{
    
    [DataMember(Name = "catcode", EmitDefaultValue = false)]
    public string Catcode { get; set; }


}
}