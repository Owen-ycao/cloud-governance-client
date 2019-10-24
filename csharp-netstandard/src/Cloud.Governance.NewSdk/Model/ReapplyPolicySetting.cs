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
using OpenAPIDateConverter = Cloud.Governance.NewSdk.Client.OpenAPIDateConverter;

namespace Cloud.Governance.NewSdk.Model
{
    /// <summary>
    /// ReapplyPolicySetting
    /// </summary>
    [DataContract]
    public partial class ReapplyPolicySetting :  IEquatable<ReapplyPolicySetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReapplyPolicySetting" /> class.
        /// </summary>
        /// <param name="isOverwriteLifecycleStartTime">isOverwriteLifecycleStartTime.</param>
        public ReapplyPolicySetting(bool isOverwriteLifecycleStartTime = default(bool))
        {
            this.IsOverwriteLifecycleStartTime = isOverwriteLifecycleStartTime;
        }
        
        /// <summary>
        /// Gets or Sets IsOverwriteLifecycleStartTime
        /// </summary>
        [DataMember(Name="isOverwriteLifecycleStartTime", EmitDefaultValue=false)]
        public bool IsOverwriteLifecycleStartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReapplyPolicySetting {\n");
            sb.Append("  IsOverwriteLifecycleStartTime: ").Append(IsOverwriteLifecycleStartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReapplyPolicySetting);
        }

        /// <summary>
        /// Returns true if ReapplyPolicySetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ReapplyPolicySetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReapplyPolicySetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsOverwriteLifecycleStartTime == input.IsOverwriteLifecycleStartTime ||
                    this.IsOverwriteLifecycleStartTime.Equals(input.IsOverwriteLifecycleStartTime)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.IsOverwriteLifecycleStartTime.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}