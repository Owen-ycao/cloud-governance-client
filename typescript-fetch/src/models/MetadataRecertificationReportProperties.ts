// tslint:disable
/**
 * Cloud Governance Api
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface MetadataRecertificationReportProperties
 */
export interface MetadataRecertificationReportProperties {
    /**
     * 
     * @type {boolean}
     * @memberof MetadataRecertificationReportProperties
     */
    enableAddOrDeletedMetadata?: boolean;
    /**
     * 
     * @type {string}
     * @memberof MetadataRecertificationReportProperties
     */
    objectId?: string;
    /**
     * 
     * @type {string}
     * @memberof MetadataRecertificationReportProperties
     */
    objectName?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof MetadataRecertificationReportProperties
     */
    isAllowedReassign?: boolean;
    /**
     * 
     * @type {Date}
     * @memberof MetadataRecertificationReportProperties
     */
    reportGeneratedTime?: Date;
    /**
     * 
     * @type {string}
     * @memberof MetadataRecertificationReportProperties
     */
    requestSummary?: string | null;
}

export function MetadataRecertificationReportPropertiesFromJSON(json: any): MetadataRecertificationReportProperties {
    return MetadataRecertificationReportPropertiesFromJSONTyped(json, false);
}

export function MetadataRecertificationReportPropertiesFromJSONTyped(json: any, ignoreDiscriminator: boolean): MetadataRecertificationReportProperties {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'enableAddOrDeletedMetadata': !exists(json, 'enableAddOrDeletedMetadata') ? undefined : json['enableAddOrDeletedMetadata'],
        'objectId': !exists(json, 'objectId') ? undefined : json['objectId'],
        'objectName': !exists(json, 'objectName') ? undefined : json['objectName'],
        'isAllowedReassign': !exists(json, 'isAllowedReassign') ? undefined : json['isAllowedReassign'],
        'reportGeneratedTime': !exists(json, 'reportGeneratedTime') ? undefined : new Date(json['reportGeneratedTime']),
        'requestSummary': !exists(json, 'requestSummary') ? undefined : json['requestSummary'],
    };
}

export function MetadataRecertificationReportPropertiesToJSON(value?: MetadataRecertificationReportProperties | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'enableAddOrDeletedMetadata': value.enableAddOrDeletedMetadata,
        'objectId': value.objectId,
        'objectName': value.objectName,
        'isAllowedReassign': value.isAllowedReassign,
        'reportGeneratedTime': value.reportGeneratedTime == null ? undefined : value.reportGeneratedTime.toISOString(),
        'requestSummary': value.requestSummary,
    };
}

