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
    /// ChangeGroupSettingCheckResult
    /// </summary>
    [DataContract]
    public partial class ChangeGroupSettingCheckResult :  IEquatable<ChangeGroupSettingCheckResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeGroupSettingCheckResult" /> class.
        /// </summary>
        /// <param name="primaryContact">primaryContact.</param>
        /// <param name="secondaryContact">secondaryContact.</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="groupEmail">groupEmail.</param>
        /// <param name="groupDescription">groupDescription.</param>
        /// <param name="isEnableSubscribeMembers">isEnableSubscribeMembers.</param>
        /// <param name="isEnableOutsideSender">isEnableOutsideSender.</param>
        /// <param name="classification">classification.</param>
        /// <param name="isTeamsEnabled">isTeamsEnabled.</param>
        /// <param name="enableManageGroupSharing">enableManageGroupSharing.</param>
        /// <param name="enableInviteAuthorizedGuestUser">enableInviteAuthorizedGuestUser.</param>
        /// <param name="enableInviteGuestUser">enableInviteGuestUser.</param>
        /// <param name="enableDynamicMembership">enableDynamicMembership.</param>
        /// <param name="isHubSite">isHubSite.</param>
        /// <param name="associatedHubSiteId">associatedHubSiteId.</param>
        /// <param name="dynamicMembershipRules">dynamicMembershipRules.</param>
        /// <param name="metadatas">metadatas.</param>
        /// <param name="errorMessage">errorMessage.</param>
        public ChangeGroupSettingCheckResult(ApiUser primaryContact = default(ApiUser), ApiUser secondaryContact = default(ApiUser), string groupId = default(string), string groupName = default(string), string groupEmail = default(string), string groupDescription = default(string), bool isEnableSubscribeMembers = default(bool), bool isEnableOutsideSender = default(bool), string classification = default(string), bool isTeamsEnabled = default(bool), bool enableManageGroupSharing = default(bool), bool enableInviteAuthorizedGuestUser = default(bool), bool enableInviteGuestUser = default(bool), bool enableDynamicMembership = default(bool), bool isHubSite = default(bool), Guid? associatedHubSiteId = default(Guid?), List<DynamicGroupRuleInfo> dynamicMembershipRules = default(List<DynamicGroupRuleInfo>), List<CustomMetadata> metadatas = default(List<CustomMetadata>), string errorMessage = default(string))
        {
            this.PrimaryContact = primaryContact;
            this.SecondaryContact = secondaryContact;
            this.GroupId = groupId;
            this.GroupName = groupName;
            this.GroupEmail = groupEmail;
            this.GroupDescription = groupDescription;
            this.IsEnableSubscribeMembers = isEnableSubscribeMembers;
            this.IsEnableOutsideSender = isEnableOutsideSender;
            this.Classification = classification;
            this.IsTeamsEnabled = isTeamsEnabled;
            this.EnableManageGroupSharing = enableManageGroupSharing;
            this.EnableInviteAuthorizedGuestUser = enableInviteAuthorizedGuestUser;
            this.EnableInviteGuestUser = enableInviteGuestUser;
            this.EnableDynamicMembership = enableDynamicMembership;
            this.IsHubSite = isHubSite;
            this.AssociatedHubSiteId = associatedHubSiteId;
            this.DynamicMembershipRules = dynamicMembershipRules;
            this.Metadatas = metadatas;
            this.ErrorMessage = errorMessage;
        }
        
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
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name="groupId", EmitDefaultValue=true)]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name="groupName", EmitDefaultValue=true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or Sets GroupEmail
        /// </summary>
        [DataMember(Name="groupEmail", EmitDefaultValue=true)]
        public string GroupEmail { get; set; }

        /// <summary>
        /// Gets or Sets GroupDescription
        /// </summary>
        [DataMember(Name="groupDescription", EmitDefaultValue=true)]
        public string GroupDescription { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableSubscribeMembers
        /// </summary>
        [DataMember(Name="isEnableSubscribeMembers", EmitDefaultValue=false)]
        public bool IsEnableSubscribeMembers { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableOutsideSender
        /// </summary>
        [DataMember(Name="isEnableOutsideSender", EmitDefaultValue=false)]
        public bool IsEnableOutsideSender { get; set; }

        /// <summary>
        /// Gets or Sets Classification
        /// </summary>
        [DataMember(Name="classification", EmitDefaultValue=true)]
        public string Classification { get; set; }

        /// <summary>
        /// Gets or Sets IsTeamsEnabled
        /// </summary>
        [DataMember(Name="isTeamsEnabled", EmitDefaultValue=false)]
        public bool IsTeamsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets EnableManageGroupSharing
        /// </summary>
        [DataMember(Name="enableManageGroupSharing", EmitDefaultValue=false)]
        public bool EnableManageGroupSharing { get; set; }

        /// <summary>
        /// Gets or Sets EnableInviteAuthorizedGuestUser
        /// </summary>
        [DataMember(Name="enableInviteAuthorizedGuestUser", EmitDefaultValue=false)]
        public bool EnableInviteAuthorizedGuestUser { get; set; }

        /// <summary>
        /// Gets or Sets EnableInviteGuestUser
        /// </summary>
        [DataMember(Name="enableInviteGuestUser", EmitDefaultValue=false)]
        public bool EnableInviteGuestUser { get; set; }

        /// <summary>
        /// Gets or Sets EnableDynamicMembership
        /// </summary>
        [DataMember(Name="enableDynamicMembership", EmitDefaultValue=false)]
        public bool EnableDynamicMembership { get; set; }

        /// <summary>
        /// Gets or Sets IsHubSite
        /// </summary>
        [DataMember(Name="isHubSite", EmitDefaultValue=false)]
        public bool IsHubSite { get; set; }

        /// <summary>
        /// Gets or Sets AssociatedHubSiteId
        /// </summary>
        [DataMember(Name="associatedHubSiteId", EmitDefaultValue=true)]
        public Guid? AssociatedHubSiteId { get; set; }

        /// <summary>
        /// Gets or Sets DynamicMembershipRules
        /// </summary>
        [DataMember(Name="dynamicMembershipRules", EmitDefaultValue=true)]
        public List<DynamicGroupRuleInfo> DynamicMembershipRules { get; set; }

        /// <summary>
        /// Gets or Sets Metadatas
        /// </summary>
        [DataMember(Name="metadatas", EmitDefaultValue=true)]
        public List<CustomMetadata> Metadatas { get; set; }

        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name="isValid", EmitDefaultValue=false)]
        public bool IsValid { get; private set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeGroupSettingCheckResult {\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  GroupEmail: ").Append(GroupEmail).Append("\n");
            sb.Append("  GroupDescription: ").Append(GroupDescription).Append("\n");
            sb.Append("  IsEnableSubscribeMembers: ").Append(IsEnableSubscribeMembers).Append("\n");
            sb.Append("  IsEnableOutsideSender: ").Append(IsEnableOutsideSender).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  IsTeamsEnabled: ").Append(IsTeamsEnabled).Append("\n");
            sb.Append("  EnableManageGroupSharing: ").Append(EnableManageGroupSharing).Append("\n");
            sb.Append("  EnableInviteAuthorizedGuestUser: ").Append(EnableInviteAuthorizedGuestUser).Append("\n");
            sb.Append("  EnableInviteGuestUser: ").Append(EnableInviteGuestUser).Append("\n");
            sb.Append("  EnableDynamicMembership: ").Append(EnableDynamicMembership).Append("\n");
            sb.Append("  IsHubSite: ").Append(IsHubSite).Append("\n");
            sb.Append("  AssociatedHubSiteId: ").Append(AssociatedHubSiteId).Append("\n");
            sb.Append("  DynamicMembershipRules: ").Append(DynamicMembershipRules).Append("\n");
            sb.Append("  Metadatas: ").Append(Metadatas).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(input as ChangeGroupSettingCheckResult);
        }

        /// <summary>
        /// Returns true if ChangeGroupSettingCheckResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeGroupSettingCheckResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeGroupSettingCheckResult input)
        {
            if (input == null)
                return false;

            return 
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
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.GroupEmail == input.GroupEmail ||
                    (this.GroupEmail != null &&
                    this.GroupEmail.Equals(input.GroupEmail))
                ) && 
                (
                    this.GroupDescription == input.GroupDescription ||
                    (this.GroupDescription != null &&
                    this.GroupDescription.Equals(input.GroupDescription))
                ) && 
                (
                    this.IsEnableSubscribeMembers == input.IsEnableSubscribeMembers ||
                    this.IsEnableSubscribeMembers.Equals(input.IsEnableSubscribeMembers)
                ) && 
                (
                    this.IsEnableOutsideSender == input.IsEnableOutsideSender ||
                    this.IsEnableOutsideSender.Equals(input.IsEnableOutsideSender)
                ) && 
                (
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && 
                (
                    this.IsTeamsEnabled == input.IsTeamsEnabled ||
                    this.IsTeamsEnabled.Equals(input.IsTeamsEnabled)
                ) && 
                (
                    this.EnableManageGroupSharing == input.EnableManageGroupSharing ||
                    this.EnableManageGroupSharing.Equals(input.EnableManageGroupSharing)
                ) && 
                (
                    this.EnableInviteAuthorizedGuestUser == input.EnableInviteAuthorizedGuestUser ||
                    this.EnableInviteAuthorizedGuestUser.Equals(input.EnableInviteAuthorizedGuestUser)
                ) && 
                (
                    this.EnableInviteGuestUser == input.EnableInviteGuestUser ||
                    this.EnableInviteGuestUser.Equals(input.EnableInviteGuestUser)
                ) && 
                (
                    this.EnableDynamicMembership == input.EnableDynamicMembership ||
                    this.EnableDynamicMembership.Equals(input.EnableDynamicMembership)
                ) && 
                (
                    this.IsHubSite == input.IsHubSite ||
                    this.IsHubSite.Equals(input.IsHubSite)
                ) && 
                (
                    this.AssociatedHubSiteId == input.AssociatedHubSiteId ||
                    (this.AssociatedHubSiteId != null &&
                    this.AssociatedHubSiteId.Equals(input.AssociatedHubSiteId))
                ) && 
                (
                    this.DynamicMembershipRules == input.DynamicMembershipRules ||
                    this.DynamicMembershipRules != null &&
                    input.DynamicMembershipRules != null &&
                    this.DynamicMembershipRules.SequenceEqual(input.DynamicMembershipRules)
                ) && 
                (
                    this.Metadatas == input.Metadatas ||
                    this.Metadatas != null &&
                    input.Metadatas != null &&
                    this.Metadatas.SequenceEqual(input.Metadatas)
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    this.IsValid.Equals(input.IsValid)
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
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
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                if (this.SecondaryContact != null)
                    hashCode = hashCode * 59 + this.SecondaryContact.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.GroupEmail != null)
                    hashCode = hashCode * 59 + this.GroupEmail.GetHashCode();
                if (this.GroupDescription != null)
                    hashCode = hashCode * 59 + this.GroupDescription.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableSubscribeMembers.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableOutsideSender.GetHashCode();
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                hashCode = hashCode * 59 + this.IsTeamsEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.EnableManageGroupSharing.GetHashCode();
                hashCode = hashCode * 59 + this.EnableInviteAuthorizedGuestUser.GetHashCode();
                hashCode = hashCode * 59 + this.EnableInviteGuestUser.GetHashCode();
                hashCode = hashCode * 59 + this.EnableDynamicMembership.GetHashCode();
                hashCode = hashCode * 59 + this.IsHubSite.GetHashCode();
                if (this.AssociatedHubSiteId != null)
                    hashCode = hashCode * 59 + this.AssociatedHubSiteId.GetHashCode();
                if (this.DynamicMembershipRules != null)
                    hashCode = hashCode * 59 + this.DynamicMembershipRules.GetHashCode();
                if (this.Metadatas != null)
                    hashCode = hashCode * 59 + this.Metadatas.GetHashCode();
                hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
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
