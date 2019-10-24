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
    /// PolicyQuotaSetting
    /// </summary>
    [DataContract]
    public partial class PolicyQuotaSetting :  IEquatable<PolicyQuotaSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyQuotaSetting" /> class.
        /// </summary>
        /// <param name="storage">storage.</param>
        /// <param name="serverResource">serverResource.</param>
        public PolicyQuotaSetting(long storage = default(long), double serverResource = default(double))
        {
            this.Storage = storage;
            this.ServerResource = serverResource;
        }
        
        /// <summary>
        /// Gets or Sets Storage
        /// </summary>
        [DataMember(Name="storage", EmitDefaultValue=false)]
        public long Storage { get; set; }

        /// <summary>
        /// Gets or Sets ServerResource
        /// </summary>
        [DataMember(Name="serverResource", EmitDefaultValue=false)]
        public double ServerResource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyQuotaSetting {\n");
            sb.Append("  Storage: ").Append(Storage).Append("\n");
            sb.Append("  ServerResource: ").Append(ServerResource).Append("\n");
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
            return this.Equals(input as PolicyQuotaSetting);
        }

        /// <summary>
        /// Returns true if PolicyQuotaSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyQuotaSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyQuotaSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Storage == input.Storage ||
                    this.Storage.Equals(input.Storage)
                ) && 
                (
                    this.ServerResource == input.ServerResource ||
                    this.ServerResource.Equals(input.ServerResource)
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
                hashCode = hashCode * 59 + this.Storage.GetHashCode();
                hashCode = hashCode * 59 + this.ServerResource.GetHashCode();
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