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

.PARAMETER IsEnabled
No description available.

.PARAMETER Duration
No description available.

.PARAMETER ReminderInterval
No description available.

.PARAMETER Assignee
No description available.

.OUTPUTS

TaskDurationModel<PSCustomObject>
#>

function New-TaskDurationModel {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnabled},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Duration},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ReminderInterval},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Assignee}
    )

    Process {
        'Creating object: Cloud.Governance.Client => TaskDurationModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "isEnabled" = ${IsEnabled}
            "duration" = ${Duration}
            "reminderInterval" = ${ReminderInterval}
            "assignee" = ${Assignee}
        }

        return $PSO
    }
}
