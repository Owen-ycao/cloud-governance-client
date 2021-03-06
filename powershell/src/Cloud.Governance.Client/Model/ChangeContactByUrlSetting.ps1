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

.PARAMETER SiteId
No description available.

.PARAMETER SiteUrl
No description available.

.PARAMETER OriginalPrimaryContact
No description available.

.PARAMETER NewPrimaryContact
No description available.

.PARAMETER OriginalSecondaryContact
No description available.

.PARAMETER NewSecondaryContact
No description available.

.PARAMETER OriginalPrimaryAdministrator
No description available.

.PARAMETER NewPrimaryAdministrator
No description available.

.PARAMETER OriginalAdditionalAdministrators
No description available.

.PARAMETER NewAdditionalAdministrators
No description available.

.OUTPUTS

ChangeContactByUrlSetting<PSCustomObject>
#>

function New-ChangeContactByUrlSetting {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteId},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteUrl},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OriginalPrimaryContact},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NewPrimaryContact},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OriginalSecondaryContact},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NewSecondaryContact},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OriginalPrimaryAdministrator},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NewPrimaryAdministrator},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${OriginalAdditionalAdministrators},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${NewAdditionalAdministrators}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ChangeContactByUrlSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "siteId" = ${SiteId}
            "siteUrl" = ${SiteUrl}
            "originalPrimaryContact" = ${OriginalPrimaryContact}
            "newPrimaryContact" = ${NewPrimaryContact}
            "originalSecondaryContact" = ${OriginalSecondaryContact}
            "newSecondaryContact" = ${NewSecondaryContact}
            "originalPrimaryAdministrator" = ${OriginalPrimaryAdministrator}
            "newPrimaryAdministrator" = ${NewPrimaryAdministrator}
            "originalAdditionalAdministrators" = ${OriginalAdditionalAdministrators}
            "newAdditionalAdministrators" = ${NewAdditionalAdministrators}
        }

        return $PSO
    }
}
