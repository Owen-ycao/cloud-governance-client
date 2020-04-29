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

.PARAMETER ExtendType
No description available.

.PARAMETER Duration
No description available.

.PARAMETER DurationType
No description available.

.PARAMETER ConstantDuration
No description available.

.PARAMETER ConstantDurationType
No description available.

.PARAMETER ExtendBasedTime
No description available.

.OUTPUTS

ExtendSiteSetting<PSCustomObject>
#>

function New-ExtendSiteSetting {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExtendType},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Duration},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DurationType},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ConstantDuration},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ConstantDurationType},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${ExtendBasedTime}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ExtendSiteSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "extendType" = ${ExtendType}
            "duration" = ${Duration}
            "durationType" = ${DurationType}
            "constantDuration" = ${ConstantDuration}
            "constantDurationType" = ${ConstantDurationType}
            "extendBasedTime" = ${ExtendBasedTime}
        }

        return $PSO
    }
}