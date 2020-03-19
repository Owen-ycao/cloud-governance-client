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
    /// AdminNotificationEscalationModel
    /// </summary>
    [DataContract]
    public partial class AdminNotificationEscalationModel :  IEquatable<AdminNotificationEscalationModel>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets IntervalType
        /// </summary>
        [DataMember(Name="intervalType", EmitDefaultValue=false)]
        public ApiDurationType? IntervalType { get; set; }
        /// <summary>
        /// Gets or Sets EscalationType
        /// </summary>
        [DataMember(Name="escalationType", EmitDefaultValue=false)]
        public ApiEscalationType? EscalationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminNotificationEscalationModel" /> class.
        /// </summary>
        /// <param name="isEnabled">isEnabled.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalType">intervalType.</param>
        /// <param name="reminderSetting">reminderSetting.</param>
        /// <param name="escalationType">escalationType.</param>
        /// <param name="escalationUser">escalationUser.</param>
        /// <param name="escalationEmailTemplate">escalationEmailTemplate.</param>
        public AdminNotificationEscalationModel(bool isEnabled = default(bool), int interval = default(int), ApiDurationType intervalType = default(ApiDurationType), GuidSettingModel reminderSetting = default(GuidSettingModel), ApiEscalationType escalationType = default(ApiEscalationType), ApiUser escalationUser = default(ApiUser), Guid escalationEmailTemplate = default(Guid))
        {
            this.IsEnabled = isEnabled;
            this.Interval = interval;
            this.IntervalType = intervalType;
            this.ReminderSetting = reminderSetting;
            this.EscalationType = escalationType;
            this.EscalationUser = escalationUser;
            this.EscalationEmailTemplate = escalationEmailTemplate;
        }
        
        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name="isEnabled", EmitDefaultValue=false)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public int Interval { get; set; }

        /// <summary>
        /// Gets or Sets ReminderSetting
        /// </summary>
        [DataMember(Name="reminderSetting", EmitDefaultValue=true)]
        public GuidSettingModel ReminderSetting { get; set; }

        /// <summary>
        /// Gets or Sets EscalationUser
        /// </summary>
        [DataMember(Name="escalationUser", EmitDefaultValue=true)]
        public ApiUser EscalationUser { get; set; }

        /// <summary>
        /// Gets or Sets EscalationEmailTemplate
        /// </summary>
        [DataMember(Name="escalationEmailTemplate", EmitDefaultValue=false)]
        public Guid EscalationEmailTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminNotificationEscalationModel {\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  IntervalType: ").Append(IntervalType).Append("\n");
            sb.Append("  ReminderSetting: ").Append(ReminderSetting).Append("\n");
            sb.Append("  EscalationType: ").Append(EscalationType).Append("\n");
            sb.Append("  EscalationUser: ").Append(EscalationUser).Append("\n");
            sb.Append("  EscalationEmailTemplate: ").Append(EscalationEmailTemplate).Append("\n");
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
            return this.Equals(input as AdminNotificationEscalationModel);
        }

        /// <summary>
        /// Returns true if AdminNotificationEscalationModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AdminNotificationEscalationModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdminNotificationEscalationModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.Interval == input.Interval ||
                    this.Interval.Equals(input.Interval)
                ) && 
                (
                    this.IntervalType == input.IntervalType ||
                    this.IntervalType.Equals(input.IntervalType)
                ) && 
                (
                    this.ReminderSetting == input.ReminderSetting ||
                    (this.ReminderSetting != null &&
                    this.ReminderSetting.Equals(input.ReminderSetting))
                ) && 
                (
                    this.EscalationType == input.EscalationType ||
                    this.EscalationType.Equals(input.EscalationType)
                ) && 
                (
                    this.EscalationUser == input.EscalationUser ||
                    (this.EscalationUser != null &&
                    this.EscalationUser.Equals(input.EscalationUser))
                ) && 
                (
                    this.EscalationEmailTemplate == input.EscalationEmailTemplate ||
                    (this.EscalationEmailTemplate != null &&
                    this.EscalationEmailTemplate.Equals(input.EscalationEmailTemplate))
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
                hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.Interval.GetHashCode();
                hashCode = hashCode * 59 + this.IntervalType.GetHashCode();
                if (this.ReminderSetting != null)
                    hashCode = hashCode * 59 + this.ReminderSetting.GetHashCode();
                hashCode = hashCode * 59 + this.EscalationType.GetHashCode();
                if (this.EscalationUser != null)
                    hashCode = hashCode * 59 + this.EscalationUser.GetHashCode();
                if (this.EscalationEmailTemplate != null)
                    hashCode = hashCode * 59 + this.EscalationEmailTemplate.GetHashCode();
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
            // Interval (int) maximum
            if(this.Interval > (int)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Interval, must be a value less than or equal to 2147483647.", new [] { "Interval" });
            }

            // Interval (int) minimum
            if(this.Interval < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Interval, must be a value greater than or equal to 0.", new [] { "Interval" });
            }

            yield break;
        }
    }

}