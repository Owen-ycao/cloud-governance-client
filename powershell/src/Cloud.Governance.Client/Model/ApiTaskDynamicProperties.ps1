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

.PARAMETER None
No description available.

.PARAMETER PrimaryContact
No description available.

.PARAMETER SecondaryContact
No description available.

.PARAMETER SiteId
No description available.

.PARAMETER SiteUrl
No description available.

.PARAMETER GroupName
No description available.

.PARAMETER ExpirationDate
No description available.

.PARAMETER GroupOwners
No description available.

.PARAMETER AutoTaskActionHistories
No description available.

.PARAMETER InactivityThresholdDate
No description available.

.PARAMETER GroupEmail
No description available.

.PARAMETER GroupId
No description available.

.PARAMETER PolicyName
No description available.

.PARAMETER PrimaryAdministrator
No description available.

.PARAMETER SiteTemplate
No description available.

.PARAMETER SiteTitle
No description available.

.PARAMETER SiteDescription
No description available.

.PARAMETER Requester
No description available.

.OUTPUTS

ApiTaskDynamicProperties<PSCustomObject>
#>

function New-ApiTaskDynamicProperties {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${None},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContact},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContact},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteId},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteUrl},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupName},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExpirationDate},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupOwners},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AutoTaskActionHistories},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${InactivityThresholdDate},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupEmail},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupId},
        [Parameter(Position = 12, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PolicyName},
        [Parameter(Position = 13, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryAdministrator},
        [Parameter(Position = 14, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteTemplate},
        [Parameter(Position = 15, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteTitle},
        [Parameter(Position = 16, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteDescription},
        [Parameter(Position = 17, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Requester}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ApiTaskDynamicProperties' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "None" = ${None}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "SiteId" = ${SiteId}
            "SiteUrl" = ${SiteUrl}
            "GroupName" = ${GroupName}
            "ExpirationDate" = ${ExpirationDate}
            "GroupOwners" = ${GroupOwners}
            "AutoTaskActionHistories" = ${AutoTaskActionHistories}
            "InactivityThresholdDate" = ${InactivityThresholdDate}
            "GroupEmail" = ${GroupEmail}
            "GroupId" = ${GroupId}
            "PolicyName" = ${PolicyName}
            "PrimaryAdministrator" = ${PrimaryAdministrator}
            "SiteTemplate" = ${SiteTemplate}
            "SiteTitle" = ${SiteTitle}
            "SiteDescription" = ${SiteDescription}
            "Requester" = ${Requester}
        }

        return $PSO
    }
}
