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

.PARAMETER InstanceId
No description available.

.PARAMETER Type
No description available.

.PARAMETER TaskId
No description available.

.PARAMETER ActionType
No description available.

.PARAMETER DisplayName
No description available.

.PARAMETER IdentityName
No description available.

.PARAMETER PermissionLevel
No description available.

.PARAMETER PermissionIds
No description available.

.PARAMETER MemberId
No description available.

.PARAMETER TitleName
No description available.

.PARAMETER Path
No description available.

.PARAMETER SharePointGroup
No description available.

.PARAMETER ParentId
No description available.

.PARAMETER IdInSharepoint
No description available.

.PARAMETER Level
No description available.

.PARAMETER LevelDescription
No description available.

.PARAMETER AccountType
No description available.

.PARAMETER AccountTypeDescription
No description available.

.PARAMETER AccessType
No description available.

.PARAMETER AccessTypeDescription
No description available.

.OUTPUTS

GroupPermissionActionItem<PSCustomObject>
#>

function New-GroupPermissionActionItem {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${InstanceId},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TaskId},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ActionType},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DisplayName},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${IdentityName},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PermissionLevel},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [Int32[]]
        ${PermissionIds},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${MemberId},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TitleName},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Path},
        [Parameter(Position = 12, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SharePointGroup},
        [Parameter(Position = 13, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ParentId},
        [Parameter(Position = 14, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${IdInSharepoint},
        [Parameter(Position = 15, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Level},
        [Parameter(Position = 16, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LevelDescription},
        [Parameter(Position = 17, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AccountType},
        [Parameter(Position = 18, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AccountTypeDescription},
        [Parameter(Position = 19, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AccessType},
        [Parameter(Position = 20, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AccessTypeDescription}
    )

    Process {
        'Creating object: Cloud.Governance.Client => GroupPermissionActionItem' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "id" = ${Id}
            "instanceId" = ${InstanceId}
            "type" = ${Type}
            "taskId" = ${TaskId}
            "actionType" = ${ActionType}
            "displayName" = ${DisplayName}
            "identityName" = ${IdentityName}
            "permissionLevel" = ${PermissionLevel}
            "permissionIds" = ${PermissionIds}
            "memberId" = ${MemberId}
            "titleName" = ${TitleName}
            "path" = ${Path}
            "sharePointGroup" = ${SharePointGroup}
            "parentId" = ${ParentId}
            "idInSharepoint" = ${IdInSharepoint}
            "level" = ${Level}
            "levelDescription" = ${LevelDescription}
            "accountType" = ${AccountType}
            "accountTypeDescription" = ${AccountTypeDescription}
            "accessType" = ${AccessType}
            "accessTypeDescription" = ${AccessTypeDescription}
        }

        return $PSO
    }
}
