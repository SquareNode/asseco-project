using Asseco.Contracts.Abstractions;
using Asseco.Contracts.Common;
using Asseco.REST.Validations;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models
{
  /// <summary>Debit (`d`) for liabilities or credit (`c`) for assets</summary>
public enum DirectionsEnum
{
     /// <summary>
     /// Debit
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"d")]
    D = 0,

     /// <summary>
     /// Credit
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"c")]
    C = 1,

}
}