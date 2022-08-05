using Asseco.Contracts.Abstractions;
using Asseco.Contracts.Common;
using Asseco.REST.Validations;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models
{
  /// <summary>List with support for paging</summary>
[Serializable]
[DataContract(Name = "paged-list", Namespace = "personal-finance-management")]
public partial class PagedList
{
    
    [DataMember(Name = "total-count", EmitDefaultValue = false)]
    public int? TotalCount { get; set; }

    
    [DataMember(Name = "page-size", EmitDefaultValue = false)]
    public int? PageSize { get; set; }

    
    [DataMember(Name = "page", EmitDefaultValue = false)]
    public int? Page { get; set; }

    
    [DataMember(Name = "total-pages", EmitDefaultValue = false)]
    public int? TotalPages { get; set; }

    
    [AllowedValues("asc,desc")]
    [DataMember(Name = "sort-order", EmitDefaultValue = false)]
    public string SortOrder { get; set; }

    
    [DataMember(Name = "sort-by", EmitDefaultValue = false)]
    public string SortBy { get; set; }


}
}