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

.PARAMETER IsEnabled
No description available.

.PARAMETER Interval
No description available.

.PARAMETER IntervalType
No description available.

.OUTPUTS

TimerConfigurationItem<PSCustomObject>
#>

function New-TimerConfigurationItem {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnabled},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Interval},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${IntervalType}
    )

    Process {
        'Creating object: Cloud.Governance.Client => TimerConfigurationItem' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "isEnabled" = ${IsEnabled}
            "interval" = ${Interval}
            "intervalType" = ${IntervalType}
        }

        return $PSO
    }
}
