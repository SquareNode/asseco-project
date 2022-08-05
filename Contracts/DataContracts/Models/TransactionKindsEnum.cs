using Asseco.Contracts.Abstractions;
using Asseco.Contracts.Common;
using Asseco.REST.Validations;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models
{
  /// <summary>Enumeration that distinguishes between accounting transactions based on their effect on the customer accounts.</summary>
public enum TransactionKindsEnum
{
     /// <summary>
     /// Deposit
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"dep")]
    Dep = 0,

     /// <summary>
     /// Withdrawal
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"wdw")]
    Wdw = 1,

     /// <summary>
     /// Payment
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"pmt")]
    Pmt = 2,

     /// <summary>
     /// Fee
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"fee")]
    Fee = 3,

     /// <summary>
     /// Interest credit
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"inc")]
    Inc = 4,

     /// <summary>
     /// Reversal
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"rev")]
    Rev = 5,

     /// <summary>
     /// Adjustment
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"adj")]
    Adj = 6,

     /// <summary>
     /// Loan disbursement
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"lnd")]
    Lnd = 7,

     /// <summary>
     /// Loan repayment
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"lnr")]
    Lnr = 8,

     /// <summary>
     /// Foreign currency exchange
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"fcx")]
    Fcx = 9,

     /// <summary>
     /// Account openning
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"aop")]
    Aop = 10,

     /// <summary>
     /// Account closing
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"acl")]
    Acl = 11,

     /// <summary>
     /// Split payment
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"spl")]
    Spl = 12,

     /// <summary>
     /// Salary
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"sal")]
    Sal = 13,

}
}