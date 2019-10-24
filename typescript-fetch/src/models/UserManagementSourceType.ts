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
 * User=0, Group=1, All=2, </br>
 * @export
 * @enum {string}
 */
export enum UserManagementSourceType {
    User = 'User',
    Group = 'Group',
    All = 'All'
}

export function UserManagementSourceTypeFromJSON(json: any): UserManagementSourceType {
    return UserManagementSourceTypeFromJSONTyped(json, false);
}

export function UserManagementSourceTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): UserManagementSourceType {
    return json as UserManagementSourceType;
}

export function UserManagementSourceTypeToJSON(value?: UserManagementSourceType): any {
    return value as any;
}
