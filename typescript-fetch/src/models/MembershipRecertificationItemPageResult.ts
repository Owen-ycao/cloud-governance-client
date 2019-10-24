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
    MembershipRecertificationItem,
    MembershipRecertificationItemFromJSON,
    MembershipRecertificationItemFromJSONTyped,
    MembershipRecertificationItemToJSON,
} from './';

/**
 * 
 * @export
 * @interface MembershipRecertificationItemPageResult
 */
export interface MembershipRecertificationItemPageResult {
    /**
     * 
     * @type {Array<MembershipRecertificationItem>}
     * @memberof MembershipRecertificationItemPageResult
     */
    value?: Array<MembershipRecertificationItem> | null;
    /**
     * 
     * @type {string}
     * @memberof MembershipRecertificationItemPageResult
     */
    nextLink?: string | null;
}

export function MembershipRecertificationItemPageResultFromJSON(json: any): MembershipRecertificationItemPageResult {
    return MembershipRecertificationItemPageResultFromJSONTyped(json, false);
}

export function MembershipRecertificationItemPageResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): MembershipRecertificationItemPageResult {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': !exists(json, 'value') ? undefined : (json['value'] as Array<any>).map(MembershipRecertificationItemFromJSON),
        'nextLink': !exists(json, 'nextLink') ? undefined : json['nextLink'],
    };
}

export function MembershipRecertificationItemPageResultToJSON(value?: MembershipRecertificationItemPageResult | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': value.value == null ? undefined : (value.value as Array<any>).map(MembershipRecertificationItemToJSON),
        'nextLink': value.nextLink,
    };
}

