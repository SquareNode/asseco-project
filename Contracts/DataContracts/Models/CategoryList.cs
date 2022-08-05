using Asseco.Contracts.Abstractions;
using Asseco.Contracts.Common;
using Asseco.REST.Validations;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models
{
  /// <summary>category list</summary>
[Serializable]
[DataContract(Name = "category-list", Namespace = "personal-finance-management")]
public partial class CategoryList 
{
    
    [DataMember(Name = "items", EmitDefaultValue = false)]
    public System.Collections.Generic.List<Category> Items { get; set; }


}
}