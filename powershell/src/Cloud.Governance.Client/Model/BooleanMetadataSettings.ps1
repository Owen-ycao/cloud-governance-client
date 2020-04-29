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

.PARAMETER EnableTerms
No description available.

.PARAMETER Value
No description available.

.PARAMETER TermsAndConditions
No description available.

.OUTPUTS

BooleanMetadataSettings<PSCustomObject>
#>

function New-BooleanMetadataSettings {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableTerms},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Value},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TermsAndConditions}
    )

    Process {
        'Creating object: Cloud.Governance.Client => BooleanMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "enableTerms" = ${EnableTerms}
            "value" = ${Value}
            "termsAndConditions" = ${TermsAndConditions}
        }

        return $PSO
    }
}