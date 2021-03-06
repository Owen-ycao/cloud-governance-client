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
    /// OwnershipRecertification
    /// </summary>
    [DataContract]
    public partial class OwnershipRecertification :  IEquatable<OwnershipRecertification>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public TaskResult? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OwnershipRecertification" /> class.
        /// </summary>
        /// <param name="taskId">taskId.</param>
        /// <param name="siteId">siteId.</param>
        /// <param name="siteUrl">siteUrl.</param>
        /// <param name="siteTitle">siteTitle.</param>
        /// <param name="siteDescription">siteDescription.</param>
        /// <param name="policy">policy.</param>
        /// <param name="generatedTime">generatedTime.</param>
        /// <param name="primaryAdministrator">primaryAdministrator.</param>
        /// <param name="primaryContact">primaryContact.</param>
        /// <param name="secondaryContact">secondaryContact.</param>
        /// <param name="template">template.</param>
        /// <param name="status">status.</param>
        public OwnershipRecertification(Guid taskId = default(Guid), Guid siteId = default(Guid), string siteUrl = default(string), string siteTitle = default(string), string siteDescription = default(string), GuidModel policy = default(GuidModel), DateTime generatedTime = default(DateTime), ApiUser primaryAdministrator = default(ApiUser), ApiUser primaryContact = default(ApiUser), ApiUser secondaryContact = default(ApiUser), string template = default(string), TaskResult status = default(TaskResult))
        {
            this.TaskId = taskId;
            this.SiteId = siteId;
            this.SiteUrl = siteUrl;
            this.SiteTitle = siteTitle;
            this.SiteDescription = siteDescription;
            this.Policy = policy;
            this.GeneratedTime = generatedTime;
            this.PrimaryAdministrator = primaryAdministrator;
            this.PrimaryContact = primaryContact;
            this.SecondaryContact = secondaryContact;
            this.Template = template;
            this.Status = status;
        }
        
        /// <summary>
        /// Gets or Sets TaskId
        /// </summary>
        [DataMember(Name="taskId", EmitDefaultValue=false)]
        public Guid TaskId { get; set; }

        /// <summary>
        /// Gets or Sets SiteId
        /// </summary>
        [DataMember(Name="siteId", EmitDefaultValue=false)]
        public Guid SiteId { get; set; }

        /// <summary>
        /// Gets or Sets SiteUrl
        /// </summary>
        [DataMember(Name="siteUrl", EmitDefaultValue=true)]
        public string SiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets SiteTitle
        /// </summary>
        [DataMember(Name="siteTitle", EmitDefaultValue=true)]
        public string SiteTitle { get; set; }

        /// <summary>
        /// Gets or Sets SiteDescription
        /// </summary>
        [DataMember(Name="siteDescription", EmitDefaultValue=true)]
        public string SiteDescription { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name="policy", EmitDefaultValue=true)]
        public GuidModel Policy { get; set; }

        /// <summary>
        /// Gets or Sets GeneratedTime
        /// </summary>
        [DataMember(Name="generatedTime", EmitDefaultValue=false)]
        public DateTime GeneratedTime { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryAdministrator
        /// </summary>
        [DataMember(Name="primaryAdministrator", EmitDefaultValue=true)]
        public ApiUser PrimaryAdministrator { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContact
        /// </summary>
        [DataMember(Name="primaryContact", EmitDefaultValue=true)]
        public ApiUser PrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryContact
        /// </summary>
        [DataMember(Name="secondaryContact", EmitDefaultValue=true)]
        public ApiUser SecondaryContact { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=true)]
        public string Template { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OwnershipRecertification {\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  SiteUrl: ").Append(SiteUrl).Append("\n");
            sb.Append("  SiteTitle: ").Append(SiteTitle).Append("\n");
            sb.Append("  SiteDescription: ").Append(SiteDescription).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  GeneratedTime: ").Append(GeneratedTime).Append("\n");
            sb.Append("  PrimaryAdministrator: ").Append(PrimaryAdministrator).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as OwnershipRecertification);
        }

        /// <summary>
        /// Returns true if OwnershipRecertification instances are equal
        /// </summary>
        /// <param name="input">Instance of OwnershipRecertification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OwnershipRecertification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.SiteId == input.SiteId ||
                    (this.SiteId != null &&
                    this.SiteId.Equals(input.SiteId))
                ) && 
                (
                    this.SiteUrl == input.SiteUrl ||
                    (this.SiteUrl != null &&
                    this.SiteUrl.Equals(input.SiteUrl))
                ) && 
                (
                    this.SiteTitle == input.SiteTitle ||
                    (this.SiteTitle != null &&
                    this.SiteTitle.Equals(input.SiteTitle))
                ) && 
                (
                    this.SiteDescription == input.SiteDescription ||
                    (this.SiteDescription != null &&
                    this.SiteDescription.Equals(input.SiteDescription))
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.GeneratedTime == input.GeneratedTime ||
                    (this.GeneratedTime != null &&
                    this.GeneratedTime.Equals(input.GeneratedTime))
                ) && 
                (
                    this.PrimaryAdministrator == input.PrimaryAdministrator ||
                    (this.PrimaryAdministrator != null &&
                    this.PrimaryAdministrator.Equals(input.PrimaryAdministrator))
                ) && 
                (
                    this.PrimaryContact == input.PrimaryContact ||
                    (this.PrimaryContact != null &&
                    this.PrimaryContact.Equals(input.PrimaryContact))
                ) && 
                (
                    this.SecondaryContact == input.SecondaryContact ||
                    (this.SecondaryContact != null &&
                    this.SecondaryContact.Equals(input.SecondaryContact))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.SiteId != null)
                    hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                if (this.SiteUrl != null)
                    hashCode = hashCode * 59 + this.SiteUrl.GetHashCode();
                if (this.SiteTitle != null)
                    hashCode = hashCode * 59 + this.SiteTitle.GetHashCode();
                if (this.SiteDescription != null)
                    hashCode = hashCode * 59 + this.SiteDescription.GetHashCode();
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.GeneratedTime != null)
                    hashCode = hashCode * 59 + this.GeneratedTime.GetHashCode();
                if (this.PrimaryAdministrator != null)
                    hashCode = hashCode * 59 + this.PrimaryAdministrator.GetHashCode();
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                if (this.SecondaryContact != null)
                    hashCode = hashCode * 59 + this.SecondaryContact.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
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
