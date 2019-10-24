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
 *
 */

import ApiClient from '../ApiClient';
import AuthenticationType from './AuthenticationType';
import ExternalUserType from './ExternalUserType';
import InviteType from './InviteType';

/**
 * The UserInfo model module.
 * @module model/UserInfo
 * @version 1.0
 */
class UserInfo {
    /**
     * Constructs a new <code>UserInfo</code>.
     * @alias module:model/UserInfo
     */
    constructor() { 
        
        UserInfo.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>UserInfo</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/UserInfo} obj Optional instance to populate.
     * @return {module:model/UserInfo} The populated <code>UserInfo</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new UserInfo();

            if (data.hasOwnProperty('identityName')) {
                obj['identityName'] = ApiClient.convertToType(data['identityName'], 'String');
            }
            if (data.hasOwnProperty('userDisplayName')) {
                obj['userDisplayName'] = ApiClient.convertToType(data['userDisplayName'], 'String');
            }
            if (data.hasOwnProperty('domainGroup')) {
                obj['domainGroup'] = ApiClient.convertToType(data['domainGroup'], 'Boolean');
            }
            if (data.hasOwnProperty('department')) {
                obj['department'] = ApiClient.convertToType(data['department'], 'String');
            }
            if (data.hasOwnProperty('mobilePhone')) {
                obj['mobilePhone'] = ApiClient.convertToType(data['mobilePhone'], 'String');
            }
            if (data.hasOwnProperty('manager')) {
                obj['manager'] = ApiClient.convertToType(data['manager'], 'String');
            }
            if (data.hasOwnProperty('permission')) {
                obj['permission'] = ApiClient.convertToType(data['permission'], 'String');
            }
            if (data.hasOwnProperty('isDeleted')) {
                obj['isDeleted'] = ApiClient.convertToType(data['isDeleted'], 'Boolean');
            }
            if (data.hasOwnProperty('securityToken')) {
                obj['securityToken'] = ApiClient.convertToType(data['securityToken'], 'String');
            }
            if (data.hasOwnProperty('userType')) {
                obj['userType'] = ApiClient.convertToType(data['userType'], 'Number');
            }
            if (data.hasOwnProperty('legalPerson')) {
                obj['legalPerson'] = ApiClient.convertToType(data['legalPerson'], 'Boolean');
            }
            if (data.hasOwnProperty('authenticationType')) {
                obj['authenticationType'] = AuthenticationType.constructFromObject(data['authenticationType']);
            }
            if (data.hasOwnProperty('adminCenterUrl')) {
                obj['adminCenterUrl'] = ApiClient.convertToType(data['adminCenterUrl'], 'String');
            }
            if (data.hasOwnProperty('inviteType')) {
                obj['inviteType'] = InviteType.constructFromObject(data['inviteType']);
            }
            if (data.hasOwnProperty('type')) {
                obj['type'] = ApiClient.convertToType(data['type'], 'String');
            }
            if (data.hasOwnProperty('isRegisteredAosGroup')) {
                obj['isRegisteredAosGroup'] = ApiClient.convertToType(data['isRegisteredAosGroup'], 'Boolean');
            }
            if (data.hasOwnProperty('isExternalUser')) {
                obj['isExternalUser'] = ExternalUserType.constructFromObject(data['isExternalUser']);
            }
            if (data.hasOwnProperty('isAPIExceptional')) {
                obj['isAPIExceptional'] = ApiClient.convertToType(data['isAPIExceptional'], 'Boolean');
            }
            if (data.hasOwnProperty('tenantId')) {
                obj['tenantId'] = ApiClient.convertToType(data['tenantId'], 'String');
            }
            if (data.hasOwnProperty('objectId')) {
                obj['objectId'] = ApiClient.convertToType(data['objectId'], 'String');
            }
            if (data.hasOwnProperty('version')) {
                obj['version'] = ApiClient.convertToType(data['version'], 'Number');
            }
            if (data.hasOwnProperty('jobTitle')) {
                obj['jobTitle'] = ApiClient.convertToType(data['jobTitle'], 'String');
            }
            if (data.hasOwnProperty('usageLocation')) {
                obj['usageLocation'] = ApiClient.convertToType(data['usageLocation'], 'String');
            }
            if (data.hasOwnProperty('physicalDeliveryOfficeName')) {
                obj['physicalDeliveryOfficeName'] = ApiClient.convertToType(data['physicalDeliveryOfficeName'], 'String');
            }
            if (data.hasOwnProperty('id')) {
                obj['id'] = ApiClient.convertToType(data['id'], 'Number');
            }
            if (data.hasOwnProperty('displayName')) {
                obj['displayName'] = ApiClient.convertToType(data['displayName'], 'String');
            }
            if (data.hasOwnProperty('title')) {
                obj['title'] = ApiClient.convertToType(data['title'], 'String');
            }
            if (data.hasOwnProperty('email')) {
                obj['email'] = ApiClient.convertToType(data['email'], 'String');
            }
            if (data.hasOwnProperty('isValid')) {
                obj['isValid'] = ApiClient.convertToType(data['isValid'], 'Boolean');
            }
            if (data.hasOwnProperty('existInAOS')) {
                obj['existInAOS'] = ApiClient.convertToType(data['existInAOS'], 'Boolean');
            }
        }
        return obj;
    }


}

