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

.PARAMETER IsRecertificationJobEnabled
No description available.

.PARAMETER SiteStatusScanJob
No description available.

.PARAMETER WebSynchronizationJob
No description available.

.PARAMETER SiteSynchronizationJob
No description available.

.PARAMETER SiteContentArchivalJob
No description available.

.PARAMETER SiteContactStatusScanJob
No description available.

.PARAMETER GroupOrTeamsSynchronizationJob
No description available.

.PARAMETER UserProfileMetadataSynchronizationJob
No description available.

.PARAMETER UserProfileRoleMetadataSynchronizationJob
No description available.

.OUTPUTS

TimerConfigurationModel<PSCustomObject>
#>

function New-TimerConfigurationModel {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsRecertificationJobEnabled},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteStatusScanJob},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${WebSynchronizationJob},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteSynchronizationJob},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteContentArchivalJob},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteContactStatusScanJob},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupOrTeamsSynchronizationJob},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UserProfileMetadataSynchronizationJob},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UserProfileRoleMetadataSynchronizationJob}
    )

    Process {
        'Creating object: Cloud.Governance.Client => TimerConfigurationModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "isRecertificationJobEnabled" = ${IsRecertificationJobEnabled}
            "siteStatusScanJob" = ${SiteStatusScanJob}
            "webSynchronizationJob" = ${WebSynchronizationJob}
            "siteSynchronizationJob" = ${SiteSynchronizationJob}
            "siteContentArchivalJob" = ${SiteContentArchivalJob}
            "siteContactStatusScanJob" = ${SiteContactStatusScanJob}
            "groupOrTeamsSynchronizationJob" = ${GroupOrTeamsSynchronizationJob}
            "userProfileMetadataSynchronizationJob" = ${UserProfileMetadataSynchronizationJob}
            "userProfileRoleMetadataSynchronizationJob" = ${UserProfileRoleMetadataSynchronizationJob}
        }

        return $PSO
    }
}
