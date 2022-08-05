using Asseco.REST.Binding.Attributes;
using Asseco.REST.Validations;
using Microsoft.AspNetCore.Mvc;
using projekat;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.HttpParams
{
  [Serializable]
  [DataContract]
  public class TransactionsGetListHttpParams: PagingSortingParams
  {
    [DataMember(Name = "transaction-kind", EmitDefaultValue = false)]
    [FromQuery]
    public string? TransactionKind { get; set; }

    [DataMember(Name = "start-date", EmitDefaultValue = false)]
    [FromQuery]
    public System.DateTime? StartDate { get; set; }

    [DataMember(Name = "end-date", EmitDefaultValue = false)]
    [FromQuery]
    public System.DateTime? EndDate { get; set; }

  }
}