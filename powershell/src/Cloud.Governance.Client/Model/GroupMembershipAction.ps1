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

None=0, Added=1, Deleted=2, </br>

.OUTPUTS

GroupMembershipAction<PSCustomObject>
#>

function New-GroupMembershipAction {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Creating object: Cloud.Governance.Client => GroupMembershipAction' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
        }

        return $PSO
    }
}
