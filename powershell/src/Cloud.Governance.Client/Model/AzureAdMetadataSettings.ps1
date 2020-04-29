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

.PARAMETER Office365Tenant
No description available.

.PARAMETER UseBuiltInProperty
No description available.

.PARAMETER Value
No description available.

.PARAMETER Property
No description available.

.PARAMETER AllowReferenceAsRoleInApprovalProcess
No description available.

.OUTPUTS

AzureAdMetadataSettings<PSCustomObject>
#>

function New-AzureAdMetadataSettings {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Office365Tenant},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${UseBuiltInProperty},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Value},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Property},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowReferenceAsRoleInApprovalProcess}
    )

    Process {
        'Creating object: Cloud.Governance.Client => AzureAdMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "office365Tenant" = ${Office365Tenant}
            "useBuiltInProperty" = ${UseBuiltInProperty}
            "value" = ${Value}
            "property" = ${Property}
            "allowReferenceAsRoleInApprovalProcess" = ${AllowReferenceAsRoleInApprovalProcess}
        }

        return $PSO
    }
}