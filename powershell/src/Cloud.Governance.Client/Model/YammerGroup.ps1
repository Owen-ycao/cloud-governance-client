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

.PARAMETER Exists
No description available.

.PARAMETER Group
No description available.

.OUTPUTS

YammerGroup<PSCustomObject>
#>

function New-YammerGroup {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Exists},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Group}
    )

    Process {
        'Creating object: Cloud.Governance.Client => YammerGroup' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "exists" = ${Exists}
            "group" = ${Group}
        }

        return $PSO
    }
}
