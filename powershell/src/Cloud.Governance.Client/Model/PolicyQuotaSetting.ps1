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

.PARAMETER Storage
No description available.

.PARAMETER ServerResource
No description available.

.OUTPUTS

PolicyQuotaSetting<PSCustomObject>
#>

function New-PolicyQuotaSetting {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${Storage},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${ServerResource}
    )

    Process {
        'Creating object: Cloud.Governance.Client => PolicyQuotaSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "storage" = ${Storage}
            "serverResource" = ${ServerResource}
        }

        return $PSO
    }
}
