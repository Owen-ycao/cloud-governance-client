#
# Cloud Governance Api
# No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
# Version: 1.0
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

<#
.SYNOPSIS

No summary available.

.DESCRIPTION

No description available.

.PARAMETER TenantId
No description available.

.PARAMETER EnableTeams
No description available.

.PARAMETER IsPrivate
No description available.

.PARAMETER EnableSubscribe
No description available.

.PARAMETER EnableApplySiteDesign
No description available.

.PARAMETER EnableOutsideSender
No description available.

.PARAMETER EnableHideGroupMembership
No description available.

.PARAMETER EnableClassification
No description available.

.PARAMETER AllowConfigureLeasePeriod
No description available.

.PARAMETER ShowNotebookLink
No description available.

.PARAMETER ShowConversationsLink
No description available.

.PARAMETER ShowFilesLink
No description available.

.PARAMETER ShowTeamSiteLink
No description available.

.PARAMETER ShowPlannerLink
No description available.

.PARAMETER Classifications
No description available.

.PARAMETER SiteDesigns
No description available.

.PARAMETER AddGroupMemberType
No description available.

.PARAMETER SelectedPolicies
No description available.

.PARAMETER SelectedLanguages
No description available.

.PARAMETER TeamsSettings
No description available.

.PARAMETER GroupNameConstructureSettings
No description available.

.PARAMETER GroupIdConstructureSettings
No description available.

.PARAMETER EnableInstallApp
No description available.

.PARAMETER EnableInstallPanel
No description available.

.PARAMETER TemplateSettings
No description available.

.PARAMETER DefaultPrimaryContact
No description available.

.PARAMETER DefaultSecondaryContact
No description available.

.PARAMETER DefaultOwners
No description available.

.PARAMETER DefaultMembers
No description available.

.PARAMETER DefaultPolicy
No description available.

.PARAMETER DefaultClassification
No description available.

.PARAMETER DefaultLanguage
No description available.

.PARAMETER DefaultSiteDesign
No description available.

.PARAMETER DefaultOwnersReal
No description available.

.PARAMETER DefaultMembersReal
No description available.

.PARAMETER MemberAssignBy
No description available.

.PARAMETER OwnerAssignBy
No description available.

.PARAMETER PrivacyAssignBy
No description available.

.PARAMETER SubscribeAssignBy
No description available.

.PARAMETER OutsideSenderAssignBy
No description available.

.PARAMETER ClassificationAssignBy
No description available.

.PARAMETER LanguageAssignBy
No description available.

.PARAMETER SecondaryContactAssignBy
No description available.

.PARAMETER PrimaryContactAssignBy
No description available.

.PARAMETER EnableDynamicMembership
No description available.

.PARAMETER HideGroupMembershipAssignBy
No description available.

.PARAMETER PolicyAssignBy
No description available.

.PARAMETER SiteDesignAssignBy
No description available.

.PARAMETER HubSiteAssignBy
No description available.

.PARAMETER MultiGeoSetting
No description available.

.PARAMETER IsShowHubSiteSection
No description available.

.PARAMETER HubSiteSettings
No description available.

.PARAMETER HasImpernastionUsers
No description available.

.PARAMETER DepartmentAssignBy
No description available.

.PARAMETER Metadatas
No description available.

.PARAMETER HideRequestSummary
No description available.

.PARAMETER Id
No description available.

.PARAMETER Name
No description available.

.PARAMETER Description
No description available.

.PARAMETER Type
No description available.

.PARAMETER Department
No description available.

.PARAMETER LoadDepartmentFromUps
No description available.

.PARAMETER Departments
No description available.

.PARAMETER ServiceContact
No description available.

.PARAMETER ServiceAdminContact
No description available.

.PARAMETER ApproversContainManagerRole
No description available.

.PARAMETER Status
No description available.

.PARAMETER ShowServiceInCatalog
No description available.

.PARAMETER CustomActions
No description available.

.PARAMETER ApprovalProcessId
No description available.

.PARAMETER LanguageId
No description available.

.PARAMETER CategoryId
No description available.

.OUTPUTS

