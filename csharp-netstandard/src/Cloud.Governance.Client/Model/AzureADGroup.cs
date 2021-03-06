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
    /// AzureADGroup
    /// </summary>
    [DataContract]
    public partial class AzureADGroup :  IEquatable<AzureADGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureADGroup" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="objectId">objectId.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="email">email.</param>
        /// <param name="description">description.</param>
        /// <param name="privacy">privacy.</param>
        /// <param name="subscribe">subscribe.</param>
        /// <param name="outsideSender">outsideSender.</param>
        /// <param name="language">language.</param>
        /// <param name="classification">classification.</param>
        /// <param name="sharePointSiteUrl">sharePointSiteUrl.</param>
        public AzureADGroup(Guid id = default(Guid), string objectId = default(string), Guid tenantId = default(Guid), string groupName = default(string), string email = default(string), string description = default(string), bool privacy = default(bool), bool subscribe = default(bool), bool outsideSender = default(bool), string language = default(string), string classification = default(string), string sharePointSiteUrl = default(string))
        {
            this.Id = id;
            this.ObjectId = objectId;
            this.TenantId = tenantId;
            this.GroupName = groupName;
            this.Email = email;
            this.Description = description;
            this.Privacy = privacy;
            this.Subscribe = subscribe;
            this.OutsideSender = outsideSender;
            this.Language = language;
            this.Classification = classification;
            this.SharePointSiteUrl = sharePointSiteUrl;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=true)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name="groupName", EmitDefaultValue=true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name="privacy", EmitDefaultValue=false)]
        public bool Privacy { get; set; }

        /// <summary>
        /// Gets or Sets Subscribe
        /// </summary>
        [DataMember(Name="subscribe", EmitDefaultValue=false)]
        public bool Subscribe { get; set; }

        /// <summary>
        /// Gets or Sets OutsideSender
        /// </summary>
        [DataMember(Name="outsideSender", EmitDefaultValue=false)]
        public bool OutsideSender { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets Classification
        /// </summary>
        [DataMember(Name="classification", EmitDefaultValue=true)]
        public string Classification { get; set; }

        /// <summary>
        /// Gets or Sets SharePointSiteUrl
        /// </summary>
        [DataMember(Name="sharePointSiteUrl", EmitDefaultValue=true)]
        public string SharePointSiteUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AzureADGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  Subscribe: ").Append(Subscribe).Append("\n");
            sb.Append("  OutsideSender: ").Append(OutsideSender).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  SharePointSiteUrl: ").Append(SharePointSiteUrl).Append("\n");
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
            return this.Equals(input as AzureADGroup);
        }

        /// <summary>
        /// Returns true if AzureADGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureADGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureADGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Privacy == input.Privacy ||
                    this.Privacy.Equals(input.Privacy)
                ) && 
                (
                    this.Subscribe == input.Subscribe ||
                    this.Subscribe.Equals(input.Subscribe)
                ) && 
                (
                    this.OutsideSender == input.OutsideSender ||
                    this.OutsideSender.Equals(input.OutsideSender)
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && 
                (
                    this.SharePointSiteUrl == input.SharePointSiteUrl ||
                    (this.SharePointSiteUrl != null &&
                    this.SharePointSiteUrl.Equals(input.SharePointSiteUrl))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Privacy.GetHashCode();
                hashCode = hashCode * 59 + this.Subscribe.GetHashCode();
                hashCode = hashCode * 59 + this.OutsideSender.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                if (this.SharePointSiteUrl != null)
                    hashCode = hashCode * 59 + this.SharePointSiteUrl.GetHashCode();
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
