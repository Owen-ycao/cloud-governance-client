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

.PARAMETER DefaultProcess
No description available.

.PARAMETER Deletion
No description available.

.PARAMETER Extension
No description available.

.PARAMETER ChangePolicy
No description available.

.PARAMETER Quota
No description available.

.PARAMETER TeamArchive
No description available.

.PARAMETER TeamUnArchive
No description available.

.OUTPUTS

GroupPolicyLifecycleSetting<PSCustomObject>
#>

function New-GroupPolicyLifecycleSetting {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultProcess},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Deletion},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Extension},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ChangePolicy},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Quota},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TeamArchive},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TeamUnArchive}
    )

    Process {
        'Creating object: Cloud.Governance.Client => GroupPolicyLifecycleSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "defaultProcess" = ${DefaultProcess}
            "deletion" = ${Deletion}
            "extension" = ${Extension}
            "changePolicy" = ${ChangePolicy}
            "quota" = ${Quota}
            "teamArchive" = ${TeamArchive}
            "teamUnArchive" = ${TeamUnArchive}
        }

        return $PSO
    }
}
