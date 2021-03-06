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

.PARAMETER UserAssignBy
No description available.

.PARAMETER User
No description available.

.PARAMETER PermissionLevels
No description available.

.OUTPUTS

ServiceUserWithPermissions<PSCustomObject>
#>

function New-ServiceUserWithPermissions {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UserAssignBy},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${User},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${PermissionLevels}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ServiceUserWithPermissions' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "userAssignBy" = ${UserAssignBy}
            "user" = ${User}
            "permissionLevels" = ${PermissionLevels}
        }

        return $PSO
    }
}
