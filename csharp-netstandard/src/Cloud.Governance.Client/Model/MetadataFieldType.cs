/* 
 * Cloud Governance Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    /// <summary>
    /// None&#x3D;0, SingleLineText&#x3D;1, MultiLineText&#x3D;2, &lt;/br&gt;YesOrNo&#x3D;3, Choices&#x3D;4, PeoplePickerValue&#x3D;5, &lt;/br&gt;Terms&#x3D;6, Hyperlink&#x3D;7, UserProfileService&#x3D;8, &lt;/br&gt;AzureADProperty&#x3D;9
    /// </summary>
    /// <value>None&#x3D;0, SingleLineText&#x3D;1, MultiLineText&#x3D;2, &lt;/br&gt;YesOrNo&#x3D;3, Choices&#x3D;4, PeoplePickerValue&#x3D;5, &lt;/br&gt;Terms&#x3D;6, Hyperlink&#x3D;7, UserProfileService&#x3D;8, &lt;/br&gt;AzureADProperty&#x3D;9</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MetadataFieldType
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum SingleLineText for value: SingleLineText
        /// </summary>
        [EnumMember(Value = "SingleLineText")]
        SingleLineText = 2,

        /// <summary>
        /// Enum MultiLineText for value: MultiLineText
        /// </summary>
        [EnumMember(Value = "MultiLineText")]
        MultiLineText = 3,

        /// <summary>
        /// Enum YesOrNo for value: YesOrNo
        /// </summary>
        [EnumMember(Value = "YesOrNo")]
        YesOrNo = 4,

        /// <summary>
        /// Enum Choices for value: Choices
        /// </summary>
        [EnumMember(Value = "Choices")]
        Choices = 5,

        /// <summary>
        /// Enum PeoplePickerValue for value: PeoplePickerValue
        /// </summary>
        [EnumMember(Value = "PeoplePickerValue")]
        PeoplePickerValue = 6,

        /// <summary>
        /// Enum Terms for value: Terms
        /// </summary>
        [EnumMember(Value = "Terms")]
        Terms = 7,

        /// <summary>
        /// Enum Hyperlink for value: Hyperlink
        /// </summary>
        [EnumMember(Value = "Hyperlink")]
        Hyperlink = 8,

        /// <summary>
        /// Enum UserProfileService for value: UserProfileService
        /// </summary>
        [EnumMember(Value = "UserProfileService")]
        UserProfileService = 9,

        /// <summary>
        /// Enum AzureADProperty for value: AzureADProperty
        /// </summary>
        [EnumMember(Value = "AzureADProperty")]
        AzureADProperty = 10

    }

}
