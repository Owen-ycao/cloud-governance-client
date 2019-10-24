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

/**
 * None=0, Exe=1, Ps1=2, </br>Dll=3
 * @export
 * @enum {string}
 */
export enum ExecutionCommandType {
    None = 'None',
    Exe = 'Exe',
    Ps1 = 'Ps1',
    Dll = 'Dll'
}

export function ExecutionCommandTypeFromJSON(json: any): ExecutionCommandType {
    return ExecutionCommandTypeFromJSONTyped(json, false);
}

export function ExecutionCommandTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ExecutionCommandType {
    return json as ExecutionCommandType;
}

export function ExecutionCommandTypeToJSON(value?: ExecutionCommandType): any {
    return value as any;
}
