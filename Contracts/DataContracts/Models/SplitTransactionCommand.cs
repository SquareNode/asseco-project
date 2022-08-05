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
[DataContract(Name = "split-transaction-command", Namespace = "personal-finance-management")]
public partial class SplitTransactionCommand 
{
    
    [DataMember(Name = "splits", EmitDefaultValue = false)]
    public System.Collections.Generic.List<SingleCategorySplit> Splits { get; set; }


}
}