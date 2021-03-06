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

.PARAMETER IsBreakInheritance
No description available.

.PARAMETER IsGrantPermissionDirectly
No description available.

.PARAMETER SelectedSPGroup
No description available.

.PARAMETER SelectedPermissionLevels
No description available.

.OUTPUTS

GrantPermissionRequestPermissionSettings<PSCustomObject>
#>

function New-GrantPermissionRequestPermissionSettings {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsBreakInheritance},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsGrantPermissionDirectly},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SelectedSPGroup},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SelectedPermissionLevels}
    )

    Process {
        'Creating object: Cloud.Governance.Client => GrantPermissionRequestPermissionSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "isBreakInheritance" = ${IsBreakInheritance}
            "isGrantPermissionDirectly" = ${IsGrantPermissionDirectly}
            "selectedSPGroup" = ${SelectedSPGroup}
            "selectedPermissionLevels" = ${SelectedPermissionLevels}
        }

        return $PSO
    }
}
