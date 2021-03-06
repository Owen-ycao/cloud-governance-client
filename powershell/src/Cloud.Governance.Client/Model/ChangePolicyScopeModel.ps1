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

.PARAMETER Title
No description available.

.PARAMETER Description
No description available.

.PARAMETER Id
No description available.

.PARAMETER Category
No description available.

.PARAMETER CategoryDisplayName
No description available.

.PARAMETER Details
No description available.

.PARAMETER Type
No description available.

.PARAMETER Owner
No description available.

.PARAMETER FarmID
No description available.

.PARAMETER OnlineType
No description available.

.OUTPUTS

ChangePolicyScopeModel<PSCustomObject>
#>

function New-ChangePolicyScopeModel {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Category},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CategoryDisplayName},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Details},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Type},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Owner},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${FarmID},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${OnlineType}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ChangePolicyScopeModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "title" = ${Title}
            "description" = ${Description}
            "id" = ${Id}
            "category" = ${Category}
            "categoryDisplayName" = ${CategoryDisplayName}
            "details" = ${Details}
            "type" = ${Type}
            "owner" = ${Owner}
            "farmID" = ${FarmID}
            "onlineType" = ${OnlineType}
        }

        return $PSO
    }
}
