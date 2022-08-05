using Asseco.Contracts.Abstractions;
using Asseco.Contracts.Common;
using Asseco.REST.Validations;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models
{
  /// <summary>transaction</summary>
[Serializable]
[DataContract(Name = "transaction", Namespace = "personal-finance-management")]
public partial class Transaction
{
    
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }

    
    [DataMember(Name = "beneficiary-name", EmitDefaultValue = false)]
    public string BeneficiaryName { get; set; }

    
    [DataMember(Name = "date", EmitDefaultValue = false)]
    public string Date { get; set; }

    
    [AllowedValues("d,c")]
    [DataMember(Name = "direction", EmitDefaultValue = false)]
    public string Direction { get; set; }

    
    [DataMember(Name = "amount", EmitDefaultValue = false)]
    public double? Amount { get; set; }

    
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }

    
    [DataMember(Name = "currency", EmitDefaultValue = false)]
    public string Currency { get; set; }

    
    [DataMember(Name = "mcc", EmitDefaultValue = false)]
    public MccCodeEnum Mcc { get; set; }

    
    [AllowedValues("dep,wdw,pmt,fee,inc,rev,adj,lnd,lnr,fcx,aop,acl,spl,sal")]
    [DataMember(Name = "kind", EmitDefaultValue = false)]
    public string Kind { get; set; }

    
    [DataMember(Name = "catcode", EmitDefaultValue = false)]
    public string Catcode { get; set; }


}
}