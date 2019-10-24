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
    /// UserProfileMetadataSettings
    /// </summary>
    [DataContract]
    public partial class UserProfileMetadataSettings :  IEquatable<UserProfileMetadataSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileMetadataSettings" /> class.
        /// </summary>
        /// <param name="adminCenter">adminCenter.</param>
        /// <param name="property">property.</param>
        /// <param name="value">value.</param>
        public UserProfileMetadataSettings(string adminCenter = default(string), string property = default(string), LookupValue value = default(LookupValue))
        {
            this.AdminCenter = adminCenter;
            this.Property = property;
            this.AdminCenter = adminCenter;
            this.Property = property;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets AdminCenter
        /// </summary>
        [DataMember(Name="adminCenter", EmitDefaultValue=true)]
        public string AdminCenter { get; set; }

        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [DataMember(Name="property", EmitDefaultValue=true)]
        public string Property { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public LookupValue Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProfileMetadataSettings {\n");
            sb.Append("  AdminCenter: ").Append(AdminCenter).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as UserProfileMetadataSettings);
        }

        /// <summary>
        /// Returns true if UserProfileMetadataSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of UserProfileMetadataSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserProfileMetadataSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdminCenter == input.AdminCenter ||
                    (this.AdminCenter != null &&
                    this.AdminCenter.Equals(input.AdminCenter))
                ) && 
                (
                    this.Property == input.Property ||
                    (this.Property != null &&
                    this.Property.Equals(input.Property))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.AdminCenter != null)
                    hashCode = hashCode * 59 + this.AdminCenter.GetHashCode();
                if (this.Property != null)
                    hashCode = hashCode * 59 + this.Property.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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