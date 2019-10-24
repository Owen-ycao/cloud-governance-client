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
    PermissionActionType,
    PermissionActionTypeFromJSON,
    PermissionActionTypeFromJSONTyped,
    PermissionActionTypeToJSON,
    PrincipalType,
    PrincipalTypeFromJSON,
    PrincipalTypeFromJSONTyped,
    PrincipalTypeToJSON,
    UserAccessType,
    UserAccessTypeFromJSON,
    UserAccessTypeFromJSONTyped,
    UserAccessTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface PermissionActionItem
 */
export interface PermissionActionItem {
    /**
     * 
     * @type {string}
     * @memberof PermissionActionItem
     */
    id?: string | null;
    /**
     * 
     * @type {string}
     * @memberof PermissionActionItem
     */
    idInSharepoint?: string | null;
    /**
     * 
     * @type {PrincipalType}
     * @memberof PermissionActionItem
     */
    accountType?: PrincipalType;
    /**
     * 
     * @type {string}
     * @memberof PermissionActionItem
     */
    readonly accountTypeDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof PermissionActionItem
     */
    displayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof PermissionActionItem
     */
    level?: string | null;
    /**
     * 
     * @type {string}
     * @memberof PermissionActionItem
     */
    levelDescription?: string | null;
    /**
     * 
     * @type {string}
     * @memberof PermissionActionItem
     */
    memberOf?: string | null;
    /**
     * 
     * @type {string}
     * @memberof PermissionActionItem
     */
    path?: string | null;
    /**
     * 
     * @type {string}
     * @memberof PermissionActionItem
     */
    permissionLevel?: string | null;
    /**
     * 
     * @type {string}
     * @memberof PermissionActionItem
     */
    sharePointGroup?: string | null;
    /**
     * 
     * @type {string}
     * @memberof PermissionActionItem
     */
    titleName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof PermissionActionItem
     */
    userOrGroup?: string | null;
    /**
     * 
     * @type {number}
     * @memberof PermissionActionItem
     */
    memberId?: number;
    /**
     * 
     * @type {string}
     * @memberof PermissionActionItem
     */
    parentId?: string | null;
    /**
     * 
     * @type {number}
     * @memberof PermissionActionItem
     */
    parentAccountType?: number;
    /**
     * 
     * @type {PermissionActionType}
     * @memberof PermissionActionItem
     */
    actionType?: PermissionActionType;
    /**
     * 
     * @type {UserAccessType}
     * @memberof PermissionActionItem
     */
    accessType?: UserAccessType;
    /**
     * 
     * @type {string}
     * @memberof PermissionActionItem
     */
    readonly accessTypeDescription?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof PermissionActionItem
     */
    isSiteAdministrator?: boolean;
}

export function PermissionActionItemFromJSON(json: any): PermissionActionItem {
    return PermissionActionItemFromJSONTyped(json, false);
}

export function PermissionActionItemFromJSONTyped(json: any, ignoreDiscriminator: boolean): PermissionActionItem {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'idInSharepoint': !exists(json, 'idInSharepoint') ? undefined : json['idInSharepoint'],
        'accountType': !exists(json, 'accountType') ? undefined : PrincipalTypeFromJSON(json['accountType']),
        'accountTypeDescription': !exists(json, 'accountTypeDescription') ? undefined : json['accountTypeDescription'],
        'displayName': !exists(json, 'displayName') ? undefined : json['displayName'],
        'level': !exists(json, 'level') ? undefined : json['level'],
        'levelDescription': !exists(json, 'levelDescription') ? undefined : json['levelDescription'],
        'memberOf': !exists(json, 'memberOf') ? undefined : json['memberOf'],
        'path': !exists(json, 'path') ? undefined : json['path'],
        'permissionLevel': !exists(json, 'permissionLevel') ? undefined : json['permissionLevel'],
        'sharePointGroup': !exists(json, 'sharePointGroup') ? undefined : json['sharePointGroup'],
        'titleName': !exists(json, 'titleName') ? undefined : json['titleName'],
        'userOrGroup': !exists(json, 'userOrGroup') ? undefined : json['userOrGroup'],
        'memberId': !exists(json, 'memberId') ? undefined : json['memberId'],
        'parentId': !exists(json, 'parentId') ? undefined : json['parentId'],
        'parentAccountType': !exists(json, 'parentAccountType') ? undefined : json['parentAccountType'],
        'actionType': !exists(json, 'actionType') ? undefined : PermissionActionTypeFromJSON(json['actionType']),
        'accessType': !exists(json, 'accessType') ? undefined : UserAccessTypeFromJSON(json['accessType']),
        'accessTypeDescription': !exists(json, 'accessTypeDescription') ? undefined : json['accessTypeDescription'],
        'isSiteAdministrator': !exists(json, 'isSiteAdministrator') ? undefined : json['isSiteAdministrator'],
    };
}

export function PermissionActionItemToJSON(value?: PermissionActionItem | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'idInSharepoint': value.idInSharepoint,
        'accountType': PrincipalTypeToJSON(value.accountType),
        'displayName': value.displayName,
        'level': value.level,
        'levelDescription': value.levelDescription,
        'memberOf': value.memberOf,
        'path': value.path,
        'permissionLevel': value.permissionLevel,
        'sharePointGroup': value.sharePointGroup,
        'titleName': value.titleName,
        'userOrGroup': value.userOrGroup,
        'memberId': value.memberId,
        'parentId': value.parentId,
        'parentAccountType': value.parentAccountType,
        'actionType': PermissionActionTypeToJSON(value.actionType),
        'accessType': UserAccessTypeToJSON(value.accessType),
        'isSiteAdministrator': value.isSiteAdministrator,
    };
}

