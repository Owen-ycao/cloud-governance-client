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
    /// SiteRecertificationProperty
    /// </summary>
    [DataContract]
    public partial class SiteRecertificationProperty :  IEquatable<SiteRecertificationProperty>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets PermissionRecertificationStatus
        /// </summary>
        [DataMember(Name="permissionRecertificationStatus", EmitDefaultValue=false)]
        public RecertificationStatus? PermissionRecertificationStatus { get; set; }
        /// <summary>
        /// Gets or Sets OwnershipRecertificationStatus
        /// </summary>
        [DataMember(Name="ownershipRecertificationStatus", EmitDefaultValue=false)]
        public RecertificationStatus? OwnershipRecertificationStatus { get; set; }
        /// <summary>
        /// Gets or Sets MetadataRecertificationStatus
        /// </summary>
        [DataMember(Name="metadataRecertificationStatus", EmitDefaultValue=false)]
        public RecertificationStatus? MetadataRecertificationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteRecertificationProperty" /> class.
        /// </summary>
        /// <param name="permissionRecertificationStatus">permissionRecertificationStatus.</param>
        /// <param name="ownershipRecertificationStatus">ownershipRecertificationStatus.</param>
        /// <param name="metadataRecertificationStatus">metadataRecertificationStatus.</param>
        public SiteRecertificationProperty(RecertificationStatus permissionRecertificationStatus = default(RecertificationStatus), RecertificationStatus ownershipRecertificationStatus = default(RecertificationStatus), RecertificationStatus metadataRecertificationStatus = default(RecertificationStatus))
        {
            this.PermissionRecertificationStatus = permissionRecertificationStatus;
            this.OwnershipRecertificationStatus = ownershipRecertificationStatus;
            this.MetadataRecertificationStatus = metadataRecertificationStatus;
        }
        
        /// <summary>
        /// Gets or Sets PermissionRecertificationStatusDesc
        /// </summary>
        [DataMember(Name="permissionRecertificationStatusDesc", EmitDefaultValue=true)]
        public string PermissionRecertificationStatusDesc { get; private set; }

        /// <summary>
        /// Gets or Sets OwnershipRecertificationStatusDesc
        /// </summary>
        [DataMember(Name="ownershipRecertificationStatusDesc", EmitDefaultValue=true)]
        public string OwnershipRecertificationStatusDesc { get; private set; }

        /// <summary>
        /// Gets or Sets MetadataRecertificationStatusDesc
        /// </summary>
        [DataMember(Name="metadataRecertificationStatusDesc", EmitDefaultValue=true)]
        public string MetadataRecertificationStatusDesc { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SiteRecertificationProperty {\n");
            sb.Append("  PermissionRecertificationStatus: ").Append(PermissionRecertificationStatus).Append("\n");
            sb.Append("  PermissionRecertificationStatusDesc: ").Append(PermissionRecertificationStatusDesc).Append("\n");
            sb.Append("  OwnershipRecertificationStatus: ").Append(OwnershipRecertificationStatus).Append("\n");
            sb.Append("  OwnershipRecertificationStatusDesc: ").Append(OwnershipRecertificationStatusDesc).Append("\n");
            sb.Append("  MetadataRecertificationStatus: ").Append(MetadataRecertificationStatus).Append("\n");
            sb.Append("  MetadataRecertificationStatusDesc: ").Append(MetadataRecertificationStatusDesc).Append("\n");
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
            return this.Equals(input as SiteRecertificationProperty);
        }

        /// <summary>
        /// Returns true if SiteRecertificationProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of SiteRecertificationProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SiteRecertificationProperty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PermissionRecertificationStatus == input.PermissionRecertificationStatus ||
                    this.PermissionRecertificationStatus.Equals(input.PermissionRecertificationStatus)
                ) && 
                (
                    this.PermissionRecertificationStatusDesc == input.PermissionRecertificationStatusDesc ||
                    (this.PermissionRecertificationStatusDesc != null &&
                    this.PermissionRecertificationStatusDesc.Equals(input.PermissionRecertificationStatusDesc))
                ) && 
                (
                    this.OwnershipRecertificationStatus == input.OwnershipRecertificationStatus ||
                    this.OwnershipRecertificationStatus.Equals(input.OwnershipRecertificationStatus)
                ) && 
                (
                    this.OwnershipRecertificationStatusDesc == input.OwnershipRecertificationStatusDesc ||
                    (this.OwnershipRecertificationStatusDesc != null &&
                    this.OwnershipRecertificationStatusDesc.Equals(input.OwnershipRecertificationStatusDesc))
                ) && 
                (
                    this.MetadataRecertificationStatus == input.MetadataRecertificationStatus ||
                    this.MetadataRecertificationStatus.Equals(input.MetadataRecertificationStatus)
                ) && 
                (
                    this.MetadataRecertificationStatusDesc == input.MetadataRecertificationStatusDesc ||
                    (this.MetadataRecertificationStatusDesc != null &&
                    this.MetadataRecertificationStatusDesc.Equals(input.MetadataRecertificationStatusDesc))
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
                hashCode = hashCode * 59 + this.PermissionRecertificationStatus.GetHashCode();
                if (this.PermissionRecertificationStatusDesc != null)
                    hashCode = hashCode * 59 + this.PermissionRecertificationStatusDesc.GetHashCode();
                hashCode = hashCode * 59 + this.OwnershipRecertificationStatus.GetHashCode();
                if (this.OwnershipRecertificationStatusDesc != null)
                    hashCode = hashCode * 59 + this.OwnershipRecertificationStatusDesc.GetHashCode();
                hashCode = hashCode * 59 + this.MetadataRecertificationStatus.GetHashCode();
                if (this.MetadataRecertificationStatusDesc != null)
                    hashCode = hashCode * 59 + this.MetadataRecertificationStatusDesc.GetHashCode();
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