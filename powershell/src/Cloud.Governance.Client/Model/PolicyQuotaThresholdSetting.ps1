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

.PARAMETER EnableQuotaThreshold
No description available.

.PARAMETER QuotaThreshold
No description available.

.PARAMETER QuotaThresholdNotifyUsers
No description available.

.OUTPUTS

PolicyQuotaThresholdSetting<PSCustomObject>
#>

function New-PolicyQuotaThresholdSetting {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableQuotaThreshold},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${QuotaThreshold},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${QuotaThresholdNotifyUsers}
    )

    Process {
        'Creating object: Cloud.Governance.Client => PolicyQuotaThresholdSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "enableQuotaThreshold" = ${EnableQuotaThreshold}
            "quotaThreshold" = ${QuotaThreshold}
            "quotaThresholdNotifyUsers" = ${QuotaThresholdNotifyUsers}
        }

        return $PSO
    }
}