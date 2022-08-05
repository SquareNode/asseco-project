using Asseco.Contracts.Abstractions;
using Asseco.Contracts.Common;
using Asseco.REST.Validations;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models
{
  [Serializable]
[DataContract(Name = "errors", Namespace = "personal-finance-management")]
public partial class Errors 
{
    
    [DataMember(Name = "tag", EmitDefaultValue = false)]
    public string Tag { get; set; }

    
    [AllowedValues("min-length,max-length,required,out-of-range,invalid-format,unknown-enum,not-on-list,check-digit-invalid,combination-required,read-only")]
    [DataMember(Name = "error", EmitDefaultValue = false)]
    public string Error { get; set; }

    
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }


}
}