CreateGroupService<PSCustomObject>
#>

function New-CreateGroupService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TenantId},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableTeams},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsPrivate},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableSubscribe},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableApplySiteDesign},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableOutsideSender},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableHideGroupMembership},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableClassification},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowConfigureLeasePeriod},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ShowNotebookLink},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ShowConversationsLink},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ShowFilesLink},
        [Parameter(Position = 12, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ShowTeamSiteLink},
        [Parameter(Position = 13, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ShowPlannerLink},
        [Parameter(Position = 14, ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Classifications},
        [Parameter(Position = 15, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SiteDesigns},
        [Parameter(Position = 16, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AddGroupMemberType},
        [Parameter(Position = 17, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SelectedPolicies},
        [Parameter(Position = 18, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SelectedLanguages},
        [Parameter(Position = 19, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TeamsSettings},
        [Parameter(Position = 20, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupNameConstructureSettings},
        [Parameter(Position = 21, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupIdConstructureSettings},
        [Parameter(Position = 22, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableInstallApp},
        [Parameter(Position = 23, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableInstallPanel},
        [Parameter(Position = 24, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TemplateSettings},
        [Parameter(Position = 25, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultPrimaryContact},
        [Parameter(Position = 26, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultSecondaryContact},
        [Parameter(Position = 27, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DefaultOwners},
        [Parameter(Position = 28, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DefaultMembers},
        [Parameter(Position = 29, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultPolicy},
        [Parameter(Position = 30, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultClassification},
        [Parameter(Position = 31, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultLanguage},
        [Parameter(Position = 32, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultSiteDesign},
        [Parameter(Position = 33, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DefaultOwnersReal},
        [Parameter(Position = 34, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DefaultMembersReal},
        [Parameter(Position = 35, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MemberAssignBy},
        [Parameter(Position = 36, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OwnerAssignBy},
        [Parameter(Position = 37, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrivacyAssignBy},
        [Parameter(Position = 38, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SubscribeAssignBy},
        [Parameter(Position = 39, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OutsideSenderAssignBy},
        [Parameter(Position = 40, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ClassificationAssignBy},
        [Parameter(Position = 41, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LanguageAssignBy},
        [Parameter(Position = 42, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContactAssignBy},
        [Parameter(Position = 43, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContactAssignBy},
        [Parameter(Position = 44, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableDynamicMembership},
        [Parameter(Position = 45, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${HideGroupMembershipAssignBy},
        [Parameter(Position = 46, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PolicyAssignBy},
        [Parameter(Position = 47, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteDesignAssignBy},
        [Parameter(Position = 48, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${HubSiteAssignBy},
        [Parameter(Position = 49, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MultiGeoSetting},
        [Parameter(Position = 50, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsShowHubSiteSection},
        [Parameter(Position = 51, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${HubSiteSettings},
        [Parameter(Position = 52, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${HasImpernastionUsers},
        [Parameter(Position = 53, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DepartmentAssignBy},
        [Parameter(Position = 54, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas},
        [Parameter(Position = 55, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${HideRequestSummary},
        [Parameter(Position = 56, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 57, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(Position = 58, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(Position = 59, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type},
        [Parameter(Position = 60, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Department},
        [Parameter(Position = 61, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${LoadDepartmentFromUps},
        [Parameter(Position = 62, ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Departments},
        [Parameter(Position = 63, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceContact},
        [Parameter(Position = 64, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceAdminContact},
        [Parameter(Position = 65, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ApproversContainManagerRole},
        [Parameter(Position = 66, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status},
        [Parameter(Position = 67, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ShowServiceInCatalog},
        [Parameter(Position = 68, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CustomActions},
        [Parameter(Position = 69, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ApprovalProcessId},
        [Parameter(Position = 70, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LanguageId},
        [Parameter(Position = 71, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CategoryId}
    )

    Process {
        'Creating object: Cloud.Governance.Client => CreateGroupService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "tenantId" = ${TenantId}
            "enableTeams" = ${EnableTeams}
            "isPrivate" = ${IsPrivate}
            "enableSubscribe" = ${EnableSubscribe}
            "enableApplySiteDesign" = ${EnableApplySiteDesign}
            "enableOutsideSender" = ${EnableOutsideSender}
            "enableHideGroupMembership" = ${EnableHideGroupMembership}
            "enableClassification" = ${EnableClassification}
            "allowConfigureLeasePeriod" = ${AllowConfigureLeasePeriod}
            "showNotebookLink" = ${ShowNotebookLink}
            "showConversationsLink" = ${ShowConversationsLink}
            "showFilesLink" = ${ShowFilesLink}
            "showTeamSiteLink" = ${ShowTeamSiteLink}
            "showPlannerLink" = ${ShowPlannerLink}
            "classifications" = ${Classifications}
            "siteDesigns" = ${SiteDesigns}
            "addGroupMemberType" = ${AddGroupMemberType}
            "selectedPolicies" = ${SelectedPolicies}
            "selectedLanguages" = ${SelectedLanguages}
            "teamsSettings" = ${TeamsSettings}
            "groupNameConstructureSettings" = ${GroupNameConstructureSettings}
            "groupIdConstructureSettings" = ${GroupIdConstructureSettings}
            "enableInstallApp" = ${EnableInstallApp}
            "enableInstallPanel" = ${EnableInstallPanel}
            "templateSettings" = ${TemplateSettings}
            "defaultPrimaryContact" = ${DefaultPrimaryContact}
            "defaultSecondaryContact" = ${DefaultSecondaryContact}
            "defaultOwners" = ${DefaultOwners}
            "defaultMembers" = ${DefaultMembers}
            "defaultPolicy" = ${DefaultPolicy}
            "defaultClassification" = ${DefaultClassification}
            "defaultLanguage" = ${DefaultLanguage}
            "defaultSiteDesign" = ${DefaultSiteDesign}
            "defaultOwnersReal" = ${DefaultOwnersReal}
            "defaultMembersReal" = ${DefaultMembersReal}
            "memberAssignBy" = ${MemberAssignBy}
            "ownerAssignBy" = ${OwnerAssignBy}
            "privacyAssignBy" = ${PrivacyAssignBy}
            "subscribeAssignBy" = ${SubscribeAssignBy}
            "outsideSenderAssignBy" = ${OutsideSenderAssignBy}
            "classificationAssignBy" = ${ClassificationAssignBy}
            "languageAssignBy" = ${LanguageAssignBy}
            "secondaryContactAssignBy" = ${SecondaryContactAssignBy}
            "primaryContactAssignBy" = ${PrimaryContactAssignBy}
            "enableDynamicMembership" = ${EnableDynamicMembership}
            "hideGroupMembershipAssignBy" = ${HideGroupMembershipAssignBy}
            "policyAssignBy" = ${PolicyAssignBy}
            "siteDesignAssignBy" = ${SiteDesignAssignBy}
            "hubSiteAssignBy" = ${HubSiteAssignBy}
            "multiGeoSetting" = ${MultiGeoSetting}
            "isShowHubSiteSection" = ${IsShowHubSiteSection}
            "hubSiteSettings" = ${HubSiteSettings}
            "hasImpernastionUsers" = ${HasImpernastionUsers}
            "departmentAssignBy" = ${DepartmentAssignBy}
            "metadatas" = ${Metadatas}
            "hideRequestSummary" = ${HideRequestSummary}
            "id" = ${Id}
            "name" = ${Name}
            "description" = ${Description}
            "type" = ${Type}
            "department" = ${Department}
            "loadDepartmentFromUps" = ${LoadDepartmentFromUps}
            "departments" = ${Departments}
            "serviceContact" = ${ServiceContact}
            "serviceAdminContact" = ${ServiceAdminContact}
            "approversContainManagerRole" = ${ApproversContainManagerRole}
            "status" = ${Status}
            "showServiceInCatalog" = ${ShowServiceInCatalog}
            "customActions" = ${CustomActions}
            "approvalProcessId" = ${ApprovalProcessId}
            "languageId" = ${LanguageId}
            "categoryId" = ${CategoryId}
        }

        return $PSO
    }
}
