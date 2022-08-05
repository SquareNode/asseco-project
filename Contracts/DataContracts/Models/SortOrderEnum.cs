using Asseco.Contracts.Abstractions;
using Asseco.Contracts.Common;
using Asseco.REST.Validations;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models
{
  /// <summary>Ascending or descending sort order</summary>
public enum SortOrderEnum
{
     /// <summary>
     /// Ascending order - A to Z
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"asc")]
    Asc = 0,

     /// <summary>
     /// Descending order - Z to A
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"desc")]
    Desc = 1,

}
}