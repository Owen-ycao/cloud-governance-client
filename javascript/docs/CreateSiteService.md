# CloudGovernanceApi.CreateSiteService

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**adminCenterUrl** | **String** |  | [optional] 
**siteLanguages** | [**[IntModel]**](IntModel.md) |  | [optional] 
**rootSiteAndManagedPaths** | [**[RootSiteWithManagedPaths]**](RootSiteWithManagedPaths.md) |  | [optional] 
**siteUrlSetting** | [**SiteUrlSetting**](SiteUrlSetting.md) |  | [optional] 
**multiGeoSetting** | [**MultiGeoSerivceSetting**](MultiGeoSerivceSetting.md) |  | [optional] 
**policies** | [**[PolicyRef]**](PolicyRef.md) |  | [optional] 
**deploymentManagerPlanSettings** | [**DeploymentManagerPlanSettings**](DeploymentManagerPlanSettings.md) |  | [optional] 
**policyIdsAndTemplates** | [**[PolicyWithTemplates]**](PolicyWithTemplates.md) |  | [optional] 
**templateIdsAndPermissions** | [**[TemplateWithPermissions]**](TemplateWithPermissions.md) |  | [optional] 
**permissionSettings** | [**PermissionSettings**](PermissionSettings.md) |  | [optional] 
**leasePeriodSettings** | [**SiteLeasePeriodServiceSettings**](SiteLeasePeriodServiceSettings.md) |  | [optional] 
**timeZones** | [**[IntModel]**](IntModel.md) |  | [optional] 
**yammerGroupSettings** | [**YammerGroupServiceSettings**](YammerGroupServiceSettings.md) |  | [optional] 
**classifications** | **[String]** |  | [optional] 
**hubSiteSettings** | [**HubSiteSettings**](HubSiteSettings.md) |  | [optional] 
**enabledCustomTemplate** | **Boolean** |  | [optional] 
**customSiteTemplateListURL** | **String** |  | [optional] 
**defaultPrimaryAdmin** | [**ApiUser**](ApiUser.md) |  | [optional] 
**defaultAdditionalAdmins** | [**[ApiUser]**](ApiUser.md) |  | [optional] 
**defaultPrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**defaultSecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**defaultSiteLanguage** | **Number** |  | [optional] 
**defaultRootSite** | **String** |  | [optional] 
**defaultManagedPath** | **String** |  | [optional] 
**defaultPolicy** | **String** |  | [optional] 
**defaultTemplate** | **String** |  | [optional] 
**defaultTimeZone** | **Number** |  | [optional] 
**defaultClassification** | **String** |  | [optional] 
**defaultDesignType** | **String** |  | [optional] 
**siteLanguageAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**templateAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**policyAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**permissionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**rootSiteAndManagedPathAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**timeZoneAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**primaryAdminAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**additionalAdminAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**primaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**secondaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**designTypeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**classificationAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**hubSiteAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**departmentAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**metadatas** | [**[CustomMetadata]**](CustomMetadata.md) |  | [optional] 
**hideRequestSummary** | **Boolean** |  | [optional] 
**id** | **String** |  | [optional] 
**name** | **String** |  | [optional] 
**description** | **String** |  | [optional] 
**type** | [**ServiceType**](ServiceType.md) |  | [optional] 
**department** | **String** |  | [optional] 
**loadDepartmentFromUps** | **Boolean** |  | [optional] 
**departments** | **[String]** |  | [optional] 
**serviceContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**serviceAdminContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**approversContainManagerRole** | **Boolean** |  | [optional] 
**status** | [**CommonStatus**](CommonStatus.md) |  | [optional] 
**showServiceInCatalog** | **Boolean** |  | [optional] 
**customActivity** | [**CustomActivityInfo**](CustomActivityInfo.md) |  | [optional] 
**approvalProcessId** | **String** |  | [optional] 
**languageId** | **Number** |  | [optional] 
**categoryId** | **String** |  | [optional] 

