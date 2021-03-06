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

.PARAMETER IsAutoApproveWhenRequesterIsApprover
No description available.

.PARAMETER IsEnableAutoApproval
No description available.

.PARAMETER IsAutoApproveWhenRequesterInSpecifiedSecurityGroup
No description available.

.PARAMETER SpecifiedSecurityGroup
No description available.

.PARAMETER StageCount
No description available.

.OUTPUTS

ApprovalProcessStageSettings<PSCustomObject>
#>

function New-ApprovalProcessStageSettings {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsAutoApproveWhenRequesterIsApprover},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableAutoApproval},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsAutoApproveWhenRequesterInSpecifiedSecurityGroup},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SpecifiedSecurityGroup},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${StageCount}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ApprovalProcessStageSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "isAutoApproveWhenRequesterIsApprover" = ${IsAutoApproveWhenRequesterIsApprover}
            "isEnableAutoApproval" = ${IsEnableAutoApproval}
            "isAutoApproveWhenRequesterInSpecifiedSecurityGroup" = ${IsAutoApproveWhenRequesterInSpecifiedSecurityGroup}
            "specifiedSecurityGroup" = ${SpecifiedSecurityGroup}
            "stageCount" = ${StageCount}
        }

        return $PSO
    }
}
