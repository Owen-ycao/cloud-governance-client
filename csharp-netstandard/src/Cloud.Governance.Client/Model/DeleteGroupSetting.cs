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
    /// DeleteGroupSetting
    /// </summary>
    [DataContract]
    public partial class DeleteGroupSetting :  IEquatable<DeleteGroupSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteGroupSetting" /> class.
        /// </summary>
        /// <param name="enableNotify">enableNotify.</param>
        /// <param name="notifyUsers">notifyUsers.</param>
        /// <param name="emailTemplate">emailTemplate.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="approvalProcess">approvalProcess.</param>
        /// <param name="isUsedDefaultProcess">isUsedDefaultProcess.</param>
        public DeleteGroupSetting(bool enableNotify = default(bool), List<ApiUser> notifyUsers = default(List<ApiUser>), GuidModel emailTemplate = default(GuidModel), bool enabled = default(bool), GuidModel approvalProcess = default(GuidModel), bool isUsedDefaultProcess = default(bool))
        {
            this.EnableNotify = enableNotify;
            this.NotifyUsers = notifyUsers;
            this.EmailTemplate = emailTemplate;
            this.Enabled = enabled;
            this.ApprovalProcess = approvalProcess;
            this.IsUsedDefaultProcess = isUsedDefaultProcess;
        }
        
        /// <summary>
        /// Gets or Sets EnableNotify
        /// </summary>
        [DataMember(Name="enableNotify", EmitDefaultValue=false)]
        public bool EnableNotify { get; set; }

        /// <summary>
        /// Gets or Sets NotifyUsers
        /// </summary>
        [DataMember(Name="notifyUsers", EmitDefaultValue=true)]
        public List<ApiUser> NotifyUsers { get; set; }

        /// <summary>
        /// Gets or Sets EmailTemplate
        /// </summary>
        [DataMember(Name="emailTemplate", EmitDefaultValue=true)]
        public GuidModel EmailTemplate { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets ApprovalProcess
        /// </summary>
        [DataMember(Name="approvalProcess", EmitDefaultValue=true)]
        public GuidModel ApprovalProcess { get; set; }

        /// <summary>
        /// Gets or Sets IsUsedDefaultProcess
        /// </summary>
        [DataMember(Name="isUsedDefaultProcess", EmitDefaultValue=false)]
        public bool IsUsedDefaultProcess { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteGroupSetting {\n");
            sb.Append("  EnableNotify: ").Append(EnableNotify).Append("\n");
            sb.Append("  NotifyUsers: ").Append(NotifyUsers).Append("\n");
            sb.Append("  EmailTemplate: ").Append(EmailTemplate).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ApprovalProcess: ").Append(ApprovalProcess).Append("\n");
            sb.Append("  IsUsedDefaultProcess: ").Append(IsUsedDefaultProcess).Append("\n");
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
            return this.Equals(input as DeleteGroupSetting);
        }

        /// <summary>
        /// Returns true if DeleteGroupSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteGroupSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteGroupSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableNotify == input.EnableNotify ||
                    this.EnableNotify.Equals(input.EnableNotify)
                ) && 
                (
                    this.NotifyUsers == input.NotifyUsers ||
                    this.NotifyUsers != null &&
                    input.NotifyUsers != null &&
                    this.NotifyUsers.SequenceEqual(input.NotifyUsers)
                ) && 
                (
                    this.EmailTemplate == input.EmailTemplate ||
                    (this.EmailTemplate != null &&
                    this.EmailTemplate.Equals(input.EmailTemplate))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.ApprovalProcess == input.ApprovalProcess ||
                    (this.ApprovalProcess != null &&
                    this.ApprovalProcess.Equals(input.ApprovalProcess))
                ) && 
                (
                    this.IsUsedDefaultProcess == input.IsUsedDefaultProcess ||
                    this.IsUsedDefaultProcess.Equals(input.IsUsedDefaultProcess)
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
                hashCode = hashCode * 59 + this.EnableNotify.GetHashCode();
                if (this.NotifyUsers != null)
                    hashCode = hashCode * 59 + this.NotifyUsers.GetHashCode();
                if (this.EmailTemplate != null)
                    hashCode = hashCode * 59 + this.EmailTemplate.GetHashCode();
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.ApprovalProcess != null)
                    hashCode = hashCode * 59 + this.ApprovalProcess.GetHashCode();
                hashCode = hashCode * 59 + this.IsUsedDefaultProcess.GetHashCode();
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
