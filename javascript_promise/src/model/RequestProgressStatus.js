/**
 * Cloud Governance Api
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 *
 * OpenAPI Generator version: 4.2.2
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.RequestProgressStatus = factory(root.CgClient.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';


  /**
   * Enum class RequestProgressStatus.
   * @enum {}
   * @readonly
   */
  var exports = {
    /**
     * value: "None"
     * @const
     */
    "None": "None",
    /**
     * value: "ErrorStart"
     * @const
     */
    "ErrorStart": "ErrorStart",
    /**
     * value: "Error"
     * @const
     */
    "Error": "Error",
    /**
     * value: "RequestSubmitted"
     * @const
     */
    "RequestSubmitted": "RequestSubmitted",
    /**
     * value: "TaskCreated"
     * @const
     */
    "TaskCreated": "TaskCreated",
    /**
     * value: "AdminContactIssueReview"
     * @const
     */
    "AdminContactIssueReview": "AdminContactIssueReview",
    /**
     * value: "Cancelled"
     * @const
     */
    "Cancelled": "Cancelled",
    /**
     * value: "Rejected"
     * @const
     */
    "Rejected": "Rejected",
    /**
     * value: "FirstStageApproval"
     * @const
     */
    "FirstStageApproval": "FirstStageApproval",
    /**
     * value: "SecondStageApproval"
     * @const
     */
    "SecondStageApproval": "SecondStageApproval",
    /**
     * value: "ThirdStageApproval"
     * @const
     */
    "ThirdStageApproval": "ThirdStageApproval",
    /**
     * value: "Completed"
     * @const
     */
    "Completed": "Completed",
    /**
     * value: "AssignContentDatabase"
     * @const
     */
    "AssignContentDatabase": "AssignContentDatabase",
    /**
     * value: "CreateSiteCollection"
     * @const
     */
    "CreateSiteCollection": "CreateSiteCollection",
    /**
     * value: "ApplySecuritySettings"
     * @const
     */
    "ApplySecuritySettings": "ApplySecuritySettings",
    /**
     * value: "ApplySharePointConfigurations"
     * @const
     */
    "ApplySharePointConfigurations": "ApplySharePointConfigurations",
    /**
     * value: "ApplyCustomMetadata"
     * @const
     */
    "ApplyCustomMetadata": "ApplyCustomMetadata",
    /**
     * value: "AddToSiteCollectionDirectory"
     * @const
     */
    "AddToSiteCollectionDirectory": "AddToSiteCollectionDirectory",
    /**
     * value: "ApplyDocAveGranularBackupPlan"
     * @const
     */
    "ApplyDocAveGranularBackupPlan": "ApplyDocAveGranularBackupPlan",
    /**
     * value: "ApplyDocAveAuditorPlan"
     * @const
     */
    "ApplyDocAveAuditorPlan": "ApplyDocAveAuditorPlan",
    /**
     * value: "ApplyDocAveDeadAccountCleaningPlan"
     * @const
     */
    "ApplyDocAveDeadAccountCleaningPlan": "ApplyDocAveDeadAccountCleaningPlan",
    /**
     * value: "ApplyDocAveScheduledStorageManagerProfile"
     * @const
     */
    "ApplyDocAveScheduledStorageManagerProfile": "ApplyDocAveScheduledStorageManagerProfile",
    /**
     * value: "ApplyDocAveArchiverProfile"
     * @const
     */
    "ApplyDocAveArchiverProfile": "ApplyDocAveArchiverProfile",
    /**
     * value: "ApplyDocAveVaultProfile"
     * @const
     */
    "ApplyDocAveVaultProfile": "ApplyDocAveVaultProfile",
    /**
     * value: "ApplyAndRunDPMPlan"
     * @const
     */
    "ApplyAndRunDPMPlan": "ApplyAndRunDPMPlan",
    /**
     * value: "ApplyPolicyEnforcerProfile"
     * @const
     */
    "ApplyPolicyEnforcerProfile": "ApplyPolicyEnforcerProfile",
    /**
     * value: "ApplyAdditionalAdministrators"
     * @const
     */
    "ApplyAdditionalAdministrators": "ApplyAdditionalAdministrators",
    /**
     * value: "CreateOrValidYammerGroup"
     * @const
     */
    "CreateOrValidYammerGroup": "CreateOrValidYammerGroup",
    /**
     * value: "AddYammerGroupFeed"
     * @const
     */
    "AddYammerGroupFeed": "AddYammerGroupFeed",
    /**
     * value: "ArchiveSiteCollection"
     * @const
     */
    "ArchiveSiteCollection": "ArchiveSiteCollection",
    /**
     * value: "UpdateSiteCollectionArchived"
     * @const
     */
    "UpdateSiteCollectionArchived": "UpdateSiteCollectionArchived",
    /**
     * value: "ExtendSiteCollection"
     * @const
     */
    "ExtendSiteCollection": "ExtendSiteCollection",
    /**
     * value: "UpdateCustomMetadata"
     * @const
     */
    "UpdateCustomMetadata": "UpdateCustomMetadata",
    /**
     * value: "UpdateSiteDirectory"
     * @const
     */
    "UpdateSiteDirectory": "UpdateSiteDirectory",
    /**
     * value: "DeleteSiteCollection"
     * @const
     */
    "DeleteSiteCollection": "DeleteSiteCollection",
    /**
     * value: "UpdateSiteCollectionDeleted"
     * @const
     */
    "UpdateSiteCollectionDeleted": "UpdateSiteCollectionDeleted",
    /**
     * value: "CreateSubSite"
     * @const
     */
    "CreateSubSite": "CreateSubSite",
    /**
     * value: "AddToSubSiteDirectory"
     * @const
     */
    "AddToSubSiteDirectory": "AddToSubSiteDirectory",
    /**
     * value: "RetractDocAveGranularBackupPlan"
     * @const
     */
    "RetractDocAveGranularBackupPlan": "RetractDocAveGranularBackupPlan",
    /**
     * value: "RetractDocAveAuditorPlan"
     * @const
     */
    "RetractDocAveAuditorPlan": "RetractDocAveAuditorPlan",
    /**
     * value: "RetractDocAveDeadAccountCleaningPlan"
     * @const
     */
    "RetractDocAveDeadAccountCleaningPlan": "RetractDocAveDeadAccountCleaningPlan",
    /**
     * value: "RetractDocAveScheduledStorageManagerProfile"
     * @const
     */
    "RetractDocAveScheduledStorageManagerProfile": "RetractDocAveScheduledStorageManagerProfile",
    /**
     * value: "RetrieveDocAveArchiveProfile"
     * @const
     */
    "RetrieveDocAveArchiveProfile": "RetrieveDocAveArchiveProfile",
    /**
     * value: "RetrieveDocAveVaultProfile"
     * @const
     */
    "RetrieveDocAveVaultProfile": "RetrieveDocAveVaultProfile",
    /**
     * value: "UpdateChangeSCPolicyMetadata"
     * @const
     */
    "UpdateChangeSCPolicyMetadata": "UpdateChangeSCPolicyMetadata",
    /**
     * value: "UpdateSiteCollectionPolicyChanged"
     * @const
     */
    "UpdateSiteCollectionPolicyChanged": "UpdateSiteCollectionPolicyChanged",
    /**
     * value: "UpdatePolicyEnforcerProfileCompleted"
     * @const
     */
    "UpdatePolicyEnforcerProfileCompleted": "UpdatePolicyEnforcerProfileCompleted",
    /**
     * value: "CreateHiddenList"
     * @const
     */
    "CreateHiddenList": "CreateHiddenList",
    /**
     * value: "ChangeSiteCollectionMetadata"
     * @const
     */
    "ChangeSiteCollectionMetadata": "ChangeSiteCollectionMetadata",
    /**
     * value: "UpdateSiteDirectoryForChangeSCMetadata"
     * @const
     */
    "UpdateSiteDirectoryForChangeSCMetadata": "UpdateSiteDirectoryForChangeSCMetadata",
    /**
     * value: "ChangeSiteCollectionContact"
     * @const
     */
    "ChangeSiteCollectionContact": "ChangeSiteCollectionContact",
    /**
     * value: "ChangeSiteCollectionOwner"
     * @const
     */
    "ChangeSiteCollectionOwner": "ChangeSiteCollectionOwner",
    /**
     * value: "ChangeSiteCollectionAdditionalAdmin"
     * @const
     */
    "ChangeSiteCollectionAdditionalAdmin": "ChangeSiteCollectionAdditionalAdmin",
    /**
     * value: "UpdateSiteDirectoryForChangeSCContact"
     * @const
     */
    "UpdateSiteDirectoryForChangeSCContact": "UpdateSiteDirectoryForChangeSCContact",
    /**
     * value: "CloneUserPermission"
     * @const
     */
    "CloneUserPermission": "CloneUserPermission",
    /**
     * value: "SearchUserPermission"
     * @const
     */
    "SearchUserPermission": "SearchUserPermission",
    /**
     * value: "InProgress"
     * @const
     */
    "InProgress": "InProgress",
    /**
     * value: "CompletedWithException"
     * @const
     */
    "CompletedWithException": "CompletedWithException",
    /**
     * value: "DeleteSubSite"
     * @const
     */
    "DeleteSubSite": "DeleteSubSite",
    /**
     * value: "UpdateDeleteSubSite"
     * @const
     */
    "UpdateDeleteSubSite": "UpdateDeleteSubSite",
    /**
     * value: "ArchiveSubSite"
     * @const
     */
    "ArchiveSubSite": "ArchiveSubSite",
    /**
     * value: "UpdateArchiveSubSite"
     * @const
     */
    "UpdateArchiveSubSite": "UpdateArchiveSubSite",
    /**
     * value: "ChangeSubSiteMetadata"
     * @const
     */
    "ChangeSubSiteMetadata": "ChangeSubSiteMetadata",
    /**
     * value: "UpdateSiteDirectoryForChangeSSMetadata"
     * @const
     */
    "UpdateSiteDirectoryForChangeSSMetadata": "UpdateSiteDirectoryForChangeSSMetadata",
    /**
     * value: "FirstTaskCreated"
     * @const
     */
    "FirstTaskCreated": "FirstTaskCreated",
    /**
     * value: "SecondTaskCreated"
     * @const
     */
    "SecondTaskCreated": "SecondTaskCreated",
    /**
     * value: "ThirdTaskCreated"
     * @const
     */
    "ThirdTaskCreated": "ThirdTaskCreated",
    /**
     * value: "GrantUserPermission"
     * @const
     */
    "GrantUserPermission": "GrantUserPermission",
    /**
     * value: "RemoveUserPermission"
     * @const
     */
    "RemoveUserPermission": "RemoveUserPermission",
    /**
     * value: "ChangeSCSettingsTitleDes"
     * @const
     */
    "ChangeSCSettingsTitleDes": "ChangeSCSettingsTitleDes",
    /**
     * value: "CreateMySiteCompleted"
     * @const
     */
    "CreateMySiteCompleted": "CreateMySiteCompleted",
    /**
     * value: "CreateCMPlan"
     * @const
     */
    "CreateCMPlan": "CreateCMPlan",
    /**
     * value: "RunCMPlan"
     * @const
     */
    "RunCMPlan": "RunCMPlan",
    /**
     * value: "CreateListCompleted"
     * @const
     */
    "CreateListCompleted": "CreateListCompleted",
    /**
     * value: "ChangeListURL"
     * @const
     */
    "ChangeListURL": "ChangeListURL",
    /**
     * value: "ChangeListSettingsCompleted"
     * @const
     */
    "ChangeListSettingsCompleted": "ChangeListSettingsCompleted",
    /**
     * value: "RegistSiteCollectionToDcoAveGroup"
     * @const
     */
    "RegistSiteCollectionToDcoAveGroup": "RegistSiteCollectionToDcoAveGroup",
    /**
     * value: "PermissionRecertificationTriggered"
     * @const
     */
    "PermissionRecertificationTriggered": "PermissionRecertificationTriggered",
    /**
     * value: "ChangingUserPermission"
     * @const
     */
    "ChangingUserPermission": "ChangingUserPermission",
    /**
     * value: "RequesterReportCreated"
     * @const
     */
    "RequesterReportCreated": "RequesterReportCreated",
    /**
     * value: "ApplyDeployAppPart"
     * @const
     */
    "ApplyDeployAppPart": "ApplyDeployAppPart",
    /**
     * value: "ApplyAddAppPart"
     * @const
     */
    "ApplyAddAppPart": "ApplyAddAppPart",
    /**
     * value: "ApplyingDeploymentManagerPlan"
     * @const
     */
    "ApplyingDeploymentManagerPlan": "ApplyingDeploymentManagerPlan",
    /**
     * value: "ApplyPermissionRecertification"
     * @const
     */
    "ApplyPermissionRecertification": "ApplyPermissionRecertification",
    /**
     * value: "ApplyMetadataRecertification"
     * @const
     */
    "ApplyMetadataRecertification": "ApplyMetadataRecertification",
    /**
     * value: "ApplyOwnershipRecertification"
     * @const
     */
    "ApplyOwnershipRecertification": "ApplyOwnershipRecertification",
    /**
     * value: "UnlockSiteCollection"
     * @const
     */
    "UnlockSiteCollection": "UnlockSiteCollection",
    /**
     * value: "UpdateSiteCollectionUnlocked"
     * @const
     */
    "UpdateSiteCollectionUnlocked": "UpdateSiteCollectionUnlocked",
    /**
     * value: "ApplyArchiverProfile"
     * @const
     */
    "ApplyArchiverProfile": "ApplyArchiverProfile",
    /**
     * value: "CancelAutoTask"
     * @const
     */
    "CancelAutoTask": "CancelAutoTask",
    /**
     * value: "ContinueAccess"
     * @const
     */
    "ContinueAccess": "ContinueAccess",
    /**
     * value: "ChangeSSSettingsTitleDes"
     * @const
     */
    "ChangeSSSettingsTitleDes": "ChangeSSSettingsTitleDes",
    /**
     * value: "FailedToSubmit"
     * @const
     */
    "FailedToSubmit": "FailedToSubmit",
    /**
     * value: "WaitingForSubmission"
     * @const
     */
    "WaitingForSubmission": "WaitingForSubmission",
    /**
     * value: "AllApprovalStageComplete"
     * @const
     */
    "AllApprovalStageComplete": "AllApprovalStageComplete",
    /**
     * value: "LockSiteCollection"
     * @const
     */
    "LockSiteCollection": "LockSiteCollection",
    /**
     * value: "UpdateSiteCollectionLocked"
     * @const
     */
    "UpdateSiteCollectionLocked": "UpdateSiteCollectionLocked",
    /**
     * value: "ChangeSiteCollectionQuota"
     * @const
     */
    "ChangeSiteCollectionQuota": "ChangeSiteCollectionQuota",
    /**
     * value: "UpdateSiteCollectionChangedQuota"
     * @const
     */
    "UpdateSiteCollectionChangedQuota": "UpdateSiteCollectionChangedQuota",
    /**
     * value: "CallCustomActionBeforeApproval"
     * @const
     */
    "CallCustomActionBeforeApproval": "CallCustomActionBeforeApproval",
    /**
     * value: "MaintanceWindow"
     * @const
     */
    "MaintanceWindow": "MaintanceWindow",
    /**
     * value: "CreateUser"
     * @const
     */
    "CreateUser": "CreateUser",
    /**
     * value: "AssignManager"
     * @const
     */
    "AssignManager": "AssignManager",
    /**
     * value: "AssignLicense"
     * @const
     */
    "AssignLicense": "AssignLicense",
    /**
     * value: "AddUserToGroups"
     * @const
     */
    "AddUserToGroups": "AddUserToGroups",
    /**
     * value: "RemoveUserFromGroups"
     * @const
     */
    "RemoveUserFromGroups": "RemoveUserFromGroups",
    /**
     * value: "AddUserReport"
     * @const
     */
    "AddUserReport": "AddUserReport",
    /**
     * value: "ApplyUserPolicy"
     * @const
     */
    "ApplyUserPolicy": "ApplyUserPolicy",
    /**
     * value: "ApplyOneDriveSiteProperties"
     * @const
     */
    "ApplyOneDriveSiteProperties": "ApplyOneDriveSiteProperties",
    /**
     * value: "ChangeUser"
     * @const
     */
    "ChangeUser": "ChangeUser",
    /**
     * value: "ChangeUserContact"
     * @const
     */
    "ChangeUserContact": "ChangeUserContact",
    /**
     * value: "ChangeUserLicense"
     * @const
     */
    "ChangeUserLicense": "ChangeUserLicense",
    /**
     * value: "ChangeUserManager"
     * @const
     */
    "ChangeUserManager": "ChangeUserManager",
    /**
     * value: "ChangeUserGroups"
     * @const
     */
    "ChangeUserGroups": "ChangeUserGroups",
    /**
     * value: "UpdateUserReport"
     * @const
     */
    "UpdateUserReport": "UpdateUserReport",
    /**
     * value: "ApplyUserRole"
     * @const
     */
    "ApplyUserRole": "ApplyUserRole",
    /**
     * value: "DeleteUser"
     * @const
     */
    "DeleteUser": "DeleteUser",
    /**
     * value: "BlockUser"
     * @const
     */
    "BlockUser": "BlockUser",
    /**
     * value: "ResetPassword"
     * @const
     */
    "ResetPassword": "ResetPassword",
    /**
     * value: "ExtendUser"
     * @const
     */
    "ExtendUser": "ExtendUser",
    /**
     * value: "ChangeUserPolicy"
     * @const
     */
    "ChangeUserPolicy": "ChangeUserPolicy",
    /**
     * value: "UnblockUser"
     * @const
     */
    "UnblockUser": "UnblockUser",
    /**
     * value: "ChangeGroup"
     * @const
     */
    "ChangeGroup": "ChangeGroup",
    /**
     * value: "UpdateGroupReport"
     * @const
     */
    "UpdateGroupReport": "UpdateGroupReport",
    /**
     * value: "AddOwnersToGroup"
     * @const
     */
    "AddOwnersToGroup": "AddOwnersToGroup",
    /**
     * value: "AddMembersToGroup"
     * @const
     */
    "AddMembersToGroup": "AddMembersToGroup",
    /**
     * value: "RemoveOwnersFromGroup"
     * @const
     */
    "RemoveOwnersFromGroup": "RemoveOwnersFromGroup",
    /**
     * value: "RemoveMembersFromGroup"
     * @const
     */
    "RemoveMembersFromGroup": "RemoveMembersFromGroup",
    /**
     * value: "UpdateMetadatasToSite"
     * @const
     */
    "UpdateMetadatasToSite": "UpdateMetadatasToSite",
    /**
     * value: "ChangeDynamicGroupRules"
     * @const
     */
    "ChangeDynamicGroupRules": "ChangeDynamicGroupRules",
    /**
     * value: "CreateGroup"
     * @const
     */
    "CreateGroup": "CreateGroup",
    /**
     * value: "UpdateGroup"
     * @const
     */
    "UpdateGroup": "UpdateGroup",
    /**
     * value: "SetGroupOwners"
     * @const
     */
    "SetGroupOwners": "SetGroupOwners",
    /**
     * value: "SetGroupMembers"
     * @const
     */
    "SetGroupMembers": "SetGroupMembers",
    /**
     * value: "SetGroupQuota"
     * @const
     */
    "SetGroupQuota": "SetGroupQuota",
    /**
     * value: "AddGroupReport"
     * @const
     */
    "AddGroupReport": "AddGroupReport",
    /**
     * value: "ApplyGroupPolicy"
     * @const
     */
    "ApplyGroupPolicy": "ApplyGroupPolicy",
    /**
     * value: "EnableTeamCollaboration"
     * @const
     */
    "EnableTeamCollaboration": "EnableTeamCollaboration",
    /**
     * value: "ApplySiteDesign"
     * @const
     */
    "ApplySiteDesign": "ApplySiteDesign",
    /**
     * value: "ApplyGroupCustomMetadata"
     * @const
     */
    "ApplyGroupCustomMetadata": "ApplyGroupCustomMetadata",
    /**
     * value: "DeleteGroup"
     * @const
     */
    "DeleteGroup": "DeleteGroup",
    /**
     * value: "ChangeGroupPolicy"
     * @const
     */
    "ChangeGroupPolicy": "ChangeGroupPolicy",
    /**
     * value: "ExtendGroup"
     * @const
     */
    "ExtendGroup": "ExtendGroup",
    /**
     * value: "UpdateGroupStatus"
     * @const
     */
    "UpdateGroupStatus": "UpdateGroupStatus",
    /**
     * value: "InstallApp"
     * @const
     */
    "InstallApp": "InstallApp",
    /**
     * value: "ArchiveTeam"
     * @const
     */
    "ArchiveTeam": "ArchiveTeam",
    /**
     * value: "UnArchiveTeam"
     * @const
     */
    "UnArchiveTeam": "UnArchiveTeam",
    /**
     * value: "GetGroup"
     * @const
     */
    "GetGroup": "GetGroup",
    /**
     * value: "RegisterSiteDocave"
     * @const
     */
    "RegisterSiteDocave": "RegisterSiteDocave",
    /**
     * value: "GetGroupSite"
     * @const
     */
    "GetGroupSite": "GetGroupSite",
    /**
     * value: "ChangeGroupQuota"
     * @const
     */
    "ChangeGroupQuota": "ChangeGroupQuota",
    /**
     * value: "CreatingSite"
     * @const
     */
    "CreatingSite": "CreatingSite",
    /**
     * value: "ApplyingCustomTemplate"
     * @const
     */
    "ApplyingCustomTemplate": "ApplyingCustomTemplate",
    /**
     * value: "ApplyingSecuritySettings"
     * @const
     */
    "ApplyingSecuritySettings": "ApplyingSecuritySettings",
    /**
     * value: "ApplyingCustomMetadata"
     * @const
     */
    "ApplyingCustomMetadata": "ApplyingCustomMetadata",
    /**
     * value: "ApplyingSitePolicy"
     * @const
     */
    "ApplyingSitePolicy": "ApplyingSitePolicy",
    /**
     * value: "ApplyingAdditionalAdministrators"
     * @const
     */
    "ApplyingAdditionalAdministrators": "ApplyingAdditionalAdministrators",
    /**
     * value: "AddingToSiteDirectory"
     * @const
     */
    "AddingToSiteDirectory": "AddingToSiteDirectory",
    /**
     * value: "RegistingSiteToDao"
     * @const
     */
    "RegistingSiteToDao": "RegistingSiteToDao",
    /**
     * value: "ApplyingServiceDpmPlan"
     * @const
     */
    "ApplyingServiceDpmPlan": "ApplyingServiceDpmPlan",
    /**
     * value: "ServiceDpmPlanExecuted"
     * @const
     */
    "ServiceDpmPlanExecuted": "ServiceDpmPlanExecuted",
    /**
     * value: "ApplyingPolicyDpmPlan"
     * @const
     */
    "ApplyingPolicyDpmPlan": "ApplyingPolicyDpmPlan",
    /**
     * value: "PolicyDpmPlanExecuted"
     * @const
     */
    "PolicyDpmPlanExecuted": "PolicyDpmPlanExecuted",
    /**
     * value: "ApplyingPolicyEnforcerProfile"
     * @const
     */
    "ApplyingPolicyEnforcerProfile": "ApplyingPolicyEnforcerProfile",
    /**
     * value: "ApplyingArchiverProfile"
     * @const
     */
    "ApplyingArchiverProfile": "ApplyingArchiverProfile",
    /**
     * value: "ApplyingRecertification"
     * @const
     */
    "ApplyingRecertification": "ApplyingRecertification",
    /**
     * value: "InstallingApp"
     * @const
     */
    "InstallingApp": "InstallingApp",
    /**
     * value: "AddingAppParts"
     * @const
     */
    "AddingAppParts": "AddingAppParts",
    /**
     * value: "CreatingOrValidYammerGroup"
     * @const
     */
    "CreatingOrValidYammerGroup": "CreatingOrValidYammerGroup",
    /**
     * value: "AddingYammerGroupFeed"
     * @const
     */
    "AddingYammerGroupFeed": "AddingYammerGroupFeed",
    /**
     * value: "RemovingServiceAccount"
     * @const
     */
    "RemovingServiceAccount": "RemovingServiceAccount",
    /**
     * value: "CreatingWeb"
     * @const
     */
    "CreatingWeb": "CreatingWeb",
    /**
     * value: "ApplyingSecuritySettingsToWeb"
     * @const
     */
    "ApplyingSecuritySettingsToWeb": "ApplyingSecuritySettingsToWeb",
    /**
     * value: "ApplyingSharePointConfigurationsToWeb"
     * @const
     */
    "ApplyingSharePointConfigurationsToWeb": "ApplyingSharePointConfigurationsToWeb",
    /**
     * value: "ApplyingCustomMetadataToWeb"
     * @const
     */
    "ApplyingCustomMetadataToWeb": "ApplyingCustomMetadataToWeb",
    /**
     * value: "ApplyAndRunDPMPlanInCreatingWeb"
     * @const
     */
    "ApplyAndRunDPMPlanInCreatingWeb": "ApplyAndRunDPMPlanInCreatingWeb",
    /**
     * value: "AddingWebToDatabase"
     * @const
     */
    "AddingWebToDatabase": "AddingWebToDatabase",
    /**
     * value: "UpdatingWebInDatabase"
     * @const
     */
    "UpdatingWebInDatabase": "UpdatingWebInDatabase",
    /**
     * value: "DeployingAppPartToWeb"
     * @const
     */
    "DeployingAppPartToWeb": "DeployingAppPartToWeb",
    /**
     * value: "AddingAppPartToWeb"
     * @const
     */
    "AddingAppPartToWeb": "AddingAppPartToWeb",
    /**
     * value: "CreatingOrValidingYammerGroupInCreatingWeb"
     * @const
     */
    "CreatingOrValidingYammerGroupInCreatingWeb": "CreatingOrValidingYammerGroupInCreatingWeb",
    /**
     * value: "AddingYammerGroupFeedInWeb"
     * @const
     */
    "AddingYammerGroupFeedInWeb": "AddingYammerGroupFeedInWeb",
    /**
     * value: "DeletingSite"
     * @const
     */
    "DeletingSite": "DeletingSite",
    /**
     * value: "ArchivingSite"
     * @const
     */
    "ArchivingSite": "ArchivingSite",
    /**
     * value: "ChangingSitePolicy"
     * @const
     */
    "ChangingSitePolicy": "ChangingSitePolicy",
    /**
     * value: "UnlockingSite"
     * @const
     */
    "UnlockingSite": "UnlockingSite",
    /**
     * value: "LockingSite"
     * @const
     */
    "LockingSite": "LockingSite",
    /**
     * value: "ExtendingSite"
     * @const
     */
    "ExtendingSite": "ExtendingSite",
    /**
     * value: "ChangingSiteQuota"
     * @const
     */
    "ChangingSiteQuota": "ChangingSiteQuota",
    /**
     * value: "ChangingListSetting"
     * @const
     */
    "ChangingListSetting": "ChangingListSetting",
    /**
     * value: "ChangingSiteTitleAndDescription"
     * @const
     */
    "ChangingSiteTitleAndDescription": "ChangingSiteTitleAndDescription",
    /**
     * value: "ChangingSiteMetadata"
     * @const
     */
    "ChangingSiteMetadata": "ChangingSiteMetadata",
    /**
     * value: "UpdatingSiteDirectory"
     * @const
     */
    "UpdatingSiteDirectory": "UpdatingSiteDirectory",
    /**
     * value: "ConvertingToHubSite"
     * @const
     */
    "ConvertingToHubSite": "ConvertingToHubSite",
    /**
     * value: "ConnectingToHubSite"
     * @const
     */
    "ConnectingToHubSite": "ConnectingToHubSite",
    /**
     * value: "UnregisteringHubSite"
     * @const
     */
    "UnregisteringHubSite": "UnregisteringHubSite",
    /**
     * value: "ChangingWebTitleAndDescription"
     * @const
     */
    "ChangingWebTitleAndDescription": "ChangingWebTitleAndDescription",
    /**
     * value: "CheckingList"
     * @const
     */
    "CheckingList": "CheckingList",
    /**
     * value: "UploadingTemplate"
     * @const
     */
    "UploadingTemplate": "UploadingTemplate",
    /**
     * value: "CreatingList"
     * @const
     */
    "CreatingList": "CreatingList",
    /**
     * value: "WaitingForGrantPermission"
     * @const
     */
    "WaitingForGrantPermission": "WaitingForGrantPermission",
    /**
     * value: "GrantingPermission"
     * @const
     */
    "GrantingPermission": "GrantingPermission",
    /**
     * value: "CreatingCMPlan"
     * @const
     */
    "CreatingCMPlan": "CreatingCMPlan",
    /**
     * value: "RunningCMPlan"
     * @const
     */
    "RunningCMPlan": "RunningCMPlan",
    /**
     * value: "SettingGroupSharing"
     * @const
     */
    "SettingGroupSharing": "SettingGroupSharing",
    /**
     * value: "SettingOutlookExperience"
     * @const
     */
    "SettingOutlookExperience": "SettingOutlookExperience",
    /**
     * value: "StartingProcess"
     * @const
     */
    "StartingProcess": "StartingProcess"  };

  /**
   * Returns a <code>RequestProgressStatus</code> enum value from a Javascript object name.
   * @param {Object} data The plain JavaScript object containing the name of the enum value.
   * @return {module:model/RequestProgressStatus} The enum <code>RequestProgressStatus</code> value.
   */
  exports.constructFromObject = function(object) {
    return object;
  }

  return exports;
}));


