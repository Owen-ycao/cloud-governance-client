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

Disabled=0, ExternalUserSharingOnly=1, ExternalUserAndGuestSharing=2, </br>ExistingExternalUserSharingOnly=3

.OUTPUTS

SharingCapabilities<PSCustomObject>
#>

function New-SharingCapabilities {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Creating object: Cloud.Governance.Client => SharingCapabilities' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
        }

        return $PSO
    }
}