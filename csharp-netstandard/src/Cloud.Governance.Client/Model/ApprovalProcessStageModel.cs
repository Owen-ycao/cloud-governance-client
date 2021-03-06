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
    /// ApprovalProcessStageModel
    /// </summary>
    [DataContract]
    public partial class ApprovalProcessStageModel :  IEquatable<ApprovalProcessStageModel>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ApproveOrder
        /// </summary>
        [DataMember(Name="approveOrder", EmitDefaultValue=false)]
        public ApproveOrder? ApproveOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovalProcessStageModel" /> class.
        /// </summary>
        /// <param name="approveOrder">approveOrder.</param>
        /// <param name="approvers">approvers.</param>
        /// <param name="description">description.</param>
        /// <param name="name">name.</param>
        /// <param name="isAllowAutocrat">isAllowAutocrat.</param>
        /// <param name="isAllowReassign">isAllowReassign.</param>
        /// <param name="durationSetting">durationSetting.</param>
        /// <param name="emailSetting">emailSetting.</param>
        public ApprovalProcessStageModel(ApproveOrder approveOrder = default(ApproveOrder), List<ApiUser> approvers = default(List<ApiUser>), string description = default(string), string name = default(string), bool isAllowAutocrat = default(bool), bool isAllowReassign = default(bool), ApprovalProcessStageDurationSetting durationSetting = default(ApprovalProcessStageDurationSetting), ApprovalProcessStageEmailSetting emailSetting = default(ApprovalProcessStageEmailSetting))
        {
            this.ApproveOrder = approveOrder;
            this.Approvers = approvers;
            this.Description = description;
            this.Name = name;
            this.IsAllowAutocrat = isAllowAutocrat;
            this.IsAllowReassign = isAllowReassign;
            this.DurationSetting = durationSetting;
            this.EmailSetting = emailSetting;
        }
        
        /// <summary>
        /// Gets or Sets Approvers
        /// </summary>
        [DataMember(Name="approvers", EmitDefaultValue=true)]
        public List<ApiUser> Approvers { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IsAllowAutocrat
        /// </summary>
        [DataMember(Name="isAllowAutocrat", EmitDefaultValue=false)]
        public bool IsAllowAutocrat { get; set; }

        /// <summary>
        /// Gets or Sets IsAllowReassign
        /// </summary>
        [DataMember(Name="isAllowReassign", EmitDefaultValue=false)]
        public bool IsAllowReassign { get; set; }

        /// <summary>
        /// Gets or Sets DurationSetting
        /// </summary>
        [DataMember(Name="durationSetting", EmitDefaultValue=true)]
        public ApprovalProcessStageDurationSetting DurationSetting { get; set; }

        /// <summary>
        /// Gets or Sets EmailSetting
        /// </summary>
        [DataMember(Name="emailSetting", EmitDefaultValue=true)]
        public ApprovalProcessStageEmailSetting EmailSetting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApprovalProcessStageModel {\n");
            sb.Append("  ApproveOrder: ").Append(ApproveOrder).Append("\n");
            sb.Append("  Approvers: ").Append(Approvers).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsAllowAutocrat: ").Append(IsAllowAutocrat).Append("\n");
            sb.Append("  IsAllowReassign: ").Append(IsAllowReassign).Append("\n");
            sb.Append("  DurationSetting: ").Append(DurationSetting).Append("\n");
            sb.Append("  EmailSetting: ").Append(EmailSetting).Append("\n");
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
            return this.Equals(input as ApprovalProcessStageModel);
        }

        /// <summary>
        /// Returns true if ApprovalProcessStageModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ApprovalProcessStageModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApprovalProcessStageModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApproveOrder == input.ApproveOrder ||
                    this.ApproveOrder.Equals(input.ApproveOrder)
                ) && 
                (
                    this.Approvers == input.Approvers ||
                    this.Approvers != null &&
                    input.Approvers != null &&
                    this.Approvers.SequenceEqual(input.Approvers)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsAllowAutocrat == input.IsAllowAutocrat ||
                    this.IsAllowAutocrat.Equals(input.IsAllowAutocrat)
                ) && 
                (
                    this.IsAllowReassign == input.IsAllowReassign ||
                    this.IsAllowReassign.Equals(input.IsAllowReassign)
                ) && 
                (
                    this.DurationSetting == input.DurationSetting ||
                    (this.DurationSetting != null &&
                    this.DurationSetting.Equals(input.DurationSetting))
                ) && 
                (
                    this.EmailSetting == input.EmailSetting ||
                    (this.EmailSetting != null &&
                    this.EmailSetting.Equals(input.EmailSetting))
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
                hashCode = hashCode * 59 + this.ApproveOrder.GetHashCode();
                if (this.Approvers != null)
                    hashCode = hashCode * 59 + this.Approvers.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.IsAllowAutocrat.GetHashCode();
                hashCode = hashCode * 59 + this.IsAllowReassign.GetHashCode();
                if (this.DurationSetting != null)
                    hashCode = hashCode * 59 + this.DurationSetting.GetHashCode();
                if (this.EmailSetting != null)
                    hashCode = hashCode * 59 + this.EmailSetting.GetHashCode();
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
