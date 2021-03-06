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
    /// NoChange&#x3D;0, Add&#x3D;1, Edit&#x3D;2, &lt;/br&gt;Delete&#x3D;-1
    /// </summary>
    /// <value>NoChange&#x3D;0, Add&#x3D;1, Edit&#x3D;2, &lt;/br&gt;Delete&#x3D;-1</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MetadataActionType
    {
        /// <summary>
        /// Enum Delete for value: Delete
        /// </summary>
        [EnumMember(Value = "Delete")]
        Delete = 1,

        /// <summary>
        /// Enum NoChange for value: NoChange
        /// </summary>
        [EnumMember(Value = "NoChange")]
        NoChange = 2,

        /// <summary>
        /// Enum Add for value: Add
        /// </summary>
        [EnumMember(Value = "Add")]
        Add = 3,

        /// <summary>
        /// Enum Edit for value: Edit
        /// </summary>
        [EnumMember(Value = "Edit")]
        Edit = 4

    }

}
