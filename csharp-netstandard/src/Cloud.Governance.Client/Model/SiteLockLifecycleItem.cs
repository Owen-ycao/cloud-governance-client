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
    /// SiteLockLifecycleItem
    /// </summary>
    [DataContract]
    public partial class SiteLockLifecycleItem :  IEquatable<SiteLockLifecycleItem>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets LockType
        /// </summary>
        [DataMember(Name="lockType", EmitDefaultValue=false)]
        public SiteLockType? LockType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteLockLifecycleItem" /> class.
        /// </summary>
        /// <param name="lockType">lockType.</param>
        /// <param name="isNotifyEnabled">isNotifyEnabled.</param>
        /// <param name="notifyUser">notifyUser.</param>
        /// <param name="notifyTemplate">notifyTemplate.</param>
        /// <param name="isEnabled">isEnabled.</param>
        /// <param name="isDefaultProcess">isDefaultProcess.</param>
        /// <param name="process">process.</param>
        public SiteLockLifecycleItem(SiteLockType lockType = default(SiteLockType), bool isNotifyEnabled = default(bool), List<ApiUser> notifyUser = default(List<ApiUser>), GuidModel notifyTemplate = default(GuidModel), bool isEnabled = default(bool), bool isDefaultProcess = default(bool), GuidModel process = default(GuidModel))
        {
            this.LockType = lockType;
            this.IsNotifyEnabled = isNotifyEnabled;
            this.NotifyUser = notifyUser;
            this.NotifyTemplate = notifyTemplate;
            this.IsEnabled = isEnabled;
            this.IsDefaultProcess = isDefaultProcess;
            this.Process = process;
        }
        
        /// <summary>
        /// Gets or Sets IsNotifyEnabled
        /// </summary>
        [DataMember(Name="isNotifyEnabled", EmitDefaultValue=false)]
        public bool IsNotifyEnabled { get; set; }

        /// <summary>
        /// Gets or Sets NotifyUser
        /// </summary>
        [DataMember(Name="notifyUser", EmitDefaultValue=true)]
        public List<ApiUser> NotifyUser { get; set; }

        /// <summary>
        /// Gets or Sets NotifyTemplate
        /// </summary>
        [DataMember(Name="notifyTemplate", EmitDefaultValue=true)]
        public GuidModel NotifyTemplate { get; set; }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name="isEnabled", EmitDefaultValue=false)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets IsDefaultProcess
        /// </summary>
        [DataMember(Name="isDefaultProcess", EmitDefaultValue=false)]
        public bool IsDefaultProcess { get; set; }

        /// <summary>
        /// Gets or Sets Process
        /// </summary>
        [DataMember(Name="process", EmitDefaultValue=true)]
        public GuidModel Process { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SiteLockLifecycleItem {\n");
            sb.Append("  LockType: ").Append(LockType).Append("\n");
            sb.Append("  IsNotifyEnabled: ").Append(IsNotifyEnabled).Append("\n");
            sb.Append("  NotifyUser: ").Append(NotifyUser).Append("\n");
            sb.Append("  NotifyTemplate: ").Append(NotifyTemplate).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  IsDefaultProcess: ").Append(IsDefaultProcess).Append("\n");
            sb.Append("  Process: ").Append(Process).Append("\n");
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
            return this.Equals(input as SiteLockLifecycleItem);
        }

        /// <summary>
        /// Returns true if SiteLockLifecycleItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SiteLockLifecycleItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SiteLockLifecycleItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LockType == input.LockType ||
                    this.LockType.Equals(input.LockType)
                ) && 
                (
                    this.IsNotifyEnabled == input.IsNotifyEnabled ||
                    this.IsNotifyEnabled.Equals(input.IsNotifyEnabled)
                ) && 
                (
                    this.NotifyUser == input.NotifyUser ||
                    this.NotifyUser != null &&
                    input.NotifyUser != null &&
                    this.NotifyUser.SequenceEqual(input.NotifyUser)
                ) && 
                (
                    this.NotifyTemplate == input.NotifyTemplate ||
                    (this.NotifyTemplate != null &&
                    this.NotifyTemplate.Equals(input.NotifyTemplate))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.IsDefaultProcess == input.IsDefaultProcess ||
                    this.IsDefaultProcess.Equals(input.IsDefaultProcess)
                ) && 
                (
                    this.Process == input.Process ||
                    (this.Process != null &&
                    this.Process.Equals(input.Process))
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
                hashCode = hashCode * 59 + this.LockType.GetHashCode();
                hashCode = hashCode * 59 + this.IsNotifyEnabled.GetHashCode();
                if (this.NotifyUser != null)
                    hashCode = hashCode * 59 + this.NotifyUser.GetHashCode();
                if (this.NotifyTemplate != null)
                    hashCode = hashCode * 59 + this.NotifyTemplate.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.IsDefaultProcess.GetHashCode();
                if (this.Process != null)
                    hashCode = hashCode * 59 + this.Process.GetHashCode();
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
