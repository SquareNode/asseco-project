using Asseco.Contracts.Abstractions;
using Asseco.Contracts.Common;
using Asseco.REST.Validations;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models
{
  /// <summary>transaction-with-splits</summary>
[Serializable]
[DataContract(Name = "transaction-with-splits", Namespace = "personal-finance-management")]
public partial class TransactionWithSplits : Transaction
{
    
    [DataMember(Name = "splits", EmitDefaultValue = false)]
    public System.Collections.Generic.List<SingleCategorySplit> Splits { get; set; }


}
}