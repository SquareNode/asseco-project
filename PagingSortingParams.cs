using Asseco.Contracts;
using Asseco.Contracts.Abstractions;
using Asseco.REST.Validations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace projekat
{
    [Serializable]
    [DataContract(Name = "page-sort-params", Namespace="common")]
    public class PagingSortingParams : Asseco.Utilities.Reflection.RuntimeSafeExpando, 
        IPageable, ISortable
    {
        // Summary:
        //     Page size for paged result.
        [DataMember(Name = "page-size")]
        [DefaultValue(10)]
        [FromQuery]
        public int PageSize { get; set; } = 10;
        //
        // Summary:
        //     Page number for paged result.
        [DataMember(Name = "page-number")]
        [DefaultValue(1)]
        [FromQuery]
        public int PageNumber { get; set; } = 1;

        // Summary:
        //     Sort order - direction (ASC or DESC).
        [DataMember(Name = "sort-order")]
        [AllowedValues("asc, desc")]
        [FromQuery]
        public string? SortOrder { get; set; }

        //
        // Summary:
        //     Name of the column for sorting.
        [DataMember(Name = "sort-by")]
        [AllowedValues("id,beneficiary-name,date,direction,amount,description,currency,mcc,kind")]
        [FromQuery]
        public string? SortType { get; set; }
    }


}
