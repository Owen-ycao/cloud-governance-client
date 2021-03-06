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

.PARAMETER AvailabeTemplates
No description available.

.PARAMETER DefaultTemplate
No description available.

.PARAMETER TemplateStoreUrl
No description available.

.OUTPUTS

ListTemplateSettings<PSCustomObject>
#>

function New-ListTemplateSettings {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${AvailabeTemplates},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultTemplate},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TemplateStoreUrl}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ListTemplateSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "availabeTemplates" = ${AvailabeTemplates}
            "defaultTemplate" = ${DefaultTemplate}
            "templateStoreUrl" = ${TemplateStoreUrl}
        }

        return $PSO
    }
}
