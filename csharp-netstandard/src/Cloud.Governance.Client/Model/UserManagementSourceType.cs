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
    /// User&#x3D;0, Group&#x3D;1, All&#x3D;2, &lt;/br&gt;
    /// </summary>
    /// <value>User&#x3D;0, Group&#x3D;1, All&#x3D;2, &lt;/br&gt;</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum UserManagementSourceType
    {
        /// <summary>
        /// Enum User for value: User
        /// </summary>
        [EnumMember(Value = "User")]
        User = 1,

        /// <summary>
        /// Enum Group for value: Group
        /// </summary>
        [EnumMember(Value = "Group")]
        Group = 2,

        /// <summary>
        /// Enum All for value: All
        /// </summary>
        [EnumMember(Value = "All")]
        All = 3

    }

}
