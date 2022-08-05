using Asseco.REST.Binding.Attributes;
using Asseco.REST.Validations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.HttpParams
{
  [Serializable]
  [DataContract]
  public class CategoriesGetListHttpParams: Asseco.Utilities.Reflection.RuntimeSafeExpando
  {
    [DataMember(Name = "parent-id", EmitDefaultValue = false)]
    [FromQuery]
    public string ParentId { get; set; }

  }
}