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
[DataContract(Name = "transaction-paged-list", Namespace = "personal-finance-management")]
public partial class TransactionPagedList : PagedList
{
    
    [DataMember(Name = "items", EmitDefaultValue = false)]
    public System.Collections.Generic.List<TransactionWithSplits> Items { get; set; }


}
}