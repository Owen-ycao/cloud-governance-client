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

.PARAMETER SelectedNodes
No description available.

.PARAMETER AutoPopulateUrlWithSPContext
No description available.

.PARAMETER AutoPopulateUrlWithSPContextAssignBy
No description available.

.OUTPUTS

ServiceScopeSettings<PSCustomObject>
#>

function New-ServiceScopeSettings {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SelectedNodes},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AutoPopulateUrlWithSPContext},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AutoPopulateUrlWithSPContextAssignBy}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ServiceScopeSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "selectedNodes" = ${SelectedNodes}
            "autoPopulateUrlWithSPContext" = ${AutoPopulateUrlWithSPContext}
            "autoPopulateUrlWithSPContextAssignBy" = ${AutoPopulateUrlWithSPContextAssignBy}
        }

        return $PSO
    }
}