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

Disabled=0, VerifiedGuestUser=1, Anyone=2, </br>ExistingGuestUser=3

.OUTPUTS

ExternalSharingOptions<PSCustomObject>
#>

function New-ExternalSharingOptions {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Creating object: Cloud.Governance.Client => ExternalSharingOptions' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
        }

        return $PSO
    }
}
