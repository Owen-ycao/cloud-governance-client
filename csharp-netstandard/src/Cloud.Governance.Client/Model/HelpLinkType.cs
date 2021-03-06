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
    /// None&#x3D;0, Guide&#x3D;1, CustomLink&#x3D;2, &lt;/br&gt;
    /// </summary>
    /// <value>None&#x3D;0, Guide&#x3D;1, CustomLink&#x3D;2, &lt;/br&gt;</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum HelpLinkType
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum Guide for value: Guide
        /// </summary>
        [EnumMember(Value = "Guide")]
        Guide = 2,

        /// <summary>
        /// Enum CustomLink for value: CustomLink
        /// </summary>
        [EnumMember(Value = "CustomLink")]
        CustomLink = 3

    }

}
