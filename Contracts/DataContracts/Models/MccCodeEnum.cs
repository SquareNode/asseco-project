using Asseco.Contracts.Abstractions;
using Asseco.Contracts.Common;
using Asseco.REST.Validations;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models
{
  /// <summary>Enumeration mcc_code are standardized 4 digit numbers used by the payments industry where this code classifies a particular business by market segment.</summary>
public enum MccCodeEnum
{
     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"4814")]
    _4814 = 0,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"4815")]
    _4815 = 1,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"4821")]
    _4821 = 2,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"4829")]
    _4829 = 3,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"4899")]
    _4899 = 4,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"4900")]
    _4900 = 5,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5013")]
    _5013 = 6,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5021")]
    _5021 = 7,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5039")]
    _5039 = 8,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5044")]
    _5044 = 9,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5045")]
    _5045 = 10,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5046")]
    _5046 = 11,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5047")]
    _5047 = 12,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5051")]
    _5051 = 13,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5065")]
    _5065 = 14,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5072")]
    _5072 = 15,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5074")]
    _5074 = 16,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5085")]
    _5085 = 17,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5094")]
    _5094 = 18,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5099")]
    _5099 = 19,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5111")]
    _5111 = 20,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5122")]
    _5122 = 21,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5131")]
    _5131 = 22,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5137")]
    _5137 = 23,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5139")]
    _5139 = 24,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5169")]
    _5169 = 25,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5172")]
    _5172 = 26,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5192")]
    _5192 = 27,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5193")]
    _5193 = 28,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5198")]
    _5198 = 29,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5199")]
    _5199 = 30,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5200")]
    _5200 = 31,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5211")]
    _5211 = 32,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5231")]
    _5231 = 33,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5251")]
    _5251 = 34,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5261")]
    _5261 = 35,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5271")]
    _5271 = 36,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5300")]
    _5300 = 37,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5309")]
    _5309 = 38,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5310")]
    _5310 = 39,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5311")]
    _5311 = 40,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5331")]
    _5331 = 41,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5399")]
    _5399 = 42,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5411")]
    _5411 = 43,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5422")]
    _5422 = 44,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5441")]
    _5441 = 45,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5451")]
    _5451 = 46,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5462")]
    _5462 = 47,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5499")]
    _5499 = 48,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5511")]
    _5511 = 49,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5521")]
    _5521 = 50,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5531")]
    _5531 = 51,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5532")]
    _5532 = 52,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5533")]
    _5533 = 53,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5541")]
    _5541 = 54,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5542")]
    _5542 = 55,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5551")]
    _5551 = 56,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5561")]
    _5561 = 57,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5571")]
    _5571 = 58,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5592")]
    _5592 = 59,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5598")]
    _5598 = 60,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5611")]
    _5611 = 61,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5621")]
    _5621 = 62,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5631")]
    _5631 = 63,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5641")]
    _5641 = 64,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5651")]
    _5651 = 65,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5655")]
    _5655 = 66,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5661")]
    _5661 = 67,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5681")]
    _5681 = 68,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5691")]
    _5691 = 69,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5697")]
    _5697 = 70,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5698")]
    _5698 = 71,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5699")]
    _5699 = 72,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5712")]
    _5712 = 73,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5713")]
    _5713 = 74,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5714")]
    _5714 = 75,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5718")]
    _5718 = 76,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5719")]
    _5719 = 77,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5722")]
    _5722 = 78,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5732")]
    _5732 = 79,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5733")]
    _5733 = 80,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5734")]
    _5734 = 81,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5735")]
    _5735 = 82,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5811")]
    _5811 = 83,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5812")]
    _5812 = 84,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5813")]
    _5813 = 85,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5814")]
    _5814 = 86,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5912")]
    _5912 = 87,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5921")]
    _5921 = 88,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5931")]
    _5931 = 89,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5832")]
    _5832 = 90,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5933")]
    _5933 = 91,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5935")]
    _5935 = 92,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5937")]
    _5937 = 93,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5940")]
    _5940 = 94,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5941")]
    _5941 = 95,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5942")]
    _5942 = 96,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5943")]
    _5943 = 97,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5944")]
    _5944 = 98,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5945")]
    _5945 = 99,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5946")]
    _5946 = 100,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5947")]
    _5947 = 101,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5948")]
    _5948 = 102,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5949")]
    _5949 = 103,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5950")]
    _5950 = 104,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5960")]
    _5960 = 105,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5961")]
    _5961 = 106,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5962")]
    _5962 = 107,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5963")]
    _5963 = 108,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5964")]
    _5964 = 109,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5965")]
    _5965 = 110,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5967")]
    _5967 = 111,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5968")]
    _5968 = 112,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5969")]
    _5969 = 113,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5970")]
    _5970 = 114,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5971")]
    _5971 = 115,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5972")]
    _5972 = 116,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5973")]
    _5973 = 117,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5975")]
    _5975 = 118,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5976")]
    _5976 = 119,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5977")]
    _5977 = 120,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5978")]
    _5978 = 121,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5983")]
    _5983 = 122,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5992")]
    _5992 = 123,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5993")]
    _5993 = 124,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5994")]
    _5994 = 125,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5995")]
    _5995 = 126,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5996")]
    _5996 = 127,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5997")]
    _5997 = 128,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5998")]
    _5998 = 129,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"5999")]
    _5999 = 130,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"6010")]
    _6010 = 131,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"6011")]
    _6011 = 132,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"6012")]
    _6012 = 133,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"6051")]
    _6051 = 134,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"6211")]
    _6211 = 135,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"6300")]
    _6300 = 136,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"6381")]
    _6381 = 137,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"6399")]
    _6399 = 138,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7011")]
    _7011 = 139,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7012")]
    _7012 = 140,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7032")]
    _7032 = 141,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7033")]
    _7033 = 142,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7210")]
    _7210 = 143,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7211")]
    _7211 = 144,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7216")]
    _7216 = 145,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7217")]
    _7217 = 146,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7221")]
    _7221 = 147,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7230")]
    _7230 = 148,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7251")]
    _7251 = 149,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7261")]
    _7261 = 150,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7273")]
    _7273 = 151,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7276")]
    _7276 = 152,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7277")]
    _7277 = 153,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7278")]
    _7278 = 154,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7296")]
    _7296 = 155,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7297")]
    _7297 = 156,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7298")]
    _7298 = 157,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7299")]
    _7299 = 158,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7311")]
    _7311 = 159,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7321")]
    _7321 = 160,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7332")]
    _7332 = 161,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7333")]
    _7333 = 162,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7338")]
    _7338 = 163,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7339")]
    _7339 = 164,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7342")]
    _7342 = 165,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7349")]
    _7349 = 166,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7361")]
    _7361 = 167,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7372")]
    _7372 = 168,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7375")]
    _7375 = 169,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7379")]
    _7379 = 170,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7392")]
    _7392 = 171,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7393")]
    _7393 = 172,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7394")]
    _7394 = 173,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7395")]
    _7395 = 174,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7399")]
    _7399 = 175,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7512")]
    _7512 = 176,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7513")]
    _7513 = 177,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7519")]
    _7519 = 178,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7523")]
    _7523 = 179,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7531")]
    _7531 = 180,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7534")]
    _7534 = 181,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7535")]
    _7535 = 182,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7538")]
    _7538 = 183,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7542")]
    _7542 = 184,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7549")]
    _7549 = 185,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7622")]
    _7622 = 186,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7623")]
    _7623 = 187,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7629")]
    _7629 = 188,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7631")]
    _7631 = 189,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7641")]
    _7641 = 190,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7692")]
    _7692 = 191,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7699")]
    _7699 = 192,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7829")]
    _7829 = 193,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7832")]
    _7832 = 194,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7841")]
    _7841 = 195,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7911")]
    _7911 = 196,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7922")]
    _7922 = 197,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7929")]
    _7929 = 198,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7932")]
    _7932 = 199,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7933")]
    _7933 = 200,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7941")]
    _7941 = 201,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7991")]
    _7991 = 202,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7992")]
    _7992 = 203,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7993")]
    _7993 = 204,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7994")]
    _7994 = 205,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7995")]
    _7995 = 206,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7996")]
    _7996 = 207,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7997")]
    _7997 = 208,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7998")]
    _7998 = 209,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"7999")]
    _7999 = 210,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8011")]
    _8011 = 211,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8021")]
    _8021 = 212,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8031")]
    _8031 = 213,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8041")]
    _8041 = 214,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8042")]
    _8042 = 215,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8043")]
    _8043 = 216,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8044")]
    _8044 = 217,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8049")]
    _8049 = 218,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8050")]
    _8050 = 219,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8062")]
    _8062 = 220,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8071")]
    _8071 = 221,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8099")]
    _8099 = 222,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8111")]
    _8111 = 223,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8211")]
    _8211 = 224,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8220")]
    _8220 = 225,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8241")]
    _8241 = 226,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8244")]
    _8244 = 227,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8249")]
    _8249 = 228,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8299")]
    _8299 = 229,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8351")]
    _8351 = 230,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8398")]
    _8398 = 231,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8641")]
    _8641 = 232,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8651")]
    _8651 = 233,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8661")]
    _8661 = 234,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8675")]
    _8675 = 235,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8699")]
    _8699 = 236,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8734")]
    _8734 = 237,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8911")]
    _8911 = 238,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8931")]
    _8931 = 239,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"8999")]
    _8999 = 240,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"9211")]
    _9211 = 241,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"9222")]
    _9222 = 242,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"9223")]
    _9223 = 243,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"9311")]
    _9311 = 244,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"9399")]
    _9399 = 245,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"9402")]
    _9402 = 246,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"9405")]
    _9405 = 247,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"9700")]
    _9700 = 248,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"9701")]
    _9701 = 249,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"9702")]
    _9702 = 250,

     /// <summary>
     /// 
     /// <summary>
    [System.Runtime.Serialization.EnumMember(Value = @"9950")]
    _9950 = 251,

}
}