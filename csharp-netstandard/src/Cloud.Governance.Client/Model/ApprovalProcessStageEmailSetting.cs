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
    /// ApprovalProcessStageEmailSetting
    /// </summary>
    [DataContract]
    public partial class ApprovalProcessStageEmailSetting :  IEquatable<ApprovalProcessStageEmailSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovalProcessStageEmailSetting" /> class.
        /// </summary>
        /// <param name="notifyApproverWhenAssigned">notifyApproverWhenAssigned.</param>
        /// <param name="notifyApproverEmailTemplateId">notifyApproverEmailTemplateId.</param>
        /// <param name="notifyReuqesterWhenApproved">notifyReuqesterWhenApproved.</param>
        /// <param name="notifyReuqesterEmailTemplateApprovedId">notifyReuqesterEmailTemplateApprovedId.</param>
        /// <param name="notifyReuqesterWhenRejected">notifyReuqesterWhenRejected.</param>
        /// <param name="notifyReuqesterEmailTemplateRejectedId">notifyReuqesterEmailTemplateRejectedId.</param>
        /// <param name="warnApproverbeforeExpired">warnApproverbeforeExpired.</param>
        /// <param name="warnApproverbeforeExpiredEmailTemplateId">warnApproverbeforeExpiredEmailTemplateId.</param>
        /// <param name="notifyApproverWhenExpired">notifyApproverWhenExpired.</param>
        /// <param name="notifyApproverWhenExpiredEmailTemplateId">notifyApproverWhenExpiredEmailTemplateId.</param>
        /// <param name="notifyApproverWhenCancelled">notifyApproverWhenCancelled.</param>
        /// <param name="notifyApproverCancelledEmailTemplateId">notifyApproverCancelledEmailTemplateId.</param>
        /// <param name="notifyApproverWhenRejected">notifyApproverWhenRejected.</param>
        /// <param name="notifyApproverRejectedEmailTemplateId">notifyApproverRejectedEmailTemplateId.</param>
        public ApprovalProcessStageEmailSetting(bool notifyApproverWhenAssigned = default(bool), Guid notifyApproverEmailTemplateId = default(Guid), bool notifyReuqesterWhenApproved = default(bool), Guid notifyReuqesterEmailTemplateApprovedId = default(Guid), bool notifyReuqesterWhenRejected = default(bool), Guid notifyReuqesterEmailTemplateRejectedId = default(Guid), bool warnApproverbeforeExpired = default(bool), Guid warnApproverbeforeExpiredEmailTemplateId = default(Guid), bool notifyApproverWhenExpired = default(bool), Guid notifyApproverWhenExpiredEmailTemplateId = default(Guid), bool notifyApproverWhenCancelled = default(bool), Guid notifyApproverCancelledEmailTemplateId = default(Guid), bool notifyApproverWhenRejected = default(bool), Guid notifyApproverRejectedEmailTemplateId = default(Guid))
        {
            this.NotifyApproverWhenAssigned = notifyApproverWhenAssigned;
            this.NotifyApproverEmailTemplateId = notifyApproverEmailTemplateId;
            this.NotifyReuqesterWhenApproved = notifyReuqesterWhenApproved;
            this.NotifyReuqesterEmailTemplateApprovedId = notifyReuqesterEmailTemplateApprovedId;
            this.NotifyReuqesterWhenRejected = notifyReuqesterWhenRejected;
            this.NotifyReuqesterEmailTemplateRejectedId = notifyReuqesterEmailTemplateRejectedId;
            this.WarnApproverbeforeExpired = warnApproverbeforeExpired;
            this.WarnApproverbeforeExpiredEmailTemplateId = warnApproverbeforeExpiredEmailTemplateId;
            this.NotifyApproverWhenExpired = notifyApproverWhenExpired;
            this.NotifyApproverWhenExpiredEmailTemplateId = notifyApproverWhenExpiredEmailTemplateId;
            this.NotifyApproverWhenCancelled = notifyApproverWhenCancelled;
            this.NotifyApproverCancelledEmailTemplateId = notifyApproverCancelledEmailTemplateId;
            this.NotifyApproverWhenRejected = notifyApproverWhenRejected;
            this.NotifyApproverRejectedEmailTemplateId = notifyApproverRejectedEmailTemplateId;
        }
        
        /// <summary>
        /// Gets or Sets NotifyApproverWhenAssigned
        /// </summary>
        [DataMember(Name="notifyApproverWhenAssigned", EmitDefaultValue=false)]
        public bool NotifyApproverWhenAssigned { get; set; }

        /// <summary>
        /// Gets or Sets NotifyApproverEmailTemplateId
        /// </summary>
        [DataMember(Name="notifyApproverEmailTemplateId", EmitDefaultValue=false)]
        public Guid NotifyApproverEmailTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets NotifyReuqesterWhenApproved
        /// </summary>
        [DataMember(Name="notifyReuqesterWhenApproved", EmitDefaultValue=false)]
        public bool NotifyReuqesterWhenApproved { get; set; }

        /// <summary>
        /// Gets or Sets NotifyReuqesterEmailTemplateApprovedId
        /// </summary>
        [DataMember(Name="notifyReuqesterEmailTemplateApprovedId", EmitDefaultValue=false)]
        public Guid NotifyReuqesterEmailTemplateApprovedId { get; set; }

        /// <summary>
        /// Gets or Sets NotifyReuqesterWhenRejected
        /// </summary>
        [DataMember(Name="notifyReuqesterWhenRejected", EmitDefaultValue=false)]
        public bool NotifyReuqesterWhenRejected { get; set; }

        /// <summary>
        /// Gets or Sets NotifyReuqesterEmailTemplateRejectedId
        /// </summary>
        [DataMember(Name="notifyReuqesterEmailTemplateRejectedId", EmitDefaultValue=false)]
        public Guid NotifyReuqesterEmailTemplateRejectedId { get; set; }

        /// <summary>
        /// Gets or Sets WarnApproverbeforeExpired
        /// </summary>
        [DataMember(Name="warnApproverbeforeExpired", EmitDefaultValue=false)]
        public bool WarnApproverbeforeExpired { get; set; }

        /// <summary>
        /// Gets or Sets WarnApproverbeforeExpiredEmailTemplateId
        /// </summary>
        [DataMember(Name="warnApproverbeforeExpiredEmailTemplateId", EmitDefaultValue=false)]
        public Guid WarnApproverbeforeExpiredEmailTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets NotifyApproverWhenExpired
        /// </summary>
        [DataMember(Name="notifyApproverWhenExpired", EmitDefaultValue=false)]
        public bool NotifyApproverWhenExpired { get; set; }

        /// <summary>
        /// Gets or Sets NotifyApproverWhenExpiredEmailTemplateId
        /// </summary>
        [DataMember(Name="notifyApproverWhenExpiredEmailTemplateId", EmitDefaultValue=false)]
        public Guid NotifyApproverWhenExpiredEmailTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets NotifyApproverWhenCancelled
        /// </summary>
        [DataMember(Name="notifyApproverWhenCancelled", EmitDefaultValue=false)]
        public bool NotifyApproverWhenCancelled { get; set; }

        /// <summary>
        /// Gets or Sets NotifyApproverCancelledEmailTemplateId
        /// </summary>
        [DataMember(Name="notifyApproverCancelledEmailTemplateId", EmitDefaultValue=false)]
        public Guid NotifyApproverCancelledEmailTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets NotifyApproverWhenRejected
        /// </summary>
        [DataMember(Name="notifyApproverWhenRejected", EmitDefaultValue=false)]
        public bool NotifyApproverWhenRejected { get; set; }

        /// <summary>
        /// Gets or Sets NotifyApproverRejectedEmailTemplateId
        /// </summary>
        [DataMember(Name="notifyApproverRejectedEmailTemplateId", EmitDefaultValue=false)]
        public Guid NotifyApproverRejectedEmailTemplateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApprovalProcessStageEmailSetting {\n");
            sb.Append("  NotifyApproverWhenAssigned: ").Append(NotifyApproverWhenAssigned).Append("\n");
            sb.Append("  NotifyApproverEmailTemplateId: ").Append(NotifyApproverEmailTemplateId).Append("\n");
            sb.Append("  NotifyReuqesterWhenApproved: ").Append(NotifyReuqesterWhenApproved).Append("\n");
            sb.Append("  NotifyReuqesterEmailTemplateApprovedId: ").Append(NotifyReuqesterEmailTemplateApprovedId).Append("\n");
            sb.Append("  NotifyReuqesterWhenRejected: ").Append(NotifyReuqesterWhenRejected).Append("\n");
            sb.Append("  NotifyReuqesterEmailTemplateRejectedId: ").Append(NotifyReuqesterEmailTemplateRejectedId).Append("\n");
            sb.Append("  WarnApproverbeforeExpired: ").Append(WarnApproverbeforeExpired).Append("\n");
            sb.Append("  WarnApproverbeforeExpiredEmailTemplateId: ").Append(WarnApproverbeforeExpiredEmailTemplateId).Append("\n");
            sb.Append("  NotifyApproverWhenExpired: ").Append(NotifyApproverWhenExpired).Append("\n");
            sb.Append("  NotifyApproverWhenExpiredEmailTemplateId: ").Append(NotifyApproverWhenExpiredEmailTemplateId).Append("\n");
            sb.Append("  NotifyApproverWhenCancelled: ").Append(NotifyApproverWhenCancelled).Append("\n");
            sb.Append("  NotifyApproverCancelledEmailTemplateId: ").Append(NotifyApproverCancelledEmailTemplateId).Append("\n");
            sb.Append("  NotifyApproverWhenRejected: ").Append(NotifyApproverWhenRejected).Append("\n");
            sb.Append("  NotifyApproverRejectedEmailTemplateId: ").Append(NotifyApproverRejectedEmailTemplateId).Append("\n");
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
            return this.Equals(input as ApprovalProcessStageEmailSetting);
        }

        /// <summary>
        /// Returns true if ApprovalProcessStageEmailSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ApprovalProcessStageEmailSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApprovalProcessStageEmailSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NotifyApproverWhenAssigned == input.NotifyApproverWhenAssigned ||
                    this.NotifyApproverWhenAssigned.Equals(input.NotifyApproverWhenAssigned)
                ) && 
                (
                    this.NotifyApproverEmailTemplateId == input.NotifyApproverEmailTemplateId ||
                    (this.NotifyApproverEmailTemplateId != null &&
                    this.NotifyApproverEmailTemplateId.Equals(input.NotifyApproverEmailTemplateId))
                ) && 
                (
                    this.NotifyReuqesterWhenApproved == input.NotifyReuqesterWhenApproved ||
                    this.NotifyReuqesterWhenApproved.Equals(input.NotifyReuqesterWhenApproved)
                ) && 
                (
                    this.NotifyReuqesterEmailTemplateApprovedId == input.NotifyReuqesterEmailTemplateApprovedId ||
                    (this.NotifyReuqesterEmailTemplateApprovedId != null &&
                    this.NotifyReuqesterEmailTemplateApprovedId.Equals(input.NotifyReuqesterEmailTemplateApprovedId))
                ) && 
                (
                    this.NotifyReuqesterWhenRejected == input.NotifyReuqesterWhenRejected ||
                    this.NotifyReuqesterWhenRejected.Equals(input.NotifyReuqesterWhenRejected)
                ) && 
                (
                    this.NotifyReuqesterEmailTemplateRejectedId == input.NotifyReuqesterEmailTemplateRejectedId ||
                    (this.NotifyReuqesterEmailTemplateRejectedId != null &&
                    this.NotifyReuqesterEmailTemplateRejectedId.Equals(input.NotifyReuqesterEmailTemplateRejectedId))
                ) && 
                (
                    this.WarnApproverbeforeExpired == input.WarnApproverbeforeExpired ||
                    this.WarnApproverbeforeExpired.Equals(input.WarnApproverbeforeExpired)
                ) && 
                (
                    this.WarnApproverbeforeExpiredEmailTemplateId == input.WarnApproverbeforeExpiredEmailTemplateId ||
                    (this.WarnApproverbeforeExpiredEmailTemplateId != null &&
                    this.WarnApproverbeforeExpiredEmailTemplateId.Equals(input.WarnApproverbeforeExpiredEmailTemplateId))
                ) && 
                (
                    this.NotifyApproverWhenExpired == input.NotifyApproverWhenExpired ||
                    this.NotifyApproverWhenExpired.Equals(input.NotifyApproverWhenExpired)
                ) && 
                (
                    this.NotifyApproverWhenExpiredEmailTemplateId == input.NotifyApproverWhenExpiredEmailTemplateId ||
                    (this.NotifyApproverWhenExpiredEmailTemplateId != null &&
                    this.NotifyApproverWhenExpiredEmailTemplateId.Equals(input.NotifyApproverWhenExpiredEmailTemplateId))
                ) && 
                (
                    this.NotifyApproverWhenCancelled == input.NotifyApproverWhenCancelled ||
                    this.NotifyApproverWhenCancelled.Equals(input.NotifyApproverWhenCancelled)
                ) && 
                (
                    this.NotifyApproverCancelledEmailTemplateId == input.NotifyApproverCancelledEmailTemplateId ||
                    (this.NotifyApproverCancelledEmailTemplateId != null &&
                    this.NotifyApproverCancelledEmailTemplateId.Equals(input.NotifyApproverCancelledEmailTemplateId))
                ) && 
                (
                    this.NotifyApproverWhenRejected == input.NotifyApproverWhenRejected ||
                    this.NotifyApproverWhenRejected.Equals(input.NotifyApproverWhenRejected)
                ) && 
                (
                    this.NotifyApproverRejectedEmailTemplateId == input.NotifyApproverRejectedEmailTemplateId ||
                    (this.NotifyApproverRejectedEmailTemplateId != null &&
                    this.NotifyApproverRejectedEmailTemplateId.Equals(input.NotifyApproverRejectedEmailTemplateId))
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
                hashCode = hashCode * 59 + this.NotifyApproverWhenAssigned.GetHashCode();
                if (this.NotifyApproverEmailTemplateId != null)
                    hashCode = hashCode * 59 + this.NotifyApproverEmailTemplateId.GetHashCode();
                hashCode = hashCode * 59 + this.NotifyReuqesterWhenApproved.GetHashCode();
                if (this.NotifyReuqesterEmailTemplateApprovedId != null)
                    hashCode = hashCode * 59 + this.NotifyReuqesterEmailTemplateApprovedId.GetHashCode();
                hashCode = hashCode * 59 + this.NotifyReuqesterWhenRejected.GetHashCode();
                if (this.NotifyReuqesterEmailTemplateRejectedId != null)
                    hashCode = hashCode * 59 + this.NotifyReuqesterEmailTemplateRejectedId.GetHashCode();
                hashCode = hashCode * 59 + this.WarnApproverbeforeExpired.GetHashCode();
                if (this.WarnApproverbeforeExpiredEmailTemplateId != null)
                    hashCode = hashCode * 59 + this.WarnApproverbeforeExpiredEmailTemplateId.GetHashCode();
                hashCode = hashCode * 59 + this.NotifyApproverWhenExpired.GetHashCode();
                if (this.NotifyApproverWhenExpiredEmailTemplateId != null)
                    hashCode = hashCode * 59 + this.NotifyApproverWhenExpiredEmailTemplateId.GetHashCode();
                hashCode = hashCode * 59 + this.NotifyApproverWhenCancelled.GetHashCode();
                if (this.NotifyApproverCancelledEmailTemplateId != null)
                    hashCode = hashCode * 59 + this.NotifyApproverCancelledEmailTemplateId.GetHashCode();
                hashCode = hashCode * 59 + this.NotifyApproverWhenRejected.GetHashCode();
                if (this.NotifyApproverRejectedEmailTemplateId != null)
                    hashCode = hashCode * 59 + this.NotifyApproverRejectedEmailTemplateId.GetHashCode();
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
