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

.PARAMETER Urls
No description available.

.PARAMETER SourceUser
No description available.

.PARAMETER TargetUser
No description available.

.PARAMETER CloneOption
No description available.

.PARAMETER AdditionalCloneOption
No description available.

.PARAMETER EnabledRemoveExplicitPermission
No description available.

.PARAMETER EnabledRemoveUserFromSPGroup
No description available.

.PARAMETER EnabledDeleteUserPermission
No description available.

.PARAMETER Id
No description available.

.PARAMETER ServiceId
No description available.

.PARAMETER Department
No description available.

.PARAMETER Summary
No description available.

.PARAMETER NotesToApprovers
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER Metadatas
No description available.

.PARAMETER TicketNumber
No description available.

.PARAMETER Type
No description available.

.PARAMETER TypeDescription
No description available.

.PARAMETER Requester
No description available.

.PARAMETER Status
No description available.

.PARAMETER ProgressStatus
No description available.

.PARAMETER ProgressStatusDescription
No description available.

.PARAMETER SubmittedTime
No description available.

.PARAMETER LastUpdated
No description available.

.PARAMETER CreatedTime
No description available.

.PARAMETER AssignTo
No description available.

.PARAMETER FullPath
No description available.

.OUTPUTS

ClonePermissionRequest<PSCustomObject>
#>

function New-ClonePermissionRequest {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Urls},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SourceUser},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TargetUser},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CloneOption},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AdditionalCloneOption},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnabledRemoveExplicitPermission},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnabledRemoveUserFromSPGroup},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnabledDeleteUserPermission},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceId},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Department},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Summary},
        [Parameter(Position = 12, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NotesToApprovers},
        [Parameter(Position = 13, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${QuestionnaireId},
        [Parameter(Position = 14, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas},
        [Parameter(Position = 15, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${TicketNumber},
        [Parameter(Position = 16, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type},
        [Parameter(Position = 17, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TypeDescription},
        [Parameter(Position = 18, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Requester},
        [Parameter(Position = 19, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status},
        [Parameter(Position = 20, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ProgressStatus},
        [Parameter(Position = 21, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ProgressStatusDescription},
        [Parameter(Position = 22, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${SubmittedTime},
        [Parameter(Position = 23, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${LastUpdated},
        [Parameter(Position = 24, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${CreatedTime},
        [Parameter(Position = 25, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssignTo},
        [Parameter(Position = 26, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${FullPath}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ClonePermissionRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "urls" = ${Urls}
            "sourceUser" = ${SourceUser}
            "targetUser" = ${TargetUser}
            "cloneOption" = ${CloneOption}
            "additionalCloneOption" = ${AdditionalCloneOption}
            "enabledRemoveExplicitPermission" = ${EnabledRemoveExplicitPermission}
            "enabledRemoveUserFromSPGroup" = ${EnabledRemoveUserFromSPGroup}
            "enabledDeleteUserPermission" = ${EnabledDeleteUserPermission}
            "id" = ${Id}
            "serviceId" = ${ServiceId}
            "department" = ${Department}
            "summary" = ${Summary}
            "notesToApprovers" = ${NotesToApprovers}
            "questionnaireId" = ${QuestionnaireId}
            "metadatas" = ${Metadatas}
            "ticketNumber" = ${TicketNumber}
            "type" = ${Type}
            "typeDescription" = ${TypeDescription}
            "requester" = ${Requester}
            "status" = ${Status}
            "progressStatus" = ${ProgressStatus}
            "progressStatusDescription" = ${ProgressStatusDescription}
            "submittedTime" = ${SubmittedTime}
            "lastUpdated" = ${LastUpdated}
            "createdTime" = ${CreatedTime}
            "assignTo" = ${AssignTo}
            "fullPath" = ${FullPath}
        }

        return $PSO
    }
}
