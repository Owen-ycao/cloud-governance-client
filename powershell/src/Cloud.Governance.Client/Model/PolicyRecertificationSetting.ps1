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

.PARAMETER ProfileId
No description available.

.OUTPUTS

PolicyRecertificationSetting<PSCustomObject>
#>

function New-PolicyRecertificationSetting {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnabled},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ProfileId}
    )

    Process {
        'Creating object: Cloud.Governance.Client => PolicyRecertificationSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "isEnabled" = ${IsEnabled}
            "profileId" = ${ProfileId}
        }

        return $PSO
    }
}
