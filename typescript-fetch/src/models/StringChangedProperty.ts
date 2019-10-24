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
 * @interface StringChangedProperty
 */
export interface StringChangedProperty {
    /**
     * 
     * @type {string}
     * @memberof StringChangedProperty
     */
    changeValue?: string | null;
    /**
     * 
     * @type {string}
     * @memberof StringChangedProperty
     */
    originalValue?: string | null;
}

export function StringChangedPropertyFromJSON(json: any): StringChangedProperty {
    return StringChangedPropertyFromJSONTyped(json, false);
}

export function StringChangedPropertyFromJSONTyped(json: any, ignoreDiscriminator: boolean): StringChangedProperty {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'changeValue': !exists(json, 'changeValue') ? undefined : json['changeValue'],
        'originalValue': !exists(json, 'originalValue') ? undefined : json['originalValue'],
    };
}

export function StringChangedPropertyToJSON(value?: StringChangedProperty | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'changeValue': value.changeValue,
        'originalValue': value.originalValue,
    };
}

