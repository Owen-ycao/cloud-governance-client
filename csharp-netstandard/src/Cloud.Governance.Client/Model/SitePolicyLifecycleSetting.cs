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
    /// SitePolicyLifecycleSetting
    /// </summary>
    [DataContract]
    public partial class SitePolicyLifecycleSetting :  IEquatable<SitePolicyLifecycleSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SitePolicyLifecycleSetting" /> class.
        /// </summary>
        /// <param name="archive">archive.</param>
        /// <param name="deletion">deletion.</param>
        /// <param name="extension">extension.</param>
        /// <param name="changePolicy">changePolicy.</param>
        /// <param name="unlock">unlock.</param>
        /// <param name="_lock">_lock.</param>
        /// <param name="quota">quota.</param>
        /// <param name="defaultProcess">defaultProcess.</param>
        public SitePolicyLifecycleSetting(SiteArchiveLifecycleItem archive = default(SiteArchiveLifecycleItem), SiteDeletionLifecycleItem deletion = default(SiteDeletionLifecycleItem), SiteExtensionLifecycleItem extension = default(SiteExtensionLifecycleItem), SiteChangePolicyLifecycleItem changePolicy = default(SiteChangePolicyLifecycleItem), SiteUnlockingLifecycleItem unlock = default(SiteUnlockingLifecycleItem), SiteLockLifecycleItem _lock = default(SiteLockLifecycleItem), SiteQuotaLifecycleItem quota = default(SiteQuotaLifecycleItem), GuidModel defaultProcess = default(GuidModel))
        {
            this.Archive = archive;
            this.Deletion = deletion;
            this.Extension = extension;
            this.ChangePolicy = changePolicy;
            this.Unlock = unlock;
            this.Lock = _lock;
            this.Quota = quota;
            this.DefaultProcess = defaultProcess;
        }
        
        /// <summary>
        /// Gets or Sets Archive
        /// </summary>
        [DataMember(Name="archive", EmitDefaultValue=true)]
        public SiteArchiveLifecycleItem Archive { get; set; }

        /// <summary>
        /// Gets or Sets Deletion
        /// </summary>
        [DataMember(Name="deletion", EmitDefaultValue=true)]
        public SiteDeletionLifecycleItem Deletion { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=true)]
        public SiteExtensionLifecycleItem Extension { get; set; }

        /// <summary>
        /// Gets or Sets ChangePolicy
        /// </summary>
        [DataMember(Name="changePolicy", EmitDefaultValue=true)]
        public SiteChangePolicyLifecycleItem ChangePolicy { get; set; }

        /// <summary>
        /// Gets or Sets Unlock
        /// </summary>
        [DataMember(Name="unlock", EmitDefaultValue=true)]
        public SiteUnlockingLifecycleItem Unlock { get; set; }

        /// <summary>
        /// Gets or Sets Lock
        /// </summary>
        [DataMember(Name="lock", EmitDefaultValue=true)]
        public SiteLockLifecycleItem Lock { get; set; }

        /// <summary>
        /// Gets or Sets Quota
        /// </summary>
        [DataMember(Name="quota", EmitDefaultValue=true)]
        public SiteQuotaLifecycleItem Quota { get; set; }

        /// <summary>
        /// Gets or Sets DefaultProcess
        /// </summary>
        [DataMember(Name="defaultProcess", EmitDefaultValue=true)]
        public GuidModel DefaultProcess { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SitePolicyLifecycleSetting {\n");
            sb.Append("  Archive: ").Append(Archive).Append("\n");
            sb.Append("  Deletion: ").Append(Deletion).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  ChangePolicy: ").Append(ChangePolicy).Append("\n");
            sb.Append("  Unlock: ").Append(Unlock).Append("\n");
            sb.Append("  Lock: ").Append(Lock).Append("\n");
            sb.Append("  Quota: ").Append(Quota).Append("\n");
            sb.Append("  DefaultProcess: ").Append(DefaultProcess).Append("\n");
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
            return this.Equals(input as SitePolicyLifecycleSetting);
        }

        /// <summary>
        /// Returns true if SitePolicyLifecycleSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of SitePolicyLifecycleSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SitePolicyLifecycleSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Archive == input.Archive ||
                    (this.Archive != null &&
                    this.Archive.Equals(input.Archive))
                ) && 
                (
                    this.Deletion == input.Deletion ||
                    (this.Deletion != null &&
                    this.Deletion.Equals(input.Deletion))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
                ) && 
                (
                    this.ChangePolicy == input.ChangePolicy ||
                    (this.ChangePolicy != null &&
                    this.ChangePolicy.Equals(input.ChangePolicy))
                ) && 
                (
                    this.Unlock == input.Unlock ||
                    (this.Unlock != null &&
                    this.Unlock.Equals(input.Unlock))
                ) && 
                (
                    this.Lock == input.Lock ||
                    (this.Lock != null &&
                    this.Lock.Equals(input.Lock))
                ) && 
                (
                    this.Quota == input.Quota ||
                    (this.Quota != null &&
                    this.Quota.Equals(input.Quota))
                ) && 
                (
                    this.DefaultProcess == input.DefaultProcess ||
                    (this.DefaultProcess != null &&
                    this.DefaultProcess.Equals(input.DefaultProcess))
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
                if (this.Archive != null)
                    hashCode = hashCode * 59 + this.Archive.GetHashCode();
                if (this.Deletion != null)
                    hashCode = hashCode * 59 + this.Deletion.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
                if (this.ChangePolicy != null)
                    hashCode = hashCode * 59 + this.ChangePolicy.GetHashCode();
                if (this.Unlock != null)
                    hashCode = hashCode * 59 + this.Unlock.GetHashCode();
                if (this.Lock != null)
                    hashCode = hashCode * 59 + this.Lock.GetHashCode();
                if (this.Quota != null)
                    hashCode = hashCode * 59 + this.Quota.GetHashCode();
                if (this.DefaultProcess != null)
                    hashCode = hashCode * 59 + this.DefaultProcess.GetHashCode();
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
