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
  public class SpendingsGetHttpParams: Asseco.Utilities.Reflection.RuntimeSafeExpando
  {
    [DataMember(Name = "catcode", EmitDefaultValue = false)]
    [FromQuery]
    public string? Catcode { get; set; }

    [DataMember(Name = "start-date", EmitDefaultValue = false)]
    [FromQuery]
    public System.DateTime? StartDate { get; set; }

    [DataMember(Name = "end-date", EmitDefaultValue = false)]
    [FromQuery]
    public System.DateTime? EndDate { get; set; }

    [DataMember(Name = "direction", EmitDefaultValue = false)]
    [AllowedValues("d,c")]
    [FromQuery]
    public string? Direction { get; set; }

  }
}