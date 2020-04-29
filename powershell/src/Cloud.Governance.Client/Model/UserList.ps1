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

.PARAMETER LoginName
No description available.

.PARAMETER DisplayName
No description available.

.PARAMETER Email
No description available.

.PARAMETER IsDomainGroup
No description available.

.PARAMETER AuthenticationType
No description available.

.PARAMETER UserTypeDescription
No description available.

.OUTPUTS

UserList<PSCustomObject>
#>

function New-UserList {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LoginName},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DisplayName},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Email},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsDomainGroup},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AuthenticationType},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${UserTypeDescription}
    )

    Process {
        'Creating object: Cloud.Governance.Client => UserList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "id" = ${Id}
            "loginName" = ${LoginName}
            "displayName" = ${DisplayName}
            "email" = ${Email}
            "isDomainGroup" = ${IsDomainGroup}
            "authenticationType" = ${AuthenticationType}
            "userTypeDescription" = ${UserTypeDescription}
        }

        return $PSO
    }
}