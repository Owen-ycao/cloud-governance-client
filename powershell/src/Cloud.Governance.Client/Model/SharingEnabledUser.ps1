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

.PARAMETER IsSharePointGroup
No description available.

.PARAMETER IsGuestUser
No description available.

.PARAMETER IsGuestUserExistsInOrganization
No description available.

.PARAMETER Id
No description available.

.PARAMETER LoginName
No description available.

.PARAMETER DisplayName
No description available.

.PARAMETER IsGroup
No description available.

.PARAMETER Email
No description available.

.PARAMETER JobTitle
No description available.

.PARAMETER PhysicalDeliveryOfficeName
No description available.

.PARAMETER IsOtherTenantUser
No description available.

.OUTPUTS

SharingEnabledUser<PSCustomObject>
#>

function New-SharingEnabledUser {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsSharePointGroup},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsGuestUser},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsGuestUserExistsInOrganization},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LoginName},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DisplayName},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsGroup},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Email},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${JobTitle},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PhysicalDeliveryOfficeName},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsOtherTenantUser}
    )

    Process {
        'Creating object: Cloud.Governance.Client => SharingEnabledUser' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "isSharePointGroup" = ${IsSharePointGroup}
            "isGuestUser" = ${IsGuestUser}
            "isGuestUserExistsInOrganization" = ${IsGuestUserExistsInOrganization}
            "id" = ${Id}
            "loginName" = ${LoginName}
            "displayName" = ${DisplayName}
            "isGroup" = ${IsGroup}
            "email" = ${Email}
            "jobTitle" = ${JobTitle}
            "physicalDeliveryOfficeName" = ${PhysicalDeliveryOfficeName}
            "isOtherTenantUser" = ${IsOtherTenantUser}
        }

        return $PSO
    }
}
