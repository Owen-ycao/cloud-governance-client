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

.PARAMETER LanguageId
No description available.

.PARAMETER TimeZoneId
No description available.

.PARAMETER IsAdjustDaylight
No description available.

.OUTPUTS

GlobalPersonalSettingModel<PSCustomObject>
#>

function New-GlobalPersonalSettingModel {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LanguageId},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${TimeZoneId},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsAdjustDaylight}
    )

    Process {
        'Creating object: Cloud.Governance.Client => GlobalPersonalSettingModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "languageId" = ${LanguageId}
            "timeZoneId" = ${TimeZoneId}
            "isAdjustDaylight" = ${IsAdjustDaylight}
        }

        return $PSO
    }
}
