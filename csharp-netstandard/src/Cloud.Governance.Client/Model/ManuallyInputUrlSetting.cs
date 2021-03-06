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
    /// ManuallyInputUrlSetting
    /// </summary>
    [DataContract]
    public partial class ManuallyInputUrlSetting :  IEquatable<ManuallyInputUrlSetting>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ConstructUrlAssignBy
        /// </summary>
        [DataMember(Name="constructUrlAssignBy", EmitDefaultValue=false)]
        public AssignBy? ConstructUrlAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets ContructUrlAssignBy
        /// </summary>
        [DataMember(Name="contructUrlAssignBy", EmitDefaultValue=false)]
        public AssignBy? ContructUrlAssignBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManuallyInputUrlSetting" /> class.
        /// </summary>
        /// <param name="enableConstructUrl">enableConstructUrl.</param>
        /// <param name="enableUrlValidation">enableUrlValidation.</param>
        /// <param name="constructUrlAssignBy">constructUrlAssignBy.</param>
        /// <param name="validationRule">validationRule.</param>
        /// <param name="rules">rules.</param>
        /// <param name="suffix">suffix.</param>
        /// <param name="connection">connection.</param>
        /// <param name="contructUrlAssignBy">contructUrlAssignBy.</param>
        public ManuallyInputUrlSetting(bool enableConstructUrl = default(bool), bool enableUrlValidation = default(bool), AssignBy constructUrlAssignBy = default(AssignBy), TextValidationRuleRef validationRule = default(TextValidationRuleRef), List<string> rules = default(List<string>), string suffix = default(string), string connection = default(string), AssignBy contructUrlAssignBy = default(AssignBy))
        {
            this.EnableConstructUrl = enableConstructUrl;
            this.EnableUrlValidation = enableUrlValidation;
            this.ConstructUrlAssignBy = constructUrlAssignBy;
            this.ValidationRule = validationRule;
            this.Rules = rules;
            this.Suffix = suffix;
            this.Connection = connection;
            this.ContructUrlAssignBy = contructUrlAssignBy;
        }
        
        /// <summary>
        /// Gets or Sets EnableConstructUrl
        /// </summary>
        [DataMember(Name="enableConstructUrl", EmitDefaultValue=false)]
        public bool EnableConstructUrl { get; set; }

        /// <summary>
        /// Gets or Sets EnableUrlValidation
        /// </summary>
        [DataMember(Name="enableUrlValidation", EmitDefaultValue=false)]
        public bool EnableUrlValidation { get; set; }

        /// <summary>
        /// Gets or Sets ValidationRule
        /// </summary>
        [DataMember(Name="validationRule", EmitDefaultValue=true)]
        public TextValidationRuleRef ValidationRule { get; set; }

        /// <summary>
        /// Gets or Sets Rules
        /// </summary>
        [DataMember(Name="rules", EmitDefaultValue=true)]
        public List<string> Rules { get; set; }

        /// <summary>
        /// Gets or Sets Suffix
        /// </summary>
        [DataMember(Name="suffix", EmitDefaultValue=true)]
        public string Suffix { get; set; }

        /// <summary>
        /// Gets or Sets Connection
        /// </summary>
        [DataMember(Name="connection", EmitDefaultValue=true)]
        public string Connection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManuallyInputUrlSetting {\n");
            sb.Append("  EnableConstructUrl: ").Append(EnableConstructUrl).Append("\n");
            sb.Append("  EnableUrlValidation: ").Append(EnableUrlValidation).Append("\n");
            sb.Append("  ConstructUrlAssignBy: ").Append(ConstructUrlAssignBy).Append("\n");
            sb.Append("  ValidationRule: ").Append(ValidationRule).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  Connection: ").Append(Connection).Append("\n");
            sb.Append("  ContructUrlAssignBy: ").Append(ContructUrlAssignBy).Append("\n");
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
            return this.Equals(input as ManuallyInputUrlSetting);
        }

        /// <summary>
        /// Returns true if ManuallyInputUrlSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ManuallyInputUrlSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManuallyInputUrlSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableConstructUrl == input.EnableConstructUrl ||
                    this.EnableConstructUrl.Equals(input.EnableConstructUrl)
                ) && 
                (
                    this.EnableUrlValidation == input.EnableUrlValidation ||
                    this.EnableUrlValidation.Equals(input.EnableUrlValidation)
                ) && 
                (
                    this.ConstructUrlAssignBy == input.ConstructUrlAssignBy ||
                    this.ConstructUrlAssignBy.Equals(input.ConstructUrlAssignBy)
                ) && 
                (
                    this.ValidationRule == input.ValidationRule ||
                    (this.ValidationRule != null &&
                    this.ValidationRule.Equals(input.ValidationRule))
                ) && 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    input.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
                ) && 
                (
                    this.Connection == input.Connection ||
                    (this.Connection != null &&
                    this.Connection.Equals(input.Connection))
                ) && 
                (
                    this.ContructUrlAssignBy == input.ContructUrlAssignBy ||
                    this.ContructUrlAssignBy.Equals(input.ContructUrlAssignBy)
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
                hashCode = hashCode * 59 + this.EnableConstructUrl.GetHashCode();
                hashCode = hashCode * 59 + this.EnableUrlValidation.GetHashCode();
                hashCode = hashCode * 59 + this.ConstructUrlAssignBy.GetHashCode();
                if (this.ValidationRule != null)
                    hashCode = hashCode * 59 + this.ValidationRule.GetHashCode();
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                if (this.Connection != null)
                    hashCode = hashCode * 59 + this.Connection.GetHashCode();
                hashCode = hashCode * 59 + this.ContructUrlAssignBy.GetHashCode();
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
