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

.PARAMETER IsDefineChangeToPolicies
No description available.

.PARAMETER SelectedPoliciesForChangePolicy
No description available.

.PARAMETER IsEnabled
No description available.

.PARAMETER IsDefaultProcess
No description available.

.PARAMETER ProcessId
No description available.

.OUTPUTS

PolicyChangeLifecycleItem<PSCustomObject>
#>

function New-PolicyChangeLifecycleItem {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsDefineChangeToPolicies},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SelectedPoliciesForChangePolicy},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnabled},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsDefaultProcess},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ProcessId}
    )

    Process {
        'Creating object: Cloud.Governance.Client => PolicyChangeLifecycleItem' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "isDefineChangeToPolicies" = ${IsDefineChangeToPolicies}
            "selectedPoliciesForChangePolicy" = ${SelectedPoliciesForChangePolicy}
            "isEnabled" = ${IsEnabled}
            "isDefaultProcess" = ${IsDefaultProcess}
            "processId" = ${ProcessId}
        }

        return $PSO
    }
}