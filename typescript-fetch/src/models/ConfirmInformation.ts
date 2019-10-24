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
import {
    RequestMetadata,
    RequestMetadataFromJSON,
    RequestMetadataFromJSONTyped,
    RequestMetadataToJSON,
} from './';

/**
 * 
 * @export
 * @interface ConfirmInformation
 */
export interface ConfirmInformation {
    /**
     * 
     * @type {string}
     * @memberof ConfirmInformation
     */
    secondaryContact?: string | null;
    /**
     * 
     * @type {string}
     * @memberof ConfirmInformation
     */
    policyId?: string;
    /**
     * 
     * @type {string}
     * @memberof ConfirmInformation
     */
    department?: string | null;
    /**
     * 
     * @type {Array<RequestMetadata>}
     * @memberof ConfirmInformation
     */
    metadatas?: Array<RequestMetadata> | null;
}

export function ConfirmInformationFromJSON(json: any): ConfirmInformation {
    return ConfirmInformationFromJSONTyped(json, false);
}

export function ConfirmInformationFromJSONTyped(json: any, ignoreDiscriminator: boolean): ConfirmInformation {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'secondaryContact': !exists(json, 'secondaryContact') ? undefined : json['secondaryContact'],
        'policyId': !exists(json, 'policyId') ? undefined : json['policyId'],
        'department': !exists(json, 'department') ? undefined : json['department'],
        'metadatas': !exists(json, 'metadatas') ? undefined : (json['metadatas'] as Array<any>).map(RequestMetadataFromJSON),
    };
}

export function ConfirmInformationToJSON(value?: ConfirmInformation | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'secondaryContact': value.secondaryContact,
        'policyId': value.policyId,
        'department': value.department,
        'metadatas': value.metadatas == null ? undefined : (value.metadatas as Array<any>).map(RequestMetadataToJSON),
    };
}

