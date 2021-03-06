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
    /// DrowDownList&#x3D;0, RadioButton&#x3D;1, ManageredMetadata&#x3D;3, &lt;/br&gt;YesNoMetadata&#x3D;4
    /// </summary>
    /// <value>DrowDownList&#x3D;0, RadioButton&#x3D;1, ManageredMetadata&#x3D;3, &lt;/br&gt;YesNoMetadata&#x3D;4</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum QuestionaireType
    {
        /// <summary>
        /// Enum DrowDownList for value: DrowDownList
        /// </summary>
        [EnumMember(Value = "DrowDownList")]
        DrowDownList = 1,

        /// <summary>
        /// Enum RadioButton for value: RadioButton
        /// </summary>
        [EnumMember(Value = "RadioButton")]
        RadioButton = 2,

        /// <summary>
        /// Enum ManageredMetadata for value: ManageredMetadata
        /// </summary>
        [EnumMember(Value = "ManageredMetadata")]
        ManageredMetadata = 3,

        /// <summary>
        /// Enum YesNoMetadata for value: YesNoMetadata
        /// </summary>
        [EnumMember(Value = "YesNoMetadata")]
        YesNoMetadata = 4

    }

}