/**
 * @member {String} identityName
 */
UserInfo.prototype['identityName'] = undefined;

/**
 * @member {String} userDisplayName
 */
UserInfo.prototype['userDisplayName'] = undefined;

/**
 * @member {Boolean} domainGroup
 */
UserInfo.prototype['domainGroup'] = undefined;

/**
 * @member {String} department
 */
UserInfo.prototype['department'] = undefined;

/**
 * @member {String} mobilePhone
 */
UserInfo.prototype['mobilePhone'] = undefined;

/**
 * @member {String} manager
 */
UserInfo.prototype['manager'] = undefined;

/**
 * @member {String} permission
 */
UserInfo.prototype['permission'] = undefined;

/**
 * @member {Boolean} isDeleted
 */
UserInfo.prototype['isDeleted'] = undefined;

/**
 * @member {String} securityToken
 */
UserInfo.prototype['securityToken'] = undefined;

/**
 * @member {Number} userType
 */
UserInfo.prototype['userType'] = undefined;

/**
 * @member {Boolean} legalPerson
 */
UserInfo.prototype['legalPerson'] = undefined;

/**
 * @member {module:model/AuthenticationType} authenticationType
 */
UserInfo.prototype['authenticationType'] = undefined;

/**
 * @member {String} adminCenterUrl
 */
UserInfo.prototype['adminCenterUrl'] = undefined;

/**
 * @member {module:model/InviteType} inviteType
 */
UserInfo.prototype['inviteType'] = undefined;

/**
 * @member {String} type
 */
UserInfo.prototype['type'] = undefined;

/**
 * @member {Boolean} isRegisteredAosGroup
 */
UserInfo.prototype['isRegisteredAosGroup'] = undefined;

/**
 * @member {module:model/ExternalUserType} isExternalUser
 */
UserInfo.prototype['isExternalUser'] = undefined;

/**
 * @member {Boolean} isAPIExceptional
 */
UserInfo.prototype['isAPIExceptional'] = undefined;

/**
 * @member {String} tenantId
 */
UserInfo.prototype['tenantId'] = undefined;

/**
 * @member {String} objectId
 */
UserInfo.prototype['objectId'] = undefined;

/**
 * @member {Number} version
 */
UserInfo.prototype['version'] = undefined;

/**
 * @member {String} jobTitle
 */
UserInfo.prototype['jobTitle'] = undefined;

/**
 * @member {String} usageLocation
 */
UserInfo.prototype['usageLocation'] = undefined;

/**
 * @member {String} physicalDeliveryOfficeName
 */
UserInfo.prototype['physicalDeliveryOfficeName'] = undefined;

/**
 * @member {Number} id
 */
UserInfo.prototype['id'] = undefined;

/**
 * @member {String} displayName
 */
UserInfo.prototype['displayName'] = undefined;

/**
 * @member {String} title
 */
UserInfo.prototype['title'] = undefined;

/**
 * @member {String} email
 */
UserInfo.prototype['email'] = undefined;

/**
 * @member {Boolean} isValid
 */
UserInfo.prototype['isValid'] = undefined;

/**
 * @member {Boolean} existInAOS
 */
UserInfo.prototype['existInAOS'] = undefined;






export default UserInfo;
