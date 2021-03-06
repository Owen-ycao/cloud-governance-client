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

.PARAMETER Id
No description available.

.PARAMETER Name
No description available.

.PARAMETER LoginName
No description available.

.PARAMETER PrincipalType
No description available.

.PARAMETER PrincipalTypeDescription
No description available.

.PARAMETER PermissionLevels
No description available.

.OUTPUTS

SPRoleAssignment<PSCustomObject>
#>

function New-SPRoleAssignment {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LoginName},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrincipalType},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrincipalTypeDescription},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${PermissionLevels}
    )

    Process {
        'Creating object: Cloud.Governance.Client => SPRoleAssignment' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "id" = ${Id}
            "name" = ${Name}
            "loginName" = ${LoginName}
            "principalType" = ${PrincipalType}
            "principalTypeDescription" = ${PrincipalTypeDescription}
            "permissionLevels" = ${PermissionLevels}
        }

        return $PSO
    }
}
