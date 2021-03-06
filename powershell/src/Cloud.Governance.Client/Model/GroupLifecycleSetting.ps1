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

.PARAMETER Enabled
No description available.

.PARAMETER ApprovalProcess
No description available.

.PARAMETER IsUsedDefaultProcess
No description available.

.OUTPUTS

GroupLifecycleSetting<PSCustomObject>
#>

function New-GroupLifecycleSetting {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Enabled},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ApprovalProcess},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsUsedDefaultProcess}
    )

    Process {
        'Creating object: Cloud.Governance.Client => GroupLifecycleSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "enabled" = ${Enabled}
            "approvalProcess" = ${ApprovalProcess}
            "isUsedDefaultProcess" = ${IsUsedDefaultProcess}
        }

        return $PSO
    }
}
