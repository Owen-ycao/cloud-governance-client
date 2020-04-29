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

.PARAMETER Id
No description available.

.PARAMETER Name
No description available.

.PARAMETER Type
No description available.

.PARAMETER SiteUrl
No description available.

.PARAMETER GroupEmail
No description available.

.PARAMETER TypeDescription
No description available.

.PARAMETER PrimaryContact
No description available.

.PARAMETER PrimaryContactEmail
No description available.

.PARAMETER Phase
No description available.

.PARAMETER PhaseDescription
No description available.

.PARAMETER IsCurrentRenewer
No description available.

.PARAMETER CreatedTime
No description available.

.PARAMETER Status
No description available.

.PARAMETER AutoImportProfileId
No description available.

.PARAMETER PendingAction
No description available.

.OUTPUTS

WorkspaceList<PSCustomObject>
#>

function New-WorkspaceList {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteUrl},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupEmail},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TypeDescription},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryContact},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryContactEmail},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Phase},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PhaseDescription},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsCurrentRenewer},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${CreatedTime},
        [Parameter(Position = 12, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status},
        [Parameter(Position = 13, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AutoImportProfileId},
        [Parameter(Position = 14, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${PendingAction}
    )

    Process {
        'Creating object: Cloud.Governance.Client => WorkspaceList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "id" = ${Id}
            "name" = ${Name}
            "type" = ${Type}
            "siteUrl" = ${SiteUrl}
            "groupEmail" = ${GroupEmail}
            "typeDescription" = ${TypeDescription}
            "primaryContact" = ${PrimaryContact}
            "primaryContactEmail" = ${PrimaryContactEmail}
            "phase" = ${Phase}
            "phaseDescription" = ${PhaseDescription}
            "isCurrentRenewer" = ${IsCurrentRenewer}
            "createdTime" = ${CreatedTime}
            "status" = ${Status}
            "autoImportProfileId" = ${AutoImportProfileId}
            "pendingAction" = ${PendingAction}
        }

        return $PSO
    }
}