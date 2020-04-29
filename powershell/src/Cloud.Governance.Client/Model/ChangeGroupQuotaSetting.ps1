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

.PARAMETER ChangeOption
No description available.

.PARAMETER MaxValue
No description available.

.PARAMETER Enabled
No description available.

.PARAMETER ApprovalProcess
No description available.

.PARAMETER IsUsedDefaultProcess
No description available.

.OUTPUTS

ChangeGroupQuotaSetting<PSCustomObject>
#>

function New-ChangeGroupQuotaSetting {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ChangeOption},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${MaxValue},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Enabled},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ApprovalProcess},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsUsedDefaultProcess}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ChangeGroupQuotaSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "changeOption" = ${ChangeOption}
            "maxValue" = ${MaxValue}
            "enabled" = ${Enabled}
            "approvalProcess" = ${ApprovalProcess}
            "isUsedDefaultProcess" = ${IsUsedDefaultProcess}
        }

        return $PSO
    }
